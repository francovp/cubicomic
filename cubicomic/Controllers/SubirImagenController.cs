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
    }


}