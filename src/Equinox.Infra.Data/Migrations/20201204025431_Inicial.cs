using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Equinox.Infra.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "timestamp", nullable: true),
                    Cpf = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Observacao = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoAnimal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAnimal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoContato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoContato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClienteAnimal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClienteId = table.Column<int>(nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(250)", maxLength: 150, nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "timestamp", nullable: true),
                    TipoAnimalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteAnimal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClienteAnimal_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClienteContato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClienteId = table.Column<int>(nullable: false),
                    TipoContatoId = table.Column<int>(nullable: false),
                    NomeContato = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteContato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClienteContato_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TipoAnimal",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Cão" },
                    { 2, "Gato" },
                    { 3, "Hamster" }
                });

            migrationBuilder.InsertData(
                table: "TipoContato",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Telefone" },
                    { 2, "Celular" },
                    { 3, "E-mail" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClienteAnimal_ClienteId",
                table: "ClienteAnimal",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteContato_ClienteId",
                table: "ClienteContato",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClienteAnimal");

            migrationBuilder.DropTable(
                name: "ClienteContato");

            migrationBuilder.DropTable(
                name: "TipoAnimal");

            migrationBuilder.DropTable(
                name: "TipoContato");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
