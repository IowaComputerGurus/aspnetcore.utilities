using System;
using AspNetCore.Utilities.Url;
using Xunit;

namespace AspNetCore.Utilities.Tests.Url
{
    public class UrlSlugGeneratorTests
    {
        private readonly IUrlSlugGenerator _urlSlugGenerator;

        public UrlSlugGeneratorTests()
        {
            _urlSlugGenerator = new UrlSlugGenerator();
        }

        [Theory]
        [InlineData("")]
        [InlineData("  ")]
        [InlineData(null)]
        public void GenerateSlugShouldThrowArgumentExceptionIfEmptyOrWhitespace(string input)
        {
            Assert.Throws<ArgumentException>(() => _urlSlugGenerator.GenerateSlug(input));
        }

        [Fact]
        public void GenerateSlugShouldReturnLowercaseString()
        {
            //Arrange
            var input = "Testing";

            //Act
            var output = _urlSlugGenerator.GenerateSlug(input);

            //Assert
            Assert.Equal(output.ToLower(), output);
        }

        [Theory]
        [InlineData("Test Input", "test-input")]
        [InlineData("Test(input", "test-input")]
        [InlineData("Test%Input", "test-input")]
        public void GenerateSlugShouldReplaceSpacesAndSpecialCharactersWithDash(string input, string expected)
        {
            //Act
            var result = _urlSlugGenerator.GenerateSlug(input);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("test-input", "test-input")]
        public void GenerateSlugShouldKeepDashCharactersFromInput(string input, string expected)
        {
            //Act
            var result = _urlSlugGenerator.GenerateSlug(input);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Test  Input", "test-input")]
        [InlineData("test(input!! Now", "test-input-now")]
        public void GenerateSlugShouldRemoveDuplicateDashCharacters(string input, string expected)
        {
            //Act
            var result = _urlSlugGenerator.GenerateSlug(input);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Test  Input ", "test-input")]
        [InlineData(" test(input!! Now ", "test-input-now")]
        public void GenerateSlugShouldRemoveLeadingAndTrailingDash(string input, string expected)
        {
            //Act
            var result = _urlSlugGenerator.GenerateSlug(input);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}