using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cubicomic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Que Somos";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Direcciones de contacto.";

            return View();
        }
    }
}