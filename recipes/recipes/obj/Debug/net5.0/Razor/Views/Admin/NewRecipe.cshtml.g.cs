#pragma checksum "C:\Users\UMUT\Desktop\DENEME\recipes\recipes\Views\Admin\NewRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36456604b735973c2089ff4a0745ac89d72b2eca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_NewRecipe), @"mvc.1.0.view", @"/Views/Admin/NewRecipe.cshtml")]
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
#line 1 "C:\Users\UMUT\Desktop\DENEME\recipes\recipes\Views\_ViewImports.cshtml"
using recipes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\UMUT\Desktop\DENEME\recipes\recipes\Views\_ViewImports.cshtml"
using recipes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36456604b735973c2089ff4a0745ac89d72b2eca", @"/Views/Admin/NewRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c29a2335b2e03ea79bc7150e9fe74d6f08f7743c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_NewRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<recipes.Models.Recipe>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\UMUT\Desktop\DENEME\recipes\recipes\Views\Admin\NewRecipe.cshtml"
   ViewData["Title"] = "Index";
                Layout = "~/Views/Shared/_AdminLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Yeni Tarif Ekleme Sayfası</h2>\n<br />\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36456604b735973c2089ff4a0745ac89d72b2eca4155", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line 8 "C:\Users\UMUT\Desktop\DENEME\recipes\recipes\Views\Admin\NewRecipe.cshtml"
Write(Html.LabelFor(x => x.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 9 "C:\Users\UMUT\Desktop\DENEME\recipes\recipes\Views\Admin\NewRecipe.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <br />\n\n    ");
#nullable restore
#line 12 "C:\Users\UMUT\Desktop\DENEME\recipes\recipes\Views\Admin\NewRecipe.cshtml"
Write(Html.LabelFor(x => x.Materials));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 13 "C:\Users\UMUT\Desktop\DENEME\recipes\recipes\Views\Admin\NewRecipe.cshtml"
Write(Html.TextAreaFor(x => x.Materials, 15, 20, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <br />\n    ");
#nullable restore
#line 15 "C:\Users\UMUT\Desktop\DENEME\recipes\recipes\Views\Admin\NewRecipe.cshtml"
Write(Html.LabelFor(x => x.Details));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 16 "C:\Users\UMUT\Desktop\DENEME\recipes\recipes\Views\Admin\NewRecipe.cshtml"
Write(Html.TextAreaFor(x => x.Details, 15, 20, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <br />\n    ");
#nullable restore
#line 18 "C:\Users\UMUT\Desktop\DENEME\recipes\recipes\Views\Admin\NewRecipe.cshtml"
Write(Html.LabelFor(x => x.FoodImage));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 19 "C:\Users\UMUT\Desktop\DENEME\recipes\recipes\Views\Admin\NewRecipe.cshtml"
Write(Html.TextBoxFor(x => x.FoodImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <br />\n    <label>CategoryId: Makarna 1, Salata 2,....</label><br />\n    ");
#nullable restore
#line 22 "C:\Users\UMUT\Desktop\DENEME\recipes\recipes\Views\Admin\NewRecipe.cshtml"
Write(Html.LabelFor(x => x.CategoryId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    ");
#nullable restore
#line 23 "C:\Users\UMUT\Desktop\DENEME\recipes\recipes\Views\Admin\NewRecipe.cshtml"
Write(Html.TextBoxFor(x => x.CategoryId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <br />\n    <button class=\"btn btn-primary\">Tarif Ekle</button>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
