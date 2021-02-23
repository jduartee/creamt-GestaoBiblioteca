using AutoMapper;
using BibliotecaNet.Apresentation.ViewModels;
using BibliotecaNet.Domain.Command.Pessoa;
using BibliotecaNet.Domain.Query.PessoaContatoTipo;
using BibliotecaNet.Domain.Query.PessoaDocumentoTipo;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaNet.Apresentation.Controllers
{
    public class PessoaController : Controller
    {
        private readonly IMapper _mapper;
        private IMediator _mediator;

        public PessoaController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Cadastro()
        {
            ViewData["TipoContato"] = await _mediator.Send(new PessoaContatoTipoListarAtivoQuery());
            ViewData["TipoDocumento"] = await _mediator.Send(new PessoaDocumentoTipoListarAtivoQuery());

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastro(PessoaCadastroVM model)
        {
            var pessoaCadastro = new PessoaCadastrarCommand(model.Nome, model.TipoPessoaId, _mapper);

            model.PessoaContato?.ToList()?.ForEach(contato => { pessoaCadastro.AdicionarContato(contato.TipoContato, contato.DescricaoContato); });
            model.PessoaDocumento?.ToList()?.ForEach(doc => { pessoaCadastro.AdicionarDocumento(doc.TipoDocumento, doc.DescricaoDocumento); });
            model.PessoaEndereco?.ToList()?.ForEach(e => { pessoaCadastro.AdicionarEndereco(e.Cep, e.Cidade, e.Estado, e.Bairro, e.Logradouro, e.Numero, e.Complemento, e.EnderecoPrincipal); });

            await _mediator.Send(pessoaCadastro);

            return View();
        }

    }
}
