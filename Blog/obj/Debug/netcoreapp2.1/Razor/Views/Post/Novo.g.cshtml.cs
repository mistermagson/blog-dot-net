#pragma checksum "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Novo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a78a651692644d7717c206445d9f0d898a4cb30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Novo), @"mvc.1.0.view", @"/Views/Post/Novo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Novo.cshtml", typeof(AspNetCore.Views_Post_Novo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a78a651692644d7717c206445d9f0d898a4cb30", @"/Views/Post/Novo.cshtml")]
    public class Views_Post_Novo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog.Models.Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validate/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(25, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Novo.cshtml"
 using (Html.BeginForm("Adiciona", "Post", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(99, 28, false);
#line 6 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Novo.cshtml"
Write(Html.LabelFor(p => p.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(134, 30, false);
#line 7 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Novo.cshtml"
Write(Html.TextBoxFor(p => p.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(171, 40, false);
#line 8 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Novo.cshtml"
Write(Html.ValidationMessageFor(p => p.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(220, 28, false);
#line 10 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Novo.cshtml"
Write(Html.LabelFor(p => p.Resumo));

#line default
#line hidden
            EndContext();
            BeginContext(255, 30, false);
#line 11 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Novo.cshtml"
Write(Html.TextBoxFor(p => p.Resumo));

#line default
#line hidden
            EndContext();
            BeginContext(292, 40, false);
#line 12 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Novo.cshtml"
Write(Html.ValidationMessageFor(p => p.Resumo));

#line default
#line hidden
            EndContext();
            BeginContext(341, 31, false);
#line 14 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Novo.cshtml"
Write(Html.LabelFor(p => p.Categoria));

#line default
#line hidden
            EndContext();
            BeginContext(379, 33, false);
#line 15 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Novo.cshtml"
Write(Html.TextBoxFor(p => p.Categoria));

#line default
#line hidden
            EndContext();
            BeginContext(419, 43, false);
#line 16 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Novo.cshtml"
Write(Html.ValidationMessageFor(p => p.Categoria));

#line default
#line hidden
            EndContext();
            BeginContext(466, 47, true);
            WriteLiteral("    <input type=\"submit\" value=\"Cadastrar\" />\r\n");
            EndContext();
#line 19 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Novo.cshtml"
}

#line default
#line hidden
            BeginContext(516, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(518, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "359665bab5a64a339ccc70d673149843", async() => {
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
            BeginContext(564, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(566, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc6b109cccaf4349a964e2862e4dea62", async() => {
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
            BeginContext(630, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(632, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa3500c39fbb4d4bb803a64c74383f95", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(722, 2, true);
            WriteLiteral("\r\n");
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
