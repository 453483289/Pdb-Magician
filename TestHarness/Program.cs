using Pdb_Magician;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            string guidAge = "afcb4fd7b7a844acaa1a4154cc1091871";
            string filename = "ntkrnlmp.pdb";

            PdbMagician myLib = new PdbMagician();
            bool result = myLib.RetrieveSymbolFile(filename, guidAge, @"c:\temp\magician");
            if(!result)
            {
                Console.WriteLine("One or more errors occurred..");
                string[] errors = myLib.GetErrorList();
                foreach (string s in errors)
                    Console.WriteLine(s);
            }
            else
                Console.WriteLine("Got It!");

            string pdbLocation = Path.Combine(Path.Combine(@"c:\temp\magician", guidAge), filename);
            List<string> todoList = new List<string>();
            //todoList.Add("_CONTROL_AREA");
            //todoList.Add("_SECTION");
            //todoList.Add("_KAPC");
            //todoList.Add("_LIST_ENTRY");
            todoList.Add("_EPROCESS");

            result = myLib.ParseSymbolFile(pdbLocation, Path.Combine(@"c:\temp\magician", guidAge), todoList.ToArray());
        }
    }
}
