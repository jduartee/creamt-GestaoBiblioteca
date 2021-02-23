using BibliotecaNet.Common;
using BibliotecaNet.Domain.Query.AcervoAutor;
using BibliotecaNet.Domain.ValueObject.AcervoAutor;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class AcervoAutorListarPaginadoHandler : IRequestHandler<AcervoAutorListarPaginadoQuery, PaginatedList<AcervoAutorVO>>
    {
        private readonly IApplicationDbContext _context;

        public AcervoAutorListarPaginadoHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<AcervoAutorVO>> Handle(AcervoAutorListarPaginadoQuery request, CancellationToken cancellationToken)
        {
            var query = (from t0 in _context.AcervoAutors
                         join t1 in _context.Pessoas on t0.Pessoa.PessoaId equals t1.PessoaId
                         where t1.Nome.Contains(request.Nome)
                         select new AcervoAutorVO { AutorId = t0.AcervoAutorId, Nome = t1.Nome });

            return await PaginatedList<AcervoAutorVO>.CreateAsync(query, request.OffSet, request.Limit);
        }
    }
}
