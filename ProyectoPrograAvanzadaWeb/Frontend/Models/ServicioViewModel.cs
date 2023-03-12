using System.ComponentModel;

namespace Frontend.Models
{
    public class ServicioViewModel
    {
        [DisplayName("Servicio ID")]
        public int SvcId { get; set; }
        [DisplayName("Descripcion de Servicio")]
        public string? SvcDescripcion { get; set; }
        [DisplayName("Precio de Servicio")]
        public double? SvcPrecio { get; set; }
    }
}
