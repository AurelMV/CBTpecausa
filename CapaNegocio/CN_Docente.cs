using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaDatos1;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Docente
    {
        private CD_Docente odocente = new CD_Docente();
        public List<Docente> listar() 
        {
            return odocente.listar();
        }
        public List<Docente> listarDocenteActivo()
        {
            return odocente.listarDocenteActivo();
        }
        public void registrarDocente(Docente docente)
        {
            odocente.registrarDocente(docente);
        }
        public void actualizarDocente(Docente docente) 
        {
            odocente.actualizarDocente(docente);
        }
    }
}
