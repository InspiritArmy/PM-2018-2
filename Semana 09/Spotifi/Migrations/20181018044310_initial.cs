using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Spotifi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bandas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Foto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bandas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albumes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    BandaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albumes_Bandas_BandaId",
                        column: x => x.BandaId,
                        principalTable: "Bandas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bandas",
                columns: new[] { "Id", "Foto", "Nombre" },
                values: new object[] { 1, "https://i.kym-cdn.com/photos/images/newsfeed/000/937/730/e9a.jpg", "Link in Park" });

            migrationBuilder.InsertData(
                table: "Bandas",
                columns: new[] { "Id", "Foto", "Nombre" },
                values: new object[] { 2, "https://multimedia.larepublica.pe/720x405/larepublica/imagen/2018/10/16/noticia-peli-bts-burn-stage.jpg", "BTS" });

            migrationBuilder.CreateIndex(
                name: "IX_Albumes_BandaId",
                table: "Albumes",
                column: "BandaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albumes");

            migrationBuilder.DropTable(
                name: "Bandas");
        }
    }
}
