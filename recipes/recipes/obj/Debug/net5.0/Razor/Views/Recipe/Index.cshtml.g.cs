#pragma checksum "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Recipe\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4fe49b32d3d6673eba8008ab3f6cc4f5c603f12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe_Index), @"mvc.1.0.view", @"/Views/Recipe/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4fe49b32d3d6673eba8008ab3f6cc4f5c603f12", @"/Views/Recipe/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c29a2335b2e03ea79bc7150e9fe74d6f08f7743c", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<recipes.Models.Recipe>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""banner-home""></section>


<section id=""blog"">
    <div class=""gradient""></div>
    <div class=""container"">
        <h1>Welcome to our food blog</h1>
    </div>
    <hr />
    <!-- Page Content -->
    <div class=""container"">
        <div class=""heading"" data-aos=""fade-up"" data-aos-delay=""300"">
            <h2>Read Food Articles</h2>
            <h3>creative and awesome food articles </h3>
        </div>
        <div class=""row"">
");
#nullable restore
#line 18 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Recipe\Index.cshtml"
             foreach(var x in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-6 col-sm-12"" data-aos=""fade-up"" data-aos-delay=""300"">
                <div class=""row"">
                    <div class=""col-lg-5 col-sm-12"">
                        <a href=""blog_single.html"" class=""d-block mb-4 h-100"">
                            <img class=""img-fluid img-thumbnail"" src=""/lib/bootstrap/dist/images/item-4.jpg"" alt=""blog-3"">
                        </a>
                    </div>
                    <div class=""col-lg-7 col-sm-12 inner-content"">
                        <h5><a");
            BeginWriteAttribute("href", " href=\"", 1057, "\"", 1091, 2);
            WriteAttributeValue("", 1064, "/Recipe/RecipesDetail/", 1064, 22, true);
#nullable restore
#line 27 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Recipe\Index.cshtml"
WriteAttributeValue("", 1086, x.Id, 1086, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Recipe\Index.cshtml"
                                                             Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\n                        <h6>");
#nullable restore
#line 28 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Recipe\Index.cshtml"
                       Write(x.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\n                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 32 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Recipe\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""row bt"">
            <div class=""col-sm-12"">
                <ul>
                    <li data-aos=""fade-right"" data-aos-delay=""100""><a class=""active"" href=""#"">1</a></li>
                    <li data-aos=""fade-right"" data-aos-delay=""300""><a href=""#"">2</a></li>
                    <li data-aos=""fade-right"" data-aos-delay=""500""><a href=""#"">3</a></li>
                    <li data-aos=""fade-right"" data-aos-delay=""700""><a href=""#"">4</a></li>
                    <li data-aos=""fade-right"" data-aos-delay=""900""><a href=""#"">5</a></li>
                </ul>
            </div>
        </div>
    </div>
    <!-- /.container -->
</section>

");
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
