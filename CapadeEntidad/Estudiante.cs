using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Estudiante
    {
        public string IdEstudiante { get; set; }
        public string Nombres { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public string Dni { get; set; }
        public char Sexo { get; set; }
        public string Celular { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Colegio { get; set; }
        public DateTime AnoCulminado { get; set; }
    }
}
