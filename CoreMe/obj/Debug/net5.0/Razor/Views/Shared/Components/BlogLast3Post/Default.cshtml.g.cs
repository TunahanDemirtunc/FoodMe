#pragma checksum "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\BlogLast3Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23cd00bc20b7a84b2a8f7363d06f8ac129d4c267"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogLast3Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
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
#line 1 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\BlogLast3Post\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23cd00bc20b7a84b2a8f7363d06f8ac129d4c267", @"/Views/Shared/Components/BlogLast3Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4145e1a4ba98378521cf6f8ed0f1d7463b1b42f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogLast3Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tech-btm\">\r\n\t<h3>Son Eklenenler </h3>\r\n");
#nullable restore
#line 5 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\BlogLast3Post\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"blog-grids row mb-3\">\r\n\t\t<div class=\"col-md-5 blog-grid-left\">\r\n\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 219, "\"", 256, 2);
            WriteAttributeValue("", 226, "/Blog/BlogReadAll/", 226, 18, true);
#nullable restore
#line 9 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 244, item.BlogID, 244, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 268, "\"", 289, 1);
#nullable restore
#line 10 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 274, item.BlogImage, 274, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 321, "\"", 327, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t</a>\r\n\t\t</div>\r\n\t\t\r\n\t\t<div class=\"col-md-7 blog-grid-right\">\r\n\r\n\t\t\t<h5>\r\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 414, "\"", 451, 2);
            WriteAttributeValue("", 421, "/Blog/BlogReadAll/", 421, 18, true);
#nullable restore
#line 17 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\BlogLast3Post\Default.cshtml"
WriteAttributeValue("", 439, item.BlogID, 439, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                        Write(item.BlogContent.Substring(0,item.BlogContent.Substring(0,50).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...  </a>\r\n\t\t\t</h5>\r\n\t\t\t<div class=\"sub-meta\">\r\n\t\t\t\t<span>\r\n\t\t\t\t\t\t<i class=\"far fa-clock\"></i> ");
#nullable restore
#line 21 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\BlogLast3Post\Default.cshtml"
                                                 Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</span>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");
#nullable restore
#line 26 "C:\Users\Tuna\source\repos\CoreMe\CoreMe\Views\Shared\Components\BlogLast3Post\Default.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
