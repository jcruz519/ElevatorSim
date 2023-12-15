using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using log4net;
using log4net.Repository.Hierarchy;

namespace ElevatorSim.ViewModels
{
    public class TextFileInputReader : ITextFileInputReader
    {
        private Logger _log;
        public TextFileInputReader() 
        {
            
        }

        public List<int> ReadInputFromFile(StreamReader TextInputFile) 
        {
            List<int> result = new List<int>();

            string line = TextInputFile.ReadLine();
            
            while (line != null) 
            { 
                result.Add(Int32.Parse(line));
                line = TextInputFile.ReadLine();
            }

            return result;
        }
    }
}
