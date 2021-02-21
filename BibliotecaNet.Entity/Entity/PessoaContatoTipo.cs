namespace BibliotecaNet.Domain.Entity
{
    public class PessoaContatoTipo
    {
        public int PessoaContatoTipoId { get; set; }
        public string Descricao { get; set; }
        public string Mascara { get; set; }
        public bool Obrigatorio { get; set; }
        public bool Ativo { get; set; }
    }
}