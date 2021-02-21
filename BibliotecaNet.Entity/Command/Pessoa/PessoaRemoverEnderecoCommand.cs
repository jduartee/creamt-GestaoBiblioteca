using MediatR;

namespace BibliotecaNet.Domain.Command.PessoaContato
{
    public class PessoaRemoverEnderecoCommand : IRequest<string>
    {
        private PessoaRemoverEnderecoCommand()
        { }

        public PessoaRemoverEnderecoCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}