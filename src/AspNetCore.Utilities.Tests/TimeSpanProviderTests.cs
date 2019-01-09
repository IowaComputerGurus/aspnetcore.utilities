using System;
using System.Globalization;
using Xunit;

namespace ICG.AspNetCore.Utilities.Tests
{
    public class TimeSpanProviderTests
    {
        private readonly ITimeSpanProvider _timeSpanProvider;

        public TimeSpanProviderTests()
        {
            _timeSpanProvider = new TimeSpanProvider();
        }

        [Fact]
        public void FromMilliseconds_ShouldReturnProperValue()
        {
            //Arrange
            var value = 15;
            var expectedResult = TimeSpan.FromMilliseconds(value);

            //Act
            var actualResult = _timeSpanProvider.FromMilliseconds(value);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void FromSeconds_ShouldReturnProperValue()
        {
            //Arrange
            var value = 15;
            var expectedResult = TimeSpan.FromSeconds(value);

            //Act
            var actualResult = _timeSpanProvider.FromSeconds(value);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void FromMinutes_ShouldReturnProperValue()
        {
            //Arrange
            var value = 15;
            var expectedResult = TimeSpan.FromMinutes(value);

            //Act
            var actualResult = _timeSpanProvider.FromMinutes(value);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void FromHours_ShouldReturnProperValue()
        {
            //Arrange
            var value = 15;
            var expectedResult = TimeSpan.FromHours(value);

            //Act
            var actualResult = _timeSpanProvider.FromHours(value);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void FromDays_ShouldReturnProperValue()
        {
            //Arrange
            var value = 15;
            var expectedResult = TimeSpan.FromDays(value);

            //Act
            var actualResult = _timeSpanProvider.FromDays(value);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void FromTicks_ShouldReturnProperValue()
        {
            //Arrange
            var value = 15;
            var expectedResult = TimeSpan.FromTicks(value);

            //Act
            var actualResult = _timeSpanProvider.FromTicks(value);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Parse_ShouldReturnSameAsTimeSpan()
        {
            //Arrange
            var input = "0:15";
            var expectedResult = TimeSpan.Parse(input);

            //Act
            var actualResult = _timeSpanProvider.Parse(input);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Parse_ShouldReturnSameAsTimeSpan_WithCustomCulture()
        {
            //Arrange
            var input = "6:15";
            var culture = new CultureInfo("ru-RU");
            var expectedResult = TimeSpan.Parse(input, culture);

            //Act
            var actualResult = _timeSpanProvider.Parse(input, culture);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void TryParse_ShouldReturnSameAsTimeSpan()
        {
            //Arrange
            var input = "0:15";
            var expectedResult = TimeSpan.TryParse(input, out var expectedValue);

            //Act
            var actualResult = _timeSpanProvider.TryParse(input, out var actualValue);

            //Assert
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void TryParse_ShouldReturnSameAsTimeSpan_WithCustomCulture()
        {
            //Arrange
            var input = "6:15";
            var culture = new CultureInfo("ru-RU");
            var expectedResult = TimeSpan.TryParse(input, culture, out var expectedValue);

            //Act
            var actualResult = _timeSpanProvider.TryParse(input, culture, out var actualValue);

            //Assert
            Assert.Equal(expectedResult, actualResult);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}