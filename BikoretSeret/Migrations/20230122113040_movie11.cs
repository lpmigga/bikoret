using Microsoft.EntityFrameworkCore.Migrations;

namespace BikoretSeret.Migrations
{
    public partial class movie11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bikoret",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "movies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "bikoret",
                table: "movies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "rating",
                table: "movies",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
