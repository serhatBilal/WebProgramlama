#pragma checksum "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05fe8f28a303d7a8cabae49edd24d2c2f0748462"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05fe8f28a303d7a8cabae49edd24d2c2f0748462", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c29a2335b2e03ea79bc7150e9fe74d6f08f7743c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<recipes.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""banner-home"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-12"">
                <h1 data-aos=""fade-left"" data-aos-delay=""300"">Yemek Tariflerine Hoşgeldiniz</h1><br>
                <h2 data-aos=""fade-left"" data-aos-delay=""500"">Çok Lezzetli Yemek Tarifleri</h2>
                <h4 data-aos=""fade-left"" data-aos-delay=""700"">İnternetteki en iyi yemek tarifleri <span>tariflere bir gözatıp deneyin </span></h4>
                <p data-aos=""fade-left"" data-aos-delay=""900"">
                    <i class=""fa fa-map-marker"" aria-hidden=""true""></i><span>Yemektarifleri.com</span>
                </p>
                <p data-aos=""fade-left"" data-aos-delay=""900"">

                    <i class=""fa fa-phone"" aria-hidden=""true""></i><span>0542 123 45 67</span>
                </p>
                <a class=""btn btn-success"" href=""/Recipe/Index"" role=""button"" data-aos=""fade-up"" data-aos-delay=""1000"">Tariflere Gözat</a>
            </div>
        </div>
    </div>
</section>
<");
            WriteLiteral(@"section class=""testimonial"">
    <div id=""carousel"">
        <div class=""container"">
            <div class=""quote"" style=""float: left;""><i class=""fa fa-quote-left fa-5x"" aria-hidden=""true""></i></div>
            <div class=""row"">
                <div class=""col-sm-12"">
                    <div class=""heading"" data-aos=""fade-up"" data-aos-delay=""300"">
                        <h2>İnsanlar bizim tariflerimizi <span>Çoooook Seviyor</span></h2>
                        <h3>İnternetteki en iyi yemek tarifleri</h3>
                    </div>
                </div>
                <div class=""col-md-6 col1"" data-aos=""fade-right"" data-aos-delay=""500"">
                    <i class=""fa fa-angle-double-down"" aria-hidden=""true""></i>
                    <div class=""carousel slide"" id=""fade-quote-carousel"" data-ride=""carousel"" data-interval=""3000"">
                        <div class=""carousel-inner"" style=""text-align: right"">
                            <div class=""active item"">
                                <blockquote>
 ");
            WriteLiteral(@"                                   <p>Sakarya üniversitesi Bilgisayar Mühendisliği Web Programlama Proje Ödevi</p>
                                </blockquote>
                                <div class=""text1"">Umut Sönmez <span>Bursa</span></div>
                                <div class=""profile-circle1"" style=""background-color: rgba(0,0,0,.2); float: right;""></div>
                            </div>
                        </div>
                    </div>
                    <i class=""fa fa-angle-double-up"" aria-hidden=""true""></i>
                </div>
                <div class=""col-md-6"" data-aos=""fade-left"" data-aos-delay=""500"">
                    <div class=""carousel slide"" id=""fade-quote-carousel"" data-ride=""carousel"" data-interval=""3000"">
                        <div class=""carousel-inner"">
                            <div class=""active item"">
                                <blockquote>
                                    <p>Sakarya üniversitesi Bilgisayar Mühendisliği Web Programlama Proje Öde");
            WriteLiteral(@"vi</p>
                                </blockquote>
                                <div class=""profile-circle2"" style=""background-color: rgba(0,0,0,.2);""></div>
                                <div class=""text2"">Serhat BİLAL <span>Sakarya</span></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""quote""><i class=""fa fa-quote-right fa-5x"" aria-hidden=""true""></i></div>
        </div>
    </div>
</section>
<section class=""items"">
    <div class=""container"">
        <div class=""heading"" data-aos=""fade-up"" data-aos-delay=""300"">
            <h2>Lezzetli <span><a href=""recipes.html"">Tariflere</a></span> Gözat</h2>
            <h3>İnternetteki en iyi yemek tarifleri burada yer almaktadır on binlerce tarif ve milyonlarca kullanıcı burada</h3>
        </div>

        <div class=""row text-center text-lg-left"">
");
#nullable restore
#line 73 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Home\Index.cshtml"
             foreach (var x in Model)
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-3 col-md-4 col-6\" data-aos=\"fade-left\" data-aos-delay=\"900\">\n                    <div class=\"imageBox\">\n\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4277, "\"", 4303, 2);
            WriteAttributeValue("", 4284, "/Recipe/Index/", 4284, 14, true);
#nullable restore
#line 79 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Home\Index.cshtml"
WriteAttributeValue("", 4298, x.Id, 4298, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block mb-4 h-100\">\n                            <img");
            BeginWriteAttribute("src", " src=\"", 4365, "\"", 4382, 1);
#nullable restore
#line 80 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Home\Index.cshtml"
WriteAttributeValue("", 4371, x.ImageUrl, 4371, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4383, "\"", 4389, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            <div class=\"textBox\">\n                                <h5>");
#nullable restore
#line 82 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Home\Index.cshtml"
                               Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                            </div>\n                        </a>\n                    </div>\n                </div>            ");
#nullable restore
#line 86 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Home\Index.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n\n    </div>\n</section>");
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
