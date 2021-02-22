using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command.AcervoMovimentacao
{
    public class AcervoMovimentacaoCadastrarCommand : IRequest<string>
    {
        public AcervoMovimentacaoCadastrarCommand(int acervoID, int pessoaId, int usuarioId, DateTime dataEmprestimo)
        {
            AcervoID = acervoID;
            PessoaId = pessoaId;
            UsuarioId = usuarioId;
            DataEmprestimo = dataEmprestimo;
        }

        public int AcervoID { get; private set; }
        public int PessoaId { get; private set; }
        public int UsuarioId { get; private set; }
        public DateTime DataEmprestimo { get; private set; }

        public Entity.AcervoMovimentacao Command()
            => new Entity.AcervoMovimentacao
            {
                Acervo = new Entity.Acervo { AcervoId = AcervoID},
                Pessoa = new Entity.Pessoa { PessoaId = PessoaId},
                Usuario = new Entity.Usuario { Id = UsuarioId},
                DataEmprestimo = DataEmprestimo
            };
    }
}
