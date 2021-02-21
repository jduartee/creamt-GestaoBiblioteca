using AutoMapper;
using BibliotecaNet.Domain.Command.Pessoa;
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

        public PessoaController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var request = new PessoaCadastrarCommand("teste", 1, _mapper);

            var a = request.Command();
            return View();
        }
    }
}
