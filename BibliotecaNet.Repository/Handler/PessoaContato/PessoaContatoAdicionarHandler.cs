using BibliotecaNet.Domain.Command.PessoaContato;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler.PessoaContato
{
    public class PessoaContatoAdicionarHandler : IRequestHandler<PessoaContatoAdicionarCommand, string>
    {

        public readonly IApplicationDbContext _context;

        public PessoaContatoAdicionarHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(PessoaContatoAdicionarCommand request, CancellationToken cancellationToken)
        {
            var pessoaContato = request.Command();
            _context.PessoaContatos.Add(pessoaContato);

            await _context.SaveChangesAsync();

            return "Contato adicionado com sucesso!";
        }
    }
}
