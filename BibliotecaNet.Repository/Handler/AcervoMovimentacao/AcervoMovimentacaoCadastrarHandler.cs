using BibliotecaNet.Domain.Command.AcervoMovimentacao;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
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
            _dbContext.AcervoMovimentacaos.Add(request.Command());
            await _dbContext.SaveChangesAsync();

            return "Emprestimo efetuado com sucesso.";
        }
    }
}
