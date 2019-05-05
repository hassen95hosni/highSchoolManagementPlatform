using Microsoft.EntityFrameworkCore.Migrations;

namespace HighSchoolManagmentApp.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absence_Student_StudentId",
                table: "Absence");

            migrationBuilder.DropForeignKey(
                name: "FK_Seance_Subject_SubjectId",
                table: "Seance");

            migrationBuilder.DropForeignKey(
                name: "FK_Seance_Enseignant_enseignantId",
                table: "Seance");

            migrationBuilder.DropForeignKey(
                name: "FK_Seance_Salle_salleId",
                table: "Seance");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "Seance",
                newName: "subjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Seance_SubjectId",
                table: "Seance",
                newName: "IX_Seance_subjectId");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Absence",
                newName: "studentId");

            migrationBuilder.RenameIndex(
                name: "IX_Absence_StudentId",
                table: "Absence",
                newName: "IX_Absence_studentId");

            migrationBuilder.AlterColumn<int>(
                name: "salleId",
                table: "Seance",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "enseignantId",
                table: "Seance",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "subjectId",
                table: "Seance",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "studentId",
                table: "Absence",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Absence_Student_studentId",
                table: "Absence",
                column: "studentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seance_Enseignant_enseignantId",
                table: "Seance",
                column: "enseignantId",
                principalTable: "Enseignant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seance_Salle_salleId",
                table: "Seance",
                column: "salleId",
                principalTable: "Salle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seance_Subject_subjectId",
                table: "Seance",
                column: "subjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absence_Student_studentId",
                table: "Absence");

            migrationBuilder.DropForeignKey(
                name: "FK_Seance_Enseignant_enseignantId",
                table: "Seance");

            migrationBuilder.DropForeignKey(
                name: "FK_Seance_Salle_salleId",
                table: "Seance");

            migrationBuilder.DropForeignKey(
                name: "FK_Seance_Subject_subjectId",
                table: "Seance");

            migrationBuilder.RenameColumn(
                name: "subjectId",
                table: "Seance",
                newName: "SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Seance_subjectId",
                table: "Seance",
                newName: "IX_Seance_SubjectId");

            migrationBuilder.RenameColumn(
                name: "studentId",
                table: "Absence",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Absence_studentId",
                table: "Absence",
                newName: "IX_Absence_StudentId");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectId",
                table: "Seance",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "salleId",
                table: "Seance",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "enseignantId",
                table: "Seance",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Absence",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Absence_Student_StudentId",
                table: "Absence",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seance_Subject_SubjectId",
                table: "Seance",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seance_Enseignant_enseignantId",
                table: "Seance",
                column: "enseignantId",
                principalTable: "Enseignant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seance_Salle_salleId",
                table: "Seance",
                column: "salleId",
                principalTable: "Salle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
