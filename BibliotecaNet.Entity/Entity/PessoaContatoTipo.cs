namespace BibliotecaNet.Domain.Entity
{
    public class PessoaContatoTipo
    {
        public int PessoaContatoTipoId { get; set; }
        public int Descricao { get; set; }
        public int Mascara { get; set; }
        public bool Obrigatorio { get; set; }
        public bool Ativo { get; set; }
    }
}