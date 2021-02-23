using BibliotecaNet.Apresentation.ViewModels.Acervo;
using BibliotecaNet.Domain.Command;
using BibliotecaNet.Domain.Query.AcervoAutor;
using BibliotecaNet.Domain.Query.AcervoCategoria;
using BibliotecaNet.Domain.Query.AcervoEditora;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BibliotecaNet.Apresentation.Controllers
{
    public class AcervoController : Controller
    {
        private readonly IMediator _mediador;

        public AcervoController(IMediator mediador)
        {
            _mediador = mediador;
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
        public async Task<IActionResult> Cadastro(AcervoVM model)
        {
            var result = await _mediador.Send(new AcervoCadastroCommand(model.Id, model.Titulo, model.Edicao, model.Ano, model.AutorId, model.EditoraId, model.CategoriaId));

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> BuscarAutorSelect(string term)
        {
            var result = await _mediador.Send(new AcervoAutorListarPorSelectQuery(term ?? ""));

            return Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> BuscarEditoraSelect(string term)
        {
            var result = await _mediador.Send(new AcervoEditoraListarPorNomeSelectQuery(term ?? ""));

            return Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> BuscarCategoriaSelect(string term)
        {
            var result = await _mediador.Send(new AcervoCategoriaObterAtivosQuery(term ?? ""));

            return Json(result);
        }
    }
}
