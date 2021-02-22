using BibliotecaNet.Domain.Command.PessoaContatoTipo;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class PessoaContatoTipoRemoverHandler : IRequestHandler<PessoaContatoTipoRemoverCommand, string>
    {
        private readonly IApplicationDbContext _context;

        public PessoaContatoTipoRemoverHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(PessoaContatoTipoRemoverCommand request, CancellationToken cancellationToken)
        {
            var pessoaContatoTipo = await _context.PessoaContatoTipos.Where(x => x.PessoaContatoTipoId == request.Id).FirstOrDefaultAsync();

            _context.PessoaContatoTipos.Remove(pessoaContatoTipo);
            await _context.SaveChangesAsync();

            return "Tipo de contato removido com sucesso.";
        }
    }
}
