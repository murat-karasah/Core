using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Migrations
{
    public partial class ekledb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FilmTurleri",
                columns: table => new
                {
                    FilmTurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TurAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmTurleri", x => x.FilmTurId);
                });

            migrationBuilder.CreateTable(
                name: "Filmler",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilmAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilmResim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilmTurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmler", x => x.FilmId);
                    table.ForeignKey(
                        name: "FK_Filmler_FilmTurleri_FilmTurId",
                        column: x => x.FilmTurId,
                        principalTable: "FilmTurleri",
                        principalColumn: "FilmTurId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmler_FilmTurId",
                table: "Filmler",
                column: "FilmTurId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmler");

            migrationBuilder.DropTable(
                name: "FilmTurleri");
        }
    }
}
