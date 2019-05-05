using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagmentApp.Models
{
    public class Seance
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Day { get; set; }
        public int Number { get; set; }
        public Subject Subject { get; set; }
        public int subjectId { get; set; }
        public Salle salle { get; set; }
        public int salleId { get; set; }
        public Enseignant enseignant { get; set; }
        public int enseignantId { get; set; }
    }
}
