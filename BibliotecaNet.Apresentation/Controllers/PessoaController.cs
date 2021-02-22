using AutoMapper;
using BibliotecaNet.Apresentation.ViewModels;
using BibliotecaNet.Domain.Command.Pessoa;
using BibliotecaNet.Domain.Query.PessoaContatoTipo;
using BibliotecaNet.Domain.Query.PessoaDocumentoTipo;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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

            await _mediator.Send(pessoaCadastro);

            return Json("ok");
        }

    }
}
