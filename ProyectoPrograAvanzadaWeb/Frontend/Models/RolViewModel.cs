using System.ComponentModel;

namespace Frontend.Models
{
    public class RolViewModel
    {
        [DisplayName("Rol ID")]
        public int RolId { get; set; }
        [DisplayName("Descripcion de rol")]
        public string? RolDescripcion { get; set; }
        
    }
}
