#pragma checksum "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Charts/Morris.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "224e968c2e3d0c270af9c0ca9e32ec9e55993033"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SlaytonHub.Areas.Template.Pages.Charts.Areas_Template_Pages_Charts_Morris), @"mvc.1.0.razor-page", @"/Areas/Template/Pages/Charts/Morris.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Template/Pages/Charts/Morris.cshtml", typeof(SlaytonHub.Areas.Template.Pages.Charts.Areas_Template_Pages_Charts_Morris), null)]
namespace SlaytonHub.Areas.Template.Pages.Charts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"224e968c2e3d0c270af9c0ca9e32ec9e55993033", @"/Areas/Template/Pages/Charts/Morris.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12120391a0edf442ef4f4de80d25de41727c708", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c25d9407126acdb25718cdff3d88e24295530e0", @"/Areas/Template/Pages/_ViewImports.cshtml")]
    public class Areas_Template_Pages_Charts_Morris : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/morris.js/morris.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/raphael/raphael.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/morris.js/morris.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Charts/Morris.cshtml"
  
    ViewData["Title"] = "Morris";

#line default
#line hidden
            DefineSection("styles", async() => {
                BeginContext(61, 31, true);
                WriteLiteral("\n    <!-- Morris chart -->\n    ");
                EndContext();
                BeginContext(92, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9affb2f892fa48a4b28ffb6cdb5148a4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(149, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            DefineSection("Scripts", async() => {
                BeginContext(169, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(174, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "741fa374d33f432695ca03a5a1988f70", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(226, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(231, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ba8d7a71ed24a639eb1c620e776e929", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(284, 3207, true);
                WriteLiteral(@"

    <script>
        $(function () {
            ""use strict"";

            // AREA CHART
            var area = new Morris.Area({
                element: 'revenue-chart',
                resize: true,
                data: [
                    { y: '2011 Q1', item1: 2666, item2: 2666 },
                    { y: '2011 Q2', item1: 2778, item2: 2294 },
                    { y: '2011 Q3', item1: 4912, item2: 1969 },
                    { y: '2011 Q4', item1: 3767, item2: 3597 },
                    { y: '2012 Q1', item1: 6810, item2: 1914 },
                    { y: '2012 Q2', item1: 5670, item2: 4293 },
                    { y: '2012 Q3', item1: 4820, item2: 3795 },
                    { y: '2012 Q4', item1: 15073, item2: 5967 },
                    { y: '2013 Q1', item1: 10687, item2: 4460 },
                    { y: '2013 Q2', item1: 8432, item2: 5713 }
                ],
                xkey: 'y',
                ykeys: ['item1', 'item2'],
                labels: ['Item 1', 'Item 2'],
                lin");
                WriteLiteral(@"eColors: ['#a0d0e0', '#3c8dbc'],
                hideHover: 'auto'
            });

            // LINE CHART
            var line = new Morris.Line({
                element: 'line-chart',
                resize: true,
                data: [
                    { y: '2011 Q1', item1: 2666 },
                    { y: '2011 Q2', item1: 2778 },
                    { y: '2011 Q3', item1: 4912 },
                    { y: '2011 Q4', item1: 3767 },
                    { y: '2012 Q1', item1: 6810 },
                    { y: '2012 Q2', item1: 5670 },
                    { y: '2012 Q3', item1: 4820 },
                    { y: '2012 Q4', item1: 15073 },
                    { y: '2013 Q1', item1: 10687 },
                    { y: '2013 Q2', item1: 8432 }
                ],
                xkey: 'y',
                ykeys: ['item1'],
                labels: ['Item 1'],
                lineColors: ['#3c8dbc'],
                hideHover: 'auto'
            });

            //DONUT CHART
            var donut = new Morris.");
                WriteLiteral(@"Donut({
                element: 'sales-chart',
                resize: true,
                colors: [""#3c8dbc"", ""#f56954"", ""#00a65a""],
                data: [
                    { label: ""Download Sales"", value: 12 },
                    { label: ""In-Store Sales"", value: 30 },
                    { label: ""Mail-Order Sales"", value: 20 }
                ],
                hideHover: 'auto'
            });
            //BAR CHART
            var bar = new Morris.Bar({
                element: 'bar-chart',
                resize: true,
                data: [
                    { y: '2006', a: 100, b: 90 },
                    { y: '2007', a: 75, b: 65 },
                    { y: '2008', a: 50, b: 40 },
                    { y: '2009', a: 75, b: 65 },
                    { y: '2010', a: 50, b: 40 },
                    { y: '2011', a: 75, b: 65 },
                    { y: '2012', a: 100, b: 90 }
                ],
                barColors: ['#00a65a', '#f56954'],
                xkey: 'y',
                y");
                WriteLiteral("keys: [\'a\', \'b\'],\n                labels: [\'CPU\', \'DISK\'],\n                hideHover: \'auto\'\n            });\n        });\n    </script>\n");
                EndContext();
            }
            );
            BeginContext(3493, 3551, true);
            WriteLiteral(@"<div class=""callout callout-warning"">
    <h4>Warning!</h4>

    <p>
        <b>Morris.js</b> charts are no longer maintained by its author. We would recommend using any of the other
        charts that come with the template.
    </p>
</div>
<div class=""row"">
    <div class=""col-md-6"">
        <!-- AREA CHART -->
        <div class=""box box-primary"">
            <div class=""box-header with-border"">
                <h3 class=""box-title"">Area Chart</h3>

                <div class=""box-tools pull-right"">
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                        <i class=""fa fa-minus""></i>
                    </button>
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i></button>
                </div>
            </div>
            <div class=""box-body chart-responsive"">
                <div class=""chart"" id=""revenue-chart"" style=""height: 300px;""></div>
            </div>
            <!-- /.b");
            WriteLiteral(@"ox-body -->
        </div>
        <!-- /.box -->
        <!-- DONUT CHART -->
        <div class=""box box-danger"">
            <div class=""box-header with-border"">
                <h3 class=""box-title"">Donut Chart</h3>

                <div class=""box-tools pull-right"">
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                        <i class=""fa fa-minus""></i>
                    </button>
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i></button>
                </div>
            </div>
            <div class=""box-body chart-responsive"">
                <div class=""chart"" id=""sales-chart"" style=""height: 300px; position: relative;""></div>
            </div>
            <!-- /.box-body -->
        </div>
        <!-- /.box -->

    </div>
    <!-- /.col (LEFT) -->
    <div class=""col-md-6"">
        <!-- LINE CHART -->
        <div class=""box box-info"">
            <div class=""box-header with-b");
            WriteLiteral(@"order"">
                <h3 class=""box-title"">Line Chart</h3>

                <div class=""box-tools pull-right"">
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                        <i class=""fa fa-minus""></i>
                    </button>
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i></button>
                </div>
            </div>
            <div class=""box-body chart-responsive"">
                <div class=""chart"" id=""line-chart"" style=""height: 300px;""></div>
            </div>
            <!-- /.box-body -->
        </div>
        <!-- /.box -->
        <!-- BAR CHART -->
        <div class=""box box-success"">
            <div class=""box-header with-border"">
                <h3 class=""box-title"">Bar Chart</h3>

                <div class=""box-tools pull-right"">
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                        <i class=""fa f");
            WriteLiteral(@"a-minus""></i>
                    </button>
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove""><i class=""fa fa-times""></i></button>
                </div>
            </div>
            <div class=""box-body chart-responsive"">
                <div class=""chart"" id=""bar-chart"" style=""height: 300px;""></div>
            </div>
            <!-- /.box-body -->
        </div>
        <!-- /.box -->

    </div>
    <!-- /.col (RIGHT) -->
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_Template_Pages_Charts_Morris> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Template_Pages_Charts_Morris> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Template_Pages_Charts_Morris>)PageContext?.ViewData;
        public Areas_Template_Pages_Charts_Morris Model => ViewData.Model;
    }
}
#pragma warning restore 1591
