using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HighSchoolManagmentApp.Models;
using System.Data.Odbc;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using HighSchoolManagmentApp.ViewModel;

namespace HighSchoolManagmentApp.Controllers
{
    public class AbsenceController : Controller
    {
        private DbContext_Model.HighSchoolManagmentContext _context;
        public AbsenceController()
        {
            var optionsBuilder = new DbContextOptionsBuilder<DbContext_Model.HighSchoolManagmentContext>();
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=HighSchoolManagment;Trusted_Connection=True;ConnectRetryCount=0");
            _context = new DbContext_Model.HighSchoolManagmentContext(optionsBuilder.Options);

        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public IActionResult All()
        {
            var absences = _context.Absence.ToList();
            return View(absences);
        }
        public ActionResult New()
        {
            var student = _context.Student.ToList();
            var seance = _context.Seance.ToList();
            var viewModel = new AbsenceSeanceviewModel
            {
                student =student,
                seance = seance
        };
            return View(viewModel);
            }
        [HttpPost]
        public ActionResult Create(Absence absence )
        {
            _context. 
                Absence.Add(absence);
            _context.SaveChanges(); 
            return RedirectToAction("All","Absence");
        }

        public ActionResult Delete(int id)
        {   
            var absnece = _context.Absence.SingleOrDefault(c=> c.id==id);
            var res= _context.Absence.Remove(absnece);
            _context.SaveChanges();

            if ( absnece!= null)
            {
                return RedirectToAction("All", "Absence");
            }
            return RedirectToAction("All", "Absence");
        }
        public ActionResult student(int id)
        {
            var student = _context.Student.SingleOrDefault(c => c.Id == id);
            if (student == null)
            {
                return RedirectToAction("All", "Absence");
            }
            return View(student);
        }
        public ActionResult seance(int id)
        {
            var seance = _context.Seance.SingleOrDefault(c => c.Id == id);
            if (seance == null)
            {
                return RedirectToAction("All", "Absence");
            }
            return View(seance);
        }
    }
}