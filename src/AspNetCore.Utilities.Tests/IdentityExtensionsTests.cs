using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using Xunit;

namespace ICG.AspNetCore.Utilities.Tests
{
    public class IdentityExtensionsTests
    {
        [Fact]
        public void GetClaimValue_ShouldReturnStringEmpty_WhenIdentityIsNotClaimsIdentity()
        {
            //Arrange
            var identity = new GenericIdentity("testing");

            //Act
            var result = identity.GetClaimValue("testing");

            //Assert.
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void GetClaimValue_ShouldReturnStringEmpty_WhenClaimsIdentityHasNoClaims()
        {
            //Arrange
            var identity = new ClaimsIdentity();

            //Act
            var result = identity.GetClaimValue("testing");

            //Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void GetClaimValue_ShouldReturnStringEmpty_WhenClaimsIdentityDoesNotIncludeExpectedClaim()
        {
            //Arrange
            var identity = new ClaimsIdentity(new List<Claim> { new Claim("MyClaim", "MyValue") });

            //Act
            var result = identity.GetClaimValue("testing");

            //Assert
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void GetClaimValue_ShouldReturnValueOfClaim_WhenIdentityContainsRequestedClaim()
        {
            //Arrange
            var claimValue = "myValue";
            var identity = new ClaimsIdentity(new List<Claim>{new Claim("testing", claimValue)});

            //Act
            var result = identity.GetClaimValue("testing");

            //Assert
            Assert.Equal(claimValue, result);
        }
    }
}
