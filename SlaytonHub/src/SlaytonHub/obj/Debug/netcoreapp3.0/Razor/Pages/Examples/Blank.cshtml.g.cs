#pragma checksum "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Pages/Examples/Blank.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3dd39220aec5749dfed172a92e966aed3bebf61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SlaytonHub.Pages.Examples.Pages_Examples_Blank), @"mvc.1.0.razor-page", @"/Pages/Examples/Blank.cshtml")]
namespace SlaytonHub.Pages.Examples
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3dd39220aec5749dfed172a92e966aed3bebf61", @"/Pages/Examples/Blank.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10c8519bb066ed35c09f85d55321516376d4ea40", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Examples_Blank : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Pages/Examples/Blank.cshtml"
  
    ViewData["Title"] = "Blank";

#line default
#line hidden
#nullable disable
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
            Start creating your amazing application!
        </div>
        <!-- /.box-body -->
        <div class=""box-footer"">
            Footer
        </div>
        <!-- /.box-footer-->
    </div>
    <!-- /.box -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Examples_Blank> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Examples_Blank> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Examples_Blank>)PageContext?.ViewData;
        public Pages_Examples_Blank Model => ViewData.Model;
    }
}
#pragma warning restore 1591
