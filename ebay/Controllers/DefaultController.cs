using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ebay.Controllers
{
    [AllowAnonymous]
    [HandleError]
    public class DefaultController : Controller
    {
        
        public ActionResult Home()
        {
            return View();
        }
    }
}