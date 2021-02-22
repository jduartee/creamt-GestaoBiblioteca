using AutoMapper;
using BibliotecaNet.Apresentation.ViewModels;
using BibliotecaNet.Domain.Command.AcervoAutor;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BibliotecaNet.Apresentation.Controllers
{
    public class AutorController : Controller
    {
        private readonly IMapper _mapper;
        private IMediator _mediator;

        public AutorController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            

            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(PessoaCadastroVM model)
        {
            var command = await _mediator.Send(new AcervoAutorAdicionarCommand(model.Nome));

            return View();
        }
    }
}
