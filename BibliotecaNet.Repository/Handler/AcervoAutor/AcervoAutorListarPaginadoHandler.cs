using BibliotecaNet.Domain.Query.AcervoAutor;
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
    public class AcervoAutorListarPaginadoHandler : IRequestHandler<AcervoAutorListarPaginadoQuery, IList<AcervoAutorVO>>
    {
        private readonly IApplicationDbContext _context;

        public AcervoAutorListarPaginadoHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<AcervoAutorVO>> Handle(AcervoAutorListarPaginadoQuery request, CancellationToken cancellationToken)
        {            
            return await (from t0 in _context.AcervoAutors
                          join t1 in _context.Pessoas on t0.Pessoa.PessoaId equals t1.PessoaId
                          select new AcervoAutorVO
                          {
                              AutorId = t0.AcervoAutorId,
                              Nome = t1.Nome
                          }).ToListAsync();
            
        }
    }
}
