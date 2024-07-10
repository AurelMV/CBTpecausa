using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CursoDeDocente
    {
        public int IdCursoDeDocente { get; set; }
        public Curso oCurso { get; set; }
        public string nombreCurso { get; set; }
        public Docente oDocente { get; set; }
        public string nombreDocente { get; set; }
        public Grupo oGrupo { get; set; }
        public string nombreGrupo { get; set; }
    }
}
