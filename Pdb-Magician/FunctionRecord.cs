using Dia2Lib;
using System;
using System.Diagnostics;

namespace Pdb_Magician
{
    class FunctionRecord
    {
        public int offset;
        public string access;
        public string type;
        public string name;
        public int length;
        public int startBit;
        public int endBit;
        public string alias;
        public string structureType;
        public string symbolType;
        public string friendlySymbolType;
        public bool isPointer;
        public bool isBitField = false;
        public bool isArray = false;
        private int _pointerSize;
        public UInt64 bitMask;
        public string arrayType;
        public int arrayCount;

        public FunctionRecord()
        {

        }
        public FunctionRecord(Symbol child, Members member, Symbol grandChild, int pointerSize)
        {
            _pointerSize = pointerSize;
            symbolType = GetSymbolType(grandChild.RootSymbol);
            friendlySymbolType = GetUsefulSymbolType(symbolType);
            isPointer = symbolType.EndsWith("*");
            offset = member.offset;
            access = SymbolWrapper.rgAccess[(int)member.access];
            name = child.Name;
            length = (int)grandChild.Length;
            alias = "alias_" + (member.offset).ToString();
            LocationType location = (LocationType)member.locationType;
            if(location == LocationType.LocIsBitField)
            {
                isBitField = true;
                startBit = (int)member.bitPosition;
                endBit = (int)(member.bitPosition + member.length);
                bitMask = GetMask(startBit, endBit);
                type = "BitField";
            }
            else if (type != null && friendlySymbolType.EndsWith("]"))
            {
                string[] parts = type.Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                if(parts.Length == 2)
                {
                    try
                    {
                        arrayType = parts[0];
                        arrayCount = int.Parse(parts[1]);
                        isArray = true;
                    }
                    catch { }
                }
            }
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
    }
}
