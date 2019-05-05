using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HighSchoolManagmentApp.Models;

namespace HighSchoolManagmentApp.ViewModel
{
    public class StudentViewModel
    {
        public Student student { get; set; }
        public IEnumerable< Grade> grade { get; set; }
        public IEnumerable< Absence> absence { get; set; }    
    }
}
