using BibliotecaNet.Domain.ValueObject.Acervo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Query.Acervo
{
    public class AcervoListarDisponivelQuery : IRequest<IList<AcervoVO>>
    {
        public AcervoListarDisponivelQuery(string titulo)
        {
            Titulo = titulo;
        }

        public string Titulo { get; private set; }
    }
}
