using ebay.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ebay.ViewModels;
using System.Drawing;
using System.Net.Mime;

namespace ebay.Controllers
{
    [HandleError]
    public class ProductController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        [AllowAnonymous]
        public ActionResult Index()
        {
            var model = db.Products.Include(a => a.Suppliers).Include(b => b.Categories).ToList();
            return View(model);
        }
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "A")]
        public ActionResult ApplyProduct(ProductFormViewModel p)
        {
            if (!ModelState.IsValid)
            {
                var model = new ProductFormViewModel() {
                    _Categories = db.Categories.ToList(),
                    _Suppliers = db.Suppliers.ToList(),
                    _Products=p._Products              
                };
                return View("ProductForm",model);
            }
            if (p._Products.ProductID==0) // ekleme işlemi
            {
                db.Products.Add(p._Products);
            }
            else
            {
                db.Entry(p._Products).State = EntityState.Modified;
            }
            db.SaveChanges();
            return RedirectToAction("Index");            
        }
        [Authorize(Roles ="A")]
        public ActionResult NewProduct()
        {
            var model = new ProductFormViewModel()
            {
                _Suppliers = db.Suppliers.ToList(),
                _Categories = db.Categories.ToList(),
                _Products= new Products()
            };
            return View("ProductForm", model);
        }
        [Authorize(Roles = "A")]
        public ActionResult UpdateProduct(int id)
        {
            var model = new ProductFormViewModel()
            {
                _Categories = db.Categories.ToList(),
                _Suppliers = db.Suppliers.ToList(),
                _Products = db.Products.Find(id)
            };                        
            return View("ProductForm",model);
        }
        [Authorize(Roles = "A")]
        public ActionResult DeleteProduct(int id)
        {
            var ss = db.Products.Find(id);
            if (ss==null)
            {
                return RedirectToAction("NotFound", "Security");
            }
            db.Products.Remove(ss);
            db.SaveChanges();
            return RedirectToAction("Index", "Product");
        }
        public ActionResult GetImage()
        {
            var model = db.Categories.ToList();     
            return View(model);
        }
        public FileContentResult ShowImage(int id)
        {
            return File(db.Categories.First(m => m.CategoryID == id).Picture, MediaTypeNames.Image.Jpeg);            
        }
    }
}