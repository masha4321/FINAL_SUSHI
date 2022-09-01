using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Globalization;

namespace SushiEShop.Web.TagHelpers
{
    public class PriceTagHelper : TagHelper
    {
        public decimal? PriceInfo { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "dd";
            string price = String.Format("{0:.00$ CAD}", PriceInfo);
            output.Attributes.SetAttribute("class", "col-sm-10");
            output.Content.SetContent(price);

        }
    }
}
