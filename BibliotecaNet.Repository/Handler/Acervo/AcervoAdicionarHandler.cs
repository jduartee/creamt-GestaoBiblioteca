using BibliotecaNet.Domain.Command;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaNet.Repository.Handler
{
    public class AcervoAdicionarHandler : IRequestHandler<AcervoCadastroCommand, string>
    {
        private readonly IApplicationDbContext _context;

        public AcervoAdicionarHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(AcervoCadastroCommand request, CancellationToken cancellationToken)
        {
            var acervo = request.Command();

            acervo.AcervoSituacao = await _context.AcervoSituacaos.Where(x => x.AcervoSituacaoId == Common.AcervoSituacaoEnum.Disponivel).FirstOrDefaultAsync();
            acervo.AcervoAutor = await _context.AcervoAutors.Where(x => x.AcervoAutorId == request.AutorId).FirstOrDefaultAsync();
            acervo.AcervoEditora = await _context.AcervoEditoras.Where(x => x.AcervoEditoraId == request.EditoraId).FirstOrDefaultAsync();
            acervo.AcervoCategoria = await _context.AcervoCategorias.Where(x => x.AcervoCategoriaId == request.CategoriaId).FirstOrDefaultAsync();

            _context.Acervos.Add(acervo);
            await _context.SaveChangesAsync();

            return "Acervo cadastrado com sucesso.";
        }
    }
}
