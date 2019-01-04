using System;
using System.Text.RegularExpressions;

namespace ICG.AspNetCore.Utilities
{
    /// <summary>
    /// A utility process to create URL slugs based on supplied content.
    /// </summary>
    public interface IUrlSlugGenerator
    {
        /// <summary>
        /// Generates a URL friendly slug from user supplied content. Keeping only a-z, A-Z, and 0-9, non-matching characters are replaced with dashes, multiple dashes are removed
        /// </summary>
        /// <param name="input">The string to generate a slug for</param>
        /// <returns>A url friendly slug</returns>
        string GenerateSlug(string input);
    }

    /// <summary>
    /// A utility process to create URL slugs based on supplied content.
    /// </summary>
    public class UrlSlugGenerator : IUrlSlugGenerator
    {
        /// <summary>
        /// Generates a URL friendly slug from user supplied content. Keeping only a-z, A-Z, and 0-9, non-matching characters are replaced with dashes, multiple dashes are removed
        /// </summary>
        /// <param name="input">The string to generate a slug for</param>
        /// <returns>A url friendly slug</returns>
        public string GenerateSlug(string input)
        {
            //Ensure it is valid
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Invalid input", nameof(input));

            //Replace all non letter & number with -
            var fragment = Regex.Replace(input, "[^a-zA-Z0-9]", "-");

            //Remove duplicates
            fragment = Regex.Replace(fragment, "-+", "-");

            return fragment.ToLower().Trim('-');
        }
    }
}