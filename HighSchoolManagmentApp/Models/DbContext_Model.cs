using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace HighSchoolManagmentApp.Models
{
    public class DbContext_Model
    {   
        public class HighSchoolManagmentContext : DbContext
        {
            public HighSchoolManagmentContext(DbContextOptions<HighSchoolManagmentContext> options)
                 : base(options)
            { }
           


            public DbSet<Materiel> Materiels { get; set; }
            public DbSet<Subject> Subject { get; set; }
            public DbSet<Student> Student { get; set; }
            public DbSet<Seance> Seance { get; set; }
            public DbSet<Grade> Grades { get; set; }
            public DbSet<Absence> Absence { get; set; }
            public DbSet<Salle> Salle { get; set; }
            public DbSet<Enseignant> Enseignant { get; set; }
        }
    }
}
