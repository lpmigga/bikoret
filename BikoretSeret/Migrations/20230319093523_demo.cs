using Microsoft.EntityFrameworkCore.Migrations;

namespace BikoretSeret.Migrations
{
    public partial class demo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "creatorName",
                table: "movies",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "creatorName",
                table: "movies");
        }
    }
}
