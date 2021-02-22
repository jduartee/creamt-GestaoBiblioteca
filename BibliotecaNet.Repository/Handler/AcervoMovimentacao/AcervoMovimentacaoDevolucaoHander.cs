using BibliotecaNet.Domain.Command.AcervoMovimentacao;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class AcervoMovimentacaoDevolucaoHander : IRequestHandler<AcervoMovimentacaoDevolucaoCommand, string>
    {
        private readonly IApplicationDbContext _context;

        public AcervoMovimentacaoDevolucaoHander(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(AcervoMovimentacaoDevolucaoCommand request, CancellationToken cancellationToken)
        {
            var acervoMovimentacao = await _context.AcervoMovimentacaos.Where(x => x.AcervoMovimentacaoId == request.Id).FirstOrDefaultAsync();
            acervoMovimentacao.DataDevolucao = request.DataDevolucao;

            await _context.SaveChangesAsync();

            return "Devolução informada com sucesso.";
        }
    }
}
