#pragma checksum "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\GetRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bba7fce30970fddb5cd52708bbc27fef49253e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetRecipe), @"mvc.1.0.view", @"/Views/Admin/GetRecipe.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bba7fce30970fddb5cd52708bbc27fef49253e6", @"/Views/Admin/GetRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c29a2335b2e03ea79bc7150e9fe74d6f08f7743c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<recipes.Models.Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\GetRecipe.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Tarif Güncelleme Sayfası</h2>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\GetRecipe.cshtml"
 using (Html.BeginForm("UpdateRecipe", "Admin", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\GetRecipe.cshtml"
Write(Html.LabelFor(x => x.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\GetRecipe.cshtml"
Write(Html.TextBoxFor(x => x.Id, new { @class = "form-control",@readonly ="readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\GetRecipe.cshtml"
Write(Html.LabelFor(x => x.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\GetRecipe.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\GetRecipe.cshtml"
Write(Html.LabelFor(x => x.Materials));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\GetRecipe.cshtml"
Write(Html.TextBoxFor(x => x.Materials, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 20 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\GetRecipe.cshtml"
Write(Html.LabelFor(x => x.Details));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\GetRecipe.cshtml"
Write(Html.TextAreaFor(x => x.Details,15,1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 23 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\GetRecipe.cshtml"
Write(Html.LabelFor(x => x.FoodImage));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\GetRecipe.cshtml"
Write(Html.TextBoxFor(x => x.FoodImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>CategoryId: Makarna 1, Salata 2,....</label>\r\n    <br />\r\n");
#nullable restore
#line 28 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\GetRecipe.cshtml"
Write(Html.LabelFor(x => x.CategoryId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\GetRecipe.cshtml"
Write(Html.TextBoxFor(x => x.CategoryId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Tarif Güncelle</button>\r\n");
#nullable restore
#line 32 "C:\Users\Serhat\Desktop\WebProgramlama\recipes\recipes\Views\Admin\GetRecipe.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<recipes.Models.Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
