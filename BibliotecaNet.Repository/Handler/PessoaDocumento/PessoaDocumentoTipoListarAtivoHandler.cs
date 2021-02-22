using BibliotecaNet.Domain.Query.PessoaDocumentoTipo;
using BibliotecaNet.Domain.ValueObject.PessoaDocumentoTipo;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class PessoaDocumentoTipoListarAtivoHandler : IRequestHandler<PessoaDocumentoTipoListarAtivoQuery, IList<PessoaDocumentoTipoVO>>
    {
        private readonly IApplicationDbContext _context;

        public PessoaDocumentoTipoListarAtivoHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<PessoaDocumentoTipoVO>> Handle(PessoaDocumentoTipoListarAtivoQuery request, CancellationToken cancellationToken)
           => await _context.PessoaDocumentoTipos.Where(x => x.Ativo == true).Select(x => new PessoaDocumentoTipoVO
           {
               Id = x.PessoaDocumentoTipoId,
               Descricao = x.Descricao,
               Obrigatorio = x.Obrigatorio,
               Mascara = x.Mascara
           }).ToListAsync();
    }
}
