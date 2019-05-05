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
    public class StudentController : Controller
    {
        private DbContext_Model.HighSchoolManagmentContext _context;
        public StudentController()
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
            var student = _context.Student.ToList();
            return View(student);
        }
        public ActionResult New()
        {
            var grade = _context.Grades.ToList();
            var ciewModel = new StudentViewModel
            {
                grade = grade
            };
            return View(ciewModel);
        }
        public ActionResult Create(StudentViewModel student)
        {
            _context.
                Student.Add(student.student);
            _context.SaveChanges();
            return RedirectToAction("All", "Student");
        }
        public ActionResult Delete(int id)
        {
            var student = _context.Student.SingleOrDefault(c => c.Id == id);
            var res = _context.Student.Remove(student);
            _context.SaveChanges();

            if (student != null)
            {
                return RedirectToAction("All", "Student");
            }
            return RedirectToAction("All", "Student");
        }

    }
}