#pragma checksum "C:\Users\prnja\Desktop\PMA_projekt Final\PMA_projekt\Views\Home\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "644fc47a3d91771c6f22f8fbe05b536096d2e663"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AccessDenied), @"mvc.1.0.view", @"/Views/Home/AccessDenied.cshtml")]
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
#line 1 "C:\Users\prnja\Desktop\PMA_projekt Final\PMA_projekt\Views\_ViewImports.cshtml"
using PMA_projekt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\prnja\Desktop\PMA_projekt Final\PMA_projekt\Views\_ViewImports.cshtml"
using PMA_projekt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"644fc47a3d91771c6f22f8fbe05b536096d2e663", @"/Views/Home/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"682483adb620494118463190569da3f077a68215", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AccessDenied : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\prnja\Desktop\PMA_projekt Final\PMA_projekt\Views\Home\AccessDenied.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""main"">
    <div class=""fof"">
        <h1>Error 403</h1>
        <p>Access Denied</p>
    </div>
</div>

<style>
    *{
        transition: all 0.6s;
    }

    html {
        height: 100%;
    }

    body{
        font-family: 'Lato', sans-serif;
        color: #888;
        margin: 0;
    }

    #main{
        display: table;
        width: 100%;
        height: 100vh;
        text-align: center;
    }

    .fof{
          display: table-cell;
          vertical-align: middle;
    }

    .fof h1{
          font-size: 50px;
          display: inline-block;
          padding-right: 12px;
          animation: type .5s alternate infinite;
    }

    ");
            WriteLiteral("@keyframes type{\r\n          from{box-shadow: inset -3px 0px 0px #888;}\r\n          to{box-shadow: inset -3px 0px 0px transparent;}\r\n    }\r\n</style>");
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
