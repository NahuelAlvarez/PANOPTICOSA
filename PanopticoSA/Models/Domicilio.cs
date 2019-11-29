using System;
using System.Collections.Generic;

namespace PanopticoSA.Models
{
    public partial class Domicilio
    {
        public int IdDomicilio { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Departamento { get; set; }
        public int? Piso { get; set; }
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public int Cp { get; set; }
        public int? IdPersona { get; set; }
        public string Barrio { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; }
    }
}
