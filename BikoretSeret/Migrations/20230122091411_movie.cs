using Microsoft.EntityFrameworkCore.Migrations;

namespace BikoretSeret.Migrations
{
    public partial class movie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    rating = table.Column<double>(type: "REAL", nullable: false),
                    bikoret = table.Column<string>(type: "TEXT", nullable: true),
                    category = table.Column<string>(type: "TEXT", nullable: true),
                    summery = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
