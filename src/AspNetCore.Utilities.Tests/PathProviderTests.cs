using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace ICG.AspNetCore.Utilities.Tests
{
    public class PathProviderTests
    {
        private readonly IPathProvider _pathProvider;

        public PathProviderTests()
        {
            _pathProvider = new PathProvider();
        }

        [Fact]
        public void ChangeExtension_ShouldReturnProperValue()
        {
            //Arrange
            var inputPath = "test.txt";
            var newExtension = ".docx";
            var expectedResult = Path.ChangeExtension(inputPath, newExtension);

            //Act
            var actualResult = _pathProvider.ChangeExtension(inputPath, newExtension);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Combine_PathsOverride_ShouldReturnProperValue()
        {
            //Arrange
            var inputs = new string[] {"C:\\", "myFolder", "myPath"};
            var expectedResult = Path.Combine(inputs);

            //act
            var actualResult = _pathProvider.Combine(inputs);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Combine_PathTwo_ShouldReturnProperValue()
        {
            //Arrange
            var path1 = "C:\\";
            var path2 = "myfile.txt";
            var expectedResult = Path.Combine(path1, path2);

            //Act
            var actualResult = _pathProvider.Combine(path1, path2);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Combine_PathThree_ShouldReturnProperValue()
        {
            //Arrange
            var path1 = "C:\\";
            var path2 = "myfolder";
            var path3 = "myfile.txt";
            var expectedResult = Path.Combine(path1, path2, path3);

            //Act
            var actualResult = _pathProvider.Combine(path1, path2, path3);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Combine_PathFour_ShouldReturnProperValue()
        {
            //Arrange
            var path1 = "C:\\";
            var path2 = "myfolder";
            var path3 = "anotherFolder";
            var path4 = "myfile.txt";
            var expectedResult = Path.Combine(path1, path2, path3, path4);

            //Act
            var actualResult = _pathProvider.Combine(path1, path2, path3, path4);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void GetDirectoryName_ShouldReturnProperValue()
        {
            //Arrange
            var input = "C:\\myfolder\\myfile.txt";
            var expectedResult = Path.GetDirectoryName(input);

            //Act
            var actualResult = _pathProvider.GetDirectoryName(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void GetExtension_ShouldReturnProperValue()
        {
            //Arrange
            var input = "C:\\myfolder\\myfile.txt";
            var expectedResult = Path.GetExtension(input);

            //Act
            var actualResult = _pathProvider.GetExtension(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void GetFileName_ShouldReturnProperValue()
        {
            //Arrange
            var input = "C:\\myfolder\\myfile.txt";
            var expectedResult = Path.GetFileName(input);

            //Act
            var actualResult = _pathProvider.GetFileName(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void GetFileNameWithoutExtension_ShouldReturnProperValue()
        {
            //Arrange
            var input = "C:\\myfolder\\myfile.txt";
            var expectedResult = Path.GetFileNameWithoutExtension(input);

            //Act
            var actualResult = _pathProvider.GetFileNameWithoutExtension(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void GetFullPath_ShouldReturnProperValue()
        {
            //Arrange
            var input = "C:\\myfolder\\myfile.txt";
            var expectedResult = Path.GetFullPath(input);

            //Act
            var actualResult = _pathProvider.GetFullPath(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void GetInvalidFileNameChars_ShouldReturnProperValue()
        {
            //Arrange
            var expectedResult = Path.GetInvalidFileNameChars();

            //Act
            var actualResult = _pathProvider.GetInvalidFileNameChars();

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void GetInvalidPathChars_ShouldReturnProperValue()
        {
            //Arrange
            var expectedResult = Path.GetInvalidPathChars();

            //Act
            var actualResult = _pathProvider.GetInvalidPathChars();

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void GetPathRoot_ShouldReturnProperValue()
        {
            //Arrange
            var input = "C:\\myfolder\\myfile.txt";
            var expectedResult = Path.GetPathRoot(input);

            //Act
            var actualResult = _pathProvider.GetPathRoot(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void HasExtension_ShouldReturnProperValue()
        {
            //Arrange
            var input = "C:\\myfolder\\myfile.txt";
            var expectedResult = Path.HasExtension(input);

            //Act
            var actualResult = _pathProvider.HasExtension(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void IsPathFullyQualified_ShouldReturnProperValue()
        {
            //Arrange
            var input = "C:\\myfolder\\myfile.txt";
            var expectedResult = Path.IsPathFullyQualified(input);

            //Act
            var actualResult = _pathProvider.IsPathFullyQualified(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void IsPathRooted_ShouldReturnProperValue()
        {
            //Arrange
            var input = "C:\\myfolder\\myfile.txt";
            var expectedResult = Path.IsPathRooted(input);

            //Act
            var actualResult = _pathProvider.IsPathRooted(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
