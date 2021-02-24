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
    public class UsuarioObterPorIdHandler : IRequestHandler<UsuarioObterPorIdQuery, UsuarioVO>
    {
        private readonly IApplicationDbContext _context;

        public UsuarioObterPorIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<UsuarioVO> Handle(UsuarioObterPorIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Usuarios
                .Include(x => x.Pessoa)
                .Where(x => x.Id == request.Id)
                .Select(x => new UsuarioVO { Id = x.Id, Nome = x.Pessoa.Nome, Email = x.Email })
                .FirstOrDefaultAsync();
        }
    }
}
