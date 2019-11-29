using System;
using System.Collections.Generic;

namespace PanopticoSA.Models
{
    public partial class Tecnico
    {
        public Tecnico()
        {
            ServicioTecnico = new HashSet<ServicioTecnico>();
        }

        public int IdTecnico { get; set; }
        public int IdEmpleado { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual ICollection<ServicioTecnico> ServicioTecnico { get; set; }
    }
}
