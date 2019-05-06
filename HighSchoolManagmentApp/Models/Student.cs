using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagmentApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String familyName { get; set; }
        public Grade Grade { get; set; }
        public int gradeId { get; set; }
        public List<Absence> absence { get; set; }

    }
}
