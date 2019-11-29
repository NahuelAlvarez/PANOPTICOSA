using System;
using System.Collections.Generic;

namespace PanopticoSA.Models
{
    public partial class Area
    {
        public int IdArea { get; set; }
        public string Tipo { get; set; }
        public int IdJefe { get; set; }

        public virtual Jefe IdJefeNavigation { get; set; }
    }
}
