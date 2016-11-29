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
            comic.Sort(new CustomComparer());
            ViewBag.comic = comic;
            return View();
        }

        public class CustomComparer : IComparer
        {
            Comparer _comparer = new Comparer(System.Globalization.CultureInfo.CurrentCulture);

            public int Compare(object x, object y)
            {
                // Convert string comparisons to int
                x = ((string)x).Replace(".jpg", "").Replace(".png", "");
                Debug.Print((string)x);
                y = ((string)y).Replace(".jpg", "").Replace(".png", "");

                return _comparer.Compare(Convert.ToInt32(x), Convert.ToInt32(y));
            }
        }
    }
   }
