using BibliotecaNet.Common;
using BibliotecaNet.Domain.Entity;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotecaNet.Repository.Migrations
{
    public partial class CargaInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            #region TipoContato

            migrationBuilder.InsertData("PessoaContatoTipos", new string[] { nameof(PessoaDocumentoTipo.Descricao), nameof(PessoaDocumentoTipo.Mascara), nameof(PessoaDocumentoTipo.Obrigatorio), nameof(PessoaDocumentoTipo.Ativo) }, new object[] { "Telefone Celular", "(00) 0 0000-0000", true, true });
            migrationBuilder.InsertData("PessoaContatoTipos", new string[] { nameof(PessoaDocumentoTipo.Descricao), nameof(PessoaDocumentoTipo.Mascara), nameof(PessoaDocumentoTipo.Obrigatorio), nameof(PessoaDocumentoTipo.Ativo) }, new object[] { "Telefone Fixo", "(00) 0000-0000", false, true });
            migrationBuilder.InsertData("PessoaContatoTipos", new string[] { nameof(PessoaDocumentoTipo.Descricao), nameof(PessoaDocumentoTipo.Mascara), nameof(PessoaDocumentoTipo.Obrigatorio), nameof(PessoaDocumentoTipo.Ativo) }, new object[] { "E-mail", "", true, true });

            #endregion

            #region PessoaTipo

            migrationBuilder.InsertData(nameof(PessoaTipo), new string[] { nameof(PessoaTipo.PessoaTipoId), nameof(PessoaTipo.Descricao) }, new object[] { (int)PessoaTipoEnum.Aluno, nameof(PessoaTipoEnum.Aluno) });
            migrationBuilder.InsertData(nameof(PessoaTipo), new string[] { nameof(PessoaTipo.PessoaTipoId), nameof(PessoaTipo.Descricao) }, new object[] { (int)PessoaTipoEnum.Autor, nameof(PessoaTipoEnum.Autor) });
            migrationBuilder.InsertData(nameof(PessoaTipo), new string[] { nameof(PessoaTipo.PessoaTipoId), nameof(PessoaTipo.Descricao) }, new object[] { (int)PessoaTipoEnum.Profissional, nameof(PessoaTipoEnum.Profissional) });
            migrationBuilder.InsertData(nameof(PessoaTipo), new string[] { nameof(PessoaTipo.PessoaTipoId), nameof(PessoaTipo.Descricao) }, new object[] { (int)PessoaTipoEnum.Outros, nameof(PessoaTipoEnum.Outros) });

            #endregion

            #region AcervoSituacao

            migrationBuilder.InsertData("AcervoSituacaos", new string[] { nameof(AcervoSituacao.AcervoSituacaoId), nameof(AcervoSituacao.Descricao) }, new object[] { (int)AcervoSituacaoEnum.Disponivel, nameof(AcervoSituacaoEnum.Disponivel) });
            migrationBuilder.InsertData("AcervoSituacaos", new string[] { nameof(AcervoSituacao.AcervoSituacaoId), nameof(AcervoSituacao.Descricao) }, new object[] { (int)AcervoSituacaoEnum.Emprestado, nameof(AcervoSituacaoEnum.Emprestado) });
            migrationBuilder.InsertData("AcervoSituacaos", new string[] { nameof(AcervoSituacao.AcervoSituacaoId), nameof(AcervoSituacao.Descricao) }, new object[] { (int)AcervoSituacaoEnum.Extraviado, nameof(AcervoSituacaoEnum.Extraviado) });
            migrationBuilder.InsertData("AcervoSituacaos", new string[] { nameof(AcervoSituacao.AcervoSituacaoId), nameof(AcervoSituacao.Descricao) }, new object[] { (int)AcervoSituacaoEnum.EmManutencao, nameof(AcervoSituacaoEnum.EmManutencao) });

            #endregion
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
