using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.ValueObject.PessoaDocumentoTipo
{
    public class PessoaDocumentoTipoVO
    {
        public int Id { get; set; }
        public int Descricao { get; set; }
        public int Mascara { get; set; }
        public bool Obrigatorio { get; set; }
    }
}
