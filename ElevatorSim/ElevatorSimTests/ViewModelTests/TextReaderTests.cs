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
            _textInputFile = new StreamReader("");
        }

        [Fact]
        private void TestEmptyFile_ShouldReturnEmptyList()
        {
            SetupSut();
            Assert.Empty(_sut.ReadInputFromFile(_textInputFile));
        }
    }
}
