#pragma checksum "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\AllRecipes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a195c158d91b858b93831581b3d1cb37dd6c1524"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AllRecipes_Index), @"mvc.1.0.view", @"/Views/AllRecipes/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a195c158d91b858b93831581b3d1cb37dd6c1524", @"/Views/AllRecipes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c29a2335b2e03ea79bc7150e9fe74d6f08f7743c", @"/Views/_ViewImports.cshtml")]
    public class Views_AllRecipes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<recipes.Models.Recipe>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""banner-home""></section>
<section id=""blog"">
    <div class=""gradient""></div>
    <div class=""container"">
        <h1>Yemek Tariflerine Hoşgeldiniz</h1>
    </div>
    <div class=""container"">
        <div class=""heading"" data-aos=""fade-up"" data-aos-delay=""300"">
            <h2>Yemek Tariflerine Gözatın</h2>
            <h3>Birbirinden Lezzetli Binlerce Yemek Tarifleri </h3>
        </div>
        <div class=""row"">
");
#nullable restore
#line 14 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\AllRecipes\Index.cshtml"
             foreach (var x in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-6 col-sm-12\" data-aos=\"fade-up\" data-aos-delay=\"300\">\n    <div class=\"row\">\n        <div class=\"col-lg-5 col-sm-12\">\n            <a href=\"blog_single.html\" class=\"d-block mb-4 h-100\">\n                <img class=\"img-fluid img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 782, "\"", 800, 1);
#nullable restore
#line 20 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\AllRecipes\Index.cshtml"
WriteAttributeValue("", 788, x.FoodImage, 788, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"blog-3\">\n            </a>\n        </div>\n        <div class=\"col-lg-7 col-sm-12 inner-content d-flex align-content-center flex-wrap \" style=\"color:green\">\n            <h5>");
#nullable restore
#line 24 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\AllRecipes\Index.cshtml"
           Write(Html.ActionLink(@x.Name, "RecipeDetail", "Recipe", new { id = @x.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        </div>\n    </div>\n</div>      ");
#nullable restore
#line 27 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\AllRecipes\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<recipes.Models.Recipe>> Html { get; private set; }
    }
}
#pragma warning restore 1591