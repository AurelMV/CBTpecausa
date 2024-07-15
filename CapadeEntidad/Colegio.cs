using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeEntidad
{
    public class Colegio
    {
        public int idcolegio { get; set; }
        public string nombrecolegio { get; set; }
        public Distrito odistrito { get; set; }
    }
}
