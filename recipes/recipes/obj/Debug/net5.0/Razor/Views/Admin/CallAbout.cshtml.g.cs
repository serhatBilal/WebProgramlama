#pragma checksum "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\CallAbout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd61ab688b995a843635b2fc96ee06b517e6f31d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CallAbout), @"mvc.1.0.view", @"/Views/Admin/CallAbout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd61ab688b995a843635b2fc96ee06b517e6f31d", @"/Views/Admin/CallAbout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c29a2335b2e03ea79bc7150e9fe74d6f08f7743c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CallAbout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<recipes.Models.About>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\CallAbout.cshtml"
  
    ViewData["Title"] = "CallAbout";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Hakkımızda Güncelleme Sayfası</h1>\n<br />\n\n<br />\n");
#nullable restore
#line 11 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\CallAbout.cshtml"
 using (Html.BeginForm("UpdateAbout", "Admin", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\CallAbout.cshtml"
Write(Html.LabelFor(x => x.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\CallAbout.cshtml"
Write(Html.TextBoxFor(x => x.Id, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n");
#nullable restore
#line 16 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\CallAbout.cshtml"
Write(Html.LabelFor(x => x.Title));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\CallAbout.cshtml"
Write(Html.TextBoxFor(x => x.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n");
#nullable restore
#line 19 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\CallAbout.cshtml"
Write(Html.LabelFor(x => x.ImageUrl));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\CallAbout.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n");
#nullable restore
#line 22 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\CallAbout.cshtml"
Write(Html.LabelFor(x => x.Detail));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\CallAbout.cshtml"
Write(Html.TextAreaFor(x => x.Detail,15,1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <button class=\"btn btn-success\">Hakkımızda Güncelle</button>\n");
#nullable restore
#line 26 "C:\Users\Serhat\Desktop\WebProgramlama-main\WebProgramlama-main\recipes\recipes\Views\Admin\CallAbout.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<recipes.Models.About> Html { get; private set; }
    }
}
#pragma warning restore 1591