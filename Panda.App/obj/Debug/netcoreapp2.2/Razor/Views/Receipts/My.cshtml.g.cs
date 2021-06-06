#pragma checksum "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Receipts\My.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cd9aad140c33563fec882b7fc62adf254306e46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Panda.App.Views.Receipts.Views_Receipts_My), @"mvc.1.0.view", @"/Views/Receipts/My.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Receipts/My.cshtml", typeof(Panda.App.Views.Receipts.Views_Receipts_My))]
namespace Panda.App.Views.Receipts
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cd9aad140c33563fec882b7fc62adf254306e46", @"/Views/Receipts/My.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"003302008ecbbd1a2318ec4c95ec61eae7b76fae", @"/Views/_ViewImports.cshtml")]
    public class Views_Receipts_My : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Panda.App.Models.Receipt.ReceiptMyViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Receipts\My.cshtml"
  
    ViewData["Title"] = "My";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 763, true);
            WriteLiteral(@"
<h1 class=""text-center"">My Receipts</h1>
<hr class=""hr-2 bg-panda"">
<div class=""d-flex justify-content-between"">
    <table class=""table table-hover table-bordered"">
        <thead>
            <tr class=""row"">
                <th scope=""col"" class=""col-lg-5 d-flex justify-content-center""><h3>Id</h3></th>
                <th scope=""col"" class=""col-lg-2 d-flex justify-content-center""><h3>Fee</h3></th>
                <th scope=""col"" class=""col-lg-2 d-flex justify-content-center""><h3>Issued On</h3></th>
                <th scope=""col"" class=""col-lg-2 d-flex justify-content-center""><h3>Recipient</h3></th>
                <th scope=""col"" class=""col-lg-1 d-flex justify-content-center""><h3>Actions</h3></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 22 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Receipts\My.cshtml"
             foreach (var receipt in Model)
            {

#line default
#line hidden
            BeginContext(960, 112, true);
            WriteLiteral("            <tr class=\"row\">\n                <th scope=\"row\" class=\"col-lg-5 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1073, 10, false);
#line 25 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Receipts\My.cshtml"
                                                                              Write(receipt.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1083, 83, true);
            WriteLiteral("</h5></th>\n                <td class=\"col-lg-2 d-flex justify-content-center\"><h5>$");
            EndContext();
            BeginContext(1167, 26, false);
#line 26 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Receipts\My.cshtml"
                                                                   Write(receipt.Fee.ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1193, 82, true);
            WriteLiteral("</h5></td>\n                <td class=\"col-lg-2 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1276, 16, false);
#line 27 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Receipts\My.cshtml"
                                                                  Write(receipt.IssuedOn);

#line default
#line hidden
            EndContext();
            BeginContext(1292, 82, true);
            WriteLiteral("</h5></td>\n                <td class=\"col-lg-2 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1375, 17, false);
#line 28 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Receipts\My.cshtml"
                                                                  Write(receipt.Recipient);

#line default
#line hidden
            EndContext();
            BeginContext(1392, 101, true);
            WriteLiteral("</h5></td>\n                <td class=\"col-lg-1 d-flex justify-content-center\">\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1493, "\"", 1529, 2);
            WriteAttributeValue("", 1500, "/Receipts/Details/", 1500, 18, true);
#line 30 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Receipts\My.cshtml"
WriteAttributeValue("", 1518, receipt.Id, 1518, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1530, 85, true);
            WriteLiteral(" class=\"btn bg-panda text-white\">Details</a>\n                </td>\n            </tr>\n");
            EndContext();
#line 33 "D:\Source\Repos\ASP.NET.CORE-PANDA.APP\Panda.App\Views\Receipts\My.cshtml"
            }

#line default
#line hidden
            BeginContext(1629, 36, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Panda.App.Models.Receipt.ReceiptMyViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
