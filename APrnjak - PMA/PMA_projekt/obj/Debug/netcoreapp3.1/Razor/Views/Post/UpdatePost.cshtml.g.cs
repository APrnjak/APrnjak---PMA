#pragma checksum "C:\Users\prnja\Desktop\PMA_projekt Final\PMA_projekt\Views\Post\UpdatePost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff7bdcd53d6597c362f3136626a4cec42665e3af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_UpdatePost), @"mvc.1.0.view", @"/Views/Post/UpdatePost.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff7bdcd53d6597c362f3136626a4cec42665e3af", @"/Views/Post/UpdatePost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"682483adb620494118463190569da3f077a68215", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_UpdatePost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\prnja\Desktop\PMA_projekt Final\PMA_projekt\Views\Post\UpdatePost.cshtml"
  
    ViewData["Title"] = "Post";

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
                <h2>Update Post</h2>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff7bdcd53d6597c362f3136626a4cec42665e3af3819", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" id=""id"" placeholder=""Recenzija br."" readonly>
                    </div>
                    <div class=""form-group"">
                        <textarea id=""sadrzaj"" class=""form-control rows=""4"" cols=""50"" placeholder=""Sadr??aj...""></textarea>
                        <span id=""sadrzaj_g"" style=""color:red;""></span>
                    </div>
                    <div class=""form-group"">
                        <input type=""text"" class=""form-control"" id=""datum"" placeholder=""Datum"">
                    </div>
                    <div class=""form-group"">
                        <select id=""grad"" class=""selectpicker"">
                            <!--Dinami??ki dodajemo opcije iz baze-->
                        </select>
                        <span id=""grad_g"" style=""color:red;""></span><br />
                    </div>
                    <div class=""form-group"">
                        <sele");
                WriteLiteral(@"ct id=""objekt"" class=""selectpicker"">
                            <!--Dinami??ki dodajemo opcije iz baze-->
                        </select>
                        <span id=""objekt_g"" style=""color:red;""></span><br />
                    </div>
                    <button id=""saveBtn"" class=""btn btn-block"" value=""Spremi"" onclick=""save()"">Spremi</button>
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
    window.onload = function () {
        if (sessionStorage.length == 0 || sessionStorage.getItem(""id"") == null || sessionStorage.getItem(""id"") == undefined) {
            window.alert(""Dogodila se pogreska kod u??itavanja\nPodaci o objavi nisu u??itani"");
            this.document.getElementById(""saveBtn"").disabled = true;
        } //nema podatka za azurirati
        else {
            var id = sessionStorage.getItem(""id"");
            axios.get(`/api/post/${id}`, id).then(response => addToForm(response.data));
            axios.get('/api/city').then(response => addToSelectCity(response.data));
            axios.get('/api/place').then(response => addToSelectPlace(response.data));

        }
    }

    function addToForm(podaci) {

        console.log(podaci);
        document.getElementById(""id"").value = podaci.id;
        document.getElementById(""sadrzaj"").value = podaci.sadrza");
            WriteLiteral(@"j;
        document.getElementById(""datum"").value = podaci.datum;
    }

    function addToSelectCity(podaci) {

        var select = document.getElementById(""grad"");
        for (var i = 0; i < podaci.length; i++) {
            var option = document.createElement(""option"");
            option.text = podaci[i].naziv;
            option.value = podaci[i].id;
            select.appendChild(option);
        }

    }

    function addToSelectPlace(podaci) {

        console.log(podaci);
        var select = document.getElementById(""objekt"");
        for (var i = 0; i < podaci.length; i++) {
            var option = document.createElement(""option"");
            option.text = podaci[i].vlasnik + "" - "" + podaci[i].naziv;
            option.value = podaci[i].id;
            select.appendChild(option);
        }

    }

    function save() {

        if (check()) {
            insert();
        }
        else {
            alert(""Podaci nisu ispravni\nMolimo ispravite podatke i poku??");
            WriteLiteral(@"ajte ponovno"");
        }
    }

    function check() {

        var ok = true;
        var sadraj = document.getElementById(""sadrzaj"").value;

        //sadrzaj
        if (sadraj.length < 1) {
            ok = false;
            document.getElementById(""sadrzaj_g"").innerHTML = ""Sadr??aj mora biti upisan i dulji od 1 znaka"";
        }
        else {
            document.getElementById(""sadrzaj_g"").innerHTML = """";
        }

        //objekt
        var objektId = document.getElementById(""objekt"").value;
        if (objektId <= 0) {
            ok = false;
            document.getElementById(""objekt_g"").innerHTML = ""Mora se odabrati ne??to od ponu??enog"";
        }
        else {
            document.getElementById(""objekt_g"").innerHTML = """";
        }
        //grad
        var gradId = document.getElementById(""grad"").value;
        if (gradId <= 0) {
            ok = false;
            document.getElementById(""grad_g"").innerHTML = ""Mora se odabrati ne??to od ponu??enog"";
        }");
            WriteLiteral(@"
        else {
            document.getElementById(""grad_g"").innerHTML = """";
        }

        return ok;
    }

    function insert() {

        //dovoljno je samo spremit podatke
        //nema potrebe provjeravat postoje li ti gradovi i/ili objekti jer smo ih izvukli iz baze podataka kod ucitavanja stranice

        var id = document.getElementById(""id"").value;
        var sadrzaj = document.getElementById(""sadrzaj"").value;
        var datum = document.getElementById(""datum"").value;
        var gradId = document.getElementById(""grad"").value;
        var objektId = document.getElementById(""objekt"").value;

        alert(id + "" "" + sadrzaj + "" "" + datum + "" "" + gradId + "" "" + objektId);
        var json = {
            ""id"": id,
            ""sadrzaj"": sadrzaj,
            ""datum"": datum,
            ""grad"": gradId,
            ""objekt"": objektId
        }

        axios.put('/api/post/update', json).then(response => alert(""Podaci su uspje??no a??urirani""));
        window.setTime");
            WriteLiteral(@"out(function () {
            window.location.href = ""/Post/Post"";
        }, 2000); 
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

    .backLeft {
        position: absolute;
        left: 0;
        width: 50%;
        height: 100%;
        background: url(https://images.unsplash.com/photo-1481931098730-318b6f776db0?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=500&q=60);
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
");
            WriteLiteral(@"    }

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
        width: 50%;
        height: 100%;
        background: #f9f9f9;
        right: 0;
        position: absolute;
    }

    .content {
        width: 250px;
        margin: 0 auto;
        top: 10%;
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
        border-radius: 2");
            WriteLiteral(@"px;
        box-shadow: 0 2px 6px rgba(0,0,0,0.1), 0 3px 6px rgba(0,0,0,0.1);
        border: 0;
        outline: 0;
        margin: 15px 15px 15px 0;
        transition: all 0.25s;
    }

        button:hover {
            background: #0288D1;
            box-shadow: 0 4px 7px rgba(0,0,0,0.1), 0 3px 6px rgba(0,0,0,0.1);
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
</style>
");
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
