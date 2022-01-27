#pragma checksum "C:\Users\prnja\Desktop\PMA_projekt Final\PMA_projekt\Views\City\City.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bcac0aea6fbe28a370e26af06e948a369cf999f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_City_City), @"mvc.1.0.view", @"/Views/City/City.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bcac0aea6fbe28a370e26af06e948a369cf999f", @"/Views/City/City.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"682483adb620494118463190569da3f077a68215", @"/Views/_ViewImports.cshtml")]
    public class Views_City_City : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\prnja\Desktop\PMA_projekt Final\PMA_projekt\Views\City\City.cshtml"
  
    ViewData["Title"] = "City";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""back"">
    <div class=""backRight""></div>
    <div class=""backLeft""></div>
</div>

<div id=""slideBox"">
    <div class=""topLayer"">
        <div class=""left"">
            <!--slika-->
        </div>
        <div class=""right"">
            <div class=""content"">
                <h2>City</h2>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bcac0aea6fbe28a370e26af06e948a369cf999f3774", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <input type=""text"" id=""naziv"" class=""form-control"" placeholder=""Naziv grada u Hrvatskoj"" required autofocus />
                        <span id=""naziv_g"" style=""color:red;""></span><br />
                    </div>
                    <button type=""button"" class=""btn btn-block"" id=""saveBtn"" onclick=""save()"">Spremi</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    'use strict';

    function save() {
        if (check()) {
            toDb();
        }
        else {
            alert(""Podaci nisu ispravni\nMolimo ispravite podatke i pokušajte ponovno"");
        }
    }

    function check() {
        var ok = true;

        var naziv = document.getElementById(""naziv"").value;

        //naziv grada
        if (naziv.length < 2) {
            ok = false;
            document.getElementById(""naziv_g"").innerHTML = ""Naziv grada mora biti upisan i dulji od 1 znaka"";
        }
        else if (!countLetter(naziv)) {  //ako pronade nesto sto nije slovo,space ili '-'
            ok = false;
            document.getElementById(""naziv_g"").innerHTML = ""Naziv smije sadržavati samo slova te po potrebi znak '-' ili razmak"";
        }
        else { //greska je ispravljena ili je nema
            document.getElementById(""naziv_g"").innerHTML = """";
        }

  ");
            WriteLiteral(@"      return ok;
    }

    function toDb() {

        var naziv = document.getElementById(""naziv"").value;

        var json = {
            ""id"": 0,//baza ce dodjeliti id
            ""naziv"": naziv,
        }
        axios.post('/api/city/save', json).then(response => alert(""Podaci su uspješno spremljeni""));
        //nakon spremanja vrati nas na popis svih knjiga
        window.setTimeout(function () {
            document.getElementById(""naziv"").value = """";
        }, 1000);
    }

    function countLetter(tekst) {
        tekst = tekst.toLowerCase();
        var abc = ""abcdefghijklmnopqrstuvwxyzšđčćž- "";
        for (var i = 0; i < tekst.length; i++) {
            if (!abc.includes(tekst[i])) {
                return false;
            }
        }
        return true;
    }

</script>

<style>
    body {
        height: 100%;
        overflow: hidden;
        width: 100% !important;
        box-sizing: border-box;
        font-family: ""Karma"", sans-serif;
    }
    .");
            WriteLiteral(@"backLeft {
        position: absolute;
        left: 0;
        width: 50%;
        height: 100%;
        background: url(https://images.unsplash.com/photo-1581321825690-944511645947?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=675&q=80);
        background-size: cover;
        background-position: 50% 50%;
    }

    #back {
        width: 100%;
        height: 100%;
        position: absolute;
        z-index: -999;
    }

    #slideBox {
        width: 50%;
        max-height: 100%;
        height: 100%;
        overflow: hidden;
        margin-left: 50%;
        position: absolute;
        box-shadow: 0 14px 28px rgba(0,0,0,0.25), 0 10px 10px rgba(0,0,0,0.22);
    }

    .topLayer {
        width: 200%;
        height: 100%;
        position: relative;
        left: 0;
        left: -100%;
    }

    .left {
        width: 50%;
        height: 100%;
        background: #2C3034;
        left: 0;
        position: absolute;
    }

    .right {
 ");
            WriteLiteral(@"       width: 50%;
        height: 100%;
        background: #f9f9f9;
        right: 0;
        position: absolute;
    }

    .content {
        width: 250px;
        margin: 0 auto;
        top: 30%;
        position: absolute;
        left: 25%;
        margin-left: -125px;
    }

        .content h2 {
            color: #03A9F4;
            font-weight: 300;
            font-size: 35px;
        }

    button {
        background: #03A9F4;
        padding: 10px 16px;
        width: auto;
        font-weight: 600;
        text-transform: uppercase;
        font-size: 14px;
        color: #fff;
        line-height: 16px;
        letter-spacing: 0.5px;
        border-radius: 2px;
        box-shadow: 0 2px 6px rgba(0,0,0,0.1), 0 3px 6px rgba(0,0,0,0.1);
        border: 0;
        outline: 0;
        margin: 15px 15px 15px 0;
        transition: all 0.25s;
    }

        button:hover {
            background: #0288D1;
            box-shadow: 0 4px 7px rgba(0,0,0,0.1), 0");
            WriteLiteral(@" 3px 6px rgba(0,0,0,0.1);
        }

    .off {
        background: none;
        color: #03A9F4;
        box-shadow: none;
    }

    .right .off:hover {
        background: #eee;
        color: #03A9F4;
        box-shadow: none;
    }

    .left .off:hover {
        box-shadow: none;
        color: #03A9F4;
        background: #363A3D;
    }

    input {
        background: transparent;
        border: 0;
        outline: 0;
        border-bottom: 1px solid #45494C;
        font-size: 14px;
        color: #959595;
        padding: 8px 0;
        margin-top: 20px;
    }
</style>");
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
