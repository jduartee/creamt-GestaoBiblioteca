using BibliotecaNet.Domain.Command.Usuario;
using BibliotecaNet.Domain.Entity;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class UsuarioCadastrarHandler : IRequestHandler<UsuarioCadastrarCommand, string>
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly IApplicationDbContext _context;

        public UsuarioCadastrarHandler(UserManager<Usuario> userManager, IApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }


        public async Task<string> Handle(UsuarioCadastrarCommand request, CancellationToken cancellationToken)
        {
            var user = request.Command();

            var result = await _userManager.CreateAsync(user, request.Password);

            if (!result.Succeeded)
                return string.Join("\n", result.Errors);

            return "Cadastro realizado com cucesso";
        }
    }
}
