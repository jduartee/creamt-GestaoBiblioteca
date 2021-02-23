using BibliotecaNet.Domain.Query.AcervoEditora;
using BibliotecaNet.Domain.ValueObject;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaNet.Repository.Handler
{
    public class AcervoEditoraListarPorNomeSelectHandler : IRequestHandler<AcervoEditoraListarPorNomeSelectQuery, RequestSelectVO>
    {
        private readonly IApplicationDbContext _context;

        public AcervoEditoraListarPorNomeSelectHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<RequestSelectVO> Handle(AcervoEditoraListarPorNomeSelectQuery request, CancellationToken cancellationToken)
        {
            var result = await _context.AcervoEditoras
                .Where(x => x.Nome.Contains(request.Nome))
                .Select(x => new SelectResult { id = x.AcervoEditoraId.ToString(), text = x.Nome })
                .ToListAsync();

            return new RequestSelectVO { results = result };
        }
    }
}
