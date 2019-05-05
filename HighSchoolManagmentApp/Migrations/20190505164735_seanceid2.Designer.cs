﻿// <auto-generated />
using System;
using HighSchoolManagmentApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HighSchoolManagmentApp.Migrations
{
    [DbContext(typeof(DbContext_Model.HighSchoolManagmentContext))]
    [Migration("20190505164735_seanceid2")]
    partial class seanceid2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HighSchoolManagmentApp.Models.Absence", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("StudentId");

                    b.Property<DateTime>("date");

                    b.Property<string>("raison");

                    b.Property<int>("seanceId");

                    b.HasKey("id");

                    b.HasIndex("StudentId");

                    b.HasIndex("seanceId");

                    b.ToTable("Absence");
                });

            modelBuilder.Entity("HighSchoolManagmentApp.Models.Enseignant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FamilyName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Enseignant");
                });

            modelBuilder.Entity("HighSchoolManagmentApp.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("HighSchoolManagmentApp.Models.Materiel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom");

                    b.Property<int?>("SalleId");

                    b.Property<int?>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("SalleId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Materiels");
                });

            modelBuilder.Entity("HighSchoolManagmentApp.Models.Salle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NombreEtudiant");

                    b.Property<string>("Type");

                    b.Property<string>("name");

                    b.HasKey("Id");

                    b.ToTable("Salle");
                });

            modelBuilder.Entity("HighSchoolManagmentApp.Models.Seance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Day");

                    b.Property<int?>("GradeId");

                    b.Property<string>("Name");

                    b.Property<int>("Number");

                    b.Property<int?>("SubjectId");

                    b.Property<int?>("enseignantId");

                    b.Property<int?>("salleId");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("enseignantId");

                    b.HasIndex("salleId");

                    b.ToTable("Seance");
                });

            modelBuilder.Entity("HighSchoolManagmentApp.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GradeId");

                    b.Property<string>("Name");

                    b.Property<string>("familyName");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("HighSchoolManagmentApp.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EnseignantId");

                    b.Property<int?>("GradeId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("EnseignantId");

                    b.HasIndex("GradeId");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("HighSchoolManagmentApp.Models.Absence", b =>
                {
                    b.HasOne("HighSchoolManagmentApp.Models.Student")
                        .WithMany("absence")
                        .HasForeignKey("StudentId");

                    b.HasOne("HighSchoolManagmentApp.Models.Seance", "seance")
                        .WithMany()
                        .HasForeignKey("seanceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HighSchoolManagmentApp.Models.Materiel", b =>
                {
                    b.HasOne("HighSchoolManagmentApp.Models.Salle")
                        .WithMany("materiels")
                        .HasForeignKey("SalleId");

                    b.HasOne("HighSchoolManagmentApp.Models.Subject")
                        .WithMany("Besoin")
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("HighSchoolManagmentApp.Models.Seance", b =>
                {
                    b.HasOne("HighSchoolManagmentApp.Models.Grade")
                        .WithMany("schedule")
                        .HasForeignKey("GradeId");

                    b.HasOne("HighSchoolManagmentApp.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");

                    b.HasOne("HighSchoolManagmentApp.Models.Enseignant", "enseignant")
                        .WithMany("emploi")
                        .HasForeignKey("enseignantId");

                    b.HasOne("HighSchoolManagmentApp.Models.Salle", "salle")
                        .WithMany()
                        .HasForeignKey("salleId");
                });

            modelBuilder.Entity("HighSchoolManagmentApp.Models.Student", b =>
                {
                    b.HasOne("HighSchoolManagmentApp.Models.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeId");
                });

            modelBuilder.Entity("HighSchoolManagmentApp.Models.Subject", b =>
                {
                    b.HasOne("HighSchoolManagmentApp.Models.Enseignant")
                        .WithMany("Subjects")
                        .HasForeignKey("EnseignantId");

                    b.HasOne("HighSchoolManagmentApp.Models.Grade")
                        .WithMany("Subjects")
                        .HasForeignKey("GradeId");
                });
#pragma warning restore 612, 618
        }
    }
}
