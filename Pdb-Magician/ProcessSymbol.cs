using Dia2Lib;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pdb_Magician
{
    public partial class PdbMagician
    {
        private List<string> _doneList = new List<string>();
        /// <summary>
        ///  this is still too big and needs to be broken down
        ///  
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool ProcessSymbol(Symbol s)
        {
            try
            {
                List<string> accessBlock = new List<string>();
                List<string> variablesBlock = new List<string>();
                List<FunctionRecord> entries = new List<FunctionRecord>();
                string structureName = s.Name;
                if (structureName.StartsWith("<unnamed-"))
                {
                    structureName = structureName.Replace("<unnamed-", "_UNNAMED_");
                    structureName = structureName.TrimEnd(new char[] { '>' });
                }
                if (_doneList.Contains(structureName))
                    return true;
                IDiaEnumSymbols children = s.TryChildren();
                AddToBody("#region " + structureName, 1);
                variablesBlock.Add("private Byte[] _StructureData;");
                variablesBlock.Add("private int _BufferOffset;");
                HashSet<int> offsets = new HashSet<int>();
                // the manifest part
                JObject rootNodes = new JObject();
                JArray section;
                JArray d = new JArray();
                d.Add((int)s.Length);
                d.Add(rootNodes);
                foreach (IDiaSymbol child in children)
                {
                    Symbol c = new Symbol(child);
                    Members member = new Members(c);
                    Symbol childType = c.InspectType();
                    if (childType.Name != null && childType.Name.StartsWith("<unnamed-"))
                    {
                        _todoSymbolList.Add(childType);
                    }
                    //if ("ExceptionPortData" == c.Name)
                    //    AddToBody("", 0);
                    FunctionRecord fr = new FunctionRecord();
                    fr.symbolType = GetSymbolType(childType.RootSymbol);
                    fr.friendlySymbolType = GetUsefulSymbolType(fr.symbolType);
                    fr.isPointer = fr.symbolType.EndsWith("*");
                    fr.offset = member.offset;
                    offsets.Add(member.offset);
                    fr.access = SymbolWrapper.rgAccess[(int)member.access];
                    fr.name = c.Name;
                    fr.length = (int)childType.Length;
                    fr.alias = "alias_" + (member.offset).ToString();

                    if ((LocationType)member.locationType == LocationType.LocIsBitField)
                    {
                        //AddToBody("// " + SymbolWrapper.rgAccess[(int)member.access] + " BitField " + c.Name + " offset: " + member.offset + " STARTBIT: " + member.bitPosition + " ENDBIT: " + (member.bitPosition + member.length) + " Target Length: " + childType.Length, 3);
                        fr.type = "BitField";
                        UpdateType(ref fr);
                        fr.startBit = (int)member.bitPosition;
                        fr.endBit = (int)(member.bitPosition + member.length);
                        UInt64 mask = GetMask(fr.startBit, fr.endBit);
                        int max = 16 > fr.endBit ? 16 : fr.endBit;
                        accessBlock.Add("public " + fr.structureType + " " + c.Name);
                        accessBlock.Add("{");
                        accessBlock.Add("\tget");
                        accessBlock.Add("\t{");
                        accessBlock.Add("\t\t// start: " + fr.startBit + "  end: " + fr.endBit + "  Mask: " + Convert.ToString((int)mask, 2).PadLeft(max, '0'));
                        if (fr.friendlySymbolType == "Byte")
                            accessBlock.Add("\t\t" + fr.structureType + " value = _StructureData[_BufferOffset + " + fr.offset + "];");
                        else
                            accessBlock.Add("\t\tvar value = BitConverter.To" + fr.structureType + "(_StructureData, _BufferOffset + " + fr.offset + ");");

                        accessBlock.Add("\t\tvar value2 = (value & " + mask + ") >> " + fr.startBit + ";");
                        accessBlock.Add("\t\treturn (" + fr.structureType + ")value2;");

                        accessBlock.Add("\t}");
                        accessBlock.Add("}");
                        // manifest bit
                        Dictionary<string, object> loaded = new Dictionary<string, object>();
                        loaded.Add("end_bit", fr.endBit);
                        loaded.Add("start_bit", fr.startBit);
                        loaded.Add("target", fr.friendlySymbolType);
                        section = GetJsonSection("BitField", fr.offset, loaded);
                        rootNodes.Add(new JProperty(c.Name, section));

                    }
                    else
                    {
                        //AddToBody("// " + SymbolWrapper.rgAccess[(int)member.access] + " " + fr.friendlySymbolType + " " + c.Name + " offset: " + member.offset + " length: " + childType.Length, 3);
                        fr.type = fr.friendlySymbolType;
                        UpdateType(ref fr);
                        if (fr.friendlySymbolType.StartsWith("_"))
                        {
                            accessBlock.Add("public " + fr.friendlySymbolType + " " + c.Name);
                            accessBlock.Add("{");
                            accessBlock.Add("\tget");
                            accessBlock.Add("\t{");
                            accessBlock.Add("\t\t" + fr.friendlySymbolType + " returnValue = new " + fr.friendlySymbolType + "(_StructureData, _BufferOffset + " + fr.offset + ");");
                            accessBlock.Add("\t\treturn returnValue;");
                            accessBlock.Add("\t}");
                            accessBlock.Add("}");
                            // manifest part
                            section = GetJsonSection(fr.friendlySymbolType, fr.offset);
                            rootNodes.Add(new JProperty(c.Name, section));
                        }
                        else
                        {
                            if (fr.friendlySymbolType.EndsWith("]"))
                            {
                                string[] parts = fr.type.Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                                // sanity check

                                accessBlock.Add("public " + fr.structureType + " " + c.Name);
                                accessBlock.Add("{");
                                accessBlock.Add("\tget");
                                accessBlock.Add("\t{");
                                accessBlock.Add("\t\t" + fr.structureType + " returnValue = new " + fr.type + ";");
                                accessBlock.Add("\t\tfor(int i=0; i<" + parts[1] + "; i++ )");
                                if (parts[0] == "Byte")
                                    accessBlock.Add("\t\t\treturnValue[i] = _StructureData[i + _BufferOffset + " + fr.offset + "];");
                                else
                                    accessBlock.Add("\t\t\treturnValue[i] = BitConverter.To" + parts[0] + "(_StructureData, (i * sizeof(" + parts[0] + ")) + _BufferOffset + " + fr.offset + ");");
                                accessBlock.Add("\t\treturn returnValue;");
                                accessBlock.Add("\t}");
                                accessBlock.Add("}");
                                // manifest part
                                Dictionary<string, object> loaded = new Dictionary<string, object>();
                                try
                                {
                                    loaded.Add("count", int.Parse(parts[1]));
                                }
                                catch (Exception ex)
                                {
                                    loaded.Add("count", "there was a parsing error: " + ex.Message);
                                }
                                loaded.Add("target", parts[0]);
                                section = GetJsonSection("Array", fr.offset, loaded);
                                rootNodes.Add(new JProperty(c.Name, section));
                            }
                            else
                            {
                                if (fr.friendlySymbolType == "Byte")
                                    accessBlock.Add("public " + fr.friendlySymbolType + " " + c.Name + "{ get { return _StructureData[_BufferOffset +" + fr.offset + "]; } }");
                                else
                                    accessBlock.Add("public " + fr.friendlySymbolType + " " + c.Name + "{ get { return BitConverter.To" + fr.friendlySymbolType + "(_StructureData, _BufferOffset + " + fr.offset + "); } }");

                                // manifest part
                                if (fr.isPointer)
                                {
                                    Dictionary<string, object> loaded = new Dictionary<string, object>();
                                    loaded.Add("target", fr.symbolType.Substring(0, fr.symbolType.Length - 1));
                                    section = GetJsonSection("Pointer", fr.offset, loaded);
                                    rootNodes.Add(new JProperty(c.Name, section));
                                }
                                else
                                {
                                    section = GetJsonSection(fr.friendlySymbolType, fr.offset);
                                    rootNodes.Add(new JProperty(c.Name, section));
                                }
                            }
                        }
                    }
                    entries.Add(fr);

                }
                JObject root = new JObject(new JProperty(structureName, d));
                string manifest = root.ToString().Replace('\n', ' ').Replace('\r', ' ').Replace("],", "],\n   ");
                for (int r = 0; r < 8; r++)
                    manifest = manifest.Replace("  ", " ");
                manifest = manifest.Replace("} ]", "}]");
                manifest = manifest.Replace("] ]", "]]");
                manifest = manifest.Replace("\"", "\"\"");
                int index = 0;
                for (int t = 0; t < 2; t++)
                {
                    index = manifest.IndexOf('{', index) + 1;
                    manifest = manifest.Insert(index, "\n");
                }
                manifest = manifest.Insert(manifest.Length - 2, "\n");
                string[] manifestParts = manifest.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);


                //Debug.WriteLine(manifest);
                foreach (int item in offsets)
                {
                    string lastAlias = "";
                    foreach (FunctionRecord entry in entries)
                    {
                        if (entry.type.StartsWith("_") && structureName != entry.type && !_doneList.Contains(entry.type) && !_todoList.Contains(entry.type))
                        {
                            _todoList.Add(entry.type);
                        }
                        lastAlias = entry.alias;
                    }
                    //Debug.WriteLine(item);
                }
                AddToBody(" ", 0);
                AddToBody("public class " + structureName, 1);
                AddToBody("{", 1);
                foreach (string a in variablesBlock)
                    AddToBody(a, 2);
                AddToBody("public " + structureName + "(Byte[] Buffer, int PartitionOffset)", 2);
                AddToBody("{", 2);
                AddToBody("_StructureData = Buffer;", 3);
                AddToBody("_BufferOffset = PartitionOffset;", 3);
                AddToBody("}", 2);
                AddToBody("public int MxStructureSize { get { return _StructureData.Length; } }", 2);

                AddToBody("public string manifest", 2);
                AddToBody("{", 2);
                AddToBody("get", 3);
                AddToBody("{", 3);
                AddToBody("return @\"(", 4);
                foreach (string line in manifestParts)
                    AddToBody(line, 4);
                AddToBody(")\";", 4);
                AddToBody("}", 3);
                AddToBody("}", 2);


                foreach (String a in accessBlock)
                    AddToBody(a, 2);

                AddToBody("}", 1);
                AddToBody("#endregion", 1);

                _doneList.Add(structureName);

                return true;
            }
            catch (Exception ex)
            {
                _errorList.Add("Error while processing symbols..");
                _errorList.Add(ex.Message);
                return false;
            }
        }
        private string GetSymbolType(IDiaSymbol symbol)
        {
            string answer = "";
            var checkme = (SymTagEnum)symbol.symTag;
            switch ((SymTagEnum)symbol.symTag)
            {
                case SymTagEnum.SymTagPointerType:
                    PointerType pointer = new PointerType(symbol);
                    answer += GetSymbolType(pointer.type);
                    //PrintType(pointer.type, session, ref s_type);
                    answer += pointer.reference ? "&" : "*";
                    break;
                case SymTagEnum.SymTagBaseType:
                    BaseType baseType = new BaseType(symbol);
                    switch (baseType.baseType)
                    {
                        case (int)BasicType.btUInt:
                            //s_type += "unsigned ";
                            switch (baseType.length)
                            {
                                case 1: answer += "Byte"; break;
                                case 2: answer += "UInt16"; break;
                                case 4: answer += "UInt32"; break;
                                case 8: answer += "UInt64"; break;
                            }
                            break;
                        case (int)BasicType.btInt:
                            //s_type += "signed ";
                            switch (baseType.length)
                            {
                                case 1: answer += "Byte"; break;
                                case 2: answer += "Int16"; break;
                                case 4: answer += "Int32"; break;
                                case 8: answer += "Int64"; break;
                            }
                            break;
                        case (int)BasicType.btFloat:
                            switch (baseType.length)
                            {
                                case 4: answer += "float "; break;
                                case 8: answer += "Double "; break;
                            }
                            break;
                        default:
                            answer += SymbolWrapper.rgBaseType[baseType.baseType];
                            break;
                    }
                    break;
                case SymTagEnum.SymTagUDT:
                    Structure utd = new Structure(symbol);
                    if (utd.name.StartsWith("<unnamed-"))
                        utd.name = "_UNNAMED_" + utd.symIndexId.ToString();
                    answer += utd.name;
                    break;
                case SymTagEnum.SymTagFunctionType:
                    answer += "void";
                    break;
                case SymTagEnum.SymTagFunctionArgType:
                    FunctionArgType arg = new FunctionArgType(symbol);
                    answer += GetSymbolType(arg.type);
                    break;
                case SymTagEnum.SymTagArrayType:
                    ArrayType array = new ArrayType(symbol);
                    answer += GetSymbolType(array.type);
                    answer += "[" + array.count + "]";
                    break;
                default:
                    Debug.WriteLine("PROCESSING ERROR: GetSymbol Type didn't handle " + symbol.name);
                    break;
            }

            return answer;
        }
        private string GetUsefulSymbolType(string st)
        {
            if (st.EndsWith("*"))
            {
                return _pointerSize == 4 ? "UInt32" : "UInt64";
            }
            if (st.EndsWith("]"))
            {
                if (st.StartsWith("unsigned long"))
                    return st.Replace("unsigned long", "UInt32");
                if (st.StartsWith("unsigned long long"))
                    return st.Replace("unsigned long long", "UInt64");
                if (st.StartsWith("long"))
                    return st.Replace("long", "Int32");
                if (st.StartsWith("long long"))
                    return st.Replace("long long", "Int64");
            }
            switch (st)
            {
                case "unsigned long":
                    return "UInt32";
                case "long":
                    return "Int32";
                case "char":
                    return "Char";
                case "byte":
                    return "Byte";
                default:
                    return st;
            }
        }
        private void UpdateType(ref FunctionRecord record)
        {
            string originalType = record.type;
            if (originalType.EndsWith("*"))
            {
                record.structureType = (record.length == 8) ? "UInt64" : "UInt32";
                return;
            }
            if (originalType.EndsWith("]"))
            {
                string[] parts = originalType.Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                record.structureType = parts[0] + "[]";
                return;
            }
            if (originalType.StartsWith("_"))
            {
                record.structureType = "Byte[]";
                return;
            }
            if (originalType == "BitField")
            {
                if (record.length == 1)
                    record.structureType = "Byte";
                else if (record.length == 2)
                    record.structureType = "UInt16";
                else if (record.length == 4)
                    record.structureType = "UInt32";
                else if (record.length == 8)
                    record.structureType = "UInt64";
                return;
            }

            record.structureType = originalType;
        }
        private UInt64 GetMask(int start, int end)
        {
            int counter = 1;
            UInt64 value = 0;
            for (int i = 0; i < end; i++)
            {
                if (i == start)
                {
                    value += (uint)counter;
                    start++;
                }
                counter *= 2;
            }
            return value;
        }
        private JArray GetJsonSection(string name, int length, Dictionary<string, object> members = null)
        {
            JArray j = new JArray();
            JArray inner = new JArray();
            JObject o = new JObject();
            if (members != null)
            {
                foreach (KeyValuePair<string, object> kvp in members)
                {
                    Dictionary<string, object> secondLevel = kvp.Value as Dictionary<string, object>;
                    if (secondLevel == null)
                        o.Add((new JProperty(kvp.Key, kvp.Value)));
                    else
                    {
                        // turn the dictionary into another JArray and add it to o.Add in place of the kvp.value??
                    }
                }
            }
            inner.Add(name);
            inner.Add(o);

            j.Add(length);
            j.Add(inner);
            return j;
        }
    }
}
