using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagmentApp.Models
{
    public class Salle
    {
        public int Id { get; set;}
        public String name { get; set;}
        public int NombreEtudiant { get; set;}
        public String Type { get; set; }
        public List<Materiel> materiels { get; set; }
        
    }
}
