using System.ComponentModel;

namespace Frontend.Models
{
    public class ReservacionUsuarioViewModel
    {
        [DisplayName("ID Reservacion")]
        public int RsvId { get; set; }
        [DisplayName("Numero de Puerta")]
        public int? RsvPuertaHab { get; set; }
        [DisplayName("Fecha Entrada")]
        public DateTime? RsvFechaEntrada { get; set; }
        [DisplayName("Fecha Salida")]
        public DateTime? RsvFechaSalida { get; set; }
        [DisplayName("Precio Final")]
        public double? RsvPrecioFinal { get; set; }
    }
}
