using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Estudiante
    {
        private CD_Estudiante objcd_estudiante = new CD_Estudiante();
        public List<Estudiante> Listar()
        {
            return objcd_estudiante.Listar();
        }

        public bool Editar(Estudiante obj, out String Mensaje)
        {
            return objcd_estudiante.Modificar(obj, out Mensaje);
        }

        public bool Registrar(Estudiante obj, out String Mensaje)
        {
            return objcd_estudiante.Agregar(obj, out Mensaje);
        }
    }
}
