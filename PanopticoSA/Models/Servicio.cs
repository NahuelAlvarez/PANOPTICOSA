using System;
using System.Collections.Generic;

namespace PanopticoSA.Models
{
    public partial class Servicio
    {
        public Servicio()
        {
            ClienteContrata = new HashSet<ClienteContrata>();
            ClienteOpina = new HashSet<ClienteOpina>();
            Presupuesto = new HashSet<Presupuesto>();
            ServicioTecnico = new HashSet<ServicioTecnico>();
            Turno = new HashSet<Turno>();
        }

        public int IdServicio { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Observaciones { get; set; }

        public virtual ICollection<ClienteContrata> ClienteContrata { get; set; }
        public virtual ICollection<ClienteOpina> ClienteOpina { get; set; }
        public virtual ICollection<Presupuesto> Presupuesto { get; set; }
        public virtual ICollection<ServicioTecnico> ServicioTecnico { get; set; }
        public virtual ICollection<Turno> Turno { get; set; }
    }
}
