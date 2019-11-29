using System;
using System.Collections.Generic;

namespace PanopticoSA.Models
{
    public partial class Cuenta
    {
        public Cuenta()
        {
            Factura = new HashSet<Factura>();
        }

        public int IdCuenta { get; set; }
        public int IdCliente { get; set; }
        public decimal? Monto { get; set; }
        public DateTime? FechaPago { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string Estado { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual ICollection<Factura> Factura { get; set; }
    }
}
