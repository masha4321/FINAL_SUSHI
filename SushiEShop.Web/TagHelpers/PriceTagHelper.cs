using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Globalization;

namespace SushiEShop.Web.TagHelpers
{
    public class PriceTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.AppendHtml(@NumberFormatInfo.CurrentInfo.CurrencySymbol);
        }
    }
}
