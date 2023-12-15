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
        private ITextFileInputReader? _sut;
        private StreamReader? _textInputFile;
        private void SetupSut()
        {
            _sut = Substitute.For<ITextFileInputReader>();
            _textInputFile = new StreamReader("");
        }

        [Fact]
        private void TestEmptyFile_ShouldReturnEmptyList()
        {
            SetupSut();
            Assert.Empty(_sut.ReadInputFromFile(_textInputFile));
        }

        [Fact]
        private void TestWrongFile_ShouldThrowException()
        {
            SetupSut();
        }

        [Fact]
        private void TestValidNonEmptyFile_ShouldReturnCorrectMovements()
        {
            SetupSut();
        }
    }
}
