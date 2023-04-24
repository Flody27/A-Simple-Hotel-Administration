using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Frontend.Models
{
    public class LoginViewModel
    {

        [DisplayName("Usuario")]
        public string UserName { get; set; }
        [DisplayName("Correo electronico")]
        public string Email { get; set; }

        [DisplayName("Contrasena")]
        [DataType(DataType.Password)]
		public string Password { get; set; } 

    }
}
