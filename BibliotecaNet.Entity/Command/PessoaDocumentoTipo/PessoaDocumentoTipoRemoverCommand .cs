using MediatR;

namespace BibliotecaNet.Domain.Command.PessoaDocumentoTipo
{
    public class PessoaDocumentoTipoRemoverCommand : IRequest<string>
    {
        public PessoaDocumentoTipoRemoverCommand(int id)
        {
            Id = id;
        }

        private PessoaDocumentoTipoRemoverCommand()
        { }

        public int Id { get; set; }
    }
}
