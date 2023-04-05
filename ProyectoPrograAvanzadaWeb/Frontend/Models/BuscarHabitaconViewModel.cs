using Microsoft.Build.Framework;
using System.ComponentModel;

namespace Frontend.Models
{
    public class BuscarHabitaconViewModel
    {
        [DisplayName("Cantidad de camas")]
        [Required]
        public int? CantCamas { get; set; }
        [DisplayName("Fecha de entrada")]
        [Required]
        public DateTime? Entrada { get; set; }
        [DisplayName("Fecha de salida")]
        [Required]
        public DateTime? Salida { get; set; }
    }
}
