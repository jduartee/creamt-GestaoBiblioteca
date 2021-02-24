using BibliotecaNet.Apresentation.ViewModels.Usuario;
using BibliotecaNet.Domain.Command.Usuario;
using BibliotecaNet.Domain.Query.Usuario;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BibliotecaNet.Apresentation.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly IMediator _mediator;

        public UsuarioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Cadastro(int? id)
        {
            UsuarioVM model = new UsuarioVM();


            if (id.GetValueOrDefault() > 0)
            {
                var usuario = await _mediator.Send(new UsuarioObterPorIdQuery(id.GetValueOrDefault()));

                model.Email = usuario.Email;
                model.UserName = usuario.Nome;
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Cadastro(UsuarioVM model)
        {
            var retorno = await _mediator.Send(new UsuarioCadastrarCommand(model.Email, model.Password, model.UserName));

            return Ok(retorno);
        }

        public async Task<IActionResult> ListarUsuario(string search, string sort, string order, int offset, int limit = 10)
        {
            var result = await _mediator.Send(new UsuarioListarPaginadoQuery(offset, limit));

            return Ok(new
            {
                result.Total,
                result.TotalNotFiltered,
                rows = result
            });
        }
    }
}
