using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class BuscarHabitacionesDisponibles
    {
        public int? CantCamas { get; set; }
        public DateTime? Entrada { get; set; }
        public DateTime? Salida { get; set; }
    }
}
