using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Membresia
    {
        public Membresia()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int MbrId { get; set; }
        public string? MbrNombre { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
