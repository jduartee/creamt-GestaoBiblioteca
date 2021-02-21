using BibliotecaNet.Domain.Command.Pessoa;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler.Pessoa
{
    public class PessoaAlterarHandler : IRequestHandler<PessoaAlterarCommand, string>
    {

        public readonly IApplicationDbContext _context;

        public PessoaAlterarHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(PessoaAlterarCommand request, CancellationToken cancellationToken)
        {
            var pessoa = _context.Pessoas.Where(x=> x.PessoaId == request.Id).FirstOrDefaultAsync();
            
            await _context.SaveChangesAsync();

            return "Contato adicionado com sucesso!";
        }
    }
}
