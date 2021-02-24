using BibliotecaNet.Domain.Entity;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotecaNet.Repository.Migrations
{
    public partial class CargaDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "AP Cultural" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Editora Ariel" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Artenova" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Grupo A(editora)" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Ateliê Editorial" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Ática(editora)" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Axcel Books" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Calibán" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Editorial Calvino Limitada" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Editora Campus - Elsevier" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Editora Carlini&Caniato" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Casa Editora Presbiteriana" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Casa Publicadora Brasileira" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Casa Publicadora das Assembleias de Deus" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Cedibra" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Cejup" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Centauro Editora" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Central Gospel Music" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "PME" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Circo Editorial" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Editora Milfontes" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Editora Nemo" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Geração Editorial" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Global Editora" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Graça Editorial" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Grupo Editorial Scortecci" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Grupo Santillana" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Hama Editora" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Editora Hemus" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Hucitec" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Ipsis Gráfica e Editora" });
            migrationBuilder.InsertData("AcervoEditoras", new string[] { nameof(AcervoEditora.Nome) }, new object[] { "Editora Pensamento - Cultrix" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
