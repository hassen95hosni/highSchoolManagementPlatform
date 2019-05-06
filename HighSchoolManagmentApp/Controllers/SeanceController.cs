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
    public class SeanceController : Controller
    {
        private DbContext_Model.HighSchoolManagmentContext _context;
        public SeanceController()
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
            var seances = _context.Seance.ToList();
            return View(seances);
        }
        public ActionResult New()
        {
            var enseignant = _context.Enseignant.ToList();
            var subject = _context.Subject.ToList();
            var salle = _context.Salle.ToList();
            var veiwModel = new SeanceViewModel
            {
                enseignant = enseignant,
                subject = subject,
                salle = salle
            };
            return View(veiwModel);
        }
        public ActionResult Create(Seance seance)
        {
            _context.
                Seance.Add(seance);
            _context.SaveChanges();
            return RedirectToAction("All", "Seance");
        }
        public ActionResult Delete(int id)
        {
            var seance = _context.Seance.SingleOrDefault(c => c.Id == id);
            var res = _context.Seance.Remove(seance);
            _context.SaveChanges();

            if (seance != null)
            {
                return RedirectToAction("All", "Seance");
            }

            return RedirectToAction("All", "Seance");
        }

        public ActionResult subject(int id)
        {
            var student = _context.Subject.SingleOrDefault(c => c.Id == id);
            if (student == null)
            {
                return RedirectToAction("All", "Seance");
            }
            return View(student);
        }
        public ActionResult salle(int id)
        {
            var seance = _context.Salle.SingleOrDefault(c => c.Id == id);
            if (seance == null)
            {
                return RedirectToAction("All", "Seance");
            }
            return View(seance);
        }
       
        public ActionResult enseignant(int id)
        {
            var seance = _context.Enseignant.SingleOrDefault(c => c.Id == id);
            if (seance == null)
            {
                return RedirectToAction("All", "Absence");
            }
            return View(seance);
        }
    }
}