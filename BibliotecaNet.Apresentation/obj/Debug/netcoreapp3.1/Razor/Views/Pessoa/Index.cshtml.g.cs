#pragma checksum "C:\Users\Squadra\source\repos\BibliotecaNet\BibliotecaNet.Apresentation\Views\Pessoa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca3b6bcaf09bd1ec16ad1b1d1de8573c8a886b3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoa_Index), @"mvc.1.0.view", @"/Views/Pessoa/Index.cshtml")]
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
#line 1 "C:\Users\Squadra\source\repos\BibliotecaNet\BibliotecaNet.Apresentation\Views\_ViewImports.cshtml"
using BibliotecaNet.Apresentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Squadra\source\repos\BibliotecaNet\BibliotecaNet.Apresentation\Views\_ViewImports.cshtml"
using BibliotecaNet.Apresentation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca3b6bcaf09bd1ec16ad1b1d1de8573c8a886b3b", @"/Views/Pessoa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a86db10214cc7c014479538e343824e7d6066f", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h4>Consulta de pessoa</h4>
<hr />

<div class=""row"">
    <div class=""col-md-12"">
        <table id=""table""
               data-toggle=""table""
               data-locale=""pt-BR""
               data-height=""460""
               data-ajax=""ajaxRequest""
               data-search=""true""
               data-side-pagination=""server""
               data-buttons=""buttons""
               data-pagination=""true"">
            <thead>
                <tr>
                    <th data-field=""nome"">Nome</th>
                    <th data-field=""pessoaTipo"">Tipo de Pessoa</th>
                    <th data-field="""" data-formatter=""exibirIconesGrid"">Exibir consulta</th>
                </tr>
            </thead>
        </table>
    </div>
</div>

<div class=""modal fade"" id=""myModal"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" style=""min-width: 99% !important"">
        <div class=""modal-content"">
  ");
            WriteLiteral(@"          <div class=""modal-header"">
                <h5 class=""modal-title"" id=""staticBackdropLabel"">Informações da consulta</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""modal-content"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>

            </div>
        </div>
    </div>
</div>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/sweetalert/2.1.2/sweetalert.min.js""></script>

<script type=""text/javascript"">

    function exibirIconesGrid(value, row) {
        return `<a class=""btn"" href='/Pessoa/Cadastro/${row.id}' >
<svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""curr");
            WriteLiteral(@"entColor"" class=""bi bi-pencil-fill"" viewBox=""0 0 16 16"">
  <path d=""M12.854.146a.5.5 0 0 0-.707 0L10.5 1.793 14.207 5.5l1.647-1.646a.5.5 0 0 0 0-.708l-3-3zm.646 6.061L9.793 2.5 3.293 9H3.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.207l6.5-6.5zm-7.468 7.468A.5.5 0 0 1 6 13.5V13h-.5a.5.5 0 0 1-.5-.5V12h-.5a.5.5 0 0 1-.5-.5V11h-.5a.5.5 0 0 1-.5-.5V10h-.5a.499.499 0 0 1-.175-.032l-.179.178a.5.5 0 0 0-.11.168l-2 5a.5.5 0 0 0 .65.65l5-2a.5.5 0 0 0 .168-.11l.178-.178z""/>
</svg>
</a>`;
    }

    function ajaxRequest(params) {
        var url = '/Pessoa/ListarPessoas'

        $.get(url + '?' + $.param(params.data)).then(function (res) {
            params.success(res)
        })
    }

    function buttons() {
        return {

            btnAdd: {
                text: 'Cadastrar',
                icon: 'fa-plus',
                event: function () {
                    window.location = '/Pessoa/Cadastro'
                },
                attributes");
            WriteLiteral(": {\r\n                    title: \'Novo\'\r\n                }\r\n            }\r\n        }\r\n    }\r\n</script>\r\n");
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
