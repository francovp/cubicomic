using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Diagnostics;

namespace cubicomic.Controllers
{
    public class MostrarPDFController : Controller
    {
        // GET: MostrarPDF
        public ActionResult Index(String busqueda)
        {
            String nuevo = null;
             nuevo = busqueda.Replace(".jpg", ".pdf").Replace(".png", ".pdf");
            
            List<string> PDF = new List<string>();
            var carpeta = Server.MapPath("~") + @"UploadsPDF";
            //Necesitas: using System.IO; para realizar esto
            DirectoryInfo d = new DirectoryInfo(carpeta);
            FileInfo[] Files = d.GetFiles("*.PDF");
            //Recorremos la carpeta
            foreach (FileInfo file in Files)
            {
                if(file.Name.Equals(nuevo))
                PDF.Add(file.Name);
            }
            ViewBag.PDF = PDF;
            return View();
        }
    }
}