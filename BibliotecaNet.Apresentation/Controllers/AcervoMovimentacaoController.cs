using BibliotecaNet.Apresentation.ViewModels.AcervoMovimentacao;
using BibliotecaNet.Domain.Command.AcervoMovimentacao;
using BibliotecaNet.Domain.Query.Acervo;
using BibliotecaNet.Domain.Query.AcervoMovimentacao;
using BibliotecaNet.Domain.Query.Pessoa;
using BibliotecaNet.Domain.Query.Usuario;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BibliotecaNet.Apresentation.Controllers
{
    public class AcervoMovimentacaoController : Controller
    {
        private readonly IMediator _mediator;

        public AcervoMovimentacaoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Cadastro(AcervoMovimentacaoVM model)
        {
            var retorno = await _mediator.Send(new AcervoMovimentacaoCadastrarCommand(model.AcervoId, model.PessoaId, model.UsuarioId));

            return Ok(retorno);
        }

        public async Task<IActionResult> ListarMovimentacoes(string search, string sort, string order, int offset, int limit = 10)
        {
            var result = await _mediator.Send(new AcervoMovimentacaoListarPaginadaQuery(offset, limit));

            return Ok(new
            {
                result.Total,
                result.TotalNotFiltered,
                rows = result
            });
        }

        [HttpGet]
        public async Task<IActionResult> ListarPessoas(string term)
        {

            var result = await _mediator.Send(new PessoaListarPorNomeQuery(term ?? ""));

            return Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> BuscarAcervoSelect(string term)
        {
            var result = await _mediator.Send(new AcervoListarDisponivelQuery(term ?? ""));

            return Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> BuscarFuncionarioSelect(string term)
        {
            var result = await _mediator.Send(new UsuarioListarPorNomeQuery(term ?? ""));

            return Json(result);
        }

    }
}
