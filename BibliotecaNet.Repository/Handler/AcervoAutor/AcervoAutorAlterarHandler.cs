using BibliotecaNet.Domain.Command.AcervoAutor;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class AcervoAutorAlterarHandler : IRequestHandler<AcervoAutorAlterarCommand, string>
    {
        private readonly IApplicationDbContext _context;

        public AcervoAutorAlterarHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(AcervoAutorAlterarCommand request, CancellationToken cancellationToken)
        {
            var acervoAutor = await _context.AcervoAutors.Where(x => x.AcervoAutorId == request.Id).FirstOrDefaultAsync();
            var pessoa = await _context.Pessoas.Where(x => x.PessoaId == acervoAutor.Pessoa.PessoaId).FirstOrDefaultAsync();

            pessoa.Nome = request.Nome;

            await _context.SaveChangesAsync();

            return "Autor Alterado com sucesso.";
        }
    }
}
