

using System.ComponentModel;

namespace Frontend.Models
{
    public class HabitacionViewModel
    {
        [DisplayName("Habitacion Id")]
        public int HabId { get; set; }
        [DisplayName("Numero de habitacion")]
        public int? HabNumPuerta { get; set; }
        [DisplayName("Cantidad de camas")]
        public int? HabCantCamas { get; set; }
        [DisplayName("Cantidad de baños")]
        public int? HabCantBannos { get; set; }
        [DisplayName("Precio pir noche")]
        public double? HabPrecioPorNoche { get; set; }
        [DisplayName("Disponible")]
        public bool? HabActiva { get; set; }
    }
}
