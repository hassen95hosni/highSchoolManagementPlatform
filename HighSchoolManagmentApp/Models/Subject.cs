using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagmentApp.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public String  Name { get; set; }
        public List<Materiel> Besoin { get; set; }
    }
}
