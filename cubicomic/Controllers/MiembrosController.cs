using System.Web.Mvc;

namespace cubicomic.Controllers
{
    public class MiembrosController : Controller
    {
        // GET: Miembros
        public ActionResult Perfil()
        {
            return View();
        }

        public ActionResult Galeria()
        {
            return View();
        }

        // GET: Miembros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Miembros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Miembros/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Miembros/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Miembros/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Miembros/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Miembros/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}