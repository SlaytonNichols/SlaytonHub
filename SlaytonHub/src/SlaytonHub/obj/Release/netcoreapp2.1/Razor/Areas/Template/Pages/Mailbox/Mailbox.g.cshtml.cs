#pragma checksum "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Mailbox/Mailbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0c5f6590621febdcbadcb9ef34c14b8b17fdfbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SlaytonHub.Areas.Template.Pages.Mailbox.Areas_Template_Pages_Mailbox_Mailbox), @"mvc.1.0.razor-page", @"/Areas/Template/Pages/Mailbox/Mailbox.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Template/Pages/Mailbox/Mailbox.cshtml", typeof(SlaytonHub.Areas.Template.Pages.Mailbox.Areas_Template_Pages_Mailbox_Mailbox), null)]
namespace SlaytonHub.Areas.Template.Pages.Mailbox
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0c5f6590621febdcbadcb9ef34c14b8b17fdfbd", @"/Areas/Template/Pages/Mailbox/Mailbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12120391a0edf442ef4f4de80d25de41727c708", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c25d9407126acdb25718cdff3d88e24295530e0", @"/Areas/Template/Pages/_ViewImports.cshtml")]
    public class Areas_Template_Pages_Mailbox_Mailbox : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Mailbox/Compose", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block margin-bottom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "ReadMail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Mailbox/Mailbox.cshtml"
  
    ViewData["Title"] = "Mailbox";
    ViewData["SubTitle"] = "13 new messages";

#line default
#line hidden
            DefineSection("styles", async() => {
                BeginContext(108, 133, true);
                WriteLiteral("\n    <!-- iCheck -->\n    <link rel=\"stylesheet\" href=\"https://d1m0vzlwib3qni.cloudfront.net/wwwroot/lib/iCheck/skins/flat/blue.css\">\n");
                EndContext();
            }
            );
            DefineSection("Scripts", async() => {
                BeginContext(260, 1911, true);
                WriteLiteral(@"
    <!-- iCheck -->
    <script src=""https://d1m0vzlwib3qni.cloudfront.net/wwwroot/lib/iCheck/icheck.min.js""></script>
    <script>
        $(function () {
            //Enable iCheck plugin for checkboxes
            //iCheck for checkbox and radio inputs
            $('.mailbox-messages input[type=""checkbox""]').iCheck({
                checkboxClass: 'icheckbox_flat-blue',
                radioClass: 'iradio_flat-blue'
            });

            //Enable check and uncheck all functionality
            $("".checkbox-toggle"").click(function () {
                var clicks = $(this).data('clicks');
                if (clicks) {
                    //Uncheck all checkboxes
                    $("".mailbox-messages input[type='checkbox']"").iCheck(""uncheck"");
                    $("".fa"", this).removeClass(""fa-check-square-o"").addClass('fa-square-o');
                } else {
                    //Check all checkboxes
                    $("".mailbox-messages input[type='checkbox']"").iCheck(""check"");
             ");
                WriteLiteral(@"       $("".fa"", this).removeClass(""fa-square-o"").addClass('fa-check-square-o');
                }
                $(this).data(""clicks"", !clicks);
            });

            //Handle starring for glyphicon and font awesome
            $("".mailbox-star"").click(function (e) {
                e.preventDefault();
                //detect type
                var $this = $(this).find(""a > i"");
                var glyph = $this.hasClass(""glyphicon"");
                var fa = $this.hasClass(""fa"");

                //Switch states
                if (glyph) {
                    $this.toggleClass(""glyphicon-star"");
                    $this.toggleClass(""glyphicon-star-empty"");
                }

                if (fa) {
                    $this.toggleClass(""fa-star"");
                    $this.toggleClass(""fa-star-o"");
                }
            });
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(2173, 54, true);
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-3\">\n        ");
            EndContext();
            BeginContext(2227, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8ba2129cee2441a885ad83603630ded", async() => {
                BeginContext(2306, 7, true);
                WriteLiteral("Compose");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2317, 4700, true);
            WriteLiteral(@"

        <div class=""box box-solid"">
            <div class=""box-header with-border"">
                <h3 class=""box-title"">Folders</h3>

                <div class=""box-tools"">
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                        <i class=""fa fa-minus""></i>
                    </button>
                </div>
            </div>
            <div class=""box-body no-padding"">
                <ul class=""nav nav-pills nav-stacked"">
                    <li class=""active"">
                        <a href=""#"">
                            <i class=""fa fa-inbox""></i> Inbox
                            <span class=""label label-primary pull-right"">12</span>
                        </a>
                    </li>
                    <li><a href=""#""><i class=""fa fa-envelope-o""></i> Sent</a></li>
                    <li><a href=""#""><i class=""fa fa-file-text-o""></i> Drafts</a></li>
                    <li>
                        <a href=""#""><i class=""fa fa-filter");
            WriteLiteral(@"""></i> Junk <span class=""label label-warning pull-right"">65</span></a>
                    </li>
                    <li><a href=""#""><i class=""fa fa-trash-o""></i> Trash</a></li>
                </ul>
            </div>
            <!-- /.box-body -->
        </div>
        <!-- /. box -->
        <div class=""box box-solid"">
            <div class=""box-header with-border"">
                <h3 class=""box-title"">Labels</h3>

                <div class=""box-tools"">
                    <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                        <i class=""fa fa-minus""></i>
                    </button>
                </div>
            </div>
            <div class=""box-body no-padding"">
                <ul class=""nav nav-pills nav-stacked"">
                    <li><a href=""#""><i class=""fa fa-circle-o text-red""></i> Important</a></li>
                    <li><a href=""#""><i class=""fa fa-circle-o text-yellow""></i> Promotions</a></li>
                    <li><a href=""#""><i class=""fa");
            WriteLiteral(@" fa-circle-o text-light-blue""></i> Social</a></li>
                </ul>
            </div>
            <!-- /.box-body -->
        </div>
        <!-- /.box -->
    </div>
    <!-- /.col -->
    <div class=""col-md-9"">
        <div class=""box box-primary"">
            <div class=""box-header with-border"">
                <h3 class=""box-title"">Inbox</h3>

                <div class=""box-tools pull-right"">
                    <div class=""has-feedback"">
                        <input type=""text"" class=""form-control input-sm"" placeholder=""Search Mail"">
                        <span class=""glyphicon glyphicon-search form-control-feedback""></span>
                    </div>
                </div>
                <!-- /.box-tools -->
            </div>
            <!-- /.box-header -->
            <div class=""box-body no-padding"">
                <div class=""mailbox-controls"">
                    <!-- Check all button -->
                    <button type=""button"" class=""btn btn-default btn-sm checkbox-toggle"">
      ");
            WriteLiteral(@"                  <i class=""fa fa-square-o""></i>
                    </button>
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-trash-o""></i></button>
                        <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-reply""></i></button>
                        <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-share""></i></button>
                    </div>
                    <!-- /.btn-group -->
                    <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-refresh""></i></button>
                    <div class=""pull-right"">
                        1-50/200
                        <div class=""btn-group"">
                            <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-chevron-left""></i></button>
                            <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-chevron-right""></i></button>
");
            WriteLiteral(@"                        </div>
                        <!-- /.btn-group -->
                    </div>
                    <!-- /.pull-right -->
                </div>
                <div class=""table-responsive mailbox-messages"">
                    <table class=""table table-hover table-striped"">
                        <tbody>
                            <tr>
                                <td><input type=""checkbox""></td>
                                <td class=""mailbox-star""><a href=""#""><i class=""fa fa-star text-yellow""></i></a></td>
                                <td class=""mailbox-name"">");
            EndContext();
            BeginContext(7017, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23b2fcde87ea481da4a02b4222185ed8", async() => {
                BeginContext(7040, 16, true);
                WriteLiteral("Alexander Pierce");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7060, 12302, true);
            WriteLiteral(@"</td>
                                <td class=""mailbox-subject"">
                                    <b>SlaytonHub Issue</b> - Trying to find a solution to this problem...
                                </td>
                                <td class=""mailbox-attachment""></td>
                                <td class=""mailbox-date"">5 mins ago</td>
                            </tr>
                            <tr>
                                <td><input type=""checkbox""></td>
                                <td class=""mailbox-star""><a href=""#""><i class=""fa fa-star-o text-yellow""></i></a></td>
                                <td class=""mailbox-name""><a href=""read-mail.html"">Alexander Pierce</a></td>
                                <td class=""mailbox-subject"">
                                    <b>SlaytonHub Issue</b> - Trying to find a solution to this problem...
                                </td>
                                <td class=""mailbox-attachment""><i class=""fa fa-paperclip""></i></td>
     ");
            WriteLiteral(@"                           <td class=""mailbox-date"">28 mins ago</td>
                            </tr>
                            <tr>
                                <td><input type=""checkbox""></td>
                                <td class=""mailbox-star""><a href=""#""><i class=""fa fa-star-o text-yellow""></i></a></td>
                                <td class=""mailbox-name""><a href=""read-mail.html"">Alexander Pierce</a></td>
                                <td class=""mailbox-subject"">
                                    <b>SlaytonHub Issue</b> - Trying to find a solution to this problem...
                                </td>
                                <td class=""mailbox-attachment""><i class=""fa fa-paperclip""></i></td>
                                <td class=""mailbox-date"">11 hours ago</td>
                            </tr>
                            <tr>
                                <td><input type=""checkbox""></td>
                                <td class=""mailbox-star""><a href=""#""><i class=""fa f");
            WriteLiteral(@"a-star text-yellow""></i></a></td>
                                <td class=""mailbox-name""><a href=""read-mail.html"">Alexander Pierce</a></td>
                                <td class=""mailbox-subject"">
                                    <b>SlaytonHub Issue</b> - Trying to find a solution to this problem...
                                </td>
                                <td class=""mailbox-attachment""></td>
                                <td class=""mailbox-date"">15 hours ago</td>
                            </tr>
                            <tr>
                                <td><input type=""checkbox""></td>
                                <td class=""mailbox-star""><a href=""#""><i class=""fa fa-star text-yellow""></i></a></td>
                                <td class=""mailbox-name""><a href=""read-mail.html"">Alexander Pierce</a></td>
                                <td class=""mailbox-subject"">
                                    <b>SlaytonHub Issue</b> - Trying to find a solution to this problem...
       ");
            WriteLiteral(@"                         </td>
                                <td class=""mailbox-attachment""><i class=""fa fa-paperclip""></i></td>
                                <td class=""mailbox-date"">Yesterday</td>
                            </tr>
                            <tr>
                                <td><input type=""checkbox""></td>
                                <td class=""mailbox-star""><a href=""#""><i class=""fa fa-star-o text-yellow""></i></a></td>
                                <td class=""mailbox-name""><a href=""read-mail.html"">Alexander Pierce</a></td>
                                <td class=""mailbox-subject"">
                                    <b>SlaytonHub Issue</b> - Trying to find a solution to this problem...
                                </td>
                                <td class=""mailbox-attachment""><i class=""fa fa-paperclip""></i></td>
                                <td class=""mailbox-date"">2 days ago</td>
                            </tr>
                            <tr>
                ");
            WriteLiteral(@"                <td><input type=""checkbox""></td>
                                <td class=""mailbox-star""><a href=""#""><i class=""fa fa-star-o text-yellow""></i></a></td>
                                <td class=""mailbox-name""><a href=""read-mail.html"">Alexander Pierce</a></td>
                                <td class=""mailbox-subject"">
                                    <b>SlaytonHub Issue</b> - Trying to find a solution to this problem...
                                </td>
                                <td class=""mailbox-attachment""><i class=""fa fa-paperclip""></i></td>
                                <td class=""mailbox-date"">2 days ago</td>
                            </tr>
                            <tr>
                                <td><input type=""checkbox""></td>
                                <td class=""mailbox-star""><a href=""#""><i class=""fa fa-star text-yellow""></i></a></td>
                                <td class=""mailbox-name""><a href=""read-mail.html"">Alexander Pierce</a></td>
            ");
            WriteLiteral(@"                    <td class=""mailbox-subject"">
                                    <b>SlaytonHub Issue</b> - Trying to find a solution to this problem...
                                </td>
                                <td class=""mailbox-attachment""></td>
                                <td class=""mailbox-date"">2 days ago</td>
                            </tr>
                            <tr>
                                <td><input type=""checkbox""></td>
                                <td class=""mailbox-star""><a href=""#""><i class=""fa fa-star text-yellow""></i></a></td>
                                <td class=""mailbox-name""><a href=""read-mail.html"">Alexander Pierce</a></td>
                                <td class=""mailbox-subject"">
                                    <b>SlaytonHub Issue</b> - Trying to find a solution to this problem...
                                </td>
                                <td class=""mailbox-attachment""></td>
                                <td class=""mailbox-date""");
            WriteLiteral(@">2 days ago</td>
                            </tr>
                            <tr>
                                <td><input type=""checkbox""></td>
                                <td class=""mailbox-star""><a href=""#""><i class=""fa fa-star-o text-yellow""></i></a></td>
                                <td class=""mailbox-name""><a href=""read-mail.html"">Alexander Pierce</a></td>
                                <td class=""mailbox-subject"">
                                    <b>SlaytonHub Issue</b> - Trying to find a solution to this problem...
                                </td>
                                <td class=""mailbox-attachment""></td>
                                <td class=""mailbox-date"">2 days ago</td>
                            </tr>
                            <tr>
                                <td><input type=""checkbox""></td>
                                <td class=""mailbox-star""><a href=""#""><i class=""fa fa-star-o text-yellow""></i></a></td>
                                <td class=""mailbo");
            WriteLiteral(@"x-name""><a href=""read-mail.html"">Alexander Pierce</a></td>
                                <td class=""mailbox-subject"">
                                    <b>SlaytonHub Issue</b> - Trying to find a solution to this problem...
                                </td>
                                <td class=""mailbox-attachment""><i class=""fa fa-paperclip""></i></td>
                                <td class=""mailbox-date"">4 days ago</td>
                            </tr>
                            <tr>
                                <td><input type=""checkbox""></td>
                                <td class=""mailbox-star""><a href=""#""><i class=""fa fa-star text-yellow""></i></a></td>
                                <td class=""mailbox-name""><a href=""read-mail.html"">Alexander Pierce</a></td>
                                <td class=""mailbox-subject"">
                                    <b>SlaytonHub Issue</b> - Trying to find a solution to this problem...
                                </td>
                       ");
            WriteLiteral(@"         <td class=""mailbox-attachment""></td>
                                <td class=""mailbox-date"">12 days ago</td>
                            </tr>
                            <tr>
                                <td><input type=""checkbox""></td>
                                <td class=""mailbox-star""><a href=""#""><i class=""fa fa-star-o text-yellow""></i></a></td>
                                <td class=""mailbox-name""><a href=""read-mail.html"">Alexander Pierce</a></td>
                                <td class=""mailbox-subject"">
                                    <b>SlaytonHub Issue</b> - Trying to find a solution to this problem...
                                </td>
                                <td class=""mailbox-attachment""><i class=""fa fa-paperclip""></i></td>
                                <td class=""mailbox-date"">12 days ago</td>
                            </tr>
                            <tr>
                                <td><input type=""checkbox""></td>
                                <");
            WriteLiteral(@"td class=""mailbox-star""><a href=""#""><i class=""fa fa-star text-yellow""></i></a></td>
                                <td class=""mailbox-name""><a href=""read-mail.html"">Alexander Pierce</a></td>
                                <td class=""mailbox-subject"">
                                    <b>SlaytonHub Issue</b> - Trying to find a solution to this problem...
                                </td>
                                <td class=""mailbox-attachment""><i class=""fa fa-paperclip""></i></td>
                                <td class=""mailbox-date"">14 days ago</td>
                            </tr>
                            <tr>
                                <td><input type=""checkbox""></td>
                                <td class=""mailbox-star""><a href=""#""><i class=""fa fa-star text-yellow""></i></a></td>
                                <td class=""mailbox-name""><a href=""read-mail.html"">Alexander Pierce</a></td>
                                <td class=""mailbox-subject"">
                                  ");
            WriteLiteral(@"  <b>SlaytonHub Issue</b> - Trying to find a solution to this problem...
                                </td>
                                <td class=""mailbox-attachment""><i class=""fa fa-paperclip""></i></td>
                                <td class=""mailbox-date"">15 days ago</td>
                            </tr>
                        </tbody>
                    </table>
                    <!-- /.table -->
                </div>
                <!-- /.mail-box-messages -->
            </div>
            <!-- /.box-body -->
            <div class=""box-footer no-padding"">
                <div class=""mailbox-controls"">
                    <!-- Check all button -->
                    <button type=""button"" class=""btn btn-default btn-sm checkbox-toggle"">
                        <i class=""fa fa-square-o""></i>
                    </button>
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-trash-o""></i></button>
           ");
            WriteLiteral(@"             <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-reply""></i></button>
                        <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-share""></i></button>
                    </div>
                    <!-- /.btn-group -->
                    <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-refresh""></i></button>
                    <div class=""pull-right"">
                        1-50/200
                        <div class=""btn-group"">
                            <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-chevron-left""></i></button>
                            <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-chevron-right""></i></button>
                        </div>
                        <!-- /.btn-group -->
                    </div>
                    <!-- /.pull-right -->
                </div>
            </div>
        </div>
        <!-- /. box -->
    </div>
    <!-- /.co");
            WriteLiteral("l -->\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_Template_Pages_Mailbox_Mailbox> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Template_Pages_Mailbox_Mailbox> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Template_Pages_Mailbox_Mailbox>)PageContext?.ViewData;
        public Areas_Template_Pages_Mailbox_Mailbox Model => ViewData.Model;
    }
}
#pragma warning restore 1591
