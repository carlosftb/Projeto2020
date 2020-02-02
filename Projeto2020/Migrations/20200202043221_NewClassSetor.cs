using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto2020.Migrations
{
    public partial class NewClassSetor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.AddColumn<int>(
                name: "SetorId",
                table: "Produto",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Produto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Setor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setor", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_SetorId",
                table: "Produto",
                column: "SetorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Setor_SetorId",
                table: "Produto",
                column: "SetorId",
                principalTable: "Setor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Setor_SetorId",
                table: "Produto");

            migrationBuilder.DropTable(
                name: "Setor");

            migrationBuilder.DropIndex(
                name: "IX_Produto_SetorId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "SetorId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Produto");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });
        }
    }
}
