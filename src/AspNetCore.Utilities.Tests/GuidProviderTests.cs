using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Bson;
using Xunit;

namespace ICG.AspNetCore.Utilities.Tests
{
    public class GuidProviderTests
    {
        private readonly IGuidProvider _guidProvider;

        public GuidProviderTests()
        {
            _guidProvider = new GuidProvider();
        }

        [Fact]
        public void Empty_ShouldReturnProperValue()
        {
            //Arrange
            var expected = Guid.Empty;

            //Act
            var actual = _guidProvider.Empty;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Parse_ShouldReturnProperValue()
        {
            //Arrange
            var input = Guid.NewGuid().ToString();
            var expected = Guid.Parse(input);

            //Act
            var actual = _guidProvider.Parse(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("N")]
        [InlineData("D")]
        [InlineData("B")]
        [InlineData("P")]
        [InlineData("X")]
        public void ParseExact_ShouldReturnProperValue(string format)
        {
            //Arrange
            var input = Guid.NewGuid().ToString(format);
            var expected = Guid.ParseExact(input, format);

            //Act
            var actual = _guidProvider.ParseExact(input, format);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TryParse_ShouldReturnProperValue()
        {
            //Arrange
            var input = Guid.NewGuid().ToString();
            var expected = Guid.TryParse(input, out var expectedResult);

            //Act
            var actual = _guidProvider.TryParse(input, out var actualResult);

            //Assert
            Assert.Equal(expected, actual);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData("N")]
        [InlineData("D")]
        [InlineData("B")]
        [InlineData("P")]
        [InlineData("X")]
        public void TryParseExact_ShouldReturnProperValue(string format)
        {
            //Arrange
            var input = Guid.NewGuid().ToString(format);
            var expected = Guid.TryParseExact(input, format, out var expectedResult);

            //Act
            var actual = _guidProvider.TryParseExact(input, format, out var actualResult);

            //Assert
            Assert.Equal(expected, actual);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
