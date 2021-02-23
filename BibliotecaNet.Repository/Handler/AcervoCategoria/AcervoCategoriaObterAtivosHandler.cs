using BibliotecaNet.Domain.Command;
using BibliotecaNet.Domain.Query.AcervoCategoria;
using BibliotecaNet.Domain.ValueObject.AcervoCategoria;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class AcervoCategoriaObterAtivosHandler : IRequestHandler<AcervoCategoriaObterAtivosQuery, IList<AcervoCategoriaVO>>
    {
        public readonly IApplicationDbContext _context;

        public AcervoCategoriaObterAtivosHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<AcervoCategoriaVO>> Handle(AcervoCategoriaObterAtivosQuery request, CancellationToken cancellationToken)
        {
            return await _context.AcervoCategorias
                .Where(x => x.Ativo == true).Select(x => new AcervoCategoriaVO { Id = x.AcervoCategoriaId, Descricao = x.Descricao })
                .ToListAsync();
        }
    }
}
