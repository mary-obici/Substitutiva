using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto.Migrations
{
    public partial class migracaoImcc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imcs",
                columns: table => new
                {
                    ImcId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AlunoId = table.Column<int>(type: "INTEGER", nullable: true),
                    Altura = table.Column<double>(type: "REAL", nullable: false),
                    Peso = table.Column<double>(type: "REAL", nullable: false),
                    ValorImc = table.Column<double>(type: "REAL", nullable: true),
                    Classificacao = table.Column<string>(type: "TEXT", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imcs", x => x.ImcId);
                    table.ForeignKey(
                        name: "FK_Imcs_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "AlunoId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Imcs_AlunoId",
                table: "Imcs",
                column: "AlunoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imcs");
        }
    }
}
