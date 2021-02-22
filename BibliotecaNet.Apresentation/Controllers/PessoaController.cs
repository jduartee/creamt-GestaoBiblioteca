using AutoMapper;
using BibliotecaNet.Domain.Command.Pessoa;
using BibliotecaNet.Domain.Query.PessoaContatoTipo;
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

        public IActionResult Cadastro()
        {
            var tipoContato = _mediator.Send(new PessoaContatoTipoListarAtivoQuery());



            return View();
        }

    }
}
