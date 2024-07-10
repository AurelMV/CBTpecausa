using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos1;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_CicloInscripcion
    {
        private CD_CicloInscripcion o_ciclo = new CD_CicloInscripcion();

        public List<CicloInscripcion> listar() { 
            return o_ciclo.listar();
        }

        public void registrarCiclos(CicloInscripcion nuevociclo) {
            o_ciclo.registrarCiclos(nuevociclo);
        }

        public void actualizarCiclos(CicloInscripcion ciclo) {
            o_ciclo.actualizarCiclos(ciclo);
        }
    }
}
