using PortalOgloszeniowy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace PortalOgloszeniowy.Controllers
{
    public class HomeController : Controller
    {
        Entities2 db;

        public HomeController()
        {
            db = new Entities2(); ;
        }

        public ActionResult Index()
        {
            ViewData.Model = db.Category.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Change(String newLanguage)
        {
            if (newLanguage != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(newLanguage);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(newLanguage);
            }
            HttpCookie cookie = new HttpCookie("_language");
            cookie.Value = newLanguage;
            Response.Cookies.Add(cookie);

            //return View("Index");
            return Redirect(HttpContext.Request.UrlReferrer.AbsoluteUri);
        }
    }
}