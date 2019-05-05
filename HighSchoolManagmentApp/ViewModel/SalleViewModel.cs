using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HighSchoolManagmentApp.Models;

namespace HighSchoolManagmentApp.ViewModel
{
    public class SalleViewModel
    {
        public Salle salle { get; set; }
        public IEnumerable<Materiel> materiel { get; set; }
    }
}
