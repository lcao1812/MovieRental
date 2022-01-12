using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRentalCRUD.Data.Migrations
{
    public partial class AddedDateRent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateRent",
                table: "MoviesCopy",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateRent",
                table: "MoviesCopy");
        }
    }
}
