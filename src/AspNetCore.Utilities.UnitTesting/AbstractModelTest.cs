using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using Xunit;

namespace ICG.AspNetCore.Utilities.UnitTesting
{
    /// <summary>
    ///     Abstract class for creating unit tests containing methods that help with unit testing
    /// </summary>
    public abstract class AbstractModelTest
    {
        /// <summary>
        ///     Asserts that an object has a <see cref="DisplayAttribute" /> for a particular property with a specific value.  Can
        ///     be used as part of a theory for detailed testing.
        /// </summary>
        /// <param name="modelType">The model type to test</param>
        /// <param name="property">The name of the property expected to contain the <see cref="DisplayAttribute" /></param>
        /// <param name="displayName">The expected name for the property defined in the <see cref="DisplayAttribute" /></param>
        /// <example>
        ///     [Theory]
        ///     [InlineData("PropertyName", "Property Name")]
        ///     public void DisplayPropertiesShouldHaveDisplayNamesDefined(string property, string expectedText)
        ///     {
        ///     //Act/Asset
        ///     AssertDisplayAttribute(typeof(ModelToTest), property, expectedText);
        ///     }
        /// </example>
        public void AssertDisplayAttribute(Type modelType, string property, string displayName)
        {
            var displayAttribute = modelType.GetTypeInfo().GetProperty(property).GetCustomAttribute<DisplayAttribute>();

            Assert.NotNull(displayAttribute);
            Assert.Equal(displayName, displayAttribute.Name);
        }

        /// <summary>
        /// Creates a string with the specified length, helpful for validating minimum and maximum values for objects
        /// </summary>
        /// <param name="desiredLength">The desired length of the resultant string</param>
        /// <returns>A string that is <see cref="desiredLength"/> characters in length</returns>
        public string CreateString(int desiredLength)
        {
            return string.Join(string.Empty, Enumerable.Repeat("a", desiredLength));
        }
    }
}