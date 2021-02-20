using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Entity
{
    public class AcervoCategoria
    {
        public int CategoriaId { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}
