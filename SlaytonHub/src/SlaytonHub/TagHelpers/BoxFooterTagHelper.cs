﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SlaytonHub.TagHelpers
{
    public class BoxFooterTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";
            var containerTag = new TagBuilder("div");
            containerTag.AddCssClass("box-footer clearfix");

            var childContent = output.Content.IsModified ? output.Content.GetContent() :
           (await output.GetChildContentAsync()).GetContent();

            containerTag.InnerHtml.AppendHtml(childContent);

            output.Content.SetHtmlContent(containerTag);
        }
    }
}
