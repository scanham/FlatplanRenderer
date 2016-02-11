using Microsoft.AspNet.Razor.TagHelpers;

namespace FlatplanRenderer.TagHelpers
{
    [HtmlTargetElement(Attributes = ConditionAtributeName)]
    public class ConditionTagHelper : TagHelper
    {
        private const string ConditionAtributeName = "condition";

        [HtmlAttributeName(ConditionAtributeName)]
        public bool Condition { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!Condition)
            {
                output.SuppressOutput();
            }
        }
    }
}
