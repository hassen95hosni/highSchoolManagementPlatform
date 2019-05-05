using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HighSchoolManagmentApp.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    familyName = table.Column<string>(nullable: true),
                    GradeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    EnseignantId = table.Column<int>(nullable: true),
                    GradeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subject_Enseignant_EnseignantId",
                        column: x => x.EnseignantId,
                        principalTable: "Enseignant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subject_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Materiel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(nullable: true),
                    SalleId = table.Column<int>(nullable: true),
                    SubjectId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materiel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materiel_Salle_SalleId",
                        column: x => x.SalleId,
                        principalTable: "Salle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Materiel_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Day = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: true),
                    salleId = table.Column<int>(nullable: true),
                    enseignantId = table.Column<int>(nullable: true),
                    GradeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seance_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Seance_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Seance_Enseignant_enseignantId",
                        column: x => x.enseignantId,
                        principalTable: "Enseignant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Seance_Salle_salleId",
                        column: x => x.salleId,
                        principalTable: "Salle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Absence",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    seanceId = table.Column<int>(nullable: true),
                    date = table.Column<DateTime>(nullable: false),
                    raison = table.Column<string>(nullable: true),
                    StudentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Absence", x => x.id);
                    table.ForeignKey(
                        name: "FK_Absence_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Absence_Seance_seanceId",
                        column: x => x.seanceId,
                        principalTable: "Seance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Absence_StudentId",
                table: "Absence",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Absence_seanceId",
                table: "Absence",
                column: "seanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Materiel_SalleId",
                table: "Materiel",
                column: "SalleId");

            migrationBuilder.CreateIndex(
                name: "IX_Materiel_SubjectId",
                table: "Materiel",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Seance_GradeId",
                table: "Seance",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Seance_SubjectId",
                table: "Seance",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Seance_enseignantId",
                table: "Seance",
                column: "enseignantId");

            migrationBuilder.CreateIndex(
                name: "IX_Seance_salleId",
                table: "Seance",
                column: "salleId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GradeId",
                table: "Student",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_EnseignantId",
                table: "Subject",
                column: "EnseignantId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_GradeId",
                table: "Subject",
                column: "GradeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Absence");

            migrationBuilder.DropTable(
                name: "Materiel");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Seance");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Grades");
        }
    }
}
