#pragma checksum "D:\Study\Programacion\Mi Codigo\Paralelismo\Paralelismo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d3cbfdd2f02d7e2da4b71079f00f4bea95300ee"
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
#line 1 "D:\Study\Programacion\Mi Codigo\Paralelismo\Paralelismo\Views\_ViewImports.cshtml"
using Paralelismo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\Programacion\Mi Codigo\Paralelismo\Paralelismo\Views\_ViewImports.cshtml"
using Paralelismo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d3cbfdd2f02d7e2da4b71079f00f4bea95300ee", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07a0910d9e9be53841dde01757ebfcfae8f553f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Study\Programacion\Mi Codigo\Paralelismo\Paralelismo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<div>
    <h4>Course</h4>
    <hr />
    <dl class=""row"">
        <dt class=""col-sm-2"">
            Tiempo de Duracion:
        </dt>
        <dd class=""col-sm-10"">
            ");
#nullable restore
#line 18 "D:\Study\Programacion\Mi Codigo\Paralelismo\Paralelismo\Views\Home\Index.cshtml"
       Write(Html.ViewBag.Duracion);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Resultado 1\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n           ");
#nullable restore
#line 24 "D:\Study\Programacion\Mi Codigo\Paralelismo\Paralelismo\Views\Home\Index.cshtml"
      Write(Html.ViewBag.ResultadosEnparalelo1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Resultado 2\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "D:\Study\Programacion\Mi Codigo\Paralelismo\Paralelismo\Views\Home\Index.cshtml"
       Write(Html.ViewBag.ResultadosEnparalelo2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n");
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