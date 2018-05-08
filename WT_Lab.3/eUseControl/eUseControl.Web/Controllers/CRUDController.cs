using BusinessLogic.ViewModels;
using eUseControl.BusinessLogic.DBModel;
using eUseControl.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.Web.Controllers
{
    public class CRUDController : Controller
    {
        private ProductDbContext _db;

        public CRUDController()
        {
            _db = new ProductDbContext();        
        }
        
        // GET: CRUD
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var brands = _db.Brands.ToList();
            var model = new ProductFormViewModel()
            {
                Brands = brands
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Save(Product product)
        {
            if(product.Id == 0)
            {
                _db.Products.Add(product);
            }
            else
            {
                var productFromDb = _db.Products.Single(m => m.Id == product.Id);
                productFromDb.Name = product.Name;
                productFromDb.Picture = product.Picture;
                productFromDb.Price = product.Price;
                productFromDb.BrandId = product.BrandId;
            }
            _db.SaveChanges();

            return RedirectToAction("Index","Football");
        }

        public ActionResult ShowAllProducts()
        {
            var model = _db.Products.Include(m => m.Brand).ToList();

            return View(model);
        }

        public ActionResult Update(Product product)
        {
            var brands = _db.Brands.ToList();
            var model = new ProductFormViewModel()
            {
                Product = product,
                Brands = brands
            };

            return View("Create", model);

        }

        public ActionResult Delete(Product product)
        {
            var productFromDb = _db.Products.Find(product.Id);
            _db.Products.Remove(productFromDb);
            _db.SaveChanges();
    
            return RedirectToAction("ShowAllProducts", "CRUD");
        }
    }
}