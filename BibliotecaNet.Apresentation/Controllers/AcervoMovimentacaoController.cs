using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaNet.Apresentation.Controllers
{
    public class AcervoMovimentacaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
