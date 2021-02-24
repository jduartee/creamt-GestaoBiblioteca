using Microsoft.EntityFrameworkCore.Migrations;

namespace BibliotecaNet.Repository.Migrations
{
    public partial class AddIsbnAcervo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {            

            migrationBuilder.AddColumn<string>(
                name: "Isbn",
                table: "Acervos",
                type: "nvarchar(20)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Isbn",
                table: "Acervos");
          
        }
    }
}
