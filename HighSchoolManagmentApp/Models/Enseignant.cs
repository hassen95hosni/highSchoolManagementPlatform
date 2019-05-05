using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagmentApp.Models
{
    public class Enseignant
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String FamilyName { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Seance> emploi { get; set; }


    }
}
