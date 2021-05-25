using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciadorDeBiblioteca.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    LivroID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    Editora = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Classificacao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PalavrasChave = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.LivroID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livros");
        }
    }
}
