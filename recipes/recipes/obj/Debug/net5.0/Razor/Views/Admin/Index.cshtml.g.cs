#pragma checksum "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfa702e6a6dc97198a3c7d7973d06ac1a5358ed7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\_ViewImports.cshtml"
using recipes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\_ViewImports.cshtml"
using recipes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfa702e6a6dc97198a3c7d7973d06ac1a5358ed7", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c29a2335b2e03ea79bc7150e9fe74d6f08f7743c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Recipe>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Yemek Tarif Listesi</h2>\r\n<br/>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>BAŞLIK</th>\r\n        <th>SİL</th>\r\n        <th>GÜNCELLE</th>\r\n        <th>DETAYLAR</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\Index.cshtml"
     foreach(var x in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 19 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\Index.cshtml"
       Write(x.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 20 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\Index.cshtml"
       Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><a href=\'#\' class=\"btn btn-danger\">Sil</a></td>\r\n        <td><a href=\'#\' class=\"btn btn-warning\">Güncelle</a></td>\r\n        <td><a href=\'#\' class=\"btn btn-info\">Detaylar</a></td>\r\n    </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href =\'/Admin/NewRecipe\' class=\"btn btn-primary\">Tarif Ekle</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Recipe>> Html { get; private set; }
    }
}
#pragma warning restore 1591
