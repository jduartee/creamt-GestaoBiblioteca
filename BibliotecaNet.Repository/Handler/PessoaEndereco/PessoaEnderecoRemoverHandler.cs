using BibliotecaNet.Domain.Command.PessoaEndereco;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class PessoaEnderecoRemoverHandler : IRequestHandler<PessoaEnderecoRemoverCommand, string>
    {
        public readonly IApplicationDbContext _context;

        public PessoaEnderecoRemoverHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(PessoaEnderecoRemoverCommand request, CancellationToken cancellationToken)
        {
            var pessoaEndereco = await _context.PessoaEnderecos.Where(x => x.PessoaEnderecoId == request.Id).FirstOrDefaultAsync();
            _context.PessoaEnderecos.Remove(pessoaEndereco);

            await _context.SaveChangesAsync();

            return "Endereço adicionado com sucesso!";
        }
    }
}
