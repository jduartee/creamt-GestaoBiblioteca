using MediatR;
using System;

namespace BibliotecaNet.Domain.Command.AcervoMovimentacao
{
    public class AcervoMovimentacaoCadastrarCommand : IRequest<string>
    {
        public AcervoMovimentacaoCadastrarCommand(int acervoID, int pessoaId, int usuarioId)
        {
            AcervoID = acervoID;
            PessoaId = pessoaId;
            UsuarioId = usuarioId;
        }

        public int AcervoID { get; private set; }
        public int PessoaId { get; private set; }
        public int UsuarioId { get; private set; }

        public Entity.AcervoMovimentacao Command()
            => new Entity.AcervoMovimentacao { DataEmprestimo = DateTime.Now };
    }
}
