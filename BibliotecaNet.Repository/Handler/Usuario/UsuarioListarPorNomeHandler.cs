using BibliotecaNet.Domain.Query.Usuario;
using BibliotecaNet.Domain.ValueObject;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class UsuarioListarPorNomeHandler : IRequestHandler<UsuarioListarPorNomeQuery, RequestSelectVO>
    {
        private readonly IApplicationDbContext _context;

        public UsuarioListarPorNomeHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<RequestSelectVO> Handle(UsuarioListarPorNomeQuery request, CancellationToken cancellationToken)
        {
            var source = await _context.Usuarios.Include(x => x.Pessoa).Where(x => x.Pessoa.Nome.Contains(request.Nome))
                .Select(x => new SelectResult { id = x.Id, text = x.Pessoa.Nome }).ToListAsync();

            return new RequestSelectVO { results = source };
        }
    }
}
