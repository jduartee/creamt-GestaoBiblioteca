using BibliotecaNet.Domain.Command;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class AcervoAdicionarHandler : IRequestHandler<AcervoCadastroCommand, string>
    {
        private readonly IApplicationDbContext _context;

        public AcervoAdicionarHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(AcervoCadastroCommand request, CancellationToken cancellationToken)
        {
            _context.Acervos.Add(request.Command());
            await _context.SaveChangesAsync();

            return "Acervo cadastrado com sucesso.";
        }
    }
}
