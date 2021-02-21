namespace BibliotecaNet.Domain.Entity
{
    public class PessoaContato
    {
        public int PessoaContatoId { get; set; }
        public Pessoa Pessoa { get; set; }
        public PessoaContatoTipo pessoaContatoTipo { get; set; }
        public string Valor { get; set; }
    }
}
