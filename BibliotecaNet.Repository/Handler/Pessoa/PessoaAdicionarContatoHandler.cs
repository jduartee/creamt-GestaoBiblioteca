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
    public class PessoaAdicionarContatoHandler : IRequestHandler<PessoaAdicionarContatoCommand, string>
    {

        public readonly IApplicationDbContext _context;

        public PessoaAdicionarContatoHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(PessoaAdicionarContatoCommand request, CancellationToken cancellationToken)
        {
            var pessoaContato = request.Command();
            _context.PessoaContatos.Add(pessoaContato);

            await _context.SaveChangesAsync();

            return "Contato adicionado com sucesso!";
        }
    }
}
