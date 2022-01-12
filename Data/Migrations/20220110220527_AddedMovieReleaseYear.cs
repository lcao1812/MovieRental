using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRentalCRUD.Data.Migrations
{
    public partial class AddedMovieReleaseYear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieYear",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieYear",
                table: "Movies");
        }
    }
}
