#pragma checksum "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Pages/Shared/_LayoutSlaytonHub.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60a0a143d188a3c299e2254a0283679ca14806fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SlaytonHub.Pages.Shared.Pages_Shared__LayoutSlaytonHub), @"mvc.1.0.view", @"/Pages/Shared/_LayoutSlaytonHub.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_LayoutSlaytonHub.cshtml", typeof(SlaytonHub.Pages.Shared.Pages_Shared__LayoutSlaytonHub))]
namespace SlaytonHub.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60a0a143d188a3c299e2254a0283679ca14806fd", @"/Pages/Shared/_LayoutSlaytonHub.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12120391a0edf442ef4f4de80d25de41727c708", @"/_ViewImports.cshtml")]
    public class Pages_Shared__LayoutSlaytonHub : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_HeadPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition skin-blue sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 23, true);
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            EndContext();
            BeginContext(23, 219, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bca7a27d6feb45d987fa57d77c64a12a", async() => {
                BeginContext(29, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(34, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3925d067120a4fb8b6113d0aec9eb4c2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(64, 129, true);
                WriteLiteral("\n    <!-- UIkit CSS -->\n    <link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/uikit@3.3.3/dist/css/uikit.min.css\"/>\n\n    ");
                EndContext();
                BeginContext(194, 40, false);
#line 8 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Pages/Shared/_LayoutSlaytonHub.cshtml"
Write(RenderSection("styles", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(234, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(242, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(243, 8959, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9426507bbab6466b89f1ff47e8294727", async() => {
                BeginContext(296, 7149, true);
                WriteLiteral(@"
<!-- TOP -->
<div class=""top-wrap uk-position-relative uk-light uk-background-secondary"">

    <!-- NAV -->
    <div class=""nav"" data-uk-sticky=""cls-active: uk-background-secondary uk-box-shadow-medium; top: 100vh; animation: uk-animation-slide-top"">
        <div class=""uk-container"">
            <nav class=""uk-navbar uk-navbar-container uk-navbar-transparent"" data-uk-navbar>
                <div class=""uk-navbar-left"">
                    <div class=""uk-navbar-item uk-padding-remove-horizontal"">
                        <a class=""uk-logo"" title=""Logo"" href="""">
                            <img src=""img/SlaytonNicholsLogo.svg"" alt=""Logo"">
                        </a>
                    </div>
                </div>
                <div class=""uk-navbar-right"">
                    <ul class=""uk-navbar-nav uk-visible@s"">
                        <li class=""uk-active uk-visible@m"">
                            <a href="""" data-uk-icon=""home""></a>
                        </li>
                        <li>
          ");
                WriteLiteral(@"                  <a href=""#about"">About</a>
                        </li>
                        <li>
                            <a href=""#projects"">Projects</a>
                        </li>
                        <li>
                            <a href=""#testimonials"">Testimonials</a>
                        </li>
                    </ul>
                    <a class=""uk-navbar-toggle uk-navbar-item uk-hidden@s"" data-uk-toggle data-uk-navbar-toggle-icon href=""#offcanvas-nav""></a>
                </div>
            </nav>
        </div>
    </div>
    <!-- /NAV -->

    <div class=""uk-cover-container uk-light uk-flex uk-flex-middle top-wrap-height"">

        <!-- TOP CONTAINER -->
        <div class=""uk-container uk-flex-auto top-container uk-position-relative uk-margin-medium-top"" data-uk-parallax=""y: 0,50; easing:0; opacity:0.2"">
            <div class=""uk-width-1-2@s"" data-uk-scrollspy=""cls: uk-animation-slide-right-medium; target: > *; delay: 150"">
                <h6 class=""uk-text-primary uk-marg");
                WriteLiteral(@"in-small-bottom"">Slayton Nichols</h6>
                <h1 class=""uk-margin-remove-top"">Full Stack Software Developer.</h1>
                <p class=""subtitle-text uk-visible@s"">
                    Full stack web development services.
                </p>
                <a href=""#"" title=""Learn More"" class=""uk-button uk-button-primary uk-border-pill"" data-uk-scrollspy-class=""uk-animation-fade"">LEARN MORE</a>
            </div>
        </div>
        <!-- /TOP CONTAINER -->
        <!-- TOP IMAGE -->
        <img src=""img/firescreek.png"" data-sizes=""100vw"" data-src=""img/firescreek.png"" alt="""" data-uk-cover data-uk-img data-uk-parallax=""opacity: 1,0.1; easing:0""/>
                  <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-srcset=""https://picsum.photos/640/700/?image=816 640w,
             				https://picsum.photos/960/700/?image=816 960w,
             				https://picsum.photos/1200/900/?image=816 1200w,
             				https://picsum.photos/2000/1000/?image=81");
                WriteLiteral(@"6 2000w""
                       data-sizes=""100vw""
                       data-src=""https://picsum.photos/1200/900/?image=816"" alt="""" data-uk-cover data-uk-img data-uk-parallax=""opacity: 1,0.1; easing:0"">
        <!-- /TOP IMAGE -->
    </div>
    <div class=""uk-position-bottom-center uk-position-medium uk-position-z-index uk-text-center"">
        <a href=""#content"" data-uk-scroll=""duration: 500"" data-uk-icon=""icon: arrow-down; ratio: 2""></a>
    </div>
</div>
<!-- /TOP -->
<section class=""uk-section uk-section-secondary uk-section-large"" id=""about"">
    <div class=""uk-container"">
        <div class=""uk-grid uk-child-width-1-2@l uk-flex-middle"">
            <div>
                <h6>About</h6>
                <h2 class=""uk-margin-small-top uk-h1"">Technology Skill Set</h2>
                <ul>
                    <li>Familiar with Web Development Life Cycle including requirement analysis, design, development, testing, deployment and support.</li>
                </ul>
                <ul>
                    <");
                WriteLiteral(@"li>Experience includes working with design patterns, OOP, Data Structures, Agile Development, Testing and Database Management.</li>
                </ul>
                <ul>
                    <li>Application development using latest ASP.NET and .NET Core Frameworks to build dynamic web pages.</li>
                </ul>
                <ul>
                    <li>Web service development and consuming web services with C#, RESTful API’s, and JSON.</li>
                </ul>
                <ul>
                    <li>MSSQL Database management including performance optimization with common design patterns and practices, DevOps against MSSQL Databases, and server administration.</li>
                </ul>
                <ul>
                    <li>Client product support including debugging field issues and product enhancement.</li>
                </ul>
                <a href=""#"" class=""uk-button uk-button-primary uk-border-pill"" data-uk-icon=""arrow-right"">LEARN MORE</a>
            </div>
            <di");
                WriteLiteral(@"v data-uk-scrollspy=""cls: uk-animation-fade"">
                <img src=""data:image/gif;base64,R0lGODlhAQABAAAAACH5BAEKAAEALAAAAAABAAEAAAICTAEAOw=="" data-src=""img/portfolio-2.svg"" data-uk-img alt=""Image"">
            </div>
        </div>
    </div>
</section>
<!-- BOTTOM -->
<section class=""uk-section uk-section-default"" id=""projects"">

    <div class=""uk-container uk-container-xsmall uk-text-center uk-section uk-padding-remove-top"">
        <h5 class=""uk-text-primary"">Projects</h5>
        <h2 class=""uk-margin-remove uk-h1"">Proven Track Record</h2>
    </div>
    <div class=""uk-container"" >
        <div class=""uk-grid uk-grid-large uk-child-width-1-3@m"" data-uk-grid data-uk-scrollspy=""target: > div; delay: 150; cls: uk-animation-slide-bottom-medium"">
            <div class=""uk-text-center"">
                <img data-src=""img/CodedAlchemy.png"" data-uk-img alt=""Image"">
                <h4 class=""uk-margin-small-bottom uk-margin-top uk-margin-remove-adjacent"">Coded Alchemy</h4>
                <p>Custom Umbraco");
                WriteLiteral(@" CMS style site. Visit the site <a href=""https://codedalchemy.com/"">here</a></p>
            </div>
            <div class=""uk-text-center"">
                <img data-src=""img/CedarViewDental.png"" data-uk-img alt=""Image"">
                <h4 class=""uk-margin-small-bottom uk-margin-top uk-margin-remove-adjacent"">Cedar View Dental</h4>
                <p>Custom Umbraco CMS style site. Visit the site <a href=""https://lynnwooddentistry.com/"">here</a></p>
            </div>
            <div class=""uk-text-center"">
                <img data-src=""img/ExampleApp.png"" data-uk-img alt=""Image"">
                <h4 class=""uk-margin-small-bottom uk-margin-top uk-margin-remove-adjacent"">Admnin Dashboard</h4>
                <p>Admin LTE Dashboard configured to run on AWS stack using CloudFormation, Lambda, CloudFront, and S3. See a demo <a href=""/template"">here</a></p>
            </div>
        </div>
    </div>
</section>
<!-- BOTTOM -->
<section id=""content"" class=""uk-section uk-section-default"">
    ");
                EndContext();
                BeginContext(7446, 12, false);
#line 137 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Pages/Shared/_LayoutSlaytonHub.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(7458, 1660, true);
                WriteLiteral(@"
</section>
<!-- FOOTER -->
<footer class=""uk-section uk-section-secondary uk-padding-remove-bottom"">
    <div class=""uk-container"">
        <div class=""uk-grid uk-grid-large"" data-uk-grid>
            <div class=""uk-width-1-2@m"">
                <h5>Slayton Nichols</h5>
                <p>Feel free to reach out for more information at <a href=""#"" title="""">nicholsslayton@gmail.com</a></p>
                <div>
                    
                    <a href="""" class=""uk-icon-button"" data-uk-icon=""facebook""></a>
                    <a href="""" class=""uk-icon-button"" data-uk-icon=""instagram""></a>
                </div>
            </div>
            <div class=""uk-width-1-6@m"">
                <h5>GitHub</h5>
                <a href=""https://github.com/SlaytonNichols"" class=""uk-icon-button"" data-uk-icon=""github""></a>
            </div>
            <div class=""uk-width-1-6@m"">
                <h5>LinkedIn</h5>
                <a href=""https://www.linkedin.com/in/SlaytonNichols/"" class=""uk-icon-button"" data-uk-ic");
                WriteLiteral(@"on=""linkedin""></a>
            </div>
            <div class=""uk-width-1-6@m"">
                <h5>Other</h5>
            </div>

        </div>
    </div>

    <div class=""uk-text-center uk-padding uk-padding-remove-horizontal"">
        <span class=""uk-text-small uk-text-muted"">
            © 2020 Slayton Nichols - <a href=""https://nicholsslayton.com"">Created by Slayton Nichols</a>
        </span>
    </div>
</footer>
<!-- /FOOTER -->
<!-- UIkit JS -->
<script src=""https://cdn.jsdelivr.net/npm/uikit@3.3.3/dist/js/uikit.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/uikit@3.3.3/dist/js/uikit-icons.min.js""></script>
");
                EndContext();
                BeginContext(9118, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "971173bac954452795f93e734a84f677", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9151, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(9153, 41, false);
#line 178 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Pages/Shared/_LayoutSlaytonHub.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(9194, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9202, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
