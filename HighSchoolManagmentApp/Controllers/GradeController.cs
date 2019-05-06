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
namespace HighSchoolManagmentApp.Controllers
{

    public class GradeController : Controller
    {
        private DbContext_Model.HighSchoolManagmentContext _context;
        public GradeController()
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
            var grades = _context.Grades.ToList();
            return View(grades);
        }
        public ActionResult New()
        {
            return View();
        }
        public ActionResult Create(Grade grade)
        {
            _context.
                Grades.Add(grade);
            _context.SaveChanges();
            return RedirectToAction("All", "Grade");
        }
        public ActionResult Delete(int id)
        {
            var grade = _context.Grades.SingleOrDefault(c => c.Id == id);
            var res = _context.Grades.Remove(grade);
            _context.SaveChanges();

            if (grade == null)
            {
                return RedirectToAction("All", "Grade");
            }
            return RedirectToAction("All", "Grade");
        }
        public ActionResult emploi(int id)
        {
            var student = _context.Seance;
            if (student == null)
            {
                return RedirectToAction("All", "Absence");
            }
            return View(student);
        }
        public ActionResult subject(int id)
        {
            var seance = _context.Subject;
            if (seance == null)
            {
                return RedirectToAction("All", "Absence");
            }
            return View(seance);
        }

    }
}