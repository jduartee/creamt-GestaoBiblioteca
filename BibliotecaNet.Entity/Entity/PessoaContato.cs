using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Entity
{
    public class PessoaContato
    {
        public int PessoaContatoId { get; set; }
        public PessoaContatoTipo pessoaContatoTipo { get; set; }
        public string Valor { get; set; }
    }
}
