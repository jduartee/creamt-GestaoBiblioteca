using BibliotecaNet.Domain.Command.AcervoAutor;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class AcervoAutorAdicionarHandler : IRequestHandler<AcervoAutorAdicionarCommand, string>
    {
        private readonly IApplicationDbContext _context;

        public AcervoAutorAdicionarHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(AcervoAutorAdicionarCommand request, CancellationToken cancellationToken)
        {
            _context.AcervoAutors.Add(request.Command());
            await _context.SaveChangesAsync();

            return "Autor cadastrado com sucesso.";
        }
    }
}
