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

        public void Subir(HttpPostedFileBase file)
        {
            // Nombre de la imagen
            string nombre = file.FileName.Substring(
              0, file.FileName.LastIndexOf("."));
            // Extensión del archivo
            string ext = nombre.Substring(nombre.LastIndexOf(".") + 1);
            // Tipo de contenido
            byte[] imagen = new byte[file.InputStream.Length];
            file.InputStream.Read(imagen, 0, imagen.Length);
            // Se insertan los valores en la base de datos
            SqlConnection cnx = GetConnection();
            try
            {
                cnx.Open();
                SqlCommand cmd = cnx.CreateCommand();
                cmd.CommandText =
                  "INSERT INTO Imagenes (nombre, imagen, extension) " +
                  "VALUES (@nombre, @imagen, @ext)";
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@imagen", imagen);
                cmd.Parameters.AddWithValue("@ext", ext);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx != null)
                {
                    if (cnx.State == ConnectionState.Open)
                        cnx.Close();
                    cnx.Dispose();
                }
            }
        }
    }


}