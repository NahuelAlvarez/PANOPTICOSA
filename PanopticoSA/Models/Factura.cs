using System;
using System.Collections.Generic;

namespace PanopticoSA.Models
{
    public partial class Factura
    {
        public int IdFactura { get; set; }
        public int Nro { get; set; }
        public int IdCuenta { get; set; }
        public int IdCliente { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Cuenta IdC { get; set; }
        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
