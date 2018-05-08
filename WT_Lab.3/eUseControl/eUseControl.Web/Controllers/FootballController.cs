using eUseControl.BusinessLogic.DBModel;
using eUseControl.Web.Models;
using System;
using System.Collections.Generic; 
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.Web.Controllers
{
    public class FootballController : Controller
    {
        private ProductDbContext _db;

        public FootballController()
        {
            _db = new ProductDbContext();
        }

        // GET: Football
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string SearchString)
        {
            var products = _db.Products.Include(m => m.Brand);

            if (!String.IsNullOrEmpty(SearchString))
            {
                products = products.Where(s => s.Name.Contains(SearchString));
            }

            return View(products);
        }

        public ActionResult Price(string price)
        {
            if(price == "All")
            {
                var productDb = _db.Products.Include(m => m.Brand);
                return View("Details", productDb);
            }
            else
            {
                if(price == "Low")
                {
                    var productDb = _db.Products.Where(m => m.Price <= 15).Include(m => m.Brand);
                    return View("Details", productDb);
                }

                else
                {
                    var productDb = _db.Products.Where(m => m.Price > 15).Include(m => m.Brand);
                    return View("Details", productDb);
                }
                
            }
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
    }
}