namespace BibliotecaNet.Domain.Entity
{
    public class Acervo
    {
        public int AcervoId { get; set; }
        public string Titulo { get; set; }
        public string Edicao { get; set; }
        public int Ano { get; set; }
        public AcervoAutor AcervoAutor { get; set; }
        public AcervoEditora AcervoEditora { get; set; }
        public AcervoCategoria AcervoCategoria { get; set; }
        public AcervoSituacao AcervoSituacao { get; set; }
    }
}
