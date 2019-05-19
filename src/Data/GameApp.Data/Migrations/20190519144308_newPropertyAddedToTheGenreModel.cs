using Microsoft.EntityFrameworkCore.Migrations;

namespace GameApp.Data.Migrations
{
    public partial class newPropertyAddedToTheGenreModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tag",
                table: "Genres",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tag",
                table: "Genres");
        }
    }
}
