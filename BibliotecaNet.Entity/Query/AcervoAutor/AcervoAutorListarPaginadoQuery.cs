using BibliotecaNet.Common;
using BibliotecaNet.Domain.ValueObject.AcervoAutor;
using MediatR;

namespace BibliotecaNet.Domain.Query.AcervoAutor
{
    public class AcervoAutorListarPaginadoQuery : IRequest<PaginatedList<AcervoAutorVO>>
    {
        public AcervoAutorListarPaginadoQuery(string nome, int offSet, int limit)
        {
            Nome = nome;
            OffSet = offSet;
            Limit = limit;
        }

        public string Nome { get; private set; }
        public int OffSet { get; private set; }
        public int Limit { get; private set; }
    }
}
