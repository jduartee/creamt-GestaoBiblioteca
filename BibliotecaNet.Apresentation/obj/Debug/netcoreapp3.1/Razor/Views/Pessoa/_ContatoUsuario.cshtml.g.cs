#pragma checksum "C:\Users\Squadra\source\repos\BibliotecaNet\BibliotecaNet.Apresentation\Views\Pessoa\_ContatoUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d88a47bcc6c167d15df83d528ffb276698dff09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoa__ContatoUsuario), @"mvc.1.0.view", @"/Views/Pessoa/_ContatoUsuario.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d88a47bcc6c167d15df83d528ffb276698dff09", @"/Views/Pessoa/_ContatoUsuario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a86db10214cc7c014479538e343824e7d6066f", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoa__ContatoUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal fade"" id=""modalContato"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""staticBackdropLabel"">Adicionar Contato</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""modal-content"">
                <div class=""row"">
                    <div class=""col-md-5"">
                        <label>Tipo Endereço</label>
                        <select class=""form-control"" id=""TipoContato"" name=""TipoContato"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d88a47bcc6c167d15df83d528ffb276698dff094123", async() => {
                WriteLiteral("Selecione");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\Squadra\source\repos\BibliotecaNet\BibliotecaNet.Apresentation\Views\Pessoa\_ContatoUsuario.cshtml"
                              

                                foreach (var tipoContato in (ViewData["TipoContato"] as IEnumerable<BibliotecaNet.Domain.ValueObject.PessoaContatoTipo.PessoaContatoTipoVO>))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d88a47bcc6c167d15df83d528ffb276698dff095584", async() => {
#nullable restore
#line 20 "C:\Users\Squadra\source\repos\BibliotecaNet\BibliotecaNet.Apresentation\Views\Pessoa\_ContatoUsuario.cshtml"
                                                                                                   Write(tipoContato.Descricao);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\Squadra\source\repos\BibliotecaNet\BibliotecaNet.Apresentation\Views\Pessoa\_ContatoUsuario.cshtml"
                                       WriteLiteral(tipoContato.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\Squadra\source\repos\BibliotecaNet\BibliotecaNet.Apresentation\Views\Pessoa\_ContatoUsuario.cshtml"
                                                                             Write(tipoContato.Mascara);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-mascara", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\Squadra\source\repos\BibliotecaNet\BibliotecaNet.Apresentation\Views\Pessoa\_ContatoUsuario.cshtml"
                                }

                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                    <div class=""col-md-7"">
                        <label>Contato</label>
                        <input type=""text"" class=""form-control"" id=""DescricaoContato"" name=""DescricaoContato"" disabled />
                    </div>
                </div>
            </div>

            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-success "" onclick=""adicionarContato()"">Adicionar</button>
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
            </div>

        </div>
    </div>
</div>

<div class=""row"">
    <div class=""offset-10 col-md-2 "">
        <button type=""button"" class=""btn btn-success "" onclick=""$('#modalContato').modal('show');"">Adicionar Contato</button>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-12"">
        <table class=""table table-striped table-bordered"">
            <thead>
                <tr>
      ");
            WriteLiteral("              <th>Tipo Contato</th>\r\n                    <th>Contato</th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody id=\"tbContatos\"></tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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