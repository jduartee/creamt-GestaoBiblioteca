using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaNet.Apresentation.ViewModels.Acervo
{
    public class AcervoVM
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Edicao { get; set; }
        public int Ano { get; set; }
        public int AutorId { get; set; }
        public int EditoraId { get; set; }
        public int CategoriaId { get; set; }
        public int SituacaoId { get; set; }
    }
}
