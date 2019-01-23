using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Net.Http.Headers;

namespace ICG.AspNetCore.Utilities
{
    /// <summary>
    ///     An <see cref="IRule" /> implementation that forces a site to be browsed using a www prefix
    /// </summary>
    public class ForceWwwRewriteRule : IRule
    {
        /// <summary>
        ///     Applies the rule to the context.  If the host starts with www no action is taken
        /// </summary>
        /// <param name="context">The rewrite context</param>
        public void ApplyRule(RewriteContext context)
        {
            var request = context.HttpContext.Request;

            if (request.Host.Value.StartsWith("www.", StringComparison.OrdinalIgnoreCase))
                return;

            var response = context.HttpContext.Response;

            var redirectUrl = $"{request.Scheme}://www.{request.Host}{request.Path}{request.QueryString}";
            response.Headers[HeaderNames.Location] = redirectUrl;
            response.StatusCode = StatusCodes.Status301MovedPermanently;
            context.Result = RuleResult.EndResponse;
        }
    }
}