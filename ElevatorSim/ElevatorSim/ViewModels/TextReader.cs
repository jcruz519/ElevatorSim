using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace ElevatorSim.ViewModels
{
    public class TextReader : ITextReader
    {
        public TextReader() { }

        public List<string> ReadInputFromFile(StreamReader TextInputFile) 
        {
            string test = ConfigurationManager.AppSettings["TextInputFile"];
            return new List<string>();
        }
    }
}
