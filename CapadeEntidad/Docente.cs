using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Docente
    {
        public string idDocente { get; set; }
        public string nombre { get; set; }
        public string aPaterno { get; set; }
        public string aMaterno { get; set; }
        public string dni { get; set; }
        public char sexo { get; set; }
        public string celular { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string email { get; set; }
        public bool estado { get; set; }
        public string estadoTexto => estado ? "Activo" : "Inactivo";
    }
}
