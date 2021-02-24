using BibliotecaNet.Domain.Query.Pessoa;
using BibliotecaNet.Domain.ValueObject;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class PessoaListarPorNomeHandler : IRequestHandler<PessoaListarPorNomeQuery, RequestSelectVO>
    {
        private readonly IApplicationDbContext _context;

        public PessoaListarPorNomeHandler(IApplicationDbContext mediator)
        {
            _context = mediator;
        }

        public async Task<RequestSelectVO> Handle(PessoaListarPorNomeQuery request, CancellationToken cancellationToken)
        {
            var pessoas = await _context.Pessoas.Where(x => x.Nome.Contains(request.Nome))
                .Select(x => new SelectResult
                { id = x.PessoaId.ToString(), text = x.Nome }).ToListAsync();

            return new RequestSelectVO { results = pessoas };
        }
    }
}
