using System;
using System.Text.RegularExpressions;

namespace AspNetCore.Utilities.Url
{
    public interface IUrlSlugGenerator
    {
        string GenerateSlug(string input);
    }

    public class UrlSlugGenerator : IUrlSlugGenerator
    {
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