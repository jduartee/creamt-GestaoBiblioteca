using BibliotecaNet.Domain.Query.PessoaContatoTipo;
using BibliotecaNet.Domain.ValueObject.PessoaContatoTipo;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler.PessoaContatoTipo
{
    public class PessoaContatoTipoListarAtivoHandler : IRequestHandler<PessoaContatoTipoListarAtivoQuery, IList<PessoaContatoTipoVO>>
    {
        private readonly IApplicationDbContext _context;

        public PessoaContatoTipoListarAtivoHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<PessoaContatoTipoVO>> Handle(PessoaContatoTipoListarAtivoQuery request, CancellationToken cancellationToken)
        {
            var pessoaContatoTipoAtivo = await _context.PessoaContatoTipos.Where(x => x.Ativo == true).ToListAsync();

            return pessoaContatoTipoAtivo.Select(x => new PessoaContatoTipoVO { Id = x.PessoaContatoTipoId, Descricao = x.Descricao, Mascara = x.Mascara, Obrigatorio = x.Obrigatorio }).ToList();
        }
    }
}
