#pragma checksum "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\CustomerLastBlog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22522db9cd91a686078ecc8997d07c5b3f420a1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CustomerLastBlog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CustomerLastBlog/Default.cshtml")]
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
#line 1 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\CustomerLastBlog\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22522db9cd91a686078ecc8997d07c5b3f420a1d", @"/Views/Shared/Components/CustomerLastBlog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4145e1a4ba98378521cf6f8ed0f1d7463b1b42f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CustomerLastBlog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tech-btm\">\r\n\t\t\t\t\t\t\t<h4>Yazarın Diğer Tatlıları(Diğer tatlılar)</h4>\r\n");
#nullable restore
#line 5 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\CustomerLastBlog\Default.cshtml"
                             foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<div class=\"blog-grids row mb-3\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-md-5 blog-grid-left\">\r\n\t\t\t\t\t\t\t\t\t<a href=\"single.html\">\r\n\t\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 302, "\"", 323, 1);
#nullable restore
#line 9 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\CustomerLastBlog\Default.cshtml"
WriteAttributeValue("", 308, item.BlogImage, 308, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 342, "\"", 348, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-md-7 blog-grid-right\">\r\n\r\n\t\t\t\t\t\t\t\t\t<h5>\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"single.html\">");
#nullable restore
#line 15 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\CustomerLastBlog\Default.cshtml"
                                                         Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n\t\t\t\t\t\t\t\t\t</h5>\r\n\t\t\t\t\t\t\t\t\t<div class=\"sub-meta\">\r\n\t\t\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t<i class=\"far fa-clock\"></i> ");
#nullable restore
#line 19 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\CustomerLastBlog\Default.cshtml"
                                                 Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 25 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\CustomerLastBlog\Default.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</div>");
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
