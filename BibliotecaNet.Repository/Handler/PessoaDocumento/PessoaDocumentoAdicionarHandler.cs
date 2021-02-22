using BibliotecaNet.Domain.Command.PessoaDocumento;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class PessoaDocumentoAdicionarHandler : IRequestHandler<PessoaDocumentoAdicionarCommand, string>
    {

        public readonly IApplicationDbContext _context;

        public PessoaDocumentoAdicionarHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(PessoaDocumentoAdicionarCommand request, CancellationToken cancellationToken)
        {
            var pessoaDocumento = request.Command();
            _context.PessoaDocumentos.Add(pessoaDocumento);

            await _context.SaveChangesAsync();

            return "Documento adicionado com sucesso!";
        }
    }
}
