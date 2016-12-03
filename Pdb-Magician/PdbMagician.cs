using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pdb_Magician
{
    public partial class PdbMagician
    {
        private string _filename;
        private string _guidAge;
        private string _symbolServer;
        private string _cacheFolder;
        private const string _userAgent = @"Microsoft-Symbol-Server/10.0.10522.521";
        private List<string> _errorList = new List<string>();

        public PdbMagician()
        {
        }
        public bool RetrieveSymbolFile(string filename, string guidAge, string cacheFolder, string server = "http://msdl.microsoft.com/download/symbols")
        {
            _filename = filename;
            _guidAge = guidAge.ToUpper();
            _symbolServer = server;
            _cacheFolder = cacheFolder;

            return FetchSymbolFile();
        }
        public bool ParseSymbolFile(string filename)
        {
            _filename = filename;
            return true;
        }
        public string[] GetErrorList()
        {
            return _errorList.ToArray();
        }
    }
}
