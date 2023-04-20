using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Frontend.Models
{
    public class UsuarioViewModel
    {

        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        /*
        [DisplayName("ID")]
        public int UsrId { get; set; }
        [DisplayName("Nombre")]
        public string? UsrNombre { get; set; }
        [DisplayName("Apellido")]
        public string? UsrApellido { get; set; }
        [DisplayName("Correo")]
        public string? UsrEmail { get; set; }
        [DisplayName("Contraseña")]
        public string? UsrPassword { get; set; }
        [DisplayName("Rol")]
        public int? UsrRolId { get; set; }
        public IEnumerable<RolViewModel> Roles { get; set; }
        [DisplayName("Membresia")]
        public int? UsrMbrId { get; set; }
        public IEnumerable<MembresiaViewModel> Membresias { get; set; }
        */

    }
}
