using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Servicio
    {
        public Servicio()
        {
            ServiciosReservaciones = new HashSet<ServiciosReservacione>();
        }

        public int SvcId { get; set; }
        public string? SvcDescripcion { get; set; }
        public double? SvcPrecio { get; set; }

        public virtual ICollection<ServiciosReservacione> ServiciosReservaciones { get; set; }
    }
}
