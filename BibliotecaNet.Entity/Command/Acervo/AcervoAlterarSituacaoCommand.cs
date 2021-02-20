using BibliotecaNet.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command
{
    public class AcervoAlterarSituacaoCommand : IRequest<string>
    {
        private AcervoAlterarSituacaoCommand()
        { }

        public AcervoAlterarSituacaoCommand(int id, int situacaoId)
        {

        }

        public int Id { get; private set; }
        public int SituacaoId { get; private set; }

        public Acervo Command()
            => new Acervo
            {
                AcervoId = Id,
                AcervoSituacao = new AcervoSituacao { AcervoSituacaoId = (Common.AcervoSituacaoEnum)SituacaoId }
            };
    }
}
