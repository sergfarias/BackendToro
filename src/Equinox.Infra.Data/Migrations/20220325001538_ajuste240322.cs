using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Equinox.Infra.Data.Migrations
{
    public partial class ajuste240322 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 24, 21, 15, 38, 191, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 24, 21, 15, 38, 193, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 24, 21, 15, 38, 193, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 24, 21, 15, 38, 193, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 24, 21, 15, 38, 193, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 24, 21, 15, 38, 193, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 24, 21, 15, 38, 193, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 24, 21, 15, 38, 193, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 24, 21, 15, 38, 193, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 24, 21, 15, 38, 193, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cpf", "DataCadastro" },
                values: new object[] { "12345678902", new DateTime(2022, 3, 24, 21, 15, 38, 195, DateTimeKind.Local).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Cpf", "DataCadastro", "Nome" },
                values: new object[] { "12345678903", new DateTime(2022, 3, 24, 21, 15, 38, 195, DateTimeKind.Local).AddTicks(7894), "Teste3" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Cpf", "DataCadastro", "Nome" },
                values: new object[] { "12345678904", new DateTime(2022, 3, 24, 21, 15, 38, 195, DateTimeKind.Local).AddTicks(7911), "Teste4" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Cpf", "DataCadastro", "Nome" },
                values: new object[] { "12345678905", new DateTime(2022, 3, 24, 21, 15, 38, 195, DateTimeKind.Local).AddTicks(7915), "Teste5" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Cpf", "DataCadastro", "Nome" },
                values: new object[] { "12345678906", new DateTime(2022, 3, 24, 21, 15, 38, 195, DateTimeKind.Local).AddTicks(7918), "Teste6" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Cpf", "DataCadastro", "Nome" },
                values: new object[] { "12345678907", new DateTime(2022, 3, 24, 21, 15, 38, 195, DateTimeKind.Local).AddTicks(7922), "Teste7" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Cpf", "DataCadastro", "Nome" },
                values: new object[] { "12345678908", new DateTime(2022, 3, 24, 21, 15, 38, 195, DateTimeKind.Local).AddTicks(7925), "Teste8" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Cpf", "DataCadastro", "Nome" },
                values: new object[] { "12345678909", new DateTime(2022, 3, 24, 21, 15, 38, 195, DateTimeKind.Local).AddTicks(7928), "Teste9" });

            migrationBuilder.UpdateData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCadastro", "UsuarioId" },
                values: new object[] { new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataCadastro", "UsuarioId" },
                values: new object[] { new DateTime(2022, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AtivoId", "DataCadastro" },
                values: new object[] { 3, new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "UsuarioAtivo",
                columns: new[] { "Id", "AtivoId", "DataCadastro", "Quantidade", "UsuarioId" },
                values: new object[,]
                {
                    { 19, 8, new DateTime(2022, 3, 24, 21, 15, 38, 204, DateTimeKind.Local).AddTicks(5481), 2, 9 },
                    { 18, 7, new DateTime(2022, 3, 24, 21, 15, 38, 204, DateTimeKind.Local).AddTicks(5478), 3, 9 },
                    { 17, 8, new DateTime(2022, 3, 24, 21, 15, 38, 204, DateTimeKind.Local).AddTicks(5458), 2, 9 },
                    { 16, 8, new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 8 },
                    { 15, 7, new DateTime(2022, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 8 },
                    { 14, 8, new DateTime(2022, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 7 },
                    { 13, 7, new DateTime(2022, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 7 },
                    { 12, 6, new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 6 },
                    { 11, 5, new DateTime(2022, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 22, 2, 53, 30, 565, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 22, 2, 53, 30, 568, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 22, 2, 53, 30, 568, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 22, 2, 53, 30, 568, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 22, 2, 53, 30, 568, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 22, 2, 53, 30, 568, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 22, 2, 53, 30, 568, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 22, 2, 53, 30, 568, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 22, 2, 53, 30, 568, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 22, 2, 53, 30, 568, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cpf", "DataCadastro" },
                values: new object[] { "12345678901", new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Cpf", "DataCadastro", "Nome" },
                values: new object[] { "12345678901", new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5027), "Teste2" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Cpf", "DataCadastro", "Nome" },
                values: new object[] { "12345678901", new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5045), "Teste2" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Cpf", "DataCadastro", "Nome" },
                values: new object[] { "12345678901", new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5048), "Teste2" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Cpf", "DataCadastro", "Nome" },
                values: new object[] { "12345678901", new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5052), "Teste2" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Cpf", "DataCadastro", "Nome" },
                values: new object[] { "12345678901", new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5057), "Teste2" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Cpf", "DataCadastro", "Nome" },
                values: new object[] { "12345678901", new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5060), "Teste2" });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Cpf", "DataCadastro", "Nome" },
                values: new object[] { "12345678901", new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5062), "Teste2" });

            migrationBuilder.UpdateData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DataCadastro", "UsuarioId" },
                values: new object[] { new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8289), 3 });

            migrationBuilder.UpdateData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DataCadastro", "UsuarioId" },
                values: new object[] { new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8291), 3 });

            migrationBuilder.UpdateData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AtivoId", "DataCadastro" },
                values: new object[] { 8, new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8296) });
        }
    }
}
