using System.ComponentModel;

namespace Frontend.Models
{
    public class ReservacionViewModel
    {
        [DisplayName("Reservacion ID")]
        public int RsvId { get; set; }
        [DisplayName("ID Usuario de Reservacion")]
        public int? RsvUsrId { get; set; }
        [DisplayName("ID Habitacion reservada")]
        public int? RsvHabId { get; set; }
        [DisplayName("Fecha de Entrada")]
        public DateTime? RsvFechaEntrada { get; set; }
        [DisplayName("Fecha de Salida")]
        public DateTime? RsvFechaSalida { get; set; }
        [DisplayName("Precio final")]
        public double? RsvPrecioFinal { get; set; }
    }
}
