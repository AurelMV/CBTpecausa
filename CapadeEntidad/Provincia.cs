using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeEntidad
{
    public class Provincia
    {
        public int idprovincia { get; set; }
        public string nombreprovincia { get; set; }
        public Departamento odepartamento { get; set; }
    }
}
