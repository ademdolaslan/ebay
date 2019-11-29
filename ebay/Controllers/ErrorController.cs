using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ebay.Controllers
{
    [AllowAnonymous]
    [HandleError]
    public class ErrorController : Controller
    {
        public ActionResult Unauthorized()
        {
            ViewBag.ErrorMessage = "Sanırım Ne Yapmak İstiyorsan Bunu Yapmana İzin Verilmemiş..";
            return View("Error");
        }
        public ActionResult Forbidden()
        {
            ViewBag.ErrorMessage = "Sanırım Yasaklı Yerlerdesin..";
            return View("Error");
        }
        public ActionResult Notfound()
        {
            ViewBag.ErrorMessage = "Sanırım Aradığın Sayfa Thanos Parmak Şıklatmasından Kurtulamamış..";
            return View("Error");
        }
        public ActionResult MethodNotAllowed()
        {
            
            ViewBag.ErrorMessage = "Sanırım Bunu Bu Şekilde Yapmana İzin Verilmiyor..";
            return View("Error");
        }
        public ActionResult NotAcceptable()
        {
            ViewBag.ErrorMessage = "Sanırım Kabul Edilemez Bir Davranış İçerisindesin..";
            return View("Error");
        }
        public ActionResult PreconditionFailed()
        {
            ViewBag.ErrorMessage = "Sanırım Ön Koşulun Başarısız Oldu..";
            return View("Error");
        }
        public ActionResult InternalServerError()
        {
            ViewBag.ErrorMessage = "Sanırım İç Sunucu Hatası Gerçekleşti..";
            return View("Error");
        }
        public ActionResult NotImplemented()
        {
            ViewBag.ErrorMessage = "Sanırım Uygulanmadı..";
            return View("Error");
        }
        public ActionResult BadGateway()
        {
            ViewBag.ErrorMessage = "Sanırım Kötü Ağ Geçidine Yakalandın İyi Uçuşlar Dilerim..";
            return View("Error");
        }
    }
}