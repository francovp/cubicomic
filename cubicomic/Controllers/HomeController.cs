using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cubicomic.DAL;

namespace cubicomic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var context = new ApplicationDbContext();
            var users = context.Users.ToList();
            ViewBag.usuarios = users;
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