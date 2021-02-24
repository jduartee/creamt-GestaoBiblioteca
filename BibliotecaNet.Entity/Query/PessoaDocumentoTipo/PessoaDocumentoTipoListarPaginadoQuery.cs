using BibliotecaNet.Common;
using BibliotecaNet.Domain.ValueObject.PessoaDocumentoTipo;
using MediatR;
using System.Collections.Generic;

namespace BibliotecaNet.Domain.Query.PessoaDocumentoTipo
{
    public class PessoaDocumentoTipoListarPaginadoQuery : IRequest<PaginatedList<PessoaDocumentoTipoVO>>
    {
        public PessoaDocumentoTipoListarPaginadoQuery(int offSet, int limit)
        {
            OffSet = offSet;
            Limit = limit;
        }

        public int OffSet { get; private set; }
        public int Limit { get; private set; }
    }
}
