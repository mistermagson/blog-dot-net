#pragma checksum "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Areas\Admin\Views\Shared\MenuAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf64b9870a87312da6c162a33ef3b213f0d4285d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_MenuAdmin), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/MenuAdmin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/MenuAdmin.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_MenuAdmin))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf64b9870a87312da6c162a33ef3b213f0d4285d", @"/Areas/Admin/Views/Shared/MenuAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c0b7962d6b847878750ddd7b9f1dfa53357497b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_MenuAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 78, true);
            WriteLiteral("<aside>\r\n    <h1>Administração</h1>\r\n    <div>\r\n        <ul>\r\n            <li>");
            EndContext();
            BeginContext(79, 40, false);
#line 5 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Areas\Admin\Views\Shared\MenuAdmin.cshtml"
           Write(Html.ActionLink("Post", "Index", "Post"));

#line default
#line hidden
            EndContext();
            BeginContext(119, 52, true);
            WriteLiteral("</li>\r\n        </ul>\r\n        <ul>\r\n            <li>");
            EndContext();
            BeginContext(172, 47, false);
#line 8 "C:\Users\aspnet8498\leandro\source\repos\Blog\Blog\Areas\Admin\Views\Shared\MenuAdmin.cshtml"
           Write(Html.ActionLink("Usuários", "Index", "Usuario"));

#line default
#line hidden
            EndContext();
            BeginContext(219, 42, true);
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n</aside>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
