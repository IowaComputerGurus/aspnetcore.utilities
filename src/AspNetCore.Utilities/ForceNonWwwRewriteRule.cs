using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Net.Http.Headers;

namespace ICG.AspNetCore.Utilities
{
    /// <summary>
    ///     An <see cref="IRule" /> implementation that ensures a www prefix is not used with a domain
    /// </summary>
    public class ForceNonWwwRewriteRule : IRule
    {
        /// <summary>
        /// Runs when applying the rule
        /// </summary>
        /// <param name="context"></param>
        public void ApplyRule(RewriteContext context)
        {
            // checking if the hostName has www. at the beginning
            var request = context.HttpContext.Request;
            if (!request.Host.Value.StartsWith("www.", StringComparison.OrdinalIgnoreCase))
                return;

            // Strip off www.
            var newHostName = request.Host.Value.Substring(4);

            // Creating new url
            var redirectUrl = $"{request.Scheme}://{newHostName}{request.Path}{request.QueryString}";

            // Modify Http Response
            var response = context.HttpContext.Response;
            response.Headers[HeaderNames.Location] = redirectUrl;
            response.StatusCode = StatusCodes.Status301MovedPermanently;
            context.Result = RuleResult.EndResponse;
        }
    }
}