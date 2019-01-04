using System;
using AspNetCore.Utilities.Date;
using Xunit;

namespace AspNetCore.Utilities.Tests.Date
{
    public class TimeProviderTests
    {
        private readonly ITimeProvider _timeProvider;

        public TimeProviderTests()
        {
            _timeProvider = new TimeProvider();
        }

        [Fact]
        public void CurrentServerTime_ShouldReturnDateTimeNow()
        {
            //Arrange
            var expected = DateTime.Now;

            //Act
            var result = _timeProvider.CurrentServerTime;

            //Assert
            //Due to clock times, make sure that we are within 1 second
            var difference = expected - result;
            Assert.True(difference.Milliseconds < 1000);
        }

        [Fact]
        public void CurrentUtcTime_ShouldReturnDateTimeUtcNow()
        {
            //Arrange
            var expected = DateTime.UtcNow;

            //Act
            var result = _timeProvider.CurrentUtcTime;

            //Assert
            //Due to clock times, make sure we are within 1 second
            var difference = expected - result;
            Assert.True(difference.Milliseconds < 1000);
        }
    }
}