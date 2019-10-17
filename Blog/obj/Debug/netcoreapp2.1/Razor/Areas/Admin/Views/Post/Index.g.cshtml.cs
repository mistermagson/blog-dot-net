#pragma checksum "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87258af55443a084468b19e37475ec55684f5e57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Post_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Post/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Post/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Post_Index))]
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
#line 2 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Areas\Admin\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87258af55443a084468b19e37475ec55684f5e57", @"/Areas/Admin/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c0b7962d6b847878750ddd7b9f1dfa53357497b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(21, 71, true);
            WriteLiteral("\r\n<h2>Lista de Posts</h2>\r\n\r\n<br />\r\n\r\n<div class=\"form-control\">\r\n    ");
            EndContext();
            BeginContext(93, 87, false);
#line 9 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
Write(Html.ActionLink("Incluir Post", "Novo", null, null, new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(180, 528, true);
            WriteLiteral(@"

</div>
<table class=""table table-striped table-hover table-bordered"">
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
#line 25 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
         foreach (var post in Model)
        {

#line default
#line hidden
            BeginContext(757, 92, true);
            WriteLiteral("            <tr>\r\n                <td style=\"border: 1px solid black\">\r\n                    ");
            EndContext();
            BeginContext(850, 63, false);
#line 29 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
               Write(Html.ActionLink(post.Titulo, "Visualiza", new { id = post.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(913, 77, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"border: 1px solid black\">");
            EndContext();
            BeginContext(991, 11, false);
#line 31 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
                                               Write(post.Resumo);

#line default
#line hidden
            EndContext();
            BeginContext(1002, 59, true);
            WriteLiteral("</td>\r\n                <td style=\"border: 1px solid black\">");
            EndContext();
            BeginContext(1062, 14, false);
#line 32 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
                                               Write(post.Categoria);

#line default
#line hidden
            EndContext();
            BeginContext(1076, 61, true);
            WriteLiteral("</td>\r\n                <td style=\"border: 1px solid black\">\r\n");
            EndContext();
#line 34 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
                     if (post.Publicado)
                    {
                        

#line default
#line hidden
            BeginContext(1227, 62, false);
#line 36 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
                   Write(Html.Raw(string.Format("{0:dd/MM/yyyy}", post.DataPublicacao)));

#line default
#line hidden
            EndContext();
#line 36 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
                                                                                       

                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(1390, 15, false);
#line 41 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
                   Write(Html.Raw("Não"));

#line default
#line hidden
            EndContext();
#line 41 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
                                        
                    }

#line default
#line hidden
            BeginContext(1430, 120, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"border: 1px solid black\">\r\n                   \r\n                    ");
            EndContext();
            BeginContext(1551, 93, false);
#line 47 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
               Write(Html.ActionLink("Remover", "Delete", new { id = post.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1644, 99, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"border: 1px solid black\">\r\n                    ");
            EndContext();
            BeginContext(1744, 100, false);
#line 50 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"
               Write(Html.ActionLink("Publicar", "publicapost", new { id = post.Id }, new { @class = "btn btn-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(1844, 46, true);
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 54 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Areas\Admin\Views\Post\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(1903, 28, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
