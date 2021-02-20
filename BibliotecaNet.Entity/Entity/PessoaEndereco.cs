﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Entity
{
    public class PessoaEndereco
    {
        public int PessoaEnderecoId { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public bool Principal { get; set; }
    }
}
