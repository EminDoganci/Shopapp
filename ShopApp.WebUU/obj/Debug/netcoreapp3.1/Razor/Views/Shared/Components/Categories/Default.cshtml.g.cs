#pragma checksum "C:\Users\emndg\Desktop\c#\ShopApp\ShopApp.WebUU\Views\Shared\Components\Categories\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a09a8c35e809a8c02ef80a8ca8a05ee55590f986"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Categories_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Categories/Default.cshtml")]
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
#line 1 "C:\Users\emndg\Desktop\c#\ShopApp\ShopApp.WebUU\Views\_ViewImports.cshtml"
using ShopApp.WebUU.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a09a8c35e809a8c02ef80a8ca8a05ee55590f986", @"/Views/Shared/Components/Categories/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a73361ed8c644a38c7d87ed1d3738cdc32d472a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Categories_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"list-group\">\r\n\r\n    <a href=\"/product/list/\" class=\"list-group-item list-group-item-action\">Tüm Kategoriler</a>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\emndg\Desktop\c#\ShopApp\ShopApp.WebUU\Views\Shared\Components\Categories\Default.cshtml"
     foreach (var category in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 207, "\"", 248, 2);
            WriteAttributeValue("", 214, "/product/list/", 214, 14, true);
#nullable restore
#line 9 "C:\Users\emndg\Desktop\c#\ShopApp\ShopApp.WebUU\Views\Shared\Components\Categories\Default.cshtml"
WriteAttributeValue("", 228, category.CategoryId, 228, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action\">");
#nullable restore
#line 9 "C:\Users\emndg\Desktop\c#\ShopApp\ShopApp.WebUU\Views\Shared\Components\Categories\Default.cshtml"
                                                                                               Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 10 "C:\Users\emndg\Desktop\c#\ShopApp\ShopApp.WebUU\Views\Shared\Components\Categories\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
