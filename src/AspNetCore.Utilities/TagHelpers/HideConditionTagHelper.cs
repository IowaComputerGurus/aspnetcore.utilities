using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ICG.AspNetCore.Utilities.TagHelpers
{
    /// <summary>
    ///     A tag helper that if passed a tre value will suppress rendering content
    /// </summary>
    [HtmlTargetElement(Attributes = nameof(HideCondition))]
    public class HideConditionTagHelper : TagHelper
    {
        /// <summary>
        ///     The boolean indicator if the element should be hidden
        /// </summary>
        public bool HideCondition { get; set; }

        /// <summary>
        ///     Processes the tag
        /// </summary>
        /// <param name="context">The input context</param>
        /// <param name="output">The output content</param>
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (HideCondition)
                output.SuppressOutput();
        }
    }
}