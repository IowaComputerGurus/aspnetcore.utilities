using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ICG.AspNetCore.Utilities.TagHelpers
{
    /// <summary>
    ///     A tag helper that if passed a false value will suppress rendering content
    /// </summary>
    [HtmlTargetElement(Attributes = "show-condition")]
    public class ShowConditionTagHelper : TagHelper
    {
        /// <summary>
        ///     The boolean indicator if the element should be shown
        /// </summary>
        public bool ShowCondition { get; set; }

        /// <summary>
        ///     Processes the tag
        /// </summary>
        /// <param name="context">The input context</param>
        /// <param name="output">The output content</param>
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!ShowCondition) 
                output.SuppressOutput();
        }
    }
}