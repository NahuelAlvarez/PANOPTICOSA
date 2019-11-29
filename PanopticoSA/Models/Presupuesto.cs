using System;
using System.Collections.Generic;

namespace PanopticoSA.Models
{
    public partial class Presupuesto
    {
        public int IdPresupuesto { get; set; }
        public int IdJefe { get; set; }
        public int IdServicio { get; set; }

        public virtual Jefe IdJefeNavigation { get; set; }
        public virtual Servicio IdServicioNavigation { get; set; }
    }
}
