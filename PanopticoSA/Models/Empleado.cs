using System;
using System.Collections.Generic;

namespace PanopticoSA.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            Tecnico = new HashSet<Tecnico>();
        }

        public int IdEmpleado { get; set; }
        public decimal? Sueldo { get; set; }
        public int IdPersona { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; }
        public virtual ICollection<Tecnico> Tecnico { get; set; }
    }
}
