using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace cubicomic.Controllers
{
    public class MostrarAllController : Controller
    {
        // GET: MostrarAll
        public ActionResult Index()
        {

            List<string> listaRutaImagenes = new List<string>();
            var carpeta = Server.MapPath("~") + @"Uploads";
            //Necesitas: using System.IO; para realizar esto
            DirectoryInfo d = new DirectoryInfo(carpeta);
            //Obtenemos todos los .jpg
            FileInfo[] Files = d.GetFiles("*.jpg");
            //Recorremos la carpeta
            foreach (FileInfo file in Files)
            {
                listaRutaImagenes.Add(file.Name);
            }
            ViewBag.lista = listaRutaImagenes;
            return View();
        }
    }
}