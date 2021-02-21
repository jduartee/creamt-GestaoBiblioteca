using BibliotecaNet.Domain.Command.Categoria;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler.AcervoCategoria
{
    public class AcervoCategoriaCadastroHandler : IRequestHandler<AcervoCategoriaCadastroCommand, int>
    {
        public readonly IApplicationDbContext _context;

        public AcervoCategoriaCadastroHandler(IApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<int> Handle(AcervoCategoriaCadastroCommand request, CancellationToken cancellationToken)
        {
            var acervoCategoria = request.Command();

            _context.AcervoCategorias.Add(acervoCategoria);

            await _context.SaveChangesAsync();

            return acervoCategoria.AcervoCategoriaId;
        }
    }
}
