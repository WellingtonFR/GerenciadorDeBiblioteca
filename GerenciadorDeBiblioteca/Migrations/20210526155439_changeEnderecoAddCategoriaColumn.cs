using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciadorDeBiblioteca.Migrations
{
    public partial class changeEnderecoAddCategoriaColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Enderecos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Enderecos");
        }
    }
}
