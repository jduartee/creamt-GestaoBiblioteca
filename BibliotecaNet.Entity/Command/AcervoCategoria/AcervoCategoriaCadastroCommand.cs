using BibliotecaNet.Domain.Entity;
using MediatR;

namespace BibliotecaNet.Domain.Command.Categoria
{
    public class AcervoCategoriaCadastroCommand : IRequest<int>
    {
        private AcervoCategoriaCadastroCommand()
        { }

        public AcervoCategoriaCadastroCommand(int id, string nome, bool ativo)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }

        public AcervoCategoria Command()
            => new AcervoCategoria { AcervoCategoriaId = Id, Descricao = Nome, Ativo = true };

    }
}
