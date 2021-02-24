using BibliotecaNet.Common;
using BibliotecaNet.Domain.ValueObject.PessoaContatoTipo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Query.PessoaContatoTipo
{
    public class PessoaContatoTipoListarPaginadoQuery: IRequest<PaginatedList<PessoaContatoTipoVO>>
    {
        public PessoaContatoTipoListarPaginadoQuery(int offSet, int limit)
        {
            OffSet = offSet;
            Limit = limit;
        }

        public int OffSet { get; private set; }
        public int Limit { get; private set; }
    }
}
