#pragma checksum "C:\Users\Squadra\source\repos\BibliotecaNet\BibliotecaNet.Apresentation\Views\PessoaDocumento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22b9df605a0a5a3ef96000beb912447b1dc88b6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PessoaDocumento_Index), @"mvc.1.0.view", @"/Views/PessoaDocumento/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22b9df605a0a5a3ef96000beb912447b1dc88b6f", @"/Views/PessoaDocumento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a86db10214cc7c014479538e343824e7d6066f", @"/Views/_ViewImports.cshtml")]
    public class Views_PessoaDocumento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h4>Consulta de tipo de documento</h4>
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
                    <th data-field=""descricao"">Descrição</th>
                    <th data-field=""mascara"">Mascara</th>
                    <th data-field=""obrigatorio"">Obrigatório</th>
                    <th data-field="""" data-formatter=""exibirIconesGrid"">Exibir consulta</th>
                </tr>
            </thead>
        </table>
    </div>
</div>

<div class=""modal fade"" id=""myModal"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialo");
            WriteLiteral(@"g"" style=""min-width: 99% !important"">
        <div class=""modal-content"">
            <div class=""modal-header"">
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
        return `<a class=""btn"" href='/PessoaDocumento/Cadastro/");
            WriteLiteral(@"${row.id}'>
                    <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-arrows-angle-expand"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                    <path fill-rule=""evenodd"" d=""M5.828 10.172a.5.5 0 0 0-.707 0l-4.096 4.096V11.5a.5.5 0 0 0-1 0v3.975a.5.5 0 0 0 .5.5H4.5a.5.5 0 0 0 0-1H1.732l4.096-4.096a.5.5 0 0 0 0-.707zm4.344-4.344a.5.5 0 0 0 .707 0l4.096-4.096V4.5a.5.5 0 1 0 1 0V.525a.5.5 0 0 0-.5-.5H11.5a.5.5 0 0 0 0 1h2.768l-4.096 4.096a.5.5 0 0 0 0 .707z""/>
                    </svg>
                </a>`;
    }

   

    function ajaxRequest(params) {
        var url = '/PessoaDocumento/Listar'

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
                    window.location = '/PessoaDocumento/Cada");
            WriteLiteral("stro\'\r\n                },\r\n                attributes: {\r\n                    title: \'Novo\'\r\n                }\r\n            }\r\n        }\r\n    }\r\n\r\n</script>\r\n");
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
