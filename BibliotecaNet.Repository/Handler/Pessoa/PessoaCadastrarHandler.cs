using BibliotecaNet.Domain.Command.Pessoa;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler.Pessoa
{
    public class PessoaCadastrarHandler : IRequestHandler<PessoaCadastrarCommand, int>
    {
        public readonly IApplicationDbContext _context;

        public PessoaCadastrarHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(PessoaCadastrarCommand request, CancellationToken cancellationToken)
        {
            var pessoa = request.Command();

            _context.Pessoas.Add(pessoa);
            await _context.SaveChangesAsync();

            return pessoa.PessoaId;
        }
    }
}
