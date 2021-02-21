using BibliotecaNet.Domain.Command.Pessoa;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler.PessoaEndereco
{
    public class PessoaAdicionarEnderecoHandler : IRequestHandler<PessoaAdicionarEnderecoCommand, string>
    {

        public readonly IApplicationDbContext _context;

        public PessoaAdicionarEnderecoHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(PessoaAdicionarEnderecoCommand request, CancellationToken cancellationToken)
        {
            var pessoaEndereco = request.Command();
            _context.PessoaEnderecos.Add(pessoaEndereco);

            await _context.SaveChangesAsync();

            return "Endereço adicionado com sucesso!";
        }
    }
}
