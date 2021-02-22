using System;

namespace BibliotecaNet.Domain.Entity
{
    public class AcervoMovimentacao
    {
        public int AcervoMovimentacaoId { get; set; }
        public Acervo Acervo { get; set; }
        public Pessoa Pessoa { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataPrazoDevolucao { get; set; }
        public DateTime? DataDevolucao { get; set; }
    }
}
