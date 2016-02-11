
using System.Collections.Generic;
using System.Linq;
using FlatplanRenderer.ViewModels;
using Microsoft.AspNet.Razor.TagHelpers;

namespace Maggie.TagHelpers
{
    [HtmlTargetElement("img", Attributes = ImagesAttributeName)]
    public class LazySizesTagHelper : TagHelper
    {
        private const string ImagesAttributeName = "images";
     

        public LazySizesTagHelper()
        {
        }

        [HtmlAttributeName(ImagesAttributeName)]
        public IEnumerable<Image> Images { get; set; }

        private string MakePath(string url, int width)
        {
            return $"{url} {width}w";
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            var specified = context?.AllAttributes[ImagesAttributeName]?.Name == ImagesAttributeName &&
                            Images != null && Images.Any();
            if (specified)
            {
                string classValue;
                classValue = output.Attributes.ContainsName("class")
                    ? string.Format("{0} {1}", output.Attributes["class"], "lazyload")
                    : "lazyload";
                output.Attributes["class"] = classValue;

                var images = Images.ToList();
                if (images.Count == 1)
                {
                    output.Attributes.Add("data-src", images[0]?.Url);
                }
                else
                {
                    output.Attributes.Add("data-sizes", "auto");

                    List<string> sizes = new List<string>();

                    foreach (var image in images)
                    {
                        sizes.Add(MakePath(image.Url, image.Width));
                    }
                    output.Attributes.Add("data-srcset", string.Join(",", sizes));
                }
            }
            else
            {
                base.Process(context, output);
            }
        }

    }
}