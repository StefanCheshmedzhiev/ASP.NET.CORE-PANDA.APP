#pragma checksum "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Pending.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df0af7c355741b86c53108983dfb177b102667b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Panda.App.Views.Packages.Views_Packages_Pending), @"mvc.1.0.view", @"/Views/Packages/Pending.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Packages/Pending.cshtml", typeof(Panda.App.Views.Packages.Views_Packages_Pending))]
namespace Panda.App.Views.Packages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\_ViewImports.cshtml"
using Panda.App;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df0af7c355741b86c53108983dfb177b102667b6", @"/Views/Packages/Pending.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"003302008ecbbd1a2318ec4c95ec61eae7b76fae", @"/Views/_ViewImports.cshtml")]
    public class Views_Packages_Pending : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Panda.App.Models.Package.PackagePendingViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Pending.cshtml"
  
    ViewData["Title"] = "Pending";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(149, 882, true);
            WriteLiteral(@"
<h1 class=""text-center"">Pending Shipment</h1>
<hr class=""hr-2 bg-panda"">
<div class=""d-flex justify-content-between"">
    <table class=""table table-hover table-bordered"">
        <thead>
            <tr class=""row"">
                <th scope=""col"" class=""col-lg-1 d-flex justify-content-center""><h3>#</h3></th>
                <th scope=""col"" class=""col-lg-4 d-flex justify-content-center""><h3>Description</h3></th>
                <th scope=""col"" class=""col-lg-1 d-flex justify-content-center""><h3>Weight</h3></th>
                <th scope=""col"" class=""col-lg-3 d-flex justify-content-center""><h3>Shipping Address</h3></th>
                <th scope=""col"" class=""col-lg-2 d-flex justify-content-center""><h3>Recipient</h3></th>
                <th scope=""col"" class=""col-lg-1 d-flex justify-content-center""><h3>Actions</h3></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 23 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Pending.cshtml"
             for (int i = 0; i < Model.Count; i++)
            {

#line default
#line hidden
            BeginContext(1096, 120, true);
            WriteLiteral("                <tr class=\"row\">\n                    <th scope=\"row\" class=\"col-lg-1 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1218, 5, false);
#line 26 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Pending.cshtml"
                                                                                   Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1224, 86, true);
            WriteLiteral("</h5></th>\n                    <td class=\"col-lg-4 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1311, 20, false);
#line 27 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Pending.cshtml"
                                                                      Write(Model[i].Description);

#line default
#line hidden
            EndContext();
            BeginContext(1331, 86, true);
            WriteLiteral("</h5></td>\n                    <td class=\"col-lg-1 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1418, 15, false);
#line 28 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Pending.cshtml"
                                                                      Write(Model[i].Weight);

#line default
#line hidden
            EndContext();
            BeginContext(1433, 89, true);
            WriteLiteral(" KG</h5></td>\n                    <td class=\"col-lg-3 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1523, 24, false);
#line 29 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Pending.cshtml"
                                                                      Write(Model[i].ShippingAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1547, 86, true);
            WriteLiteral("</h5></td>\n                    <td class=\"col-lg-2 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1634, 18, false);
#line 30 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Pending.cshtml"
                                                                      Write(Model[i].Recipient);

#line default
#line hidden
            EndContext();
            BeginContext(1652, 109, true);
            WriteLiteral("</h5></td>\n                    <td class=\"col-lg-1 d-flex justify-content-center\">\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1761, "\"", 1795, 2);
            WriteAttributeValue("", 1768, "/Packages/Ship/", 1768, 15, true);
#line 32 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Pending.cshtml"
WriteAttributeValue("", 1783, Model[i].Id, 1783, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1796, 90, true);
            WriteLiteral(" class=\"btn bg-panda text-white\">Ship</a>\n                    </td>\n                </tr>\n");
            EndContext();
#line 35 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Pending.cshtml"
            }

#line default
#line hidden
            BeginContext(1900, 37, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Panda.App.Models.Package.PackagePendingViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
