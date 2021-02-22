using BibliotecaNet.Domain.Query.PessoaContato;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class PessoaContatoListarPorPessoaCommand : IRequestHandler<PessoaContatoListarPorPessoaQuery, object>
    {
        private readonly IApplicationDbContext _context;

        public PessoaContatoListarPorPessoaCommand(IApplicationDbContext context)
        {
            _context = context;
        }

        public Task<object> Handle(PessoaContatoListarPorPessoaQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
