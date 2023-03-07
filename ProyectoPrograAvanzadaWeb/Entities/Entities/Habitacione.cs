using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Habitacione
    {
        public Habitacione()
        {
            Reservaciones = new HashSet<Reservacione>();
        }

        public int HabId { get; set; }
        public int? HabNumPuerta { get; set; }
        public int? HabCantCamas { get; set; }
        public int? HabCantBannos { get; set; }
        public double? HabPrecioPorNoche { get; set; }
        public bool? HabActiva { get; set; }

        public virtual ICollection<Reservacione> Reservaciones { get; set; }
    }
}
