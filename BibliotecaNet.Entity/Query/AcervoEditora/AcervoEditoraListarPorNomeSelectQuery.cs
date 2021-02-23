using BibliotecaNet.Domain.ValueObject;
using MediatR;

namespace BibliotecaNet.Domain.Query.AcervoEditora
{
    public class AcervoEditoraListarPorNomeSelectQuery : IRequest<RequestSelectVO>
    {
        public AcervoEditoraListarPorNomeSelectQuery(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
    }
}
