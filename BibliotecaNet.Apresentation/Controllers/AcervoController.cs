using BibliotecaNet.Domain.Query.AcervoAutor;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
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

        [HttpGet]
        public async Task<IActionResult> BuscarAutorSelect(string term)
        {
            var result = await _mediador.Send(new AcervoAutorListarPorSelectQuery(term));

            return Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> BuscarEditoraSelect(string term)
        {
            var result = await _mediador.Send(new AcervoAutorListarPorSelectQuery(term));

            return Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> BuscarCategoriaSelect(string term)
        {
            var result = await _mediador.Send(new AcervoAutorListarPorSelectQuery(term));

            return Json(result);
        }
    }
}
