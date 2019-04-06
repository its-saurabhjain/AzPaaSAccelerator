#pragma checksum "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AzConfigurations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0c17bbbd8e7e64ef6f7a64d44d23507382eee1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AzConfigurations), @"mvc.1.0.view", @"/Views/Home/AzConfigurations.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AzConfigurations.cshtml", typeof(AspNetCore.Views_Home_AzConfigurations))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c17bbbd8e7e64ef6f7a64d44d23507382eee1a", @"/Views/Home/AzConfigurations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f9c6cfe3764b55f1d35dcc3000668580dd35cc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AzConfigurations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AzAccountsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AzConfigurations.cshtml"
  
    ViewData["Title"] = "Azure Configurations";

#line default
#line hidden
            BeginContext(84, 361, true);
            WriteLiteral(@"<style>
    #main {
        width: 204px;
        height: 204px;
    }

    .form-textbox {
        width: 125px;
        height: 20px;
        border: 1px solid #000;
    }
    .form-dropdown {
        width: 200px;
        height: 25px;
        border: 1px solid #000;
    }
</style>

<h5>Azure Configurations</h5>
<div class=""text-left"">
");
            EndContext();
#line 25 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AzConfigurations.cshtml"
     using (Html.BeginForm("AzConfigurations", "Home", FormMethod.Post))
    {

#line default
#line hidden
            BeginContext(526, 255, true);
            WriteLiteral("        <table border=\"0\" style=\"width:1020px;\">\r\n            <tr>\r\n                <td align=\"left\" style=\"height:26px;\" valign=\"top\">\r\n                    <div>\r\n                        <p id=\"resGrp\"> Azure Resource Group:\r\n                            ");
            EndContext();
            BeginContext(782, 158, false);
#line 32 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AzConfigurations.cshtml"
                       Write(Html.DropDownListFor(m => m.Subscription, new SelectList(Model.ResourceGroupList), "Select Resource Group", new { id = "AzResGrp", @class = "form-dropdown" }));

#line default
#line hidden
            EndContext();
            BeginContext(940, 118, true);
            WriteLiteral("\r\n                        </p>\r\n                        <p id=\"Location\">Azure Location:\r\n                            ");
            EndContext();
            BeginContext(1059, 84, false);
#line 35 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AzConfigurations.cshtml"
                       Write(Html.TextBox("AzLocation", null, new { id = "AzLocation", @class = "form-textbox" }));

#line default
#line hidden
            EndContext();
            BeginContext(1143, 128, true);
            WriteLiteral("\r\n                        </p>\r\n                        <p id=\"AppSvcPlan\">Azure App Service Plan:\r\n                            ");
            EndContext();
            BeginContext(1272, 88, false);
#line 38 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AzConfigurations.cshtml"
                       Write(Html.TextBox("AzAppSvcPlan", null, new { id = "AzAppSvcPlan", @class = "form-textbox" }));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 121, true);
            WriteLiteral("\r\n                        </p>\r\n                        <p id=\"AppName\">Azure Web App Name:\r\n                            ");
            EndContext();
            BeginContext(1482, 80, false);
#line 41 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AzConfigurations.cshtml"
                       Write(Html.TextBox("AzAppName", null, new { id = "AzAppName", @class= "form-textbox"}));

#line default
#line hidden
            EndContext();
            BeginContext(1562, 412, true);
            WriteLiteral(@"
                        </p>
                    </div>
                </td>
                <td>

                </td>
            </tr>
            <tr>
                <td align=""right"">
                    <input id=""submit"" type=""submit"" value=""Next"" style=""border:0px;background:transparent;text-decoration:none;cursor:pointer;"" />
                </td>
            </tr>
        </table>
");
            EndContext();
#line 55 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AzConfigurations.cshtml"
    }

#line default
#line hidden
            BeginContext(1981, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AzAccountsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591