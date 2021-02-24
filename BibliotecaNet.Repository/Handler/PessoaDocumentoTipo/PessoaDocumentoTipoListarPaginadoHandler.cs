using BibliotecaNet.Common;
using BibliotecaNet.Domain.Query.PessoaDocumentoTipo;
using BibliotecaNet.Domain.ValueObject.PessoaDocumentoTipo;
using BibliotecaNet.Repository.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaNet.Repository.Handler.PessoaDocumentoTipo
{
    class PessoaDocumentoTipoListarPaginadoHandler:IRequestHandler<PessoaDocumentoTipoListarPaginadoQuery, PaginatedList<PessoaDocumentoTipoVO>>
    {
        private readonly IApplicationDbContext _context;

        public PessoaDocumentoTipoListarPaginadoHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<PessoaDocumentoTipoVO>> Handle(PessoaDocumentoTipoListarPaginadoQuery request, CancellationToken cancellationToken)
        {
         var querable= _context.PessoaDocumentoTipos.Where(x => x.Ativo == true).Select(x => new PessoaDocumentoTipoVO
            {
                Id = x.PessoaDocumentoTipoId,
                Descricao = x.Descricao,
                Obrigatorio = x.Obrigatorio,
                Mascara = x.Mascara
            });

            return await PaginatedList<PessoaDocumentoTipoVO>.CreateAsync(querable, request.OffSet, request.Limit);
        }
    }
}
