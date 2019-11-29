using System;
using System.Collections.Generic;

namespace PanopticoSA.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            ClienteContrata = new HashSet<ClienteContrata>();
            ClienteOpina = new HashSet<ClienteOpina>();
            Cuenta = new HashSet<Cuenta>();
            Emergencia = new HashSet<Emergencia>();
            Factura = new HashSet<Factura>();
            Turno = new HashSet<Turno>();
        }

        public int IdCliente { get; set; }
        public int IdPersona { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; }
        public virtual ICollection<ClienteContrata> ClienteContrata { get; set; }
        public virtual ICollection<ClienteOpina> ClienteOpina { get; set; }
        public virtual ICollection<Cuenta> Cuenta { get; set; }
        public virtual ICollection<Emergencia> Emergencia { get; set; }
        public virtual ICollection<Factura> Factura { get; set; }
        public virtual ICollection<Turno> Turno { get; set; }
    }
}
