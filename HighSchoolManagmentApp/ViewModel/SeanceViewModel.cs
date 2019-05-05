using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HighSchoolManagmentApp.Models;

namespace HighSchoolManagmentApp.ViewModel
{
    public class SeanceViewModel
    {
        public Seance seance { get; set; }
        public IEnumerable<Subject> subject { get; set; }
        public IEnumerable<Salle> salle { get; set; }
        public IEnumerable<Enseignant> enseignant { get; set; }

    }
}
