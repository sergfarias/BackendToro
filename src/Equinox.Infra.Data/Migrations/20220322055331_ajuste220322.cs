using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Equinox.Infra.Data.Migrations
{
    public partial class ajuste220322 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "UsuarioAtivo",
                type: "datetime",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CodConta",
                table: "Usuario",
                type: "varchar(6)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(6)");

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

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "CodConta", "Cpf", "DataCadastro", "Email", "Nome", "Saldo", "Senha" },
                values: new object[,]
                {
                    { 8, "000008", "12345678901", new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5060), "email@gmail.com", "Teste2", 100m, "1234" },
                    { 7, "000007", "12345678901", new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5057), "email@gmail.com", "Teste2", 100m, "1234" },
                    { 6, "000006", "12345678901", new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5052), "email@gmail.com", "Teste2", 100m, "1234" },
                    { 5, "000005", "12345678901", new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5048), "email@gmail.com", "Teste2", 100m, "1234" },
                    { 4, "000004", "12345678901", new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5045), "email@gmail.com", "Teste2", 100m, "1234" },
                    { 3, "000003", "12345678901", new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5027), "email@gmail.com", "Teste2", 100m, "1234" },
                    { 9, "000009", "12345678901", new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5062), "email@gmail.com", "Teste2", 100m, "1234" },
                    { 2, "000002", "12345678901", new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(1105), "email@gmail.com", "Teste2", 100m, "1234" }
                });

            migrationBuilder.InsertData(
                table: "UsuarioAtivo",
                columns: new[] { "Id", "AtivoId", "DataCadastro", "Quantidade", "UsuarioId" },
                values: new object[,]
                {
                    { 3, 1, new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(5293), 3, 2 },
                    { 4, 3, new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8267), 2, 2 },
                    { 5, 1, new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8283), 3, 3 },
                    { 6, 3, new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8286), 2, 3 },
                    { 7, 5, new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8289), 3, 3 },
                    { 8, 6, new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8291), 2, 3 },
                    { 9, 7, new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8293), 3, 5 },
                    { 10, 8, new DateTime(2022, 3, 22, 2, 53, 30, 569, DateTimeKind.Local).AddTicks(8296), 2, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UsuarioAtivo",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "UsuarioAtivo");

            migrationBuilder.AlterColumn<string>(
                name: "CodConta",
                table: "Usuario",
                type: "varchar(6)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(6)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 21, 2, 34, 55, 414, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 21, 2, 34, 55, 416, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 21, 2, 34, 55, 416, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 21, 2, 34, 55, 416, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 21, 2, 34, 55, 416, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 21, 2, 34, 55, 416, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 21, 2, 34, 55, 416, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 21, 2, 34, 55, 416, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 21, 2, 34, 55, 416, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Ativo",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataCadastro",
                value: new DateTime(2022, 3, 21, 2, 34, 55, 416, DateTimeKind.Local).AddTicks(7177));
        }
    }
}
