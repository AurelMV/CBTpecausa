using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Inscripcion
    {
        public int IdInscripcion { get; set; }
        public string Turno { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public bool EstadoPago { get; set; }

        // Propiedades de navegación
        public Estudiante oEstudiante { get; set; }
        public CicloInscripcion oCicloInscripcion { get; set; }
        public Grupo oGrupo { get; set; }
        public ProgramaEstudios oProgramaEstudios { get; set; }
        public Usuario oUsuario { get; set; }

    }
}
