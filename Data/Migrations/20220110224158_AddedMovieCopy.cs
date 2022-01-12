using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRentalCRUD.Data.Migrations
{
    public partial class AddedMovieCopy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MoviesCopy",
                columns: table => new
                {
                    CopyId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MovieId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesCopy", x => x.CopyId);
                    table.ForeignKey(
                        name: "FK_MoviesCopy_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviesCopy_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoviesCopy_MovieId",
                table: "MoviesCopy",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviesCopy_UserId",
                table: "MoviesCopy",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoviesCopy");
        }
    }
}
