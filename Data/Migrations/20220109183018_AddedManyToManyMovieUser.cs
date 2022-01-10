using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRentalCRUD.Data.Migrations
{
    public partial class AddedManyToManyMovieUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieUser");

            migrationBuilder.CreateTable(
                name: "Movie_User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movie_User_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movie_User_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_User_MovieId",
                table: "Movie_User",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_User_UserId",
                table: "Movie_User",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie_User");

            migrationBuilder.CreateTable(
                name: "MovieUser",
                columns: table => new
                {
                    UserRentalsMovieId = table.Column<int>(type: "INTEGER", nullable: false),
                    UsersRentingUserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieUser", x => new { x.UserRentalsMovieId, x.UsersRentingUserId });
                    table.ForeignKey(
                        name: "FK_MovieUser_Movies_UserRentalsMovieId",
                        column: x => x.UserRentalsMovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieUser_Users_UsersRentingUserId",
                        column: x => x.UsersRentingUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieUser_UsersRentingUserId",
                table: "MovieUser",
                column: "UsersRentingUserId");
        }
    }
}
