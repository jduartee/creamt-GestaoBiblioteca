using BibliotecaNet.Common;
using BibliotecaNet.Domain.Query.Usuario;
using BibliotecaNet.Domain.ValueObject.Usuario;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class UsuarioListarPaginadoHandler : IRequestHandler<UsuarioListarPaginadoQuery, PaginatedList<UsuarioVO>>
    {
        private readonly IApplicationDbContext _context;

        public UsuarioListarPaginadoHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<UsuarioVO>> Handle(UsuarioListarPaginadoQuery request, CancellationToken cancellationToken)
        {
            var query = _context.Usuarios.Include(x => x.Pessoa).Select(x => new UsuarioVO { Id = x.Id, Nome = x.Pessoa.Nome, Email = x.Email });

            return await PaginatedList<UsuarioVO>.CreateAsync(query, request.OffSet, request.Limit);
        }
    }
}
