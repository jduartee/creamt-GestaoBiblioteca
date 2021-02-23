using BibliotecaNet.Domain.ValueObject;
using MediatR;

namespace BibliotecaNet.Domain.Query.AcervoAutor
{
    public class AcervoAutorListarPorSelectQuery : IRequest<RequestSelectVO>
    {
        public AcervoAutorListarPorSelectQuery(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
    }
}
