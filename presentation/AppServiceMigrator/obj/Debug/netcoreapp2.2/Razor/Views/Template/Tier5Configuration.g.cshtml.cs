#pragma checksum "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Template\Tier5Configuration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90f06ecb706d51fcc3d4d3b78da3d2f501503c58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Tier5Configuration), @"mvc.1.0.view", @"/Views/Template/Tier5Configuration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Template/Tier5Configuration.cshtml", typeof(AspNetCore.Views_Template_Tier5Configuration))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90f06ecb706d51fcc3d4d3b78da3d2f501503c58", @"/Views/Template/Tier5Configuration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f9c6cfe3764b55f1d35dcc3000668580dd35cc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Tier5Configuration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Template\Tier5Configuration.cshtml"
  
    ViewData["Title"] = "Tier5Configuration";

#line default
#line hidden
            BeginContext(56, 138, true);
            WriteLiteral("\r\n<b>Tier5 Configuration</b>\r\n<ul>\r\n    <li>Host name bindings</li>\r\n    <li>Site extensions</li>\r\n</ul>\r\n<input id=\"submit\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 194, "\"", 261, 3);
            WriteAttributeValue("", 204, "location.href=\'", 204, 15, true);
#line 11 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Template\Tier5Configuration.cshtml"
WriteAttributeValue("", 219, Url.Action("TemplateReview", "Template"), 219, 41, false);

#line default
#line hidden
            WriteAttributeValue("", 260, "\'", 260, 1, true);
            EndWriteAttribute();
            BeginContext(262, 118, true);
            WriteLiteral("\r\n       value=\"Review & Submit\" style=\"border:0px;background:transparent;text-decoration:none;cursor:pointer;\" />\r\n\r\n");
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
