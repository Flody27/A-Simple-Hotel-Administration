using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Keyless]
    public class sp_BuscarHabitacionesDisponibles
    {
        public int HabId { get; set; }
        public int? HabNumPuerta { get; set; }
        public int? HabCantCamas { get; set; }
        public int? HabCantBannos { get; set; }
        public double? HabPrecioPorNoche { get; set; }
        public bool? HabActiva { get; set; }
    }
}
