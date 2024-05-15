using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProtoDEV___Proyecto_Programacion.Models
{
    public class ApplicationUser:IdentityUser
    {

        [Required]
        public string nombre { get; set;}

        [DisplayName("Dirección")]
        public string? direccionCalle {get; set;}

        [DisplayName("Ciudad")]
        public string? ciudad { get; set;}

        [DisplayName("Provincia")]
        public string? provincia { get; set; }

        [DisplayName("Código Postal")]
        public string? codigoPostal { get; set; }

    }
}
