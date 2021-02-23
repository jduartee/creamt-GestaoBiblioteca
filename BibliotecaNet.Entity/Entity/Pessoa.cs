using System.Collections.Generic;

namespace BibliotecaNet.Domain.Entity
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public int MatriculaId { get; set; }
        public string Nome { get; set; }
        public IList<PessoaDocumento> PessoaDocumentos { get; set; }
        public IList<PessoaEndereco> PessoaEnderecos { get; set; }
        public IList<PessoaContato> PessoaContatos { get; set; }
        public bool Ativo { get; set; }
        public PessoaTipo PessoaTipo { get; set; }
    }
}
