using System;
using System.Collections.Generic;

namespace PanopticoSA.Models
{
    public partial class Turno
    {
        public int IdTurno { get; set; }
        public DateTime? Fecha { get; set; }
        public TimeSpan? Hora { get; set; }
        public int IdCliente { get; set; }
        public int IdServicio { get; set; }
        public string Estado { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Servicio IdServicioNavigation { get; set; }
    }
}
