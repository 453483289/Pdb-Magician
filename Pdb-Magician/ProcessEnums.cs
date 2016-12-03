﻿using Dia2Lib;
using System;
using System.Collections.Generic;
using System.IO;

namespace Pdb_Magician
{
    public partial class PdbMagician
    {
        private bool ExportEnums()
        {
            try
            {
                string outputFile = Path.Combine(_destinationFolder, "PdbEnums.cs");
                _enumEnums.Reset();
                List<string> done = new List<string>();

                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    writer.WriteLine("using System;");
                    writer.WriteLine("");
                    writer.WriteLine("namespace MemoryExplorer.Symbols");
                    writer.WriteLine("{");
                    foreach (IDiaSymbol sym in _enumEnums)
                    {
                        Enumerator enumerator = new Enumerator();
                        enumerator.name = sym.name;
                        enumerator.id = sym.symIndexId;
                        IDiaEnumSymbols children;
                        sym.findChildren(SymTagEnum.SymTagNull, null, 0, out children);
                        enumerator.values = new SubEnumerator[children.count];
                        int j = 0;
                        if (enumerator.name.Contains("-"))
                            continue;
                        if (done.Contains(enumerator.name))
                            continue;
                        done.Add(enumerator.name);
                        writer.WriteLine("\tpublic enum " + enumerator.name);
                        writer.WriteLine("\t{");
                        foreach (IDiaSymbol c in children)
                        {
                            enumerator.values[j] = new SubEnumerator();
                            enumerator.values[j].value = c.value;
                            enumerator.values[j].name = c.name;
                            enumerator.values[j].id = c.symIndexId;
                            j++;
                            if (j == children.count)
                                writer.WriteLine("\t\t" + c.name + " = " + c.value);
                            else
                                writer.WriteLine("\t\t" + c.name + " = " + c.value + ",");
                        }
                        writer.WriteLine("\t}");
                    }
                    writer.WriteLine("}");
                }
                return true;
            }
            catch (Exception ex)
            {
                _errorList.Add("Error while processing enums..");
                _errorList.Add(ex.Message);
                return false;
            }
        }
    }
}
