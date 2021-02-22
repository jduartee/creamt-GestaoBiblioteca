using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Entity
{
    public class PessoaDocumentoTipo
    {
        public int PessoaDocumentoTipoId { get; set; }
        public string Descricao { get; set; }
        public string Mascara { get; set; }
        public bool Obrigatorio { get; set; }
        public bool Ativo { get; set; }
    }
}
