using BibliotecaNet.Domain.ValueObject;
using MediatR;

namespace BibliotecaNet.Domain.Query.AcervoCategoria
{
    public class AcervoCategoriaObterAtivosQuery : IRequest<RequestSelectVO>
    {
        public AcervoCategoriaObterAtivosQuery(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; set; }
    }
}
