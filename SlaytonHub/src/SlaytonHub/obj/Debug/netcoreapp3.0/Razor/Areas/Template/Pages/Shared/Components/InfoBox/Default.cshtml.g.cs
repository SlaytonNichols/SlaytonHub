#pragma checksum "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Shared/Components/InfoBox/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3338f8b4c145e6d2f80a01e9c9e6068df71b4fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SlaytonHub.Areas.Template.Pages.Shared.Components.InfoBox.Areas_Template_Pages_Shared_Components_InfoBox_Default), @"mvc.1.0.view", @"/Areas/Template/Pages/Shared/Components/InfoBox/Default.cshtml")]
namespace SlaytonHub.Areas.Template.Pages.Shared.Components.InfoBox
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3338f8b4c145e6d2f80a01e9c9e6068df71b4fb", @"/Areas/Template/Pages/Shared/Components/InfoBox/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f12120391a0edf442ef4f4de80d25de41727c708", @"/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c25d9407126acdb25718cdff3d88e24295530e0", @"/Areas/Template/Pages/_ViewImports.cshtml")]
    public class Areas_Template_Pages_Shared_Components_InfoBox_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SlaytonHub.Model.InfoBoxModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 41, "\"", 142, 2);
            WriteAttributeValue("", 49, "info-box", 49, 8, true);
#nullable restore
#line 2 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Shared/Components/InfoBox/Default.cshtml"
WriteAttributeValue(" ", 57, !string.IsNullOrWhiteSpace(Model.BackgroundBox)? $"bg-{Model.BackgroundBox}":null, 58, 84, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    <span");
            BeginWriteAttribute("class", " class=\"", 154, "\"", 262, 2);
            WriteAttributeValue("", 162, "info-box-icon", 162, 13, true);
#nullable restore
#line 3 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Shared/Components/InfoBox/Default.cshtml"
WriteAttributeValue(" ", 175, !string.IsNullOrWhiteSpace(Model.BackgroundIcon)? $"bg-{Model.BackgroundIcon}":null, 176, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 266, "\"", 291, 3);
            WriteAttributeValue("", 274, "fa", 274, 2, true);
            WriteAttributeValue(" ", 276, "fa-", 277, 4, true);
#nullable restore
#line 3 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Shared/Components/InfoBox/Default.cshtml"
WriteAttributeValue("", 280, Model.Icon, 280, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></span>\n\n    <div class=\"info-box-content\">\n        <span class=\"info-box-text\">");
#nullable restore
#line 6 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Shared/Components/InfoBox/Default.cshtml"
                               Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n        <span class=\"info-box-number\">");
#nullable restore
#line 7 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Shared/Components/InfoBox/Default.cshtml"
                                 Write(Model.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\n");
#nullable restore
#line 9 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Shared/Components/InfoBox/Default.cshtml"
         if (Model.ProgressValue.HasValue)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"progress\">\n                <div class=\"progress-bar\"");
            BeginWriteAttribute("style", " style=\"", 585, "\"", 627, 3);
            WriteAttributeValue("", 593, "width:", 593, 6, true);
#nullable restore
#line 12 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Shared/Components/InfoBox/Default.cshtml"
WriteAttributeValue(" ", 599, Model.ProgressValue.Value, 600, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 626, "%", 626, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\n            </div>\n");
#nullable restore
#line 14 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Shared/Components/InfoBox/Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Shared/Components/InfoBox/Default.cshtml"
         if (!string.IsNullOrWhiteSpace(Model.ProgressDescription))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"progress-description\">\n                ");
#nullable restore
#line 18 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Shared/Components/InfoBox/Default.cshtml"
           Write(Model.ProgressDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </span>\n");
#nullable restore
#line 20 "/home/slayton/Projects/SlaytonHub/SlaytonHub/src/SlaytonHub/Areas/Template/Pages/Shared/Components/InfoBox/Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SlaytonHub.Model.InfoBoxModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
