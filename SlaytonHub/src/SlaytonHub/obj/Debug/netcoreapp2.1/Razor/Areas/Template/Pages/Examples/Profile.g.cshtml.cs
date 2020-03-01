#pragma checksum "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Examples/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdcf0eb144e714c5c54b169f29a068735f2df495"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SlaytonHub.Areas.Template.Pages.Examples.Areas_Template_Pages_Examples_Profile), @"mvc.1.0.razor-page", @"/Areas/Template/Pages/Examples/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Template/Pages/Examples/Profile.cshtml", typeof(SlaytonHub.Areas.Template.Pages.Examples.Areas_Template_Pages_Examples_Profile), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdcf0eb144e714c5c54b169f29a068735f2df495", @"/Areas/Template/Pages/Examples/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12120391a0edf442ef4f4de80d25de41727c708", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c25d9407126acdb25718cdff3d88e24295530e0", @"/Areas/Template/Pages/_ViewImports.cshtml")]
    public class Areas_Template_Pages_Examples_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Examples/Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "_LayoutAdminLTE";

#line default
#line hidden
            BeginContext(78, 6410, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-3"">

        <!-- Profile Image -->
        <div class=""box box-primary"">
            <div class=""box-body box-profile"">
                <img class=""profile-user-img img-responsive img-circle"" src=""https://d1m0vzlwib3qni.cloudfront.net/admin-lte/img/user4-128x128.jpg"" alt=""User profile picture"">

                <h3 class=""profile-username text-center"">Nina Mcintire</h3>

                <p class=""text-muted text-center"">Software Engineer</p>

                <ul class=""list-group list-group-unbordered"">
                    <li class=""list-group-item"">
                        <b>Followers</b> <a class=""pull-right"">1,322</a>
                    </li>
                    <li class=""list-group-item"">
                        <b>Following</b> <a class=""pull-right"">543</a>
                    </li>
                    <li class=""list-group-item"">
                        <b>Friends</b> <a class=""pull-right"">13,287</a>
                    </li>
                </ul>

        ");
            WriteLiteral(@"        <a href=""#"" class=""btn btn-primary btn-block""><b>Follow</b></a>
            </div>
            <!-- /.box-body -->
        </div>
        <!-- /.box -->
        <!-- About Me Box -->
        <div class=""box box-primary"">
            <div class=""box-header with-border"">
                <h3 class=""box-title"">About Me</h3>
            </div>
            <!-- /.box-header -->
            <div class=""box-body"">
                <strong><i class=""fa fa-book margin-r-5""></i> Education</strong>

                <p class=""text-muted"">
                    B.S. in Computer Science from the University of Tennessee at Knoxville
                </p>

                <hr>

                <strong><i class=""fa fa-map-marker margin-r-5""></i> Location</strong>

                <p class=""text-muted"">Malibu, California</p>

                <hr>

                <strong><i class=""fa fa-pencil margin-r-5""></i> Skills</strong>

                <p>
                    <span class=""label label-danger"">UI Design</span>
        ");
            WriteLiteral(@"            <span class=""label label-success"">Coding</span>
                    <span class=""label label-info"">Javascript</span>
                    <span class=""label label-warning"">PHP</span>
                    <span class=""label label-primary"">Node.js</span>
                </p>

                <hr>

                <strong><i class=""fa fa-file-text-o margin-r-5""></i> Notes</strong>

                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam fermentum enim neque.</p>
            </div>
            <!-- /.box-body -->
        </div>
        <!-- /.box -->
    </div>
    <!-- /.col -->
    <div class=""col-md-9"">
        <div class=""nav-tabs-custom"">
            <ul class=""nav nav-tabs"">
                <li class=""active""><a href=""#activity"" data-toggle=""tab"">Activity</a></li>
                <li><a href=""#timeline"" data-toggle=""tab"">Timeline</a></li>
                <li><a href=""#settings"" data-toggle=""tab"">Settings</a></li>
            </ul>
            <div class=""tab-content"">
   ");
            WriteLiteral(@"             <div class=""active tab-pane"" id=""activity"">
                    <!-- Post -->
                    <div class=""post"">
                        <div class=""user-block"">
                            <img class=""img-circle img-bordered-sm"" src=""https://d1m0vzlwib3qni.cloudfront.net/admin-lte/img/user1-128x128.jpg"" alt=""user image"">
                            <span class=""username"">
                                <a href=""#"">Jonathan Burke Jr.</a>
                                <a href=""#"" class=""pull-right btn-box-tool""><i class=""fa fa-times""></i></a>
                            </span>
                            <span class=""description"">Shared publicly - 7:30 PM today</span>
                        </div>
                        <!-- /.user-block -->
                        <p>
                            Lorem ipsum represents a long-held tradition for designers,
                            typographers and the like. Some people hate it and argue for
                            its demise, but o");
            WriteLiteral(@"thers ignore the hate as they create awesome
                            tools to help create filler text for everyone from bacon lovers
                            to Charlie Sheen fans.
                        </p>
                        <ul class=""list-inline"">
                            <li><a href=""#"" class=""link-black text-sm""><i class=""fa fa-share margin-r-5""></i> Share</a></li>
                            <li>
                                <a href=""#"" class=""link-black text-sm""><i class=""fa fa-thumbs-o-up margin-r-5""></i> Like</a>
                            </li>
                            <li class=""pull-right"">
                                <a href=""#"" class=""link-black text-sm"">
                                    <i class=""fa fa-comments-o margin-r-5""></i> Comments
                                    (5)
                                </a>
                            </li>
                        </ul>

                        <input class=""form-control input-sm"" type=""text"" placeholder=""");
            WriteLiteral(@"Type a comment"">
                    </div>
                    <!-- /.post -->
                    <!-- Post -->
                    <div class=""post clearfix"">
                        <div class=""user-block"">
                            <img class=""img-circle img-bordered-sm"" src=""https://d1m0vzlwib3qni.cloudfront.net/admin-lte/img/user7-128x128.jpg"" alt=""User Image"">
                            <span class=""username"">
                                <a href=""#"">Sarah Ross</a>
                                <a href=""#"" class=""pull-right btn-box-tool""><i class=""fa fa-times""></i></a>
                            </span>
                            <span class=""description"">Sent you a message - 3 days ago</span>
                        </div>
                        <!-- /.user-block -->
                        <p>
                            Lorem ipsum represents a long-held tradition for designers,
                            typographers and the like. Some people hate it and argue for
                     ");
            WriteLiteral(@"       its demise, but others ignore the hate as they create awesome
                            tools to help create filler text for everyone from bacon lovers
                            to Charlie Sheen fans.
                        </p>

                        ");
            EndContext();
            BeginContext(6488, 577, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d325b82a45124da793faff8585f5e4be", async() => {
                BeginContext(6518, 540, true);
                WriteLiteral(@"
                            <div class=""form-group margin-bottom-none"">
                                <div class=""col-sm-9"">
                                    <input class=""form-control input-sm"" placeholder=""Response"">
                                </div>
                                <div class=""col-sm-3"">
                                    <button type=""submit"" class=""btn btn-danger pull-right btn-block btn-sm"">Send</button>
                                </div>
                            </div>
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
            BeginContext(7065, 8399, true);
            WriteLiteral(@"
                    </div>
                    <!-- /.post -->
                    <!-- Post -->
                    <div class=""post"">
                        <div class=""user-block"">
                            <img class=""img-circle img-bordered-sm"" src=""https://d1m0vzlwib3qni.cloudfront.net/admin-lte/img/user6-128x128.jpg"" alt=""User Image"">
                            <span class=""username"">
                                <a href=""#"">Adam Jones</a>
                                <a href=""#"" class=""pull-right btn-box-tool""><i class=""fa fa-times""></i></a>
                            </span>
                            <span class=""description"">Posted 5 photos - 5 days ago</span>
                        </div>
                        <!-- /.user-block -->
                        <div class=""row margin-bottom"">
                            <div class=""col-sm-6"">
                                <img class=""img-responsive"" src=""https://d1m0vzlwib3qni.cloudfront.net/admin-lte/img/photo1.png"" alt=""Photo"">
     ");
            WriteLiteral(@"                       </div>
                            <!-- /.col -->
                            <div class=""col-sm-6"">
                                <div class=""row"">
                                    <div class=""col-sm-6"">
                                        <img class=""img-responsive"" src=""https://d1m0vzlwib3qni.cloudfront.net/admin-lte/img/photo2.png"" alt=""Photo"">
                                        <br>
                                        <img class=""img-responsive"" src=""https://d1m0vzlwib3qni.cloudfront.net/admin-lte/img/photo3.jpg"" alt=""Photo"">
                                    </div>
                                    <!-- /.col -->
                                    <div class=""col-sm-6"">
                                        <img class=""img-responsive"" src=""https://d1m0vzlwib3qni.cloudfront.net/admin-lte/img/photo4.jpg"" alt=""Photo"">
                                        <br>
                                        <img class=""img-responsive"" src=""https://d1m0vzlwib3qni.cl");
            WriteLiteral(@"oudfront.net/admin-lte/img/photo1.png"" alt=""Photo"">
                                    </div>
                                    <!-- /.col -->
                                </div>
                                <!-- /.row -->
                            </div>
                            <!-- /.col -->
                        </div>
                        <!-- /.row -->

                        <ul class=""list-inline"">
                            <li><a href=""#"" class=""link-black text-sm""><i class=""fa fa-share margin-r-5""></i> Share</a></li>
                            <li>
                                <a href=""#"" class=""link-black text-sm""><i class=""fa fa-thumbs-o-up margin-r-5""></i> Like</a>
                            </li>
                            <li class=""pull-right"">
                                <a href=""#"" class=""link-black text-sm"">
                                    <i class=""fa fa-comments-o margin-r-5""></i> Comments
                                    (5)
                        ");
            WriteLiteral(@"        </a>
                            </li>
                        </ul>

                        <input class=""form-control input-sm"" type=""text"" placeholder=""Type a comment"">
                    </div>
                    <!-- /.post -->
                </div>
                <!-- /.tab-pane -->
                <div class=""tab-pane"" id=""timeline"">
                    <!-- The timeline -->
                    <ul class=""timeline timeline-inverse"">
                        <!-- timeline time label -->
                        <li class=""time-label"">
                            <span class=""bg-red"">
                                10 Feb. 2014
                            </span>
                        </li>
                        <!-- /.timeline-label -->
                        <!-- timeline item -->
                        <li>
                            <i class=""fa fa-envelope bg-blue""></i>

                            <div class=""timeline-item"">
                                <span class=""time""><i c");
            WriteLiteral(@"lass=""fa fa-clock-o""></i> 12:05</span>

                                <h3 class=""timeline-header""><a href=""#"">Support Team</a> sent you an email</h3>

                                <div class=""timeline-body"">
                                    Etsy doostang zoodles disqus groupon greplin oooj voxy zoodles,
                                    weebly ning heekya handango imeem plugg dopplr jibjab, movity
                                    jajah plickers sifteo edmodo ifttt zimbra. Babblely odeo kaboodle
                                    quora plaxo ideeli hulu weebly balihoo...
                                </div>
                                <div class=""timeline-footer"">
                                    <a class=""btn btn-primary btn-xs"">Read more</a>
                                    <a class=""btn btn-danger btn-xs"">Delete</a>
                                </div>
                            </div>
                        </li>
                        <!-- END timeline item -->
             ");
            WriteLiteral(@"           <!-- timeline item -->
                        <li>
                            <i class=""fa fa-user bg-aqua""></i>

                            <div class=""timeline-item"">
                                <span class=""time""><i class=""fa fa-clock-o""></i> 5 mins ago</span>

                                <h3 class=""timeline-header no-border"">
                                    <a href=""#"">Sarah Young</a> accepted your friend request
                                </h3>
                            </div>
                        </li>
                        <!-- END timeline item -->
                        <!-- timeline item -->
                        <li>
                            <i class=""fa fa-comments bg-yellow""></i>

                            <div class=""timeline-item"">
                                <span class=""time""><i class=""fa fa-clock-o""></i> 27 mins ago</span>

                                <h3 class=""timeline-header""><a href=""#"">Jay White</a> commented on your post</h3>

     ");
            WriteLiteral(@"                           <div class=""timeline-body"">
                                    Take me to your leader!
                                    Switzerland is small and neutral!
                                    We are more like Germany, ambitious and misunderstood!
                                </div>
                                <div class=""timeline-footer"">
                                    <a class=""btn btn-warning btn-flat btn-xs"">View comment</a>
                                </div>
                            </div>
                        </li>
                        <!-- END timeline item -->
                        <!-- timeline time label -->
                        <li class=""time-label"">
                            <span class=""bg-green"">
                                3 Jan. 2014
                            </span>
                        </li>
                        <!-- /.timeline-label -->
                        <!-- timeline item -->
                        <li>
       ");
            WriteLiteral(@"                     <i class=""fa fa-camera bg-purple""></i>

                            <div class=""timeline-item"">
                                <span class=""time""><i class=""fa fa-clock-o""></i> 2 days ago</span>

                                <h3 class=""timeline-header""><a href=""#"">Mina Lee</a> uploaded new photos</h3>

                                <div class=""timeline-body"">
                                    <img src=""http://placehold.it/150x100"" alt=""..."" class=""margin"">
                                    <img src=""http://placehold.it/150x100"" alt=""..."" class=""margin"">
                                    <img src=""http://placehold.it/150x100"" alt=""..."" class=""margin"">
                                    <img src=""http://placehold.it/150x100"" alt=""..."" class=""margin"">
                                </div>
                            </div>
                        </li>
                        <!-- END timeline item -->
                        <li>
                            <i class=""fa fa-cloc");
            WriteLiteral("k-o bg-gray\"></i>\n                        </li>\n                    </ul>\n                </div>\n                <!-- /.tab-pane -->\n\n                <div class=\"tab-pane\" id=\"settings\">\n                    ");
            EndContext();
            BeginContext(15464, 2706, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71f2afa5d3fc4f83a3a642e873760215", async() => {
                BeginContext(15494, 2669, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label for=""inputName"" class=""col-sm-2 control-label"">Name</label>

                            <div class=""col-sm-10"">
                                <input type=""email"" class=""form-control"" id=""inputName"" placeholder=""Name"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""inputEmail"" class=""col-sm-2 control-label"">Email</label>

                            <div class=""col-sm-10"">
                                <input type=""email"" class=""form-control"" id=""inputEmail"" placeholder=""Email"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""inputName"" class=""col-sm-2 control-label"">Name</label>

                            <div class=""col-sm-10"">
                                <input type=""text"" class=""form-control"" id=""inpu");
                WriteLiteral(@"tName"" placeholder=""Name"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""inputExperience"" class=""col-sm-2 control-label"">Experience</label>

                            <div class=""col-sm-10"">
                                <textarea class=""form-control"" id=""inputExperience"" placeholder=""Experience""></textarea>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""inputSkills"" class=""col-sm-2 control-label"">Skills</label>

                            <div class=""col-sm-10"">
                                <input type=""text"" class=""form-control"" id=""inputSkills"" placeholder=""Skills"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-sm-offset-2 col-sm-10"">
                                <div cla");
                WriteLiteral(@"ss=""checkbox"">
                                    <label>
                                        <input type=""checkbox""> I agree to the <a href=""#"">terms and conditions</a>
                                    </label>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-sm-offset-2 col-sm-10"">
                                <button type=""submit"" class=""btn btn-danger"">Submit</button>
                            </div>
                        </div>
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
            BeginContext(18170, 202, true);
            WriteLiteral("\n                </div>\n                <!-- /.tab-pane -->\n            </div>\n            <!-- /.tab-content -->\n        </div>\n        <!-- /.nav-tabs-custom -->\n    </div>\n    <!-- /.col -->\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_Template_Pages_Examples_Profile> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Template_Pages_Examples_Profile> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Template_Pages_Examples_Profile>)PageContext?.ViewData;
        public Areas_Template_Pages_Examples_Profile Model => ViewData.Model;
    }
}
#pragma warning restore 1591
