#pragma checksum "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5081eaddbc871d6e12b65670734c25970046320"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Index.cshtml", typeof(AspNetCore.Views_Post_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5081eaddbc871d6e12b65670734c25970046320", @"/Views/Post/Index.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog.Models.Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(33, 29, true);
            WriteLiteral("\r\n<h2>Lista de Posts</h2>\r\n\r\n");
            EndContext();
            BeginContext(63, 31, false);
#line 6 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Index.cshtml"
Write(Html.ActionLink("Novo", "Novo"));

#line default
#line hidden
            EndContext();
            BeginContext(94, 497, true);
            WriteLiteral(@"

<table style=""border: 1px solid black"">
    <thead>
        <tr>
            <!-- TH significa head, que é o cabeçalho -->
            <th style=""border: 1px solid black"">Título</th>
            <th style=""border: 1px solid black"">Resumo</th>
            <th style=""border: 1px solid black"">Categoria</th>
            <th style=""border: 1px solid black"">Publicado</th>
            <th style=""border: 1px solid black"" colspan=""2"">Ações</th>

        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 21 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Index.cshtml"
         foreach (var post in Model)
        {

#line default
#line hidden
            BeginContext(640, 92, true);
            WriteLiteral("            <tr>\r\n                <td style=\"border: 1px solid black\">\r\n                    ");
            EndContext();
            BeginContext(733, 63, false);
#line 25 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Index.cshtml"
               Write(Html.ActionLink(post.Titulo, "Visualiza", new { id = post.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(796, 77, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"border: 1px solid black\">");
            EndContext();
            BeginContext(874, 11, false);
#line 27 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Index.cshtml"
                                               Write(post.Resumo);

#line default
#line hidden
            EndContext();
            BeginContext(885, 59, true);
            WriteLiteral("</td>\r\n                <td style=\"border: 1px solid black\">");
            EndContext();
            BeginContext(945, 14, false);
#line 28 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Index.cshtml"
                                               Write(post.Categoria);

#line default
#line hidden
            EndContext();
            BeginContext(959, 61, true);
            WriteLiteral("</td>\r\n                <td style=\"border: 1px solid black\">\r\n");
            EndContext();
#line 30 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Index.cshtml"
                     if (post.Publicado)
                    {
                        

#line default
#line hidden
            BeginContext(1110, 62, false);
#line 32 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Index.cshtml"
                   Write(Html.Raw(string.Format("{0:dd/MM/yyyy}", post.DataPublicacao)));

#line default
#line hidden
            EndContext();
#line 32 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Index.cshtml"
                                                                                       

                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(1273, 15, false);
#line 37 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Index.cshtml"
                   Write(Html.Raw("Não"));

#line default
#line hidden
            EndContext();
#line 37 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Index.cshtml"
                                        
                    }

#line default
#line hidden
            BeginContext(1313, 99, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"border: 1px solid black\">\r\n                    ");
            EndContext();
            BeginContext(1413, 58, false);
#line 42 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Index.cshtml"
               Write(Html.ActionLink("Remover", "Delete", new { id = post.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1471, 99, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"border: 1px solid black\">\r\n                    ");
            EndContext();
            BeginContext(1571, 64, false);
#line 45 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Index.cshtml"
               Write(Html.ActionLink("Publicar", "publicapost", new { id = post.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1635, 46, true);
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 49 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Views\Post\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(1694, 28, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
