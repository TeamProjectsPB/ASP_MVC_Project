using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalOgloszeniowy.Controllers
{
    public class AdvertismentController : Controller
    {
        // GET: Advertisment
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}