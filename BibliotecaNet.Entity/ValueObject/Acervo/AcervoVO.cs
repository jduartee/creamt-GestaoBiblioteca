using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.ValueObject.Acervo
{
    public class AcervoVO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Edicao { get; set; }
        public int Ano { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Categoria { get; set; }
        public string Situacao { get; set; }
    }
}
