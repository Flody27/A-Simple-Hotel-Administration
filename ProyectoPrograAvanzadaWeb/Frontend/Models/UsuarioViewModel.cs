using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Frontend.Models
{
    public class UsuarioViewModel
    {
        // Completar con lo de las mebresias y roles
        [DisplayName("Usuario ID")]
        public int UsrId { get; set; }
        [DisplayName("Nombre de usuario")]
        public string? UsrNombre { get; set; }
        [DisplayName("Apellido del usuario")]
        public string? UsrApellido { get; set; }
        [DisplayName("Correo del usuario")]
        public string? UsrEmail { get; set; }
        [DisplayName("Contraseña del usuario")]
        public string? UsrPassword { get; set; }
        [DisplayName("Rol del usuario")]
        public int? UsrRolId { get; set; }
        [DisplayName("Membresia del usuario")]
        public int? UsrMbrId { get; set; }
    }
}
