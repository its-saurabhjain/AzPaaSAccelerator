#pragma checksum "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Template\Tier1Configuration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6149fcbad4745db22fc75cbf834d82bf979190c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Template_Tier1Configuration), @"mvc.1.0.view", @"/Views/Template/Tier1Configuration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Template/Tier1Configuration.cshtml", typeof(AspNetCore.Views_Template_Tier1Configuration))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6149fcbad4745db22fc75cbf834d82bf979190c4", @"/Views/Template/Tier1Configuration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f9c6cfe3764b55f1d35dcc3000668580dd35cc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Template_Tier1Configuration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Template\Tier1Configuration.cshtml"
  
    ViewData["Title"] = "Tier1Configuration";

#line default
#line hidden
            BeginContext(56, 184, true);
            WriteLiteral("<b>Tier1 Configuration</b>\r\n<ul>\r\n    <li>App Service plan.</li>\r\n    <li>Any other related resources, like databases or storage accounts.</li>\r\n</ul>\r\n<input id=\"submit\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 240, "\"", 311, 3);
            WriteAttributeValue("", 250, "location.href=\'", 250, 15, true);
#line 10 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Template\Tier1Configuration.cshtml"
WriteAttributeValue("", 265, Url.Action("Tier2Configuration", "Template"), 265, 45, false);

#line default
#line hidden
            WriteAttributeValue("", 310, "\'", 310, 1, true);
            EndWriteAttribute();
            BeginContext(312, 109, true);
            WriteLiteral("\r\n       value=\"Next\" style=\"border:0px;background:transparent;text-decoration:none;cursor:pointer;\" />\r\n\r\n\r\n");
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
