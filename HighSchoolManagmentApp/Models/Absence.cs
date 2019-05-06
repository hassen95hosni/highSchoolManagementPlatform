using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagmentApp.Models
{
    public class Absence
    {
        public int id { get; set; }

        public Seance seance { get; set; }
        public DateTime date { get; set; }
        public String raison { get; set; }
        public int seanceId { get; set; }
        public Student student { get; set; }
        public int studentId { get; set; }
    }
}
