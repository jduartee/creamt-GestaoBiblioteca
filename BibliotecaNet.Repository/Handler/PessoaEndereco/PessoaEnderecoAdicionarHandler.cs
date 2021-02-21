using BibliotecaNet.Domain.Command.PessoaEndereco;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler.PessoaEndereco
{
    public class PessoaEnderecoAdicionarHandler : IRequestHandler<PessoaEnderecoAdicionarCommand, string>
    {

        public readonly IApplicationDbContext _context;

        public PessoaEnderecoAdicionarHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(PessoaEnderecoAdicionarCommand request, CancellationToken cancellationToken)
        {
            var pessoaEndereco = request.Command();
            _context.PessoaEnderecos.Add(pessoaEndereco);

            await _context.SaveChangesAsync();

            return "Endereço adicionado com sucesso!";
        }
    }
}
