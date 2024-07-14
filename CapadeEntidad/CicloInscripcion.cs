using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CicloInscripcion
    {
        public int idciclo { get; set; }
        public string nombreCiclo { get; set; }
        public DateTime fechainicio { get; set; }
        public DateTime fechafin { get; set; }
        public bool Estado { get; set; }
    }
}
