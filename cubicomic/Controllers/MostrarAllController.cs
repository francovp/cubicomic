using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Diagnostics;


namespace cubicomic.Controllers
{
    public class MostrarAllController : Controller
    {
        private string uploadsPath = "/Uploads";

        // GET: MostrarAll

        public ActionResult Index()
        {
            //busca imagenes
            List<string> listaRutaImagenes = new List<string>();
            var carpeta = Server.MapPath(uploadsPath);
            //Necesitas: using System.IO; para realizar esto
            DirectoryInfo d = new DirectoryInfo(carpeta);
            //Obtenemos todos los .jpg
            FileInfo[] Files = d.GetFiles("*image*");
            //Recorremos la carpeta
            foreach (FileInfo file in Files)
            {
                listaRutaImagenes.Add(file.Name);
            }
            ViewBag.lista = listaRutaImagenes;

            //Busca PDF
            List<string> listaRutaPDF = new List<string>();
            var carpetaPDF = Server.MapPath(uploadsPath);
            //Necesitas: using System.IO; para realizar esto
            DirectoryInfo de = new DirectoryInfo(carpetaPDF);
            //Obtenemos todos los .jpg con pdf adjunto
            FileInfo[] Filess = de.GetFiles("*pdf*");
            //Recorremos la carpeta

            foreach (FileInfo file in Filess)
            {
                listaRutaPDF.Add(file.Name);
            }
            ViewBag.muestraPDF = listaRutaPDF;

            // busca comic
            List<string> listaRutaComic = new List<string>();
            var carpetaComic = Server.MapPath(uploadsPath);
            //Necesitas: using System.IO; para realizar esto
            DirectoryInfo dec = new DirectoryInfo(carpetaComic);
            //Obtenemos todos los .jpg con pdf adjunto
            FileInfo[] Files3 = dec.GetFiles("*-comic-*");
            //Recorremos la carpeta

            foreach (FileInfo file in Files3)
            {
                listaRutaComic.Add(file.Name);
            }
            ViewBag.muestraComic = listaRutaComic;
            return View();
        }

        public PartialViewResult _ImagenesAllPartial()
        {
            //busca imagenes
            List<string> listaRutaImagenes = new List<string>();
            var carpeta = Server.MapPath(uploadsPath);
            //Necesitas: using System.IO; para realizar esto
            DirectoryInfo d = new DirectoryInfo(carpeta);
            //Obtenemos todos los .jpg
            FileInfo[] Files = d.GetFiles("*image*");
            //Recorremos la carpeta
            foreach (FileInfo file in Files)
            {
                listaRutaImagenes.Add(file.Name);
            }
            ViewBag.lista = listaRutaImagenes;

            //busca PDF
            List<string> listaRutaPDF = new List<string>();
            var carpetaPDF = Server.MapPath(uploadsPath);
            //Necesitas: using System.IO; para realizar esto
            DirectoryInfo de = new DirectoryInfo(carpetaPDF);
            //Obtenemos todos los .jpg con pdf adjunto
            FileInfo[] Filess = de.GetFiles("*pdf*");
            //Recorremos la carpeta

            foreach (FileInfo file in Filess)
            {
                listaRutaPDF.Add(file.Name);
            }
            ViewBag.muestraPDF = listaRutaPDF;

            //buscar comic

            // busca comic
            List<string> listaRutaComic = new List<string>();
            var carpetaComic = Server.MapPath(uploadsPath);
            //Necesitas: using System.IO; para realizar esto
            DirectoryInfo dec = new DirectoryInfo(carpetaComic);
            //Obtenemos todos los .jpg con pdf adjunto
            FileInfo[] Files3 = dec.GetFiles("*-comic-*");
            //Recorremos la carpeta

            foreach (FileInfo file in Files3)
            {
                listaRutaComic.Add(file.Name);
            }
            ViewBag.muestraComic = listaRutaComic;

            return PartialView();
        }


        public PartialViewResult _ImagenesPartial(string id)
        {
            List<string> listaRutaImagenes = new List<string>();
            var carpeta = Server.MapPath(uploadsPath);
            //Necesitas: using System.IO; para realizar esto
            DirectoryInfo da = new DirectoryInfo(carpeta);
            //Obtenemos todos los .jpg
            FileInfo[] Files = da.GetFiles("*--."+ @id +".--image*");
            //Recorremos la carpeta
            foreach (FileInfo file in Files)
            {
                listaRutaImagenes.Add(file.Name);
            }
            ViewBag.lista = listaRutaImagenes;
            return PartialView();
        }

        public PartialViewResult _NovelasPartial(string id)
        {
            List<string> listaRutaPDF = new List<string>();
            var carpetaPDF = Server.MapPath(uploadsPath);
            //Necesitas: using System.IO; para realizar esto
            DirectoryInfo de = new DirectoryInfo(carpetaPDF);
            //Obtenemos todos los .jpg con pdf adjunto
            FileInfo[] Filess = de.GetFiles("*pdf*");
            //Recorremos la carpeta

            foreach (FileInfo file in Filess)
            {
                listaRutaPDF.Add(file.Name);
            }
            ViewBag.muestraPDF = listaRutaPDF;
            return PartialView();
        }
    }
}