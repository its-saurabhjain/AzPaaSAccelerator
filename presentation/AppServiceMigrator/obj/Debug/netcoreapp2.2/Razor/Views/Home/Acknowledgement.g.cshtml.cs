#pragma checksum "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\Acknowledgement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a634feea6b537c016610f7f164e82911d4859103"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Acknowledgement), @"mvc.1.0.view", @"/Views/Home/Acknowledgement.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Acknowledgement.cshtml", typeof(AspNetCore.Views_Home_Acknowledgement))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\_ViewImports.cshtml"
using MigrationAcceleratorApp;

#line default
#line hidden
#line 2 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\_ViewImports.cshtml"
using MigrationAcceleratorApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a634feea6b537c016610f7f164e82911d4859103", @"/Views/Home/Acknowledgement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f9c6cfe3764b55f1d35dcc3000668580dd35cc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Acknowledgement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InformationUpdates", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\Acknowledgement.cshtml"
  
    ViewData["Title"] = "Acknowledgement";

#line default
#line hidden
            BeginContext(51, 213, true);
            WriteLiteral("<h5>Acknowledgement</h5>\r\n<table border=\"0\" style=\"width:1020px;\">\r\n    <tr>\r\n        <td align=\"left\" style=\"height:26px;\" valign=\"top\">\r\n            <div>Application Migration Task ID <span style=\"color:maroon\">");
            EndContext();
            BeginContext(265, 10, false);
#line 8 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\Acknowledgement.cshtml"
                                                                     Write(ViewBag.ID);

#line default
#line hidden
            EndContext();
            BeginContext(275, 119, true);
            WriteLiteral(" </span> has been submitted to the engine. Updates to the migration progress can be viewed on Information Updates page,");
            EndContext();
            BeginContext(394, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a634feea6b537c016610f7f164e82911d48591034787", async() => {
                BeginContext(451, 10, true);
                WriteLiteral("click here");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(465, 197, true);
            WriteLiteral(" to get updates on your migration.</div>\r\n            \r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <td align=\"left\" style=\"height:26px;\" valign=\"top\">\r\n            <input id=\"submit\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 662, "\"", 725, 3);
            WriteAttributeValue("", 672, "location.href=\'", 672, 15, true);
#line 14 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\Acknowledgement.cshtml"
WriteAttributeValue("", 687, Url.Action("AppInformation", "Home"), 687, 37, false);

#line default
#line hidden
            WriteAttributeValue("", 724, "\'", 724, 1, true);
            EndWriteAttribute();
            BeginContext(726, 157, true);
            WriteLiteral("\r\n                   value=\"Start Over\" style=\"border:0px;background:transparent;text-decoration:none;cursor:pointer;\" />\r\n        </td>\r\n    </tr>\r\n</table>");
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