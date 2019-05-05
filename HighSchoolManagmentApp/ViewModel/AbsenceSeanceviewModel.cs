using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HighSchoolManagmentApp.Models;

namespace HighSchoolManagmentApp.ViewModel
{
    public class AbsenceSeanceviewModel
    {
        public Absence absence { get; set; }
        public IEnumerable<Seance> seance { get; set; }
        public int seanceId { get; set; }
        public IEnumerable<Student> student { get; set; }
    }
}
