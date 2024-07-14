using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapadeEntidad
{
    internal class Distrito
    {
        public int iddistrito { get; set; }
        public string nombredistrito { get; set; }
        public Provincia oProvincia { get; set; }
    }
}
