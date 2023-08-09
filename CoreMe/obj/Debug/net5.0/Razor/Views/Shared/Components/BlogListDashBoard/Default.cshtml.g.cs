#pragma checksum "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\BlogListDashBoard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3809e75fff61f29d7b881fe0df93b2c3645a904"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogListDashBoard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogListDashBoard/Default.cshtml")]
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
#line 1 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\_ViewImports.cshtml"
using CoreMe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\_ViewImports.cshtml"
using CoreMe.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\BlogListDashBoard\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3809e75fff61f29d7b881fe0df93b2c3645a904", @"/Views/Shared/Components/BlogListDashBoard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4145e1a4ba98378521cf6f8ed0f1d7463b1b42f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogListDashBoard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Son 10 Tarif</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> Başlık </th>
                                <th> Kategori </th>
                                <th> Tarih </th>
                                <th> Detaylar </th>
                               
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 22 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\BlogListDashBoard\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 977, "\"", 998, 1);
#nullable restore
#line 26 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\BlogListDashBoard\Default.cshtml"
WriteAttributeValue("", 983, item.BlogImage, 983, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\" alt=\"image\"> \r\n                                    \r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 30 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\BlogListDashBoard\Default.cshtml"
                               Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td> \r\n                                <td>\r\n                                    <label class=\"badge badge-gradient-success\">");
#nullable restore
#line 33 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\BlogListDashBoard\Default.cshtml"
                                                                           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                </td>\r\n                                    <td> ");
#nullable restore
#line 35 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\BlogListDashBoard\Default.cshtml"
                                     Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> <a");
            BeginWriteAttribute("href", " href=\"", 1580, "\"", 1617, 2);
            WriteAttributeValue("", 1587, "/Blog/BlogReadAll/", 1587, 18, true);
#nullable restore
#line 36 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\BlogListDashBoard\Default.cshtml"
WriteAttributeValue("", 1605, item.BlogID, 1605, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">Detaylar</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\BlogListDashBoard\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591