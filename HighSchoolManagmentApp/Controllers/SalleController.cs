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
    public class SalleController : Controller
    {
       private DbContext_Model.HighSchoolManagmentContext _context;
        public SalleController()
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
            var salle = _context.Salle.ToList();
            
            return View(salle);
        }

        public ActionResult New()
        {
            var materiel = _context.Materiels.ToList();
            var viewModel = new SalleViewModel
            {
                materiel = materiel
            };
            return View(viewModel);
        }
        public ActionResult Create(Salle salle)
        {
            _context.
                Salle.Add(salle);
            _context.SaveChanges();
            return RedirectToAction("All", "Salle");
        }
        public ActionResult Delete(int id)
        {
            var salle = _context.Salle.SingleOrDefault(c => c.Id == id);
            var res = _context.Salle.Remove(salle);
            _context.SaveChanges();

            if (salle != null)
            {
                return RedirectToAction("All", "Salle");
            }
            return RedirectToAction("All", "Salle");
        }
        public ActionResult materiel(int id)
        {
            var seance = _context.Materiels;
            if (seance == null)
            {
                return RedirectToAction("All", "Absence");
            }
            return View(seance);
        }

    }
}