using BibliotecaNet.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaNet.Domain.Command
{
    public class AcervoCadastroCommand : IRequest<int>
    {
        private AcervoCadastroCommand()
        { }

        public AcervoCadastroCommand(int id, string titulo, string edicao, int autorId, int editoraId, int ano, int categoriaId)
        {
            Id = id;
            Titulo = titulo;
            Edicao = edicao;
            AutorId = autorId;
            EditoraId = editoraId;
            Ano = ano;
            CategoriaId = categoriaId;
        }

        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Edicao { get; set; }
        public int AutorId { get; set; }
        public int EditoraId { get; set; }
        public int Ano { get; set; }
        public int CategoriaId { get; set; }

        public Acervo Command()
            => new Acervo
            {
                AcervoId = Id,
                Titulo = Titulo,
                Edicao = Edicao,
                Ano = Ano,
                AcervoAutor = new AcervoAutor { AcervoAutorId = AutorId },
                AcervoEditora = new AcervoEditora { AcervoEditoraId = EditoraId },
                AcervoCategoria = new AcervoCategoria
                {
                    CategoriaId = CategoriaId
                },
                AcervoSituacao = new AcervoSituacao { AcervoSituacaoId = Common.AcervoSituacaoEnum.Disponivel }
            };
    }
}
