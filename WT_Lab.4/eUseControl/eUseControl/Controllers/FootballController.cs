using eUseControl.BusinessLogic.DBModel;
using eUseControl.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic; 
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.Web.Controllers
{
    [Authorize]
    public class FootballController : Controller
    {
        private ApplicationDbContext _db;

        public FootballController()
        {
            _db = new ApplicationDbContext();
        }

        public Boolean isAdminUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ApplicationDbContext context = new ApplicationDbContext();
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = UserManager.GetRoles(user.GetUserId());
                if (s[0].ToString() == "Admin")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        // GET: Football
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ViewBag.Name = user.Name;
                ViewBag.displayMenu = "No";

                if (isAdminUser())
                {
                    ViewBag.displayMenu = "Yes";
                }
                return View();
            }
            else
            {
                ViewBag.Name = "Not Logged IN";
            }
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