using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciadorDeBiblioteca.Migrations
{
    public partial class changeLivroModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Enderecos_EnderecoId",
                table: "Livros");

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "Livros",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Enderecos_EnderecoId",
                table: "Livros",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Enderecos_EnderecoId",
                table: "Livros");

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "Livros",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Enderecos_EnderecoId",
                table: "Livros",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "EnderecoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
