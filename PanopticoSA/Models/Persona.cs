using System;
using System.Collections.Generic;

namespace PanopticoSA.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Cliente = new HashSet<Cliente>();
            Domicilio = new HashSet<Domicilio>();
            Empleado = new HashSet<Empleado>();
        }

        public int IdPersona { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdDomicilio { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Domicilio> Domicilio { get; set; }
        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
