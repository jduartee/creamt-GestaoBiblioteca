using System;

namespace BibliotecaNet.Domain.ValueObject.AcervoMovimentacao
{
    public class AcervoMovimentacaoVO
    {
        public int Id { get; set; }
        public string Acervo { get; set; }
        public string Pessoa { get; set; }
        public string Usuario { get; set; }
        public string DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public string DataPrazoDevolucao
        {
            get
            {
                return Convert.ToDateTime(DataEmprestimo).AddDays(15).ToShortDateString();
            }
        }

        public string Situacao
        {
            get
            {
                DateTime emprestimo = Convert.ToDateTime(DataEmprestimo);

                if (DataDevolucao != null)
                {
                    return Common.SituacaoEmprestimo.Devolvido.ToString();
                }

                var dias = (DateTime.Today - emprestimo).Days;

                if (dias > 15)
                {
                    return Common.SituacaoEmprestimo.Atrasado.ToString();
                }

                return Common.SituacaoEmprestimo.Emprestado.ToString();
            }
        }

    }
}
