using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.ValueObject.AcervoAutor
{
    public class AcervoAutorListarPorNomeQuery : IRequest
    {
        public AcervoAutorListarPorNomeQuery(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
    }
}
