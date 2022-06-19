using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    public partial class _10Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestation_Factures_FactureId",
                table: "Prestation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prestation",
                table: "Prestation");

            migrationBuilder.RenameTable(
                name: "Prestation",
                newName: "Prestations");

            migrationBuilder.RenameIndex(
                name: "IX_Prestation_FactureId",
                table: "Prestations",
                newName: "IX_Prestations_FactureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prestations",
                table: "Prestations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestations_Factures_FactureId",
                table: "Prestations",
                column: "FactureId",
                principalTable: "Factures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestations_Factures_FactureId",
                table: "Prestations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prestations",
                table: "Prestations");

            migrationBuilder.RenameTable(
                name: "Prestations",
                newName: "Prestation");

            migrationBuilder.RenameIndex(
                name: "IX_Prestations_FactureId",
                table: "Prestation",
                newName: "IX_Prestation_FactureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prestation",
                table: "Prestation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestation_Factures_FactureId",
                table: "Prestation",
                column: "FactureId",
                principalTable: "Factures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
