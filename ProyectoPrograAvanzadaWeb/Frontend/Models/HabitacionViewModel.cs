using System.ComponentModel;

namespace Frontend.Models
{
    public class HabitacionViewModel
    {
        [DisplayName("Habitacion ID")]
        public int HabId { get; set; }
        [DisplayName("Numero Puerta Habitacion")]
        public int? HabNumPuerta { get; set; }
        [DisplayName("Cantidad de Camas")]
        public int? HabCantCamas { get; set; }
        [DisplayName("Cantidad de Baños")]
        public int? HabCantBannos { get; set; }
        [DisplayName("Precio por Noche")]
        public double? HabPrecioPorNoche { get; set; }
        [DisplayName("Habitacion Activa?")]
        public bool? HabActiva { get; set; }

    }
}
