using BibliotecaNet.Common;
using BibliotecaNet.Domain.ValueObject.AcervoMovimentacao;
using MediatR;

namespace BibliotecaNet.Domain.Query.AcervoMovimentacao
{
    public class AcervoMovimentacaoListarPaginadaQuery : IRequest<PaginatedList<AcervoMovimentacaoVO>>
    {
        public AcervoMovimentacaoListarPaginadaQuery(int offSet, int limit)
        {
            OffSet = offSet;
            Limit = limit;
        }

        public int OffSet { get; private set; }
        public int Limit { get; private set; }
    }
}
