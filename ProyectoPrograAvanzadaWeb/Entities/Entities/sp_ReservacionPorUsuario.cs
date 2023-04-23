using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Keyless]
    public class sp_ReservacionPorUsuario
    {
        public int RsvId { get; set; }
        public int? RsvPuertaHab { get; set; }
        public DateTime? RsvFechaEntrada { get; set; }
        public DateTime? RsvFechaSalida { get; set; }
        public double? RsvPrecioFinal { get; set; }


    }
}
