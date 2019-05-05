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
    public class SubjectController : Controller
    {
        private DbContext_Model.HighSchoolManagmentContext _context;
        public SubjectController()
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
            var subject = _context.Subject.ToList();
            return View(subject);
        }
        public ActionResult New() {
            var matriels = _context.Materiels.ToList();
            var veiwModel = new SubjectViewModel
            {
                materiel = matriels
            };
            return View(veiwModel);
        }
        public ActionResult Create(SubjectViewModel subject)
        {
            _context.
                Subject.Add(subject.subject);
            _context.SaveChanges();
            return RedirectToAction("All", "Subject");
        }
        public ActionResult Delete(int id)
        {
            var subject = _context.Subject.SingleOrDefault(c => c.Id == id);
            var res = _context.Subject.Remove(subject);
            _context.SaveChanges();

            if (subject != null)
            {
                return RedirectToAction("All", "Subject");
            }
            return RedirectToAction("All", "Subject");
        }
    }
}