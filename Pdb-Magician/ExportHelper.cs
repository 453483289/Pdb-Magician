﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Pdb_Magician
{
    public partial class PdbMagician
    {
        private List<string> _bodyList = new List<string>();

        private void AddToBody(string line, int indent)
        {
            string newLine = "";
            for (int i = 0; i < indent; i++)
            {
                newLine += "\t";
            }
            newLine += line;
            _bodyList.Add(newLine);
        }

        private bool ExportStructures()
        {
            try
            {
                string outputFile = Path.Combine(_destinationFolder, "PdbStructures.cs");
                /// start by writing out the header part
                /// 
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    writer.WriteLine("using System;");
                    writer.WriteLine("");
                    writer.WriteLine("namespace MemoryExplorer.Symbols");
                    writer.WriteLine("{");
                }
                /// write out the header function
                /// 
                using (StreamWriter writer = new StreamWriter(outputFile, true))
                {
                    writer.WriteLine("\t#region HEADER");
                    writer.WriteLine("\tpublic class CatalogueInformation");
                    writer.WriteLine("\t{");
                    Guid g = _session.globalScope.guid;
                    writer.WriteLine("\t\t public Guid Guid { get { return new Guid(\"" + g + "\"); } }");
                    uint age = _session.globalScope.age;
                    writer.WriteLine("\t\t public uint Age { get { return " + age.ToString() + "; } }");
                    Machine m = (Machine)_session.globalScope.machineType;
                    writer.WriteLine("\t\t public string MachineType { get { return @\"" + m.ToString() + "\"; } }");
                    writer.WriteLine("\t\t public string SymbolsFileName { get { return @\"" + _session.globalScope.symbolsFileName + "\"; } }");
                    writer.WriteLine("\t\t public uint Signature { get { return " + _session.globalScope.signature.ToString() + "; } }");
                    writer.WriteLine("\t}");
                    writer.WriteLine("\t#endregion");
                }
                /// now write out all the structures
                /// 
                using (StreamWriter writer = new StreamWriter(outputFile, true))
                {
                    foreach (string line in _bodyList)
                        writer.WriteLine(line);
                }
                /// and finally write the closing tags
                /// 
                using (StreamWriter writer = new StreamWriter(outputFile, true))
                {
                    writer.WriteLine("}");
                }
                return true;
            }
            catch (Exception ex)
            {
                _errorList.Add("Error while processing structures..");
                _errorList.Add(ex.Message);
                return false;
            }

        }
    }
}
