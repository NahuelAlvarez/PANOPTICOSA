using System;
using System.Collections.Generic;

namespace PanopticoSA.Models
{
    public partial class ClienteOpina
    {
        public int IdCliente { get; set; }
        public int IdServicio { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Servicio IdServicioNavigation { get; set; }
    }
}
