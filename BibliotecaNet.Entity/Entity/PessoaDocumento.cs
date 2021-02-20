using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Entity
{
   public class PessoaDocumento
    {
        public int PessoaDocumentoId { get; set; }
        public PessoaDocumentoTipo PessoaDocumentoTipo { get; set; }
        public string Valor { get; set; }
    }
}
