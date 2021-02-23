using BibliotecaNet.Common;
using BibliotecaNet.Domain.Query.AcervoAutor;
using BibliotecaNet.Domain.ValueObject;
using BibliotecaNet.Domain.ValueObject.AcervoAutor;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class AcervoAutorListarPorSelectHandler : IRequestHandler<AcervoAutorListarPorSelectQuery, RequestSelectVO>
    {
        private readonly IApplicationDbContext _context;

        public AcervoAutorListarPorSelectHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<RequestSelectVO> Handle(AcervoAutorListarPorSelectQuery request, CancellationToken cancellationToken)
        {
            var query = await (from t0 in _context.AcervoAutors
                               join t1 in _context.Pessoas on t0.Pessoa.PessoaId equals t1.PessoaId
                               where t1.Nome.Contains(request.Nome)
                               select new SelectResult { id = t0.AcervoAutorId.ToString(), text = t1.Nome }).ToListAsync();

            return new RequestSelectVO { results = query };
        }
    }
}
