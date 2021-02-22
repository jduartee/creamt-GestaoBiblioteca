using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaNet.Apresentation.ViewModels.PessoaDocumento
{
    public class PessoaDocumentoVM
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Mascara { get; set; }
        public bool Obrigatorio { get; set; }

    }
}
