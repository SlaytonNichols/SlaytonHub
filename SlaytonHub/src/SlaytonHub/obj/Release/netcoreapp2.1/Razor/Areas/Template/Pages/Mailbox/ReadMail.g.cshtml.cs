#pragma checksum "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Mailbox/ReadMail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b612b21f3ee73e9650b593b1637b829bd838fc99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SlaytonHub.Areas.Template.Pages.Mailbox.Areas_Template_Pages_Mailbox_ReadMail), @"mvc.1.0.razor-page", @"/Areas/Template/Pages/Mailbox/ReadMail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Template/Pages/Mailbox/ReadMail.cshtml", typeof(SlaytonHub.Areas.Template.Pages.Mailbox.Areas_Template_Pages_Mailbox_ReadMail), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b612b21f3ee73e9650b593b1637b829bd838fc99", @"/Areas/Template/Pages/Mailbox/ReadMail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12120391a0edf442ef4f4de80d25de41727c708", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c25d9407126acdb25718cdff3d88e24295530e0", @"/Areas/Template/Pages/_ViewImports.cshtml")]
    public class Areas_Template_Pages_Mailbox_ReadMail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Mailbox/ReadMail.cshtml"
  
    ViewData["Title"] = "Read Mail";
    Layout = "_LayoutAdminLTE";

#line default
#line hidden
            BeginContext(80, 11534, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-3"">
        <a href=""compose.html"" class=""btn btn-primary btn-block margin-bottom"">Compose</a>

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
                    <li>
                        <a href=""mailbox.html"">
                            <i class=""fa fa-inbox""></i> Inbox
                            <span class=""label label-primary pull-right"">12</span>
                        </a>
                    </li>
                    <li><a href=""#""><i class=""fa fa-envelope-o""></i> Sent</a></li>
                    <li><a href=""#""><");
            WriteLiteral(@"i class=""fa fa-file-text-o""></i> Drafts</a></li>
                    <li>
                        <a href=""#""><i class=""fa fa-filter""></i> Junk <span class=""label label-warning pull-right"">65</span></a>
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
               ");
            WriteLiteral(@"     <li><a href=""#""><i class=""fa fa-circle-o text-yellow""></i> Promotions</a></li>
                    <li><a href=""#""><i class=""fa fa-circle-o text-light-blue""></i> Social</a></li>
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
                <h3 class=""box-title"">Read Mail</h3>

                <div class=""box-tools pull-right"">
                    <a href=""#"" class=""btn btn-box-tool"" data-toggle=""tooltip"" title=""Previous""><i class=""fa fa-chevron-left""></i></a>
                    <a href=""#"" class=""btn btn-box-tool"" data-toggle=""tooltip"" title=""Next""><i class=""fa fa-chevron-right""></i></a>
                </div>
            </div>
            <!-- /.box-header -->
            <div class=""box-body no-padding"">
                <div class=""mailbox-read-info"">
                    <h3>Message Subject Is P");
            WriteLiteral(@"laced Here</h3>
                    <h5>
                        From: help@example.com
                        <span class=""mailbox-read-time pull-right"">15 Feb. 2016 11:03 PM</span>
                    </h5>
                </div>
                <!-- /.mailbox-read-info -->
                <div class=""mailbox-controls with-border text-center"">
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-default btn-sm"" data-toggle=""tooltip"" data-container=""body"" title=""Delete"">
                            <i class=""fa fa-trash-o""></i>
                        </button>
                        <button type=""button"" class=""btn btn-default btn-sm"" data-toggle=""tooltip"" data-container=""body"" title=""Reply"">
                            <i class=""fa fa-reply""></i>
                        </button>
                        <button type=""button"" class=""btn btn-default btn-sm"" data-toggle=""tooltip"" data-container=""body"" title=""Forward"">
                            <i class=""");
            WriteLiteral(@"fa fa-share""></i>
                        </button>
                    </div>
                    <!-- /.btn-group -->
                    <button type=""button"" class=""btn btn-default btn-sm"" data-toggle=""tooltip"" title=""Print"">
                        <i class=""fa fa-print""></i>
                    </button>
                </div>
                <!-- /.mailbox-controls -->
                <div class=""mailbox-read-message"">
                    <p>Hello John,</p>

                    <p>
                        Keffiyeh blog actually fashion axe vegan, irony biodiesel. Cold-pressed hoodie chillwave put a bird
                        on it aesthetic, bitters brunch meggings vegan iPhone. Dreamcatcher vegan scenester mlkshk. Ethical
                        master cleanse Bushwick, occupy Thundercats banjo cliche ennui farm-to-table mlkshk fanny pack
                        gluten-free. Marfa butcher vegan quinoa, bicycle rights disrupt tofu scenester chillwave 3 wolf moon
                        asymmetrical t");
            WriteLiteral(@"axidermy pour-over. Quinoa tote bag fashion axe, Godard disrupt migas church-key tofu
                        blog locavore. Thundercats cronut polaroid Neutra tousled, meh food truck selfies narwhal American
                        Apparel.
                    </p>

                    <p>
                        Raw denim McSweeney's bicycle rights, iPhone trust fund quinoa Neutra VHS kale chips vegan PBR&amp;B
                        literally Thundercats +1. Forage tilde four dollar toast, banjo health goth paleo butcher. Four dollar
                        toast Brooklyn pour-over American Apparel sustainable, lumbersexual listicle gluten-free health goth
                        umami hoodie. Synth Echo Park bicycle rights DIY farm-to-table, retro kogi sriracha dreamcatcher PBR&amp;B
                        flannel hashtag irony Wes Anderson. Lumbersexual Williamsburg Helvetica next level. Cold-pressed
                        slow-carb pop-up normcore Thundercats Portland, cardigan literally meditation l");
            WriteLiteral(@"umbersexual crucifix.
                        Wayfarers raw denim paleo Bushwick, keytar Helvetica scenester keffiyeh 8-bit irony mumblecore
                        whatever viral Truffaut.
                    </p>

                    <p>
                        Post-ironic shabby chic VHS, Marfa keytar flannel lomo try-hard keffiyeh cray. Actually fap fanny
                        pack yr artisan trust fund. High Life dreamcatcher church-key gentrify. Tumblr stumptown four dollar
                        toast vinyl, cold-pressed try-hard blog authentic keffiyeh Helvetica lo-fi tilde Intelligentsia. Lomo
                        locavore salvia bespoke, twee fixie paleo cliche brunch Schlitz blog McSweeney's messenger bag swag
                        slow-carb. Odd Future photo booth pork belly, you probably haven't heard of them actually tofu ennui
                        keffiyeh lo-fi Truffaut health goth. Narwhal sustainable retro disrupt.
                    </p>

                    <p>
                ");
            WriteLiteral(@"        Skateboard artisan letterpress before they sold out High Life messenger bag. Bitters chambray
                        leggings listicle, drinking vinegar chillwave synth. Fanny pack hoodie American Apparel twee. American
                        Apparel PBR listicle, salvia aesthetic occupy sustainable Neutra kogi. Organic synth Tumblr viral
                        plaid, shabby chic single-origin coffee Etsy 3 wolf moon slow-carb Schlitz roof party tousled squid
                        vinyl. Readymade next level literally trust fund. Distillery master cleanse migas, Vice sriracha
                        flannel chambray chia cronut.
                    </p>

                    <p>Thanks,<br>Jane</p>
                </div>
                <!-- /.mailbox-read-message -->
            </div>
            <!-- /.box-body -->
            <div class=""box-footer"">
                <ul class=""mailbox-attachments clearfix"">
                    <li>
                        <span class=""mailbox-attachment-icon""><");
            WriteLiteral(@"i class=""fa fa-file-pdf-o""></i></span>

                        <div class=""mailbox-attachment-info"">
                            <a href=""#"" class=""mailbox-attachment-name""><i class=""fa fa-paperclip""></i> Sep2014-report.pdf</a>
                            <span class=""mailbox-attachment-size"">
                                1,245 KB
                                <a href=""#"" class=""btn btn-default btn-xs pull-right""><i class=""fa fa-cloud-download""></i></a>
                            </span>
                        </div>
                    </li>
                    <li>
                        <span class=""mailbox-attachment-icon""><i class=""fa fa-file-word-o""></i></span>

                        <div class=""mailbox-attachment-info"">
                            <a href=""#"" class=""mailbox-attachment-name""><i class=""fa fa-paperclip""></i> App Description.docx</a>
                            <span class=""mailbox-attachment-size"">
                                1,245 KB
                                <a href");
            WriteLiteral(@"=""#"" class=""btn btn-default btn-xs pull-right""><i class=""fa fa-cloud-download""></i></a>
                            </span>
                        </div>
                    </li>
                    <li>
                        <span class=""mailbox-attachment-icon has-img""><img src=""https://d1m0vzlwib3qni.cloudfront.net/admin-lte/img/photo1.png"" alt=""Attachment""></span>

                        <div class=""mailbox-attachment-info"">
                            <a href=""#"" class=""mailbox-attachment-name""><i class=""fa fa-camera""></i> photo1.png</a>
                            <span class=""mailbox-attachment-size"">
                                2.67 MB
                                <a href=""#"" class=""btn btn-default btn-xs pull-right""><i class=""fa fa-cloud-download""></i></a>
                            </span>
                        </div>
                    </li>
                    <li>
                        <span class=""mailbox-attachment-icon has-img""><img src=""https://d1m0vzlwib3qni.cloudfront.net/");
            WriteLiteral(@"admin-lte/img/photo2.png"" alt=""Attachment""></span>

                        <div class=""mailbox-attachment-info"">
                            <a href=""#"" class=""mailbox-attachment-name""><i class=""fa fa-camera""></i> photo2.png</a>
                            <span class=""mailbox-attachment-size"">
                                1.9 MB
                                <a href=""#"" class=""btn btn-default btn-xs pull-right""><i class=""fa fa-cloud-download""></i></a>
                            </span>
                        </div>
                    </li>
                </ul>
            </div>
            <!-- /.box-footer -->
            <div class=""box-footer"">
                <div class=""pull-right"">
                    <button type=""button"" class=""btn btn-default""><i class=""fa fa-reply""></i> Reply</button>
                    <button type=""button"" class=""btn btn-default""><i class=""fa fa-share""></i> Forward</button>
                </div>
                <button type=""button"" class=""btn btn-default""><i class=""");
            WriteLiteral(@"fa fa-trash-o""></i> Delete</button>
                <button type=""button"" class=""btn btn-default""><i class=""fa fa-print""></i> Print</button>
            </div>
            <!-- /.box-footer -->
        </div>
        <!-- /. box -->
    </div>
    <!-- /.col -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_Template_Pages_Mailbox_ReadMail> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Template_Pages_Mailbox_ReadMail> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Template_Pages_Mailbox_ReadMail>)PageContext?.ViewData;
        public Areas_Template_Pages_Mailbox_ReadMail Model => ViewData.Model;
    }
}
#pragma warning restore 1591
