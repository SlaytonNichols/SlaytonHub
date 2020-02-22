#pragma checksum "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/UI/Sliders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9c963ea9acf3e6fa9571ea4b460fc4f5c9b970e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SlaytonHub.Areas.Template.Pages.UI.Areas_Template_Pages_UI_Sliders), @"mvc.1.0.razor-page", @"/Areas/Template/Pages/UI/Sliders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Template/Pages/UI/Sliders.cshtml", typeof(SlaytonHub.Areas.Template.Pages.UI.Areas_Template_Pages_UI_Sliders), null)]
namespace SlaytonHub.Areas.Template.Pages.UI
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c963ea9acf3e6fa9571ea4b460fc4f5c9b970e", @"/Areas/Template/Pages/UI/Sliders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12120391a0edf442ef4f4de80d25de41727c708", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c25d9407126acdb25718cdff3d88e24295530e0", @"/Areas/Template/Pages/_ViewImports.cshtml")]
    public class Areas_Template_Pages_UI_Sliders : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/UI/Sliders.cshtml"
  
    ViewData["Title"] = "Sliders";

#line default
#line hidden
            DefineSection("styles", async() => {
                BeginContext(62, 132, true);
                WriteLiteral("\n    <link rel=\"stylesheet\" href=\"https://d1m0vzlwib3qni.cloudfront.net/wwwroot/lib/bootstrap-slider/css/bootstrap-slider.min.css\">\n");
                EndContext();
            }
            );
            DefineSection("Scripts", async() => {
                BeginContext(213, 251, true);
                WriteLiteral("\n    <script src=\"https://d1m0vzlwib3qni.cloudfront.net/wwwroot/lib/bootstrap-slider/bootstrap-slider.min.js\"></script>\n    <script>\n        $(function () {\n            /* BOOTSTRAP SLIDER */\n            $(\'.slider\').slider()\n        })\n    </script>\n");
                EndContext();
            }
            );
            BeginContext(466, 5244, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-xs-12"">
        <div class=""box box-primary"">
            <div class=""box-header"">
                <h3 class=""box-title"">Bootstrap Slider</h3>
            </div>
            <!-- /.box-header -->
            <div class=""box-body"">
                <div class=""row margin"">
                    <div class=""col-sm-6"">
                        <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                               data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""horizontal""
                               data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""red"">

                        <p>data-slider-id=""red""</p>
                        <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                               data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""horizontal""
                 ");
            WriteLiteral(@"              data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""blue"">

                        <p>data-slider-id=""blue""</p>
                        <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                               data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""horizontal""
                               data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""green"">

                        <p>data-slider-id=""green""</p>
                        <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                               data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""horizontal""
                               data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""yellow"">

                        <p>data-slider-id=""yellow""</p>
                        <input type=""text"" valu");
            WriteLiteral(@"e="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                               data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""horizontal""
                               data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""aqua"">

                        <p>data-slider-id=""aqua""</p>
                        <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                               data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""horizontal""
                               data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""purple"">

                        <p style=""margin-top: 10px"">data-slider-id=""purple""</p>
                    </div>
                    <div class=""col-sm-6 text-center"">
                        <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
             ");
            WriteLiteral(@"                  data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""vertical""
                               data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""red"">
                        <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                               data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""vertical""
                               data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""blue"">
                        <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                               data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""vertical""
                               data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""green"">
                        <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""");
            WriteLiteral(@"-200"" data-slider-max=""200""
                               data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""vertical""
                               data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""yellow"">
                        <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                               data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""vertical""
                               data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""aqua"">
                        <input type=""text"" value="""" class=""slider form-control"" data-slider-min=""-200"" data-slider-max=""200""
                               data-slider-step=""5"" data-slider-value=""[-100,100]"" data-slider-orientation=""vertical""
                               data-slider-selection=""before"" data-slider-tooltip=""show"" data-slider-id=""purple"">
                    </div>
                </div>
  ");
            WriteLiteral("          </div>\n            <!-- /.box-body -->\n        </div>\n        <!-- /.box -->\n    </div>\n    <!-- /.col -->\n</div>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_Template_Pages_UI_Sliders> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Template_Pages_UI_Sliders> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Template_Pages_UI_Sliders>)PageContext?.ViewData;
        public Areas_Template_Pages_UI_Sliders Model => ViewData.Model;
    }
}
#pragma warning restore 1591
