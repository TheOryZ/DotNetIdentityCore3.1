#pragma checksum "C:\Users\Lenovo\source\repos\DotNetCoreIdentityExample\Example.MVCWebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "554d2450b2236fdfeb0bdf73a0d71f12215ca3fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Lenovo\source\repos\DotNetCoreIdentityExample\Example.MVCWebUI\Views\_ViewImports.cshtml"
using Example.MVCWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\DotNetCoreIdentityExample\Example.MVCWebUI\Views\_ViewImports.cshtml"
using Example.MVCWebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"554d2450b2236fdfeb0bdf73a0d71f12215ca3fb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6bfd865e8cfae4c9b94044b4117434c7eeec4dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Example.MVCWebUI.Models.ProjectListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\DotNetCoreIdentityExample\Example.MVCWebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""offset-md-1 col-md-10"">
        <div class=""card"">
            <div class=""card-header"">
                Project List
            </div>
            <div class=""card-body"">
                <div class=""table-responsive-sm"">
                    <table class=""table table-bordered table-striped"">
                        <thead>
                            <tr>
                                <th scope=""col"">Title</th>
                                <th scope=""col"">Description</th>
                                <th scope=""col"">Owner</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 22 "C:\Users\Lenovo\source\repos\DotNetCoreIdentityExample\Example.MVCWebUI\Views\Home\Index.cshtml"
                             foreach (var project in Model.Projects)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 25 "C:\Users\Lenovo\source\repos\DotNetCoreIdentityExample\Example.MVCWebUI\Views\Home\Index.cshtml"
                                   Write(project.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 26 "C:\Users\Lenovo\source\repos\DotNetCoreIdentityExample\Example.MVCWebUI\Views\Home\Index.cshtml"
                                   Write(project.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 27 "C:\Users\Lenovo\source\repos\DotNetCoreIdentityExample\Example.MVCWebUI\Views\Home\Index.cshtml"
                                   Write(project.OwnerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Lenovo\source\repos\DotNetCoreIdentityExample\Example.MVCWebUI\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Example.MVCWebUI.Models.ProjectListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
