using System.Linq;
using System.Security.Claims;
using System.Security.Principal;

namespace ICG.AspNetCore.Utilities
{
    /// <summary>
    /// Extension methods for working with <see cref="IIdentity"/> objects
    /// </summary>
    public static class IdentityExtensions
    {
        /// <summary>
        ///     This extension is used to extract the value of a specific type of claim, based on type.  If not found
        ///     <see cref="string.Empty" /> is returned
        /// </summary>
        /// <param name="userIdentity">The user identity, should be of type <see cref="ClaimsIdentity" /></param>
        /// <param name="claimType">The type of claim to extract</param>
        /// <returns>The value of the specified claim type for the user, or <see cref="string.Empty" /> if the claim wasn't found</returns>
        /// <example>
        ///     @User.Identity.GetClaimValue("Profile:FirstName")
        /// </example>
        public static string GetClaimValue(this IIdentity userIdentity, string claimType)
        {
            var claimIdentity = (ClaimsIdentity) userIdentity;

            //Lookup the claim
            var foundClaim = claimIdentity?.Claims.FirstOrDefault(c => c.Type == claimType);
            if (foundClaim == null)
                return string.Empty;

            return foundClaim.Value;
        }
    }
}