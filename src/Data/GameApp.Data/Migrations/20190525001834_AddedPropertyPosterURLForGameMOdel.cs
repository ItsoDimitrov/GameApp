using Microsoft.EntityFrameworkCore.Migrations;

namespace GameApp.Data.Migrations
{
    public partial class AddedPropertyPosterURLForGameMOdel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PosterURL",
                table: "Games",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PosterURL",
                table: "Games");
        }
    }
}
