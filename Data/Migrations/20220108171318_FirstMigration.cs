using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRentalCRUD.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    MovieSummary = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: false),
                    MovieStock = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "MovieName", "MovieStock", "MovieSummary" },
                values: new object[] { 1, "Example Movie 0 Title", 0, "Example Movie 0 Content" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "MovieName", "MovieStock", "MovieSummary" },
                values: new object[] { 2, "Example Movie 1 Title", 0, "Example Movie 1 Content" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "MovieName", "MovieStock", "MovieSummary" },
                values: new object[] { 3, "Example Movie 2 Title", 0, "Example Movie 2 Content" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "MovieName", "MovieStock", "MovieSummary" },
                values: new object[] { 4, "Example Movie 3 Title", 0, "Example Movie 3 Content" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "MovieName", "MovieStock", "MovieSummary" },
                values: new object[] { 5, "Example Movie 4 Title", 0, "Example Movie 4 Content" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "MovieName", "MovieStock", "MovieSummary" },
                values: new object[] { 6, "Example Movie 5 Title", 0, "Example Movie 5 Content" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
