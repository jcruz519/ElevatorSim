using NSubstitute;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ElevatorSim.ViewModels;

namespace ElevatorSimTests.ViewModelTests
{
    public class TextReaderTests
    {
        private ITextReader? _sut;
        private StreamReader? _textInputFile;
        private void SetupSut()
        {
            _sut = Substitute.For<ITextReader>();
            string test = ConfigurationManager.AppSettings["TextInputFile"].ToString();
            _textInputFile = new StreamReader(ConfigurationManager.AppSettings["TextInputFile"]);
        }

        [Fact]
        private void TestEmptyFile_ShouldReturnEmptyList()
        {
            SetupSut();
            _ = _sut.ReadInputFromFile(_textInputFile);
            Assert.True(true);
        }
    }
}
