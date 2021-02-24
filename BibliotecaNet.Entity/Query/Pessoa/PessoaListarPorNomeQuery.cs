using BibliotecaNet.Domain.ValueObject;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Query.Pessoa
{
    public class PessoaListarPorNomeQuery : IRequest<RequestSelectVO>
    {
        public PessoaListarPorNomeQuery(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
    }
}
