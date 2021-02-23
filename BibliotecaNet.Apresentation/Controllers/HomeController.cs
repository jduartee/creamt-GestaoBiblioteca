using BibliotecaNet.Apresentation.Models;
using BibliotecaNet.Domain.Query.AcervoAutor;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.Threading.Tasks;

namespace BibliotecaNet.Apresentation.Controllers
{
    public class HomeController : Controller
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();


        public async Task<IActionResult> Index()
        {
        var D=   await Mediator.Send(new AcervoAutorListarPaginadoQuery("ju", 1, 10));

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
