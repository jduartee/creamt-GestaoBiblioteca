using BibliotecaNet.Domain.Command;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler 
{
    public class AcervoCategoriaAlterarStatusHandler : IRequestHandler<AcervoCategoriaAlterarStatusCommand, string>
    {
        public readonly IApplicationDbContext _context;

        public AcervoCategoriaAlterarStatusHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<string> Handle(AcervoCategoriaAlterarStatusCommand request, CancellationToken cancellationToken)
        {
            var acervoCategoria = _context.AcervoCategorias.Where(x => x.AcervoCategoriaId == request.Id).FirstOrDefault();
            acervoCategoria.Ativo = request.Ativo;

            await _context.SaveChangesAsync();

            return $"Categoria {(request.Ativo ? "ativada" : "inativada")} com sucesso!";
        }
    }
}
