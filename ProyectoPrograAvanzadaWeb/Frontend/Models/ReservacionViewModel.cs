using System.ComponentModel;

namespace Frontend.Models
{
    public class ReservacionViewModel
    {
        [DisplayName("Reservacion ID")]
        public int RsvId { get; set; }
        [DisplayName("ID Usuario de Reservacion")]
        public string? RsvUsrId { get; set; }
        public IEnumerable<UsuarioViewModel> Usuarios { get; set; }

        [DisplayName("ID Habitacion reservada")]
        public int? RsvHabId { get; set; }
        public IEnumerable<HabitacionViewModel> Habitaciones { get; set; }

        [DisplayName("Fecha de Entrada")]
        public DateTime? RsvFechaEntrada { get; set; }
        [DisplayName("Fecha de Salida")]
        public DateTime? RsvFechaSalida { get; set; }
        [DisplayName("Precio final")]
        public double? RsvPrecioFinal { get; set; }
    }
}
