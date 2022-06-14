using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    public partial class secMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "src",
                table: "HotelImage",
                newName: "Src");

            migrationBuilder.RenameColumn(
                name: "src",
                table: "ChambreImage",
                newName: "Src");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Src",
                table: "HotelImage",
                newName: "src");

            migrationBuilder.RenameColumn(
                name: "Src",
                table: "ChambreImage",
                newName: "src");
        }
    }
}
