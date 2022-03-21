using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Equinox.Infra.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ativo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sigla = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ativo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodConta = table.Column<string>(type: "varchar(6)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Cpf = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    Senha = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movimento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(nullable: false),
                    Evento = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true),
                    BancoDestino = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    AgenciaDestino = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    ContaDestino = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    BancoOrigem = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    AgenciaOrigem = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    CpfOrigem = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movimento_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioAtivo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtivoId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioAtivo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioAtivo_Ativo_AtivoId",
                        column: x => x.AtivoId,
                        principalTable: "Ativo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioAtivo_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ativo",
                columns: new[] { "Id", "DataCadastro", "Descricao", "Sigla", "Valor" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 21, 2, 34, 55, 414, DateTimeKind.Local).AddTicks(3927), "PETR4", "PETR4", 28.44m },
                    { 2, new DateTime(2022, 3, 21, 2, 34, 55, 416, DateTimeKind.Local).AddTicks(7084), "SANB11", "SANB11", 40.77m },
                    { 3, new DateTime(2022, 3, 21, 2, 34, 55, 416, DateTimeKind.Local).AddTicks(7128), "AZUL4", "AZUL4", 22.23m },
                    { 4, new DateTime(2022, 3, 21, 2, 34, 55, 416, DateTimeKind.Local).AddTicks(7151), "ALPA4", "ALPA4", 25.25m },
                    { 5, new DateTime(2022, 3, 21, 2, 34, 55, 416, DateTimeKind.Local).AddTicks(7156), "BBDC3", "BBDC3", 17.50m },
                    { 6, new DateTime(2022, 3, 21, 2, 34, 55, 416, DateTimeKind.Local).AddTicks(7161), "CMIG3", "CMIG3", 19.18m },
                    { 7, new DateTime(2022, 3, 21, 2, 34, 55, 416, DateTimeKind.Local).AddTicks(7166), "ELET3", "ELET3", 35.28m },
                    { 8, new DateTime(2022, 3, 21, 2, 34, 55, 416, DateTimeKind.Local).AddTicks(7170), "EMBR3", "EMBR3", 15.28m },
                    { 9, new DateTime(2022, 3, 21, 2, 34, 55, 416, DateTimeKind.Local).AddTicks(7173), "EQTL3", "EQTL3", 26.81m },
                    { 10, new DateTime(2022, 3, 21, 2, 34, 55, 416, DateTimeKind.Local).AddTicks(7177), "ENEV3", "ENEV3", 13.71m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movimento_UsuarioId",
                table: "Movimento",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioAtivo_AtivoId",
                table: "UsuarioAtivo",
                column: "AtivoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioAtivo_UsuarioId",
                table: "UsuarioAtivo",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movimento");

            migrationBuilder.DropTable(
                name: "UsuarioAtivo");

            migrationBuilder.DropTable(
                name: "Ativo");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
