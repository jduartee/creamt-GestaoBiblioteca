using BibliotecaNet.Domain.Command;
using BibliotecaNet.Domain.ValueObject.AcervoCategoria;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler.AcervoCategoria
{
    public class AcervoCategoriaListarHandler : IRequestHandler<AcervoCategoriaListarAtivoCommand, IList<AcervoCategoriaVO>>
    {
        public readonly IApplicationDbContext _context;

        public AcervoCategoriaListarHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<AcervoCategoriaVO>> Handle(AcervoCategoriaListarAtivoCommand request, CancellationToken cancellationToken)
        {
            return await _context.AcervoCategorias.Where(x => x.Ativo == true).Select(x => new AcervoCategoriaVO { Id = x.AcervoCategoriaId, Descricao = x.Descricao }).ToListAsync();
        }
    }
}
