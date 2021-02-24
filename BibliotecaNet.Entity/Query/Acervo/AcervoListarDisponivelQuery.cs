using BibliotecaNet.Domain.ValueObject;
using MediatR;

namespace BibliotecaNet.Domain.Query.Acervo
{
    public class AcervoListarDisponivelQuery : IRequest<RequestSelectVO>
    {
        public AcervoListarDisponivelQuery(string titulo)
        {
            Titulo = titulo;
        }

        public string Titulo { get; private set; }
    }
}
