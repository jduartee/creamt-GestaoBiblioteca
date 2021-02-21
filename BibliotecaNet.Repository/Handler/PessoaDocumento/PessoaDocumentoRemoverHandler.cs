using BibliotecaNet.Domain.Command.PessoaDocumento;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler.PessoaDocumento
{
    public class PessoaDocumentoRemoverHandler : IRequestHandler<PessoaDocumentoRemoverCommand, string>
    {

        public readonly IApplicationDbContext _context;

        public PessoaDocumentoRemoverHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(PessoaDocumentoRemoverCommand request, CancellationToken cancellationToken)
        {
            var pessoaDocumento = await _context.PessoaDocumentos.Where(x => x.PessoaDocumentoId == request.Id).FirstOrDefaultAsync();
            _context.PessoaDocumentos.Remove(pessoaDocumento);

            await _context.SaveChangesAsync();

            return "Documento removido com sucesso!";
        }
    }
}
