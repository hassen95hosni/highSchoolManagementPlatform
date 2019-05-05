using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HighSchoolManagmentApp.Models;

namespace HighSchoolManagmentApp.ViewModel
{
    public class GradeViewModel
    {
        public Grade grade { get; set; }
        public IEnumerable<Subject> subjects { get; set; }
        public IEnumerable<Seance> seance { get; set; }
    }
}
