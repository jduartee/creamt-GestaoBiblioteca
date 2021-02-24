using BibliotecaNet.Domain.Command.AcervoAutor;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var autor = request.Command();

            autor.Pessoa.PessoaTipo = await _context.PessoaTipo.Where(x => x.PessoaTipoId == Common.PessoaTipoEnum.Outros).FirstOrDefaultAsync();

            _context.AcervoAutors.Add(autor);
            await _context.SaveChangesAsync();

            return "Autor cadastrado com sucesso.";
        }
    }
}
