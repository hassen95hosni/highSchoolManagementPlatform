using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HighSchoolManagmentApp.Models;

namespace HighSchoolManagmentApp.ViewModel
{
    public class EnseignantViewModel
    {
        public Enseignant enseignant { get; set; }
        public IEnumerable<Subject> subjects { get; set; }
        public IEnumerable<Seance> emploi { get; set; }
    }
}
