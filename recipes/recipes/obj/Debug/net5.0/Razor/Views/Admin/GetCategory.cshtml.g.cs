#pragma checksum "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\GetCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52fe199f9dcbff2d9149134d9561364a672e6acb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetCategory), @"mvc.1.0.view", @"/Views/Admin/GetCategory.cshtml")]
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
#line 1 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\_ViewImports.cshtml"
using recipes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\_ViewImports.cshtml"
using recipes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52fe199f9dcbff2d9149134d9561364a672e6acb", @"/Views/Admin/GetCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c29a2335b2e03ea79bc7150e9fe74d6f08f7743c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<recipes.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\GetCategory.cshtml"
   ViewData["Title"] = "GetCategory";
                Layout = "~/Views/Shared/_AdminLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Kategori Listesi</h2>\n<br />\n<table class=\"table table-bordered\">\n    <tr>\n        <th>ID</th>\n        <th>Kategori</th>\n        <th>Image URL</th>\n    </tr>\n");
#nullable restore
#line 13 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\GetCategory.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 16 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\GetCategory.cshtml"
   Write(x.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 17 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\GetCategory.cshtml"
   Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 18 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\GetCategory.cshtml"
   Write(x.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 426, "\"", 460, 2);
            WriteAttributeValue("", 433, "/Admin/DeleteCategory/", 433, 22, true);
#nullable restore
#line 19 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\GetCategory.cshtml"
WriteAttributeValue("", 455, x.Id, 455, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 508, "\"", 540, 2);
            WriteAttributeValue("", 515, "/Admin/CallCategory/", 515, 20, true);
#nullable restore
#line 20 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\GetCategory.cshtml"
WriteAttributeValue("", 535, x.Id, 535, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Güncelle</a></td>\n</tr>");
#nullable restore
#line 21 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\GetCategory.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>\n<a href=\'/Admin/NewCategory\' class=\"btn btn-primary\">Kategori Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<recipes.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591