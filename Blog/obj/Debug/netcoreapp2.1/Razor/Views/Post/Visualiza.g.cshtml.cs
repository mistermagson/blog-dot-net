#pragma checksum "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Visualiza.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d022ffd7ef16cdef6209e50b9ad5739e7163ba2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Visualiza), @"mvc.1.0.view", @"/Views/Post/Visualiza.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Visualiza.cshtml", typeof(AspNetCore.Views_Post_Visualiza))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d022ffd7ef16cdef6209e50b9ad5739e7163ba2", @"/Views/Post/Visualiza.cshtml")]
    public class Views_Post_Visualiza : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog.Models.Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validate/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 80, true);
            WriteLiteral("\r\n<form method=\"post\" action=\"/Post/Altera\">\r\n    <input type=\"hidden\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 105, "\"", 122, 1);
#line 4 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Visualiza.cshtml"
WriteAttributeValue("", 113, Model.Id, 113, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(123, 50, true);
            WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"datapublicado\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 173, "\"", 202, 1);
#line 5 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Visualiza.cshtml"
WriteAttributeValue("", 181, Model.DataPublicacao, 181, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(203, 46, true);
            WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"publicado\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 249, "\"", 284, 1);
#line 6 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Visualiza.cshtml"
WriteAttributeValue("", 257, Model.Publicado.ToString(), 257, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(285, 56, true);
            WriteLiteral(" />\r\n\r\n    <label>\r\n        Título: <input name=\"titulo\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 341, "\"", 362, 1);
#line 9 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Visualiza.cshtml"
WriteAttributeValue("", 349, Model.Titulo, 349, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(363, 32, true);
            WriteLiteral(" required />\r\n    </label>\r\n    ");
            EndContext();
            BeginContext(396, 32, false);
#line 11 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Visualiza.cshtml"
Write(Html.ValidationMessage("titulo"));

#line default
#line hidden
            EndContext();
            BeginContext(428, 54, true);
            WriteLiteral(";\r\n\r\n    <label>\r\n        Resumo: <input name=\"resumo\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 482, "\"", 503, 1);
#line 14 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Visualiza.cshtml"
WriteAttributeValue("", 490, Model.Resumo, 490, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(504, 47, true);
            WriteLiteral(" required maxlength=\"50\" />\r\n    </label>\r\n    ");
            EndContext();
            BeginContext(552, 32, false);
#line 16 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Visualiza.cshtml"
Write(Html.ValidationMessage("resumo"));

#line default
#line hidden
            EndContext();
            BeginContext(584, 60, true);
            WriteLiteral(";\r\n\r\n    <label>\r\n        Categoria: <input name=\"categoria\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 644, "\"", 668, 1);
#line 19 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Visualiza.cshtml"
WriteAttributeValue("", 652, Model.Categoria, 652, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(669, 23, true);
            WriteLiteral(" />\r\n    </label>\r\n    ");
            EndContext();
            BeginContext(693, 35, false);
#line 21 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Visualiza.cshtml"
Write(Html.ValidationMessage("categoria"));

#line default
#line hidden
            EndContext();
            BeginContext(728, 59, true);
            WriteLiteral(";\r\n\r\n    <input type=\"submit\" value=\"Alterar\" />\r\n</form>\r\n");
            EndContext();
            BeginContext(787, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a50c4e7e8c347658df2833e9d0e8cc2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(833, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(835, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2a7f676e3cc4164a4b2d438754a48e2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(899, 48, true);
            WriteLiteral("\r\n<script>\r\n    $(\'form\').validade();\r\n</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
