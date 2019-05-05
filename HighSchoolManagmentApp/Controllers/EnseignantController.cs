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
    public class EnseignantController : Controller
    {
        private DbContext_Model.HighSchoolManagmentContext _context;
        public EnseignantController()
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
            var enseignants = _context.Enseignant.ToList();

            return View(enseignants);
        }
        public ActionResult New()
        {
            //var emploi = _context.Seance.ToList();
            var subjects = _context.Subject.ToList();
            var viewModel = new EnseignantViewModel
            {
           //     emploi = emploi,
            subjects = subjects
            };
            return View(viewModel);
        }
        public ActionResult Create(EnseignantViewModel ensignant)
        {
            _context.
                Enseignant.Add(ensignant.enseignant);
            _context.SaveChanges();
            return RedirectToAction("All", "Enseignant");
        }
        public ActionResult Delete(int id)
        {
            var enseignant = _context.Enseignant.SingleOrDefault(c => c.Id == id);
            var res = _context.Enseignant.Remove(enseignant);
            _context.SaveChanges();

            if (enseignant != null)
            {
                return RedirectToAction("All", "Enseignant");
            }
            return RedirectToAction("All", "Enseignant");
        }

    }
}