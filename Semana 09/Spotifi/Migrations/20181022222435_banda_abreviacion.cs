using Microsoft.EntityFrameworkCore.Migrations;

namespace Spotifi.Migrations
{
    public partial class banda_abreviacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Abreviacion",
                table: "Bandas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Abreviacion",
                table: "Bandas");
        }
    }
}
