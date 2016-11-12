using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace cubicomic.Controllers
{
    public class MostrarPDFController : Controller
    {
        // GET: MostrarPDF
        public ActionResult Index()
        {

            List<string> PDF = new List<string>();
            var carpeta = Server.MapPath("~") + @"Uploads";
            //Necesitas: using System.IO; para realizar esto
            DirectoryInfo d = new DirectoryInfo(carpeta);
            //Obtenemos todos los .jpg
            FileInfo[] Files = d.GetFiles("*.PDF");
            //Recorremos la carpeta
            foreach (FileInfo file in Files)
            {
                PDF.Add(file.Name);
            }
            ViewBag.PDF = PDF;
            return View();
        }
    }
}