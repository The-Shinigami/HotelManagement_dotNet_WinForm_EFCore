using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    public partial class sevenMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Chambres_ChambreId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Factures_FactureId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Utilisateur_UtilisateurId",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "Reservations");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_UtilisateurId",
                table: "Reservations",
                newName: "IX_Reservations_UtilisateurId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_FactureId",
                table: "Reservations",
                newName: "IX_Reservations_FactureId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_ChambreId",
                table: "Reservations",
                newName: "IX_Reservations_ChambreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Chambres_ChambreId",
                table: "Reservations",
                column: "ChambreId",
                principalTable: "Chambres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Factures_FactureId",
                table: "Reservations",
                column: "FactureId",
                principalTable: "Factures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Utilisateur_UtilisateurId",
                table: "Reservations",
                column: "UtilisateurId",
                principalTable: "Utilisateur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Chambres_ChambreId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Factures_FactureId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Utilisateur_UtilisateurId",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations");

            migrationBuilder.RenameTable(
                name: "Reservations",
                newName: "Reservation");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_UtilisateurId",
                table: "Reservation",
                newName: "IX_Reservation_UtilisateurId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_FactureId",
                table: "Reservation",
                newName: "IX_Reservation_FactureId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_ChambreId",
                table: "Reservation",
                newName: "IX_Reservation_ChambreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Chambres_ChambreId",
                table: "Reservation",
                column: "ChambreId",
                principalTable: "Chambres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Factures_FactureId",
                table: "Reservation",
                column: "FactureId",
                principalTable: "Factures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Utilisateur_UtilisateurId",
                table: "Reservation",
                column: "UtilisateurId",
                principalTable: "Utilisateur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
