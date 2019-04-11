#pragma checksum "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1f67142241ff92dd741e3d9ce60380e8a69de6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AppInformation), @"mvc.1.0.view", @"/Views/Home/AppInformation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AppInformation.cshtml", typeof(AspNetCore.Views_Home_AppInformation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1f67142241ff92dd741e3d9ce60380e8a69de6c", @"/Views/Home/AppInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f9c6cfe3764b55f1d35dcc3000668580dd35cc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AppInformation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppServiceConfiguration>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
  
    ViewData["Title"] = "App Migration Accelerator";

#line default
#line hidden
#line 5 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
  
    var zipfilename = TempData["zipFile"];
    var gitRepo = TempData["gitRepo"];
    

#line default
#line hidden
            BeginContext(188, 63, true);
            WriteLiteral("<b>Collect Application Details</b>\r\n<div class=\"text-center\">\r\n");
            EndContext();
#line 11 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
     using (Html.BeginForm("AppInformation", "Home", FormMethod.Post))
    {

#line default
#line hidden
            BeginContext(330, 273, true);
            WriteLiteral(@"        <table border=""0"" style=""width:1020px;"">
            <tr>
                <td align=""left"" style=""height:26px;"" valign=""top"">
                    Existing Application Framework/Runtime:
                    <p style=""margin-left:26px;"">
                        ");
            EndContext();
            BeginContext(604, 111, false);
#line 18 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.RadioButton("appFramework", ".Net Framework 4.5", new { Checked = "checked", id = "appFramework_.net45" }));

#line default
#line hidden
            EndContext();
            BeginContext(715, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(742, 55, false);
#line 19 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.Label("appFramework_.net45", ".Net Framework 4.5"));

#line default
#line hidden
            EndContext();
            BeginContext(797, 32, true);
            WriteLiteral("<br />\r\n                        ");
            EndContext();
            BeginContext(830, 83, false);
#line 20 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.RadioButton("appFramework", ".Net Core", new { id = "appFramework_.netCore" }));

#line default
#line hidden
            EndContext();
            BeginContext(913, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(940, 48, false);
#line 21 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.Label("appFramework_.netCore", ".Net Core"));

#line default
#line hidden
            EndContext();
            BeginContext(988, 32, true);
            WriteLiteral("<br />\r\n                        ");
            EndContext();
            BeginContext(1021, 74, false);
#line 22 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.RadioButton("appFramework", "Java", new { id = "appFramework_java" }));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1122, 39, false);
#line 23 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.Label("appFramework_java", "Java"));

#line default
#line hidden
            EndContext();
            BeginContext(1161, 32, true);
            WriteLiteral("<br />\r\n                        ");
            EndContext();
            BeginContext(1194, 72, false);
#line 24 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.RadioButton("appFramework", "PHP", new { id = "appFramework_php" }));

#line default
#line hidden
            EndContext();
            BeginContext(1266, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1293, 37, false);
#line 25 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.Label("appFramework_php", "PHP"));

#line default
#line hidden
            EndContext();
            BeginContext(1330, 32, true);
            WriteLiteral("<br />\r\n                        ");
            EndContext();
            BeginContext(1363, 78, false);
#line 26 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.RadioButton("appFramework", "Python", new { id = "appFramework_python" }));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1468, 43, false);
#line 27 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.Label("appFramework_python", "Python"));

#line default
#line hidden
            EndContext();
            BeginContext(1511, 31, true);
            WriteLiteral("<br/>\r\n                        ");
            EndContext();
            BeginContext(1543, 74, false);
#line 28 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.RadioButton("appFramework", "Node", new { id = "appFramework_node" }));

#line default
#line hidden
            EndContext();
            BeginContext(1617, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1644, 39, false);
#line 29 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.Label("appFramework_node", "Node"));

#line default
#line hidden
            EndContext();
            BeginContext(1683, 234, true);
            WriteLiteral("\r\n                    </p>\r\n                </td>\r\n                <td align=\"left\" style=\"height:26px;\" valign=\"top\">\r\n                    Deployment Option\r\n                    <p style=\"margin-left:26px;\">\r\n                        ");
            EndContext();
            BeginContext(1918, 91, false);
#line 35 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.RadioButton("deployment", "Zip", new { id = "deployment_Zip", @class = "deployment" }));

#line default
#line hidden
            EndContext();
            BeginContext(2009, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2036, 35, false);
#line 36 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.Label("deployment_Zip", "Zip"));

#line default
#line hidden
            EndContext();
            BeginContext(2071, 14, true);
            WriteLiteral("&nbsp;&nbsp;\r\n");
            EndContext();
#line 37 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                         if (zipfilename == null)
                        {

#line default
#line hidden
            BeginContext(2163, 81, true);
            WriteLiteral("                            <input id=\"uploadZip\" type=\"button\" value=\"UploadZip\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2244, "\"", 2324, 3);
            WriteAttributeValue("", 2254, "location.href=\'", 2254, 15, true);
#line 39 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
WriteAttributeValue("", 2269, Url.Action("_fileUploadForm", "Home", new { id = 1 }), 2269, 54, false);

#line default
#line hidden
            WriteAttributeValue("", 2323, "\'", 2323, 1, true);
            EndWriteAttribute();
            BeginContext(2325, 137, true);
            WriteLiteral("\r\n                                   style=\"border:0px;background:transparent;text-decoration:none;cursor:pointer;visibility:hidden\" />\r\n");
            EndContext();
#line 41 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2546, 60, true);
            WriteLiteral("                            <input id=\"submit\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("value", " value=\'", 2606, "\'", 2637, 1);
#line 44 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
WriteAttributeValue("", 2614, zipfilename.ToString(), 2614, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2638, "\"", 2718, 3);
            WriteAttributeValue("", 2648, "location.href=\'", 2648, 15, true);
#line 44 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
WriteAttributeValue("", 2663, Url.Action("_fileUploadForm", "Home", new { id = 1 }), 2663, 54, false);

#line default
#line hidden
            WriteAttributeValue("", 2717, "\'", 2717, 1, true);
            EndWriteAttribute();
            BeginContext(2719, 120, true);
            WriteLiteral("\r\n                                   style=\"border:0px;background:transparent;text-decoration:none;cursor:pointer;\" />\r\n");
            EndContext();
            BeginContext(2868, 44, false);
#line 46 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                       Write(Html.Hidden("zipFile", @TempData["zipFile"]));

#line default
#line hidden
            EndContext();
#line 46 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                                                                         
                        }

#line default
#line hidden
            BeginContext(2939, 32, true);
            WriteLiteral("<br />\r\n                        ");
            EndContext();
            BeginContext(2972, 91, false);
#line 48 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.RadioButton("deployment", "FTP", new { id = "deployment_FTP", @class = "deployment" }));

#line default
#line hidden
            EndContext();
            BeginContext(3063, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3090, 35, false);
#line 49 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.Label("deployment_FTP", "FTP"));

#line default
#line hidden
            EndContext();
            BeginContext(3125, 32, true);
            WriteLiteral("<br />\r\n                        ");
            EndContext();
            BeginContext(3158, 97, false);
#line 50 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.RadioButton("deployment", "LocalGit", new { id = "deployment_LGIT", @class = "deployment" }));

#line default
#line hidden
            EndContext();
            BeginContext(3255, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3282, 45, false);
#line 51 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.Label("deployment_LocalGit", "LocalGit"));

#line default
#line hidden
            EndContext();
            BeginContext(3327, 32, true);
            WriteLiteral("<br />\r\n                        ");
            EndContext();
            BeginContext(3360, 95, false);
#line 52 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.RadioButton("deployment", "GitRepo", new { id = "deployment_GIT", @class = "deployment" }));

#line default
#line hidden
            EndContext();
            BeginContext(3455, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3482, 39, false);
#line 53 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.Label("deployment_GIT", "GitRepo"));

#line default
#line hidden
            EndContext();
            BeginContext(3521, 225, true);
            WriteLiteral("\r\n                        <input id=\"gitRepoUrl\" name=\"gitRepoUrl\" type=\"text\" value=\"https://github.com/Azure-Samples/aci-helloworld.git\" style=\"visibility:hidden\" />\r\n                        <br />\r\n                        ");
            EndContext();
            BeginContext(3747, 104, false);
#line 56 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.RadioButton("deployment", "AzureDevOps", new { id = "deployment_AzDevOps", @class = "deployment" }));

#line default
#line hidden
            EndContext();
            BeginContext(3851, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3878, 51, false);
#line 57 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.Label("deployment_AzureDevOps", "AzureDevOps"));

#line default
#line hidden
            EndContext();
            BeginContext(3929, 32, true);
            WriteLiteral("<br />\r\n                        ");
            EndContext();
            BeginContext(3962, 115, false);
#line 58 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.RadioButton("deployment", "ContiniousDeployment", new { id = "deployment_continious", @class = "deployment" }));

#line default
#line hidden
            EndContext();
            BeginContext(4077, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(4104, 59, false);
#line 59 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.Label("deployment_continious", "ContiniousDeployment"));

#line default
#line hidden
            EndContext();
            BeginContext(4163, 32, true);
            WriteLiteral("<br />\r\n                        ");
            EndContext();
            BeginContext(4196, 101, false);
#line 60 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.RadioButton("deployment", "Template", new { id = "deployment_template", @class = "deployment" }));

#line default
#line hidden
            EndContext();
            BeginContext(4297, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(4324, 45, false);
#line 61 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.Label("deployment_template", "Template"));

#line default
#line hidden
            EndContext();
            BeginContext(4369, 90, true);
            WriteLiteral("\r\n                        <input id=\"createTemplate\" type=\"button\" value=\'Create Template\'");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4459, "\"", 4546, 3);
            WriteAttributeValue("", 4469, "location.href=\'", 4469, 15, true);
#line 62 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
WriteAttributeValue("", 4484, Url.Action("Tier1Configuration", "Template", new { id = 1 }), 4484, 61, false);

#line default
#line hidden
            WriteAttributeValue("", 4545, "\'", 4545, 1, true);
            EndWriteAttribute();
            BeginContext(4547, 409, true);
            WriteLiteral(@"
                               style=""border:0px;background:transparent;text-decoration:none;cursor:pointer;visibility:hidden"" />
                        <br />
                    </p>
                </td>
                <td align=""left"" style=""height:26px;"" valign=""top"">
                    Containerize Your Application
                    <p style=""margin-left:26px;"">
                        ");
            EndContext();
            BeginContext(4957, 99, false);
#line 70 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.RadioButton("container", "Windows", new { id = "container_Windows", @class = "containerApp" }));

#line default
#line hidden
            EndContext();
            BeginContext(5056, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(5083, 42, false);
#line 71 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.Label("container_Windows", "Windows"));

#line default
#line hidden
            EndContext();
            BeginContext(5125, 32, true);
            WriteLiteral("<br />\r\n                        ");
            EndContext();
            BeginContext(5158, 95, false);
#line 72 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.RadioButton("container", "Linux", new { id = "container_Linux", @class = "containerApp" }));

#line default
#line hidden
            EndContext();
            BeginContext(5253, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(5280, 38, false);
#line 73 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                   Write(Html.Label("container_Linux", "Linux"));

#line default
#line hidden
            EndContext();
            BeginContext(5318, 345, true);
            WriteLiteral(@"
                    </p>
                </td>
            </tr>
            <tr>
                <td align=""right"" colspan=""3"">
                    <input id=""submit"" type=""submit"" value=""Next"" style=""border:0px;background:transparent;text-decoration:none;cursor:pointer;"" />
                </td>
            </tr>
        </table>
");
            EndContext();
#line 83 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"

    }

#line default
#line hidden
            BeginContext(5672, 2, true);
            WriteLiteral("  ");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5692, 70, true);
                WriteLiteral("\r\n        <script type=\"text/javascript\">\r\n            var zipFile = \"");
                EndContext();
                BeginContext(5763, 11, false);
#line 87 "C:\PaaSAccelerators\presentation\AppServiceMigrator\Views\Home\AppInformation.cshtml"
                      Write(zipfilename);

#line default
#line hidden
                EndContext();
                BeginContext(5774, 1428, true);
                WriteLiteral(@""";
            $(function () { //Same as $(document).ready()
                if (zipFile != '') {
                    $('#deployment_Zip').attr(""Checked"",""checked"");
                    }
                    else {
                        //console.log(""the forms info is not valid"");
                }

                $(document).on(""click"", "".deployment"", function () {
                    if ($('#deployment_Zip').is(':checked')) {
                        document.getElementById(""uploadZip"").style.visibility = 'visible';
                    }
                    else {
                        document.getElementById(""uploadZip"").style.visibility = 'hidden';
                    }
                    if ($('#deployment_GIT').is(':checked')) {
                        document.getElementById(""gitRepoUrl"").style.visibility = 'visible';
                    }
                    else {
                        document.getElementById(""gitRepoUrl"").style.visibility = 'hidden';
                    ");
                WriteLiteral(@"}
                    if ($('#deployment_template').is(':checked')) {
                        document.getElementById(""createTemplate"").style.visibility = 'visible';

                    }
                    else {
                        document.getElementById(""createTemplate"").style.visibility = 'hidden';
                    }
                });
            });

        </script>
    ");
                EndContext();
            }
            );
            BeginContext(7205, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppServiceConfiguration> Html { get; private set; }
    }
}
#pragma warning restore 1591
