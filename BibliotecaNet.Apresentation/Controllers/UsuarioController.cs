using BibliotecaNet.Apresentation.ViewModels.Usuario;
using BibliotecaNet.Domain.Command.Usuario;
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

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastro(UsuarioVM model)
        {
            var retorno = await _mediator.Send(new UsuarioCadastrarCommand(model.Email, model.Password, model.UserName));

            return Ok(retorno);
        }
    }
}
