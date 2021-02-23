using BibliotecaNet.Common;
using BibliotecaNet.Domain.ValueObject.Pessoa;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Query.Pessoa
{
    public class PessoaListarPaginadoQuery : IRequest<PaginatedList<PessoaVO>>
    {
        public string Nome { get; private set; }
        public int OffSet { get; private set; }
        public int Limit { get; private set; }
    }
}
