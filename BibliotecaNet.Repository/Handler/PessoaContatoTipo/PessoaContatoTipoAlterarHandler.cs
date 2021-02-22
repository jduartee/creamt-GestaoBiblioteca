using BibliotecaNet.Domain.Command.PessoaContatoTipo;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class PessoaContatoTipoAlterarHandler : IRequestHandler<PessoaContatoTipoAlterarCommand, string>
    {
        private readonly IApplicationDbContext _context;

        public PessoaContatoTipoAlterarHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(PessoaContatoTipoAlterarCommand request, CancellationToken cancellationToken)
        {
            var pessoaContatoTipo = await _context.PessoaContatoTipos.Where(x => x.PessoaContatoTipoId == request.Id).FirstOrDefaultAsync();

            if (pessoaContatoTipo == null)
            {
                return "Tipo de contato não encontrado.";
            }

            pessoaContatoTipo.Descricao = request.Descricao;
            pessoaContatoTipo.Mascara = request.Mascara;

            await _context.SaveChangesAsync();

            return "Tipo de contato alterado com sucesso.";
        }
    }
}
