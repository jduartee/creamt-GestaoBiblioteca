using BibliotecaNet.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command
{
    public class AcervoCadastroCommand : IRequest<string>
    {
        private AcervoCadastroCommand()
        { }

        public AcervoCadastroCommand(int id, string titulo, string edicao, string isbn, int ano, int autorId, int editoraId, int categoriaId)
        {
            Id = id;
            Titulo = titulo;
            Edicao = edicao;
            Isbn = isbn;
            AutorId = autorId;
            EditoraId = editoraId;
            Ano = ano;
            CategoriaId = categoriaId;
        }

        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Edicao { get; private set; }
        public string Isbn { get; private set; }
        public int AutorId { get; private set; }
        public int EditoraId { get; private set; }
        public int Ano { get; private set; }
        public int CategoriaId { get; private set; }

        public Acervo Command()
            => new Acervo
            {
                AcervoId = Id,
                Titulo = Titulo,
                Edicao = Edicao,
                Isbn = Isbn,
                Ano = Ano
            };
    }
}
