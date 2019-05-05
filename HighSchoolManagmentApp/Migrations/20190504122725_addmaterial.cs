using Microsoft.EntityFrameworkCore.Migrations;

namespace HighSchoolManagmentApp.Migrations
{
    public partial class addmaterial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materiel_Salle_SalleId",
                table: "Materiel");

            migrationBuilder.DropForeignKey(
                name: "FK_Materiel_Subject_SubjectId",
                table: "Materiel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materiel",
                table: "Materiel");

            migrationBuilder.RenameTable(
                name: "Materiel",
                newName: "Materiels");

            migrationBuilder.RenameIndex(
                name: "IX_Materiel_SubjectId",
                table: "Materiels",
                newName: "IX_Materiels_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Materiel_SalleId",
                table: "Materiels",
                newName: "IX_Materiels_SalleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materiels",
                table: "Materiels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Materiels_Salle_SalleId",
                table: "Materiels",
                column: "SalleId",
                principalTable: "Salle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Materiels_Subject_SubjectId",
                table: "Materiels",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materiels_Salle_SalleId",
                table: "Materiels");

            migrationBuilder.DropForeignKey(
                name: "FK_Materiels_Subject_SubjectId",
                table: "Materiels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materiels",
                table: "Materiels");

            migrationBuilder.RenameTable(
                name: "Materiels",
                newName: "Materiel");

            migrationBuilder.RenameIndex(
                name: "IX_Materiels_SubjectId",
                table: "Materiel",
                newName: "IX_Materiel_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Materiels_SalleId",
                table: "Materiel",
                newName: "IX_Materiel_SalleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materiel",
                table: "Materiel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Materiel_Salle_SalleId",
                table: "Materiel",
                column: "SalleId",
                principalTable: "Salle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Materiel_Subject_SubjectId",
                table: "Materiel",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
