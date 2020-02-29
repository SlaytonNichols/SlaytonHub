#pragma checksum "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Examples/Error404.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d7a8721571d876529e1f97047e7d88f11feaed3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SlaytonHub.Areas.Template.Pages.Examples.Areas_Template_Pages_Examples_Error404), @"mvc.1.0.razor-page", @"/Areas/Template/Pages/Examples/Error404.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Template/Pages/Examples/Error404.cshtml", typeof(SlaytonHub.Areas.Template.Pages.Examples.Areas_Template_Pages_Examples_Error404), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8721571d876529e1f97047e7d88f11feaed3", @"/Areas/Template/Pages/Examples/Error404.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12120391a0edf442ef4f4de80d25de41727c708", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c25d9407126acdb25718cdff3d88e24295530e0", @"/Areas/Template/Pages/_ViewImports.cshtml")]
    public class Areas_Template_Pages_Examples_Error404 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Examples/Error404.cshtml"
  
    ViewData["Title"] = "404 Error Page";
    Layout = "_LayoutAdminLTE";

#line default
#line hidden
            BeginContext(85, 395, true);
            WriteLiteral(@"
<div class=""error-page"">
    <h2 class=""headline text-yellow""> 404</h2>

    <div class=""error-content"">
        <h3><i class=""fa fa-warning text-yellow""></i> Oops! Page not found.</h3>

        <p>
            We could not find the page you were looking for.
            Meanwhile, you may <a href=""../../index.html"">return to dashboard</a> or try using the search form.
        </p>

        ");
            EndContext();
            BeginContext(480, 469, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fddd54eaedd476a8083f5faee4f2010", async() => {
                BeginContext(506, 436, true);
                WriteLiteral(@"
            <div class=""input-group"">
                <input type=""text"" name=""search"" class=""form-control"" placeholder=""Search"">

                <div class=""input-group-btn"">
                    <button type=""submit"" name=""submit"" class=""btn btn-warning btn-flat"">
                        <i class=""fa fa-search""></i>
                    </button>
                </div>
            </div>
            <!-- /.input-group -->
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(949, 49, true);
            WriteLiteral("\n    </div>\n    <!-- /.error-content -->\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_Template_Pages_Examples_Error404> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Template_Pages_Examples_Error404> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Template_Pages_Examples_Error404>)PageContext?.ViewData;
        public Areas_Template_Pages_Examples_Error404 Model => ViewData.Model;
    }
}
#pragma warning restore 1591
