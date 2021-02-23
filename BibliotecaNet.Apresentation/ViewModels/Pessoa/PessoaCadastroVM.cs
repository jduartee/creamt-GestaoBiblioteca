using BibliotecaNet.Apresentation.ViewModels.Pessoa;
using System.Collections.Generic;

namespace BibliotecaNet.Apresentation.ViewModels
{
    public class PessoaCadastroVM
    {
        public string Nome { get; set; }
        public int TipoPessoaId { get; set; }
        public IList<PessoaDocumentoVM> PessoaDocumento { get; set; }
        public IList<PessoaEnderecoVM> PessoaEndereco { get; set; }
        public IList<PessoaContatoVM> PessoaContato { get; set; }
    }
}
