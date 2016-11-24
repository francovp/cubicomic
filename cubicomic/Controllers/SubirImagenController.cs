using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace cubicomic.Controllers
{
    public class SubirImagenController : Controller
    {
        // GET: SubirImagen
        public ActionResult Index()
        {
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
        public void Subir(IEnumerable<HttpPostedFileBase> file)
        {
            if (file == null) return;
            foreach (var files in file)
            {
                if (files != null && files.ContentLength > 0)
                {
                    string archivo = (DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + files.FileName).ToLower();
                    files.SaveAs(Server.MapPath("~/Uploads/" + archivo));
                }
            }
        }

        [HttpPost]
        public ActionResult SubirPDF(HttpPostedFileBase[] file)
        {
            if (file == null) return null;

            if (file[0] != null) { 
            
                string archivo = (DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + file[0].FileName).ToLower();
                file[0].SaveAs(Server.MapPath("~/Uploads/" + archivo));
            }
            if (file[1] != null)
            {

                string archivo = (DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + file[1].FileName).ToLower();
                file[1].SaveAs(Server.MapPath("~/UploadsPDF/" + archivo));
            }
            return View();
        }
    }
}