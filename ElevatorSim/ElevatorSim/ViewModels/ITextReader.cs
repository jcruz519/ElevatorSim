using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSim.ViewModels
{
    public interface ITextReader
    {
        List<string> ReadInputFromFile(StreamReader TextInputFile);
    }
}
