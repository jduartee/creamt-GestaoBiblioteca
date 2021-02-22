using BibliotecaNet.Domain.Command.PessoaContatoTipo;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class PessoaContatoTipoAdicionarHandler : IRequestHandler<PessoaContatoTipoAdicionarCommand, string>
    {
        private readonly IApplicationDbContext _context;

        public PessoaContatoTipoAdicionarHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(PessoaContatoTipoAdicionarCommand request, CancellationToken cancellationToken)
        {
            _context.PessoaContatoTipos.Add(request.Command());
            await _context.SaveChangesAsync();

            return "Tipo de contato salvo com sucesso.";
        }
    }
}
