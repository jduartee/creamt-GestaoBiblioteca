using BibliotecaNet.Domain.Command.PessoaContato;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class PessoaContatoRemoverHandler : IRequestHandler<PessoaContatoRemoverCommand, string>
    {

        public readonly IApplicationDbContext _context;

        public PessoaContatoRemoverHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(PessoaContatoRemoverCommand request, CancellationToken cancellationToken)
        {
            var pessoaContato = await _context.PessoaContatos.Where(x => x.PessoaContatoId == request.Id).FirstOrDefaultAsync();
            _context.PessoaContatos.Remove(pessoaContato);

            await _context.SaveChangesAsync();

            return "Contato removido com sucesso!";
        }
    }
}
