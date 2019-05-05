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
    public class MaterialController : Controller
    {
        private DbContext_Model.HighSchoolManagmentContext _context;
        public MaterialController()
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
            var materiels = _context.Materiels.ToList();
            return View(materiels);
        }
        public ActionResult New()
        {
            return View();
        }
        public ActionResult Create(Materiel materiel)
        {
            _context.
                Materiels.Add(materiel);
            _context.SaveChanges();
            return RedirectToAction("All", "Material");
        }
        public ActionResult Delete(int id)
        {
            var materiel = _context.Materiels.SingleOrDefault(c => c.Id == id);
            var res = _context.Materiels.Remove(materiel);
            _context.SaveChanges();

            if (materiel != null)
            {
                return RedirectToAction("All", "Material");
            }
            return RedirectToAction("All", "Material");
        }
    }
}