using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Usuario
    {

        public int UsrId { get; set; }
        public string? UsrNombre { get; set; }
        public string? UsrApellido { get; set; }
        public string? UsrEmail { get; set; }
        public string? UsrPassword { get; set; }
        public int? UsrRolId { get; set; }
        public int? UsrMbrId { get; set; }

        public virtual Membresia? UsrMbr { get; set; }
        public virtual Role? UsrRol { get; set; }
        //public virtual ICollection<Reservacione> Reservaciones { get; set; }
    }
}
