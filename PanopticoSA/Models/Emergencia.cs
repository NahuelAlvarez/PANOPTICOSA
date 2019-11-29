using System;
using System.Collections.Generic;

namespace PanopticoSA.Models
{
    public partial class Emergencia
    {
        public int IdEmergencia { get; set; }
        public int IdCliente { get; set; }
        public int IdJefe { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
