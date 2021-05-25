using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciadorDeBiblioteca.Migrations
{
    public partial class Endereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LivroID",
                table: "Livros",
                newName: "LivroId");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Livros",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rua = table.Column<int>(type: "int", nullable: false),
                    Coluna = table.Column<int>(type: "int", nullable: false),
                    Prateleira = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.EnderecoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livros_EnderecoId",
                table: "Livros",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Enderecos_EnderecoId",
                table: "Livros",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Enderecos_EnderecoId",
                table: "Livros");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropIndex(
                name: "IX_Livros_EnderecoId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Livros");

            migrationBuilder.RenameColumn(
                name: "LivroId",
                table: "Livros",
                newName: "LivroID");
        }
    }
}
