using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using cubicomic.DAL;

namespace cubicomic.Controllers
{
    public class PerfilController : Controller
    {
        // GET: Perfil
        public ActionResult Index()
        {
            var context = new ApplicationDbContext();
            var users = context.Users.ToList();
            ViewBag.usuarios = users;
            return View();
        }
    }
}