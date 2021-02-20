using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Entity
{
    public class PessoaDocumentoTipo
    {
        public int PessoaDocumentoTipoId { get; set; }
        public int Descricao { get; set; }
        public int Mascara { get; set; }
        public bool Obrigatorio { get; set; }
        public bool Ativo { get; set; }
    }
}
