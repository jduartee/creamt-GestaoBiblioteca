﻿using AutoMapper;
using BibliotecaNet.Apresentation.ViewModels.PessoaDocumento;
using BibliotecaNet.Domain.Command.PessoaDocumentoTipo;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaNet.Apresentation.Controllers
{
    public class PessoaDocumentoController : Controller
    {
        private IMediator _mediator;
        private IMapper _mapper;

        public PessoaDocumentoController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro(int? id)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastro(PessoaDocumentoVM model)
        {
            var command = await _mediator.Send(new PessoaDocumentoTipoAdicionarCommand(model.Descricao, model.Mascara, model.Obrigatorio, true, _mapper));

            return View();
        }
    }
}
