using BibliotecaNet.Domain.Command.PessoaDocumentoTipo;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class PessoaDocumentoTipoRemoverHandler : IRequestHandler<PessoaDocumentoTipoRemoverCommand, string>
    {
        private readonly IApplicationDbContext _context;

        public PessoaDocumentoTipoRemoverHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(PessoaDocumentoTipoRemoverCommand request, CancellationToken cancellationToken)
        {
            var pessoaDocumentoTipo = await _context.PessoaDocumentoTipos.Where(x => x.PessoaDocumentoTipoId == request.Id).FirstOrDefaultAsync();
            _context.PessoaDocumentoTipos.Remove(pessoaDocumentoTipo);
            await _context.SaveChangesAsync();

            return "Tipo de documento removido com sucesso";
        }
    }
}
