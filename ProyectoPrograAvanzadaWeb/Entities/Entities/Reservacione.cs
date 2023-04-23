using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Reservacione
    {
        public Reservacione()
        {
            ServiciosReservaciones = new HashSet<ServiciosReservacione>();
        }

        public int RsvId { get; set; }
        public string? RsvUsrId { get; set; }
        public int? RsvHabId { get; set; }
        public DateTime? RsvFechaEntrada { get; set; }
        public DateTime? RsvFechaSalida { get; set; }
        public double? RsvPrecioFinal { get; set; }

        public virtual Habitacione? RsvHab { get; set; }
        //public virtual Usuario? RsvUsr { get; set; }
        public virtual ICollection<ServiciosReservacione> ServiciosReservaciones { get; set; }
    }
}
