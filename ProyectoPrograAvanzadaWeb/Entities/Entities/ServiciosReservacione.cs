using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class ServiciosReservacione
    {
        public int SrId { get; set; }
        public int? SrRsvId { get; set; }
        public int? SrSvcId { get; set; }

        public virtual Reservacione? SrRsv { get; set; }
        public virtual Servicio? SrSvc { get; set; }
    }
}
