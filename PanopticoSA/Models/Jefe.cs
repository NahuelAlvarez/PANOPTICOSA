using System;
using System.Collections.Generic;

namespace PanopticoSA.Models
{
    public partial class Jefe
    {
        public Jefe()
        {
            Area = new HashSet<Area>();
            Presupuesto = new HashSet<Presupuesto>();
        }

        public int IdJefe { get; set; }
        public int IdEmpleado { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Area> Area { get; set; }
        public virtual ICollection<Presupuesto> Presupuesto { get; set; }
    }
}
