using System;
using System.Collections.Generic;

namespace PanopticoSA.Models
{
    public partial class ServicioTecnico
    {
        public int IdTurno { get; set; }
        public int IdTecnico { get; set; }

        public virtual Tecnico IdTecnicoNavigation { get; set; }
        public virtual Servicio IdTurnoNavigation { get; set; }
    }
}
