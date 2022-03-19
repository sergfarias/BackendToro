using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Equinox.Infra.Data.Migrations
{
    public partial class ajusteVeterinario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Veterinario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    DataContratacao = table.Column<DateTime>(type: "timestamp", nullable: true),
                    Cpf = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Geriatra = table.Column<bool>(type: "boolean", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veterinario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VeterinarioGrade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VeterinarioId = table.Column<int>(nullable: false),
                    DiaSemana = table.Column<int>(nullable: false),
                    HorIni = table.Column<DateTime>(type: "timestamp", nullable: false),
                    HorFim = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeterinarioGrade", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veterinario");

            migrationBuilder.DropTable(
                name: "VeterinarioGrade");
        }
    }
}
