using CapadeEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
        public string TipoDocumento { get; set; }
        public string Documneto { get; set; }
        public char Sexo { get; set; }
        public string Celular { get; set; }
        public String CelularApoderado { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Colegio { get; set; }
        public String AnoCulminado { get; set; }
        
        public TypeVarBinarySchemaImporterExtension  foto { get; set; }
        public Colegio oColegio { get; set; }
    }
}
