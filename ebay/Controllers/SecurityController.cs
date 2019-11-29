using ebay.Models;
using ebay.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ebay.Controllers
{
    [HandleError]
    [AllowAnonymous]
    public class SecurityController : Controller
    {
        //public static string _contactName = "";       
        NorthwindEntities db = new NorthwindEntities();      
        
        
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]        
        public ActionResult Login(Customers c)
        {           
            if (c.UserName!=null && c.Password!=null)
            {
                var user = db.Customers.FirstOrDefault(x => x.UserName == c.UserName && x.Password == c.Password);
                if (user != null)
                {
                    //_contactName = " - "+user.ContactName;                                     
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    return RedirectToAction("Home", "Default");
                }
                else
                {
                    ViewBag.Mesaj = "Geçersiz Kullanıcı Adı Veya Şifre!!";
                    return View();
                }
            }
            ViewBag.Mesaj = "Lütfen Kullanıcı Adınızı ve Şifrenizi Giriniz!";
            return View();
            
            
        }

        public ActionResult Logout()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        public ActionResult SifremiUnuttum()
        {

            return View();
        }
        public string contactName()
        {
            var s = db.Customers.Where(x => x.UserName == User.Identity.Name).FirstOrDefault();
            if (s!=null)
            {
                return " - "+s.ContactName.ToString();
            }
            return "";
        }
    }
}