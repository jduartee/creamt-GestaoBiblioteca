using BibliotecaNet.Domain.Command.AcervoMovimentacao;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class AcervoMovimentacaoCadastrarHandler : IRequestHandler<AcervoMovimentacaoCadastrarCommand, string>
    {
        private readonly IApplicationDbContext _dbContext;

        public AcervoMovimentacaoCadastrarHandler(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> Handle(AcervoMovimentacaoCadastrarCommand request, CancellationToken cancellationToken)
        {
            var acervoMovimentacao = request.Command();
            acervoMovimentacao.Acervo = await _dbContext.Acervos.Where(x => x.AcervoId == request.AcervoID).FirstOrDefaultAsync();
            acervoMovimentacao.Pessoa = await _dbContext.Pessoas.Where(x => x.PessoaId == request.PessoaId).FirstOrDefaultAsync();
            acervoMovimentacao.Usuario = await _dbContext.Usuarios.Where(x => x.Id == request.UsuarioId).FirstOrDefaultAsync();

            _dbContext.AcervoMovimentacaos.Add(acervoMovimentacao);

            await _dbContext.SaveChangesAsync();

            return "Emprestimo efetuado com sucesso.";
        }
    }
}
