using Microsoft.EntityFrameworkCore.Migrations;

namespace HighSchoolManagmentApp.Migrations
{
    public partial class seanceid2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absence_Seance_SeanceId",
                table: "Absence");

            migrationBuilder.RenameColumn(
                name: "SeanceId",
                table: "Absence",
                newName: "seanceId");

            migrationBuilder.RenameIndex(
                name: "IX_Absence_SeanceId",
                table: "Absence",
                newName: "IX_Absence_seanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Absence_Seance_seanceId",
                table: "Absence",
                column: "seanceId",
                principalTable: "Seance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absence_Seance_seanceId",
                table: "Absence");

            migrationBuilder.RenameColumn(
                name: "seanceId",
                table: "Absence",
                newName: "SeanceId");

            migrationBuilder.RenameIndex(
                name: "IX_Absence_seanceId",
                table: "Absence",
                newName: "IX_Absence_SeanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Absence_Seance_SeanceId",
                table: "Absence",
                column: "SeanceId",
                principalTable: "Seance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
