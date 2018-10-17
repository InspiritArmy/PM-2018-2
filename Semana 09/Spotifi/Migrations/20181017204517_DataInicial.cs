using Microsoft.EntityFrameworkCore.Migrations;

namespace Spotifi.Migrations
{
    public partial class DataInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bandas",
                columns: new[] { "Id", "Foto", "Nombre" },
                values: new object[] { 1, "https://i.kym-cdn.com/photos/images/newsfeed/000/937/730/e9a.jpg", "Link in Park" });

            migrationBuilder.InsertData(
                table: "Bandas",
                columns: new[] { "Id", "Foto", "Nombre" },
                values: new object[] { 2, "https://multimedia.larepublica.pe/720x405/larepublica/imagen/2018/10/16/noticia-peli-bts-burn-stage.jpg", "BTS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bandas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bandas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
