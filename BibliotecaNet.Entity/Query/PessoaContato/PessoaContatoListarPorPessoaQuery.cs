using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Query.PessoaContato
{
    public class PessoaContatoListarPorPessoaQuery : IRequest<object>
    {
        public PessoaContatoListarPorPessoaQuery(int pessoaId)
        {
            PessoaId = pessoaId;
        }

        public int PessoaId { get; private set; }
    }
}
