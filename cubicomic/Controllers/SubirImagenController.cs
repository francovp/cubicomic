using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using cubicomic.Models;

namespace cubicomic.Controllers
{
    public class SubirImagenController : Controller
    {
        ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());

        // GET: SubirImagen
        public ActionResult Index()
        {
            ViewBag.Error = TempData["error"];
            return View();
        }

        public ActionResult PDF()
        {
            return View();
        }
        
        public ActionResult Comic()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Subir(IEnumerable<HttpPostedFileBase> file)
        {
            if (file == null) return RedirectToAction("Index", "SubirImagen"); ;
            Directory.CreateDirectory(Server.MapPath("~/Uploads/" + user.UserName + "/"));
            foreach (var files in file)
            {
                if (files != null && files.ContentLength > 0)
                {
                    string archivo = (DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + files.FileName).ToLower();
                    files.SaveAs(Server.MapPath("~/Uploads/" + user.UserName + "/" + archivo));
                    return RedirectToAction("Index", "SubirImagen");
                }
            }
            return RedirectToAction("Index", "SubirImagen");
        }

        [HttpPost]
        public ActionResult SubirPDF(HttpPostedFileBase[] file)
        {
            string fileExt = Path.GetExtension(file[0].FileName).ToLower();
            string fileName = Path.GetFileName(file[0].FileName);
            if (file == null )
            {
                ViewBag.Error = TempData["Error el Archivo no fue Subido exitosamente"];
                return RedirectToAction("Index", "SubirImagen");
            }
            if (file[0] != null && (fileExt == ".png" || fileExt == ".jpg"))
            {
               
                string fileExt2 = Path.GetExtension(file[1].FileName).ToLower();
                string fileName2 = Path.GetFileName(file[1].FileName);
                string archivo = ("pdf" + file[0].FileName).ToLower();

                if (file[1] != null && fileExt2 == ".pdf")
                {
                    string archivo2 = ("pdf" + file[0].FileName).ToLower();
                    String nuevo = null;
                    nuevo = archivo2.Replace(".jpg", ".pdf").Replace(".png", ".pdf");
                    file[0].SaveAs(Server.MapPath("~/Uploads/" + archivo));
                    file[1].SaveAs(Server.MapPath("~/UploadsPDF/" + nuevo));
                    
                    return RedirectToAction("Index", "SubirImagen");
                }
            }
            ViewBag.Error = TempData["error"];
            return RedirectToAction("Index", "SubirImagen");
        }

        public ActionResult SubirComic(IEnumerable<HttpPostedFileBase> comic, HttpPostedFileBase[] portada)
        {
          
            string fileExt = Path.GetExtension(portada[0].FileName).ToLower();
            string fileName = Path.GetFileName(portada[0].FileName);
            if (portada != null && (fileExt == ".png" || fileExt == ".jpg"))
            {
               
                string archivoP = ("comic" + portada[0].FileName).ToLower();
                Directory.CreateDirectory(Server.MapPath("~/UploadsComic/" + user.UserName + "/" + archivoP));
                if (comic != null)
                {
                    foreach (var files in comic)
                    {
                        string fileExt2 = Path.GetExtension(files.FileName).ToLower();
                        string fileName2 = Path.GetFileName(files.FileName);
                        if (files != null && files.ContentLength > 0 && (fileExt2 == ".png" || fileExt2 == ".jpg"))
                        {
                            string archivo = (files.FileName).ToLower();
                            files.SaveAs(Server.MapPath("~/UploadsComic/" + user.UserName + "/" + archivoP + "/" + archivo));
                        }
                    }
                    portada[0].SaveAs(Server.MapPath("~/Uploads/" + archivoP));
                    return RedirectToAction("Index", "SubirImagen");
                }
            }
            return RedirectToAction("Index", "SubirImagen");
        }
    }
}