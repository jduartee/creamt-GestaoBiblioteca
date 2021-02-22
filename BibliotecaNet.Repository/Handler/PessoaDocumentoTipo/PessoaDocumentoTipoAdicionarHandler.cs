using BibliotecaNet.Domain.Command.PessoaDocumentoTipo;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler
{
    public class PessoaDocumentoTipoAdicionarHandler : IRequestHandler<PessoaDocumentoTipoAdicionarCommand, string>
    {
        private readonly IApplicationDbContext _context;

        public PessoaDocumentoTipoAdicionarHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(PessoaDocumentoTipoAdicionarCommand request, CancellationToken cancellationToken)
        {
            _context.PessoaDocumentoTipos.Add(request.Command());
            await _context.SaveChangesAsync();

            return "Tipo de documento Cadastrado com sucesso";
        }
    }
}
