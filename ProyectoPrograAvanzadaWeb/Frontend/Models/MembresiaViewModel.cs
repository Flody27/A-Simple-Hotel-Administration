using System.ComponentModel;

namespace Frontend.Models
{
    public class MembresiaViewModel
    {
        [DisplayName("Membresia ID")]
        public int MbrId { get; set; }
        [DisplayName("Nombre de membresia")]
        public string? MbrNombre { get; set; }
        
    }
}
