using BibliotecaNet.Common;
using BibliotecaNet.Domain.ValueObject.Acervo;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Query.Acervo
{
    public class AcervoListarPaginadoQuery : IRequest<PaginatedList<AcervoVO>>
    {
        public AcervoListarPaginadoQuery(string titulo, int offSet, int limit)
        {
            Titulo = titulo;
            OffSet = offSet;
            Limit = limit;
        }

        public string Titulo { get; private set; }
        public int OffSet { get; private set; }
        public int Limit { get; private set; }
    }
}
