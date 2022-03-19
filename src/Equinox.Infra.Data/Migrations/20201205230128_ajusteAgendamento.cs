using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Equinox.Infra.Data.Migrations
{
    public partial class ajusteAgendamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agendamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClienteId = table.Column<int>(nullable: false),
                    AnimalId = table.Column<int>(nullable: false),
                    VeterinarioId = table.Column<int>(nullable: false),
                    Horario = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    DataConsulta = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "timestamp", nullable: true),
                    ClienteAnimalId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agendamento_ClienteAnimal_ClienteAnimalId",
                        column: x => x.ClienteAnimalId,
                        principalTable: "ClienteAnimal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agendamento_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendamento_Veterinario_VeterinarioId",
                        column: x => x.VeterinarioId,
                        principalTable: "Veterinario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_ClienteAnimalId",
                table: "Agendamento",
                column: "ClienteAnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_ClienteId",
                table: "Agendamento",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_VeterinarioId",
                table: "Agendamento",
                column: "VeterinarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamento");
        }
    }
}
