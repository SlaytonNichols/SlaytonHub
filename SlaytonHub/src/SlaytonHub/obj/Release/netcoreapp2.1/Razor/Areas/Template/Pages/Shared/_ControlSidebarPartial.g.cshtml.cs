#pragma checksum "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Shared/_ControlSidebarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "352ba6a9aee1ad12ccda8ee4e71e9151f43d7315"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SlaytonHub.Areas.Template.Pages.Shared.Areas_Template_Pages_Shared__ControlSidebarPartial), @"mvc.1.0.view", @"/Areas/Template/Pages/Shared/_ControlSidebarPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Template/Pages/Shared/_ControlSidebarPartial.cshtml", typeof(SlaytonHub.Areas.Template.Pages.Shared.Areas_Template_Pages_Shared__ControlSidebarPartial))]
namespace SlaytonHub.Areas.Template.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"352ba6a9aee1ad12ccda8ee4e71e9151f43d7315", @"/Areas/Template/Pages/Shared/_ControlSidebarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12120391a0edf442ef4f4de80d25de41727c708", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c25d9407126acdb25718cdff3d88e24295530e0", @"/Areas/Template/Pages/_ViewImports.cshtml")]
    public class Areas_Template_Pages_Shared__ControlSidebarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 5443, true);
            WriteLiteral(@"
    <aside class=""control-sidebar control-sidebar-dark"">
        <!-- Create the tabs -->
        <ul class=""nav nav-tabs nav-justified control-sidebar-tabs"">
            <li><a href=""#control-sidebar-home-tab"" data-toggle=""tab""><i class=""fa fa-home""></i></a></li>
            <li><a href=""#control-sidebar-settings-tab"" data-toggle=""tab""><i class=""fa fa-gears""></i></a></li>
        </ul>
        <!-- Tab panes -->
        <div class=""tab-content"">
            <!-- Home tab content -->
            <div class=""tab-pane"" id=""control-sidebar-home-tab"">
                <h3 class=""control-sidebar-heading"">Recent Activity</h3>
                <ul class=""control-sidebar-menu"">
                    <li>
                        <a href=""javascript:void(0)"">
                            <i class=""menu-icon fa fa-birthday-cake bg-red""></i>
                            <div class=""menu-info"">
                                <h4 class=""control-sidebar-subheading"">Langdon's Birthday</h4>
                                <p>Will");
            WriteLiteral(@" be 23 on April 24th</p>
                            </div>
                        </a>
                    </li>
                    <li>
                        <a href=""javascript:void(0)"">
                            <i class=""menu-icon fa fa-user bg-yellow""></i>
                            <div class=""menu-info"">
                                <h4 class=""control-sidebar-subheading"">Frodo Updated His Profile</h4>
                                <p>New phone +1(800)555-1234</p>
                            </div>
                        </a>
                    </li>
                    <li>
                        <a href=""javascript:void(0)"">
                            <i class=""menu-icon fa fa-envelope-o bg-light-blue""></i>
                            <div class=""menu-info"">
                                <h4 class=""control-sidebar-subheading"">Nora Joined Mailing List</h4>
                                <p>nora@example.com</p>
                            </div>
                        </a>
         ");
            WriteLiteral(@"           </li>
                    <li>
                        <a href=""javascript:void(0)"">
                            <i class=""menu-icon fa fa-file-code-o bg-green""></i>
                            <div class=""menu-info"">
                                <h4 class=""control-sidebar-subheading"">Cron Job 254 Executed</h4>
                                <p>Execution time 5 seconds</p>
                            </div>
                        </a>
                    </li>
                </ul>
                <!-- /.control-sidebar-menu -->
                <h3 class=""control-sidebar-heading"">Tasks Progress</h3>
                <ul class=""control-sidebar-menu"">
                    <li>
                        <a href=""javascript:void(0)"">
                            <h4 class=""control-sidebar-subheading"">
                                Custom Template Design
                                <span class=""label label-danger pull-right"">70%</span>
                            </h4>
                            ");
            WriteLiteral(@"<div class=""progress progress-xxs"">
                                <div class=""progress-bar progress-bar-danger"" style=""width: 70%""></div>
                            </div>
                        </a>
                    </li>
                    <li>
                        <a href=""javascript:void(0)"">
                            <h4 class=""control-sidebar-subheading"">
                                Update Resume
                                <span class=""label label-success pull-right"">95%</span>
                            </h4>
                            <div class=""progress progress-xxs"">
                                <div class=""progress-bar progress-bar-success"" style=""width: 95%""></div>
                            </div>
                        </a>
                    </li>
                    <li>
                        <a href=""javascript:void(0)"">
                            <h4 class=""control-sidebar-subheading"">
                                Laravel Integration
                     ");
            WriteLiteral(@"           <span class=""label label-warning pull-right"">50%</span>
                            </h4>
                            <div class=""progress progress-xxs"">
                                <div class=""progress-bar progress-bar-warning"" style=""width: 50%""></div>
                            </div>
                        </a>
                    </li>
                    <li>
                        <a href=""javascript:void(0)"">
                            <h4 class=""control-sidebar-subheading"">
                                Back End Framework
                                <span class=""label label-primary pull-right"">68%</span>
                            </h4>
                            <div class=""progress progress-xxs"">
                                <div class=""progress-bar progress-bar-primary"" style=""width: 68%""></div>
                            </div>
                        </a>
                    </li>
                </ul>
                <!-- /.control-sidebar-menu -->
            </d");
            WriteLiteral(@"iv>
            <!-- /.tab-pane -->
            <!-- Stats tab content -->
            <div class=""tab-pane"" id=""control-sidebar-stats-tab"">Stats Tab Content</div>
            <!-- /.tab-pane -->
            <!-- Settings tab content -->
            <div class=""tab-pane"" id=""control-sidebar-settings-tab"">
                ");
            EndContext();
            BeginContext(5443, 2672, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ec32a4cd1504b5bb888450070109e59", async() => {
                BeginContext(5463, 2645, true);
                WriteLiteral(@"
                    <h3 class=""control-sidebar-heading"">General Settings</h3>
                    <div class=""form-group"">
                        <label class=""control-sidebar-subheading"">
                            Report panel usage
                            <input type=""checkbox"" class=""pull-right"" checked>
                        </label>
                        <p>
                            Some information about this general settings option
                        </p>
                    </div>
                    <!-- /.form-group -->
                    <div class=""form-group"">
                        <label class=""control-sidebar-subheading"">
                            Allow mail redirect
                            <input type=""checkbox"" class=""pull-right"" checked>
                        </label>
                        <p>
                            Other sets of options are available
                        </p>
                    </div>
                    <!-- /.form-group -->
      ");
                WriteLiteral(@"              <div class=""form-group"">
                        <label class=""control-sidebar-subheading"">
                            Expose author name in posts
                            <input type=""checkbox"" class=""pull-right"" checked>
                        </label>
                        <p>
                            Allow the user to show his name in blog posts
                        </p>
                    </div>
                    <!-- /.form-group -->
                    <h3 class=""control-sidebar-heading"">Chat Settings</h3>
                    <div class=""form-group"">
                        <label class=""control-sidebar-subheading"">
                            Show me as online
                            <input type=""checkbox"" class=""pull-right"" checked>
                        </label>
                    </div>
                    <!-- /.form-group -->
                    <div class=""form-group"">
                        <label class=""control-sidebar-subheading"">
                        ");
                WriteLiteral(@"    Turn off notifications
                            <input type=""checkbox"" class=""pull-right"">
                        </label>
                    </div>
                    <!-- /.form-group -->
                    <div class=""form-group"">
                        <label class=""control-sidebar-subheading"">
                            Delete chat history
                            <a href=""javascript:void(0)"" class=""text-red pull-right""><i class=""fa fa-trash-o""></i></a>
                        </label>
                    </div>
                    <!-- /.form-group -->
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8115, 79, true);
            WriteLiteral("\n            </div>\n            <!-- /.tab-pane -->\n        </div>\n    </aside>");
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
