using MediatR;

namespace BibliotecaNet.Domain.Command.PessoaEndereco
{
    public class PessoaEnderecoRemoverCommand : IRequest<string>
    {
        private PessoaEnderecoRemoverCommand()
        { }

        public PessoaEnderecoRemoverCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}