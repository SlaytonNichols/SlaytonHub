#pragma checksum "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Pages/UI/Modals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54449ff0336924bd0df38d26f36d7233f812be82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SlaytonHub.Pages.UI.Pages_UI_Modals), @"mvc.1.0.razor-page", @"/Pages/UI/Modals.cshtml")]
namespace SlaytonHub.Pages.UI
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54449ff0336924bd0df38d26f36d7233f812be82", @"/Pages/UI/Modals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10c8519bb066ed35c09f85d55321516376d4ea40", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UI_Modals : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Pages/UI/Modals.cshtml"
  
    ViewData["Title"] = "Modals";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""callout callout-info"">
    <h4>Reminder!</h4>
    Instructions for how to use modals are available on the
    <a href=""http://getbootstrap.com/javascript/#modals"">Bootstrap documentation</a>
</div>

<div class=""row"">
    <div class=""col-xs-12"">
        <div class=""box box-default"">
            <div class=""box-header with-border"">
                <h3 class=""box-title"">Modal Examples</h3>
            </div>
            <div class=""box-body"">
                <button type=""button"" class=""btn btn-default"" data-toggle=""modal"" data-target=""#modal-default"">
                    Launch Default Modal
                </button>
                <button type=""button"" class=""btn btn-info"" data-toggle=""modal"" data-target=""#modal-info"">
                    Launch Info Modal
                </button>
                <button type=""button"" class=""btn btn-danger"" data-toggle=""modal"" data-target=""#modal-danger"">
                    Launch Danger Modal
                </button>
                <button type=""button"" clas");
            WriteLiteral(@"s=""btn btn-warning"" data-toggle=""modal"" data-target=""#modal-warning"">
                    Launch Warning Modal
                </button>
                <button type=""button"" class=""btn btn-success"" data-toggle=""modal"" data-target=""#modal-success"">
                    Launch Success Modal
                </button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""modal-default"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <h4 class=""modal-title"">Default Modal</h4>
            </div>
            <div class=""modal-body"">
                <p>One fine body&hellip;</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default pull-left"" data-dismiss=""modal"">Close</button>
");
            WriteLiteral(@"                <button type=""button"" class=""btn btn-primary"">Save changes</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

<div class=""modal modal-primary fade"" id=""modal-primary"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <h4 class=""modal-title"">Primary Modal</h4>
            </div>
            <div class=""modal-body"">
                <p>One fine body&hellip;</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-outline pull-left"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-outline"">Save changes</button>
            </div>
        </div>
        <!-- /.modal-c");
            WriteLiteral(@"ontent -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

<div class=""modal modal-info fade"" id=""modal-info"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <h4 class=""modal-title"">Info Modal</h4>
            </div>
            <div class=""modal-body"">
                <p>One fine body&hellip;</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-outline pull-left"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-outline"">Save changes</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

<div class=""modal modal-warning fade"" id=""modal-warning"">
    <div class=""");
            WriteLiteral(@"modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <h4 class=""modal-title"">Warning Modal</h4>
            </div>
            <div class=""modal-body"">
                <p>One fine body&hellip;</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-outline pull-left"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-outline"">Save changes</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

<div class=""modal modal-success fade"" id=""modal-success"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close");
            WriteLiteral(@""" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
                <h4 class=""modal-title"">Success Modal</h4>
            </div>
            <div class=""modal-body"">
                <p>One fine body&hellip;</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-outline pull-left"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-outline"">Save changes</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->

<div class=""modal modal-danger fade"" id=""modal-danger"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
             ");
            WriteLiteral(@"   <h4 class=""modal-title"">Danger Modal</h4>
            </div>
            <div class=""modal-body"">
                <p>One fine body&hellip;</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-outline pull-left"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-outline"">Save changes</button>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.modal -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_UI_Modals> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_UI_Modals> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_UI_Modals>)PageContext?.ViewData;
        public Pages_UI_Modals Model => ViewData.Model;
    }
}
#pragma warning restore 1591
