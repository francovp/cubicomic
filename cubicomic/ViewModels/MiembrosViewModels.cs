using cubicomic.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace cubicomic.ViewModels
{
    public class PerfilViewModel
    {
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [Display(Name = "Nombre Completo")]
        public string CompleteName { get; set; }

        [Display(Name = "Nombre de usuario")]
        public string UserName { get; set; }

        [EmailAddress]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "Avatar")]
        public File Avatar { get; set; }
    }
}
