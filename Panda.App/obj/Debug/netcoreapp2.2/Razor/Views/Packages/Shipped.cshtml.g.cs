#pragma checksum "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Shipped.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae29875c552629d332d13baa87cddf4ff2e5cb65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Panda.App.Views.Packages.Views_Packages_Shipped), @"mvc.1.0.view", @"/Views/Packages/Shipped.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Packages/Shipped.cshtml", typeof(Panda.App.Views.Packages.Views_Packages_Shipped))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae29875c552629d332d13baa87cddf4ff2e5cb65", @"/Views/Packages/Shipped.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"003302008ecbbd1a2318ec4c95ec61eae7b76fae", @"/Views/_ViewImports.cshtml")]
    public class Views_Packages_Shipped : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Panda.App.Models.Package.PackageShippedViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Shipped.cshtml"
  
    ViewData["Title"] = "Shipped";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(155, 896, true);
            WriteLiteral(@"
<h1 class=""text-center"">Shipped</h1>
<hr class=""hr-2 bg-panda"">
<div class=""d-flex justify-content-between"">
    <table class=""table table-hover table-bordered"">
        <thead>
            <tr class=""row"">
                <th scope=""col"" class=""col-lg-1 d-flex justify-content-center""><h3>#</h3></th>
                <th scope=""col"" class=""col-lg-4 d-flex justify-content-center""><h3>Description</h3></th>
                <th scope=""col"" class=""col-lg-1 d-flex justify-content-center""><h3>Weight</h3></th>
                <th scope=""col"" class=""col-lg-3 d-flex justify-content-center""><h3>Estimated Delivery Date</h3></th>
                <th scope=""col"" class=""col-lg-2 d-flex justify-content-center""><h3>Recipient</h3></th>
                <th scope=""col"" class=""col-lg-1 d-flex justify-content-center""><h3>Actions</h3></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 23 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Shipped.cshtml"
             for (int i = 0; i < Model.Count; i++)
            {

#line default
#line hidden
            BeginContext(1118, 121, true);
            WriteLiteral("                <tr class=\"row\">\r\n                    <th scope=\"row\" class=\"col-lg-1 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1241, 5, false);
#line 26 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Shipped.cshtml"
                                                                                   Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1247, 87, true);
            WriteLiteral("</h5></th>\r\n                    <td class=\"col-lg-4 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1335, 20, false);
#line 27 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Shipped.cshtml"
                                                                      Write(Model[i].Description);

#line default
#line hidden
            EndContext();
            BeginContext(1355, 87, true);
            WriteLiteral("</h5></td>\r\n                    <td class=\"col-lg-1 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1443, 15, false);
#line 28 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Shipped.cshtml"
                                                                      Write(Model[i].Weight);

#line default
#line hidden
            EndContext();
            BeginContext(1458, 90, true);
            WriteLiteral(" KG</h5></td>\r\n                    <td class=\"col-lg-3 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1549, 30, false);
#line 29 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Shipped.cshtml"
                                                                      Write(Model[i].EstimatedDeliveryDate);

#line default
#line hidden
            EndContext();
            BeginContext(1579, 87, true);
            WriteLiteral("</h5></td>\r\n                    <td class=\"col-lg-2 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1667, 18, false);
#line 30 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Shipped.cshtml"
                                                                      Write(Model[i].Recipient);

#line default
#line hidden
            EndContext();
            BeginContext(1685, 111, true);
            WriteLiteral("</h5></td>\r\n                    <td class=\"col-lg-1 d-flex justify-content-center\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1796, "\"", 1833, 2);
            WriteAttributeValue("", 1803, "/Packages/Deliver/", 1803, 18, true);
#line 32 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Shipped.cshtml"
WriteAttributeValue("", 1821, Model[i].Id, 1821, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1834, 96, true);
            WriteLiteral(" class=\"btn bg-panda text-white\">Deliver</a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 35 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Packages\Shipped.cshtml"
            }

#line default
#line hidden
            BeginContext(1945, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Panda.App.Models.Package.PackageShippedViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
