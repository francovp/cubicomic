using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Web.Mvc;

namespace cubicomic.Controllers
{
    public class LectorComicController : Controller
    {
        // GET: LectorComic
        public ActionResult Index(String busqueda)
        {
            String nuevo = null;
            ViewBag.Ruta = busqueda;
            ArrayList comic = new ArrayList();
            var carpeta = Server.MapPath("~") + @"UploadsComic/" + busqueda;
            //Necesitas: using System.IO; para realizar esto
            DirectoryInfo d = new DirectoryInfo(carpeta);
            FileInfo[] Files = d.GetFiles("*.*");
            //Recorremos la carpeta
            foreach (FileInfo file in Files)
            {
                 comic.Add(file.Name);
            }
            ViewBag.comic = comic;
            return View();
        }

        
    }
}
