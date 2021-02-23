using BibliotecaNet.Domain.Query.AcervoCategoria;
using BibliotecaNet.Domain.ValueObject;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class AcervoCategoriaObterAtivosHandler : IRequestHandler<AcervoCategoriaObterAtivosQuery, RequestSelectVO>
    {
        public readonly IApplicationDbContext _context;

        public AcervoCategoriaObterAtivosHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<RequestSelectVO> Handle(AcervoCategoriaObterAtivosQuery request, CancellationToken cancellationToken)
        {
            var result = await _context.AcervoCategorias
                .Where(x => x.Ativo == true && x.Descricao.Contains(request.Descricao))
                .Select(x => new SelectResult { id = x.AcervoCategoriaId.ToString(), text = x.Descricao })
                .ToListAsync();

            return new RequestSelectVO { results = result };
        }
    }
}
