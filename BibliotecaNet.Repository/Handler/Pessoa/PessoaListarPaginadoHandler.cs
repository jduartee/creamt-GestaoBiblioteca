using BibliotecaNet.Common;
using BibliotecaNet.Domain.Query.Pessoa;
using BibliotecaNet.Domain.ValueObject.Pessoa;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class PessoaListarPaginadoHandler : IRequestHandler<PessoaListarPaginadoQuery, PaginatedList<PessoaVO>>
    {
        private readonly IApplicationDbContext _context;

        public PessoaListarPaginadoHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<PessoaVO>> Handle(PessoaListarPaginadoQuery request, CancellationToken cancellationToken)
        {
            var query = _context.Pessoas.Where(x => x.Nome.Contains(request.Nome)).Select(x => new PessoaVO { Id = x.PessoaId, Nome = x.Nome });

            return await PaginatedList<PessoaVO>.CreateAsync(query, request.OffSet, request.Limit);
        }
    }
}
