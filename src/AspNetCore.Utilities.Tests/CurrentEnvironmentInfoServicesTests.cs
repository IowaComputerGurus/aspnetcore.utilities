using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Moq;
using Xunit;

namespace ICG.AspNetCore.Utilities.Tests
{
    public class CurrentEnvironmentInfoServicesTests
    {
        private readonly ICurrentEnvironmentInfoService _currentEnvironmentInfoService;
        private readonly Mock<IWebHostEnvironment> _hostingEnvironmentMock;
        private readonly Mock<IConfiguration> _configurationMock;
        private readonly Mock<IDatabaseEnvironmentModelFactory> _databaseEnvironmentModelFactoryMock;

        public CurrentEnvironmentInfoServicesTests()
        {
            _hostingEnvironmentMock = new Mock<IWebHostEnvironment>();
            _configurationMock = new Mock<IConfiguration>();
            _databaseEnvironmentModelFactoryMock = new Mock<IDatabaseEnvironmentModelFactory>();
            _currentEnvironmentInfoService = new CurrentEnvironmentInfoService(_hostingEnvironmentMock.Object,
                _configurationMock.Object, _databaseEnvironmentModelFactoryMock.Object);
        }

        [Fact]
        public void GetCurrentEnvironment_ShouldIncludeApplicationName()
        {
            //Arrange
            var expectedValue = "MyApp";
            _hostingEnvironmentMock.SetupGet(he => he.ApplicationName).Returns(expectedValue).Verifiable();

            //Act
            var result = _currentEnvironmentInfoService.GetCurrentEnvironment(new List<string>());

            //Assert
            _hostingEnvironmentMock.Verify();
            Assert.Equal(expectedValue, result.ApplicationName);
        }

        [Fact]
        public void GetCurrentEnvironment_ShouldIncludeApplicationRootPath()
        {
            //Arrange
            var expectedValue = "MyApp";
            _hostingEnvironmentMock.SetupGet(he => he.ContentRootPath).Returns(expectedValue).Verifiable();

            //Act
            var result = _currentEnvironmentInfoService.GetCurrentEnvironment(new List<string>());

            //Assert
            _hostingEnvironmentMock.Verify();
            Assert.Equal(expectedValue, result.ApplicationRootPath);
        }

        [Fact]
        public void GetCurrentEnvironment_ShouldIncludeWebRootPath()
        {
            //Arrange
            var expectedValue = "MyApp";
            _hostingEnvironmentMock.SetupGet(he => he.WebRootPath).Returns(expectedValue).Verifiable();

            //Act
            var result = _currentEnvironmentInfoService.GetCurrentEnvironment(new List<string>());

            //Assert
            _hostingEnvironmentMock.Verify();
            Assert.Equal(expectedValue, result.WebRootPath);
        }

        [Fact]
        public void GetCurrentEnvironment_ShouldIncludeEnvironmentName()
        {
            //Arrange
            var expectedValue = "MyApp";
            _hostingEnvironmentMock.SetupGet(he => he.EnvironmentName).Returns(expectedValue).Verifiable();

            //Act
            var result = _currentEnvironmentInfoService.GetCurrentEnvironment(new List<string>());

            //Assert
            _hostingEnvironmentMock.Verify();
            Assert.Equal(expectedValue, result.EnvironmentName);
        }

        [Fact]
        public void GetCurrentEnvironment_ShouldIncludeFrameworkDescription()
        {
            //Arrange
            var expectedValue = RuntimeInformation.FrameworkDescription;

            //Act
            var result = _currentEnvironmentInfoService.GetCurrentEnvironment(new List<string>());

            //Assert
            Assert.Equal(expectedValue, result.FrameworkDescription);
        }

        [Fact]
        public void GetCurrentEnvironment_ShouldIncludeOSDescription()
        {
            //Arrange
            var expectedValue = RuntimeInformation.OSDescription;

            //Act
            var result = _currentEnvironmentInfoService.GetCurrentEnvironment(new List<string>());

            //Assert
            Assert.Equal(expectedValue, result.OperatingSystemDescription);
        }

        [Fact]
        public void GetCurrentEnvironment_ShouldIncludeProcessorArchitecture()
        {
            //Arrange
            var expectedValue = RuntimeInformation.ProcessArchitecture.ToString();

            //Act
            var result = _currentEnvironmentInfoService.GetCurrentEnvironment(new List<string>());

            //Assert
            Assert.Equal(expectedValue, result.ProcessorArchitecture);
        }
    }
}
