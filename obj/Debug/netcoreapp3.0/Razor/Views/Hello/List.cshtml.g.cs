#pragma checksum "D:\VisualStudio2019\Project\QuickMaster\QuickMaster\Views\Hello\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7bafd5219b8112ba359df0f4dc338ebb6642a7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hello_List), @"mvc.1.0.view", @"/Views/Hello/List.cshtml")]
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
#line 1 "D:\VisualStudio2019\Project\QuickMaster\QuickMaster\Views\_ViewImports.cshtml"
using QuickMaster;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VisualStudio2019\Project\QuickMaster\QuickMaster\Views\_ViewImports.cshtml"
using QuickMaster.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7bafd5219b8112ba359df0f4dc338ebb6642a7b", @"/Views/Hello/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8164bf216da33cfe9d72908f38122be779b15605", @"/Views/_ViewImports.cshtml")]
    public class Views_Hello_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\VisualStudio2019\Project\QuickMaster\QuickMaster\Views\Hello\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>List</h2>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>書名</th>\r\n            <th>価格</th>\r\n            <th>出版社</th>\r\n            <th>配布サンプル</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "D:\VisualStudio2019\Project\QuickMaster\QuickMaster\Views\Hello\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "D:\VisualStudio2019\Project\QuickMaster\QuickMaster\Views\Hello\List.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "D:\VisualStudio2019\Project\QuickMaster\QuickMaster\Views\Hello\List.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "D:\VisualStudio2019\Project\QuickMaster\QuickMaster\Views\Hello\List.cshtml"
           Write(item.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "D:\VisualStudio2019\Project\QuickMaster\QuickMaster\Views\Hello\List.cshtml"
           Write(item.Sample);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "D:\VisualStudio2019\Project\QuickMaster\QuickMaster\Views\Hello\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
