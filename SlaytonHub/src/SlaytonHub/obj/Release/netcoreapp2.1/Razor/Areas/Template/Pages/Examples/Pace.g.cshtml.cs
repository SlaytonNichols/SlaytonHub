#pragma checksum "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Examples/Pace.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f34edb1f136527f76947eb7a0d8023a46682b8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SlaytonHub.Areas.Template.Pages.Examples.Areas_Template_Pages_Examples_Pace), @"mvc.1.0.razor-page", @"/Areas/Template/Pages/Examples/Pace.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Template/Pages/Examples/Pace.cshtml", typeof(SlaytonHub.Areas.Template.Pages.Examples.Areas_Template_Pages_Examples_Pace), null)]
namespace SlaytonHub.Areas.Template.Pages.Examples
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f34edb1f136527f76947eb7a0d8023a46682b8d", @"/Areas/Template/Pages/Examples/Pace.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12120391a0edf442ef4f4de80d25de41727c708", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c25d9407126acdb25718cdff3d88e24295530e0", @"/Areas/Template/Pages/_ViewImports.cshtml")]
    public class Areas_Template_Pages_Examples_Pace : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Examples/Pace.cshtml"
  
    ViewData["Title"] = "Pace page";
     ViewData["SubTitle"] = "Loading example";
    Layout = "_LayoutAdminLTE";

#line default
#line hidden
            BeginContext(127, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(144, 134, true);
                WriteLiteral("\n    <link rel=\"stylesheet\" href=\"https://d1m0vzlwib3qni.cloudfront.net/wwwroot/lib/pace/themes/blue/pace-theme-loading-bar.min.css\">\n");
                EndContext();
            }
            );
            DefineSection("Scripts", async() => {
                BeginContext(297, 525, true);
                WriteLiteral(@"
    <!-- PACE -->
    <script src=""https://d1m0vzlwib3qni.cloudfront.net/wwwroot/lib/PACE/pace.min.js""></script>
    <script type=""text/javascript"">
        // To make Pace works on Ajax calls
        $(document).ajaxStart(function () {
            Pace.restart()
        })
        $('.ajax').click(function () {
            $.ajax({
                url: '#', success: function (result) {
                    $('.ajax-content').html('<hr>Ajax Request Completed !')
                }
            })
        })
    </script>
");
                EndContext();
            }
            );
            BeginContext(824, 1325, true);
            WriteLiteral(@"
<!-- Default box -->
<div class=""box"">
    <div class=""box-header with-border"">
        <h3 class=""box-title"">Title</h3>

        <div class=""box-tools pull-right"">
            <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"" data-toggle=""tooltip""
                    title=""Collapse"">
                <i class=""fa fa-minus""></i>
            </button>
            <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove"" data-toggle=""tooltip"" title=""Remove"">
                <i class=""fa fa-times""></i>
            </button>
        </div>
    </div>
    <div class=""box-body"">
        Pace loading works automatically on page. You can still implement it with ajax requests by adding this js:
        <br /><code>$(document).ajaxStart(function() { Pace.restart(); });</code>
        <br />
        <div class=""row"">
            <div class=""col-xs-12 text-center"">
                <button type=""button"" class=""btn btn-default btn-lrg ajax"" title=""Ajax Request"">
                    <i class=""");
            WriteLiteral(@"fa fa-spin fa-refresh""></i>&nbsp; Get External Content
                </button>
            </div>
        </div>
        <div class=""ajax-content"">
        </div>
    </div>
    <!-- /.box-body -->
    <div class=""box-footer"">
        Footer
    </div>
    <!-- /.box-footer-->
</div>
<!-- /.box -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_Template_Pages_Examples_Pace> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Template_Pages_Examples_Pace> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Template_Pages_Examples_Pace>)PageContext?.ViewData;
        public Areas_Template_Pages_Examples_Pace Model => ViewData.Model;
    }
}
#pragma warning restore 1591