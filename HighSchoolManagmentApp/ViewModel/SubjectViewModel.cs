using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HighSchoolManagmentApp.Models;
namespace HighSchoolManagmentApp.ViewModel
{
    public class SubjectViewModel
    {
        public Subject subject { get; set; }
        public IEnumerable<Materiel> materiel { get; set; }
    }
}
