using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.ValueObject.AcervoAutor
{
    public class AcervoAutorVO 
    {
        public int AutorId { get; set; }
        public string Nome { get; set; }
    }
}
