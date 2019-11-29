using ebay.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ebay.Controllers
{
    [HandleError]
    public class RegionController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();        
        public ActionResult Index()
        {
            var model = db.Region.ToList();
            return View(model);
        }     
        [Authorize(Roles = "A")]
        public ActionResult DeleteRegion(int id)
        {
            var dep = db.Region.Find(id);
            if (dep==null)
            {
                return RedirectToAction("NotFound", "Security");
            }
            db.Region.Remove(dep);
            db.SaveChanges();
            return RedirectToAction("Index","Region");
        }
        public ActionResult ListTerritories(int id)
        {
            var model = db.Territories.Where(x => x.RegionID == id).ToList();
            return PartialView("ListTerritories",model);
        }
    }
}