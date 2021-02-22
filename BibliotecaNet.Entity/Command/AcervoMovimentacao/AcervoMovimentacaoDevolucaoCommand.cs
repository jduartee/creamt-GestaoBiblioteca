using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command.AcervoMovimentacao
{
    public class AcervoMovimentacaoDevolucaoCommand : IRequest<string>
    {
        private AcervoMovimentacaoDevolucaoCommand()
        { }

        public AcervoMovimentacaoDevolucaoCommand(int id, DateTime dataDevolucao)
        {
            Id = id;
            DataDevolucao = dataDevolucao;
        }

        public int Id { get; private set; }
        public DateTime DataDevolucao { get; private set; }
    }
}
