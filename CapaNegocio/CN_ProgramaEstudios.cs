using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_ProgramaEstudios
    {
        private CD_ProgramaEstudios o_programa = new CD_ProgramaEstudios();
        public List<ProgramaEstudios> listar() {
            return o_programa.listar();
        }
        public void registrarPrograma(ProgramaEstudios programa)
        {
            o_programa.registrarPrograma(programa);
        }
        public void actualizarPrograma(ProgramaEstudios programa)
        {
            o_programa.actualizarPrograma(programa);
        }
    }
}
