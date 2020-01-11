using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SlaytonHub.TagHelpers
{
    public class BoxSolidDecorator : BoxBase
    {
        private readonly BoxBase box;

        public BoxSolidDecorator(BoxBase box)
        {
            this.box = box;

        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
           
            //BoxTag.AddCssClass("box-solid");
            //output.Content.SetHtmlContent(header);
            box.Process(context, output);
        }

    }
}
