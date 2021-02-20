using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Entity
{
    public class AcervoAutor
    {
        public int AcervoAutorId { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
