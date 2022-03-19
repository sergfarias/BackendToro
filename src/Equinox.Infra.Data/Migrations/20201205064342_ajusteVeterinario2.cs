using Microsoft.EntityFrameworkCore.Migrations;

namespace Equinox.Infra.Data.Migrations
{
    public partial class ajusteVeterinario2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Intervalo",
                table: "VeterinarioGrade",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Intervalo",
                table: "VeterinarioGrade");
        }
    }
}
