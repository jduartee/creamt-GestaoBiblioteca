using BibliotecaNet.Domain.ValueObject.AcervoAutor;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Query.AcervoAutor
{
    public class AcervoAutorListarPaginadoQuery : IRequest<IList<AcervoAutorVO>>
    {
        public AcervoAutorListarPaginadoQuery(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
    }
}
