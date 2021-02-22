using BibliotecaNet.Domain.Command.AcervoAutor;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class AcervoAutorRemoverHandler : IRequestHandler<AcervoAutorRemoverCommand, string>
    {
        private readonly IApplicationDbContext _context;

        public AcervoAutorRemoverHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(AcervoAutorRemoverCommand request, CancellationToken cancellationToken)
        {
            var acervoAutor = await _context.AcervoAutors.Where(x => x.AcervoAutorId == request.Id).FirstOrDefaultAsync();

            _context.AcervoAutors.Remove(acervoAutor);
            await _context.SaveChangesAsync();
            return "Autor removido com sucesso.";
        }
    }
}
