using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Inscripcion
    {
        private CD_Inscripcion obj_inscriplis = new CD_Inscripcion();
        public List<Inscripcion> Listar()
        {
            return obj_inscriplis.Listar();
        }
        public List<Inscripcion> Listar2()
        {
            return obj_inscriplis.Listar2();
        }

        public bool Editar(Inscripcion obj, out String Mensaje)
        {
            return obj_inscriplis.Modificar(obj, out Mensaje);
        }

        public bool Registrar(Inscripcion obj, out String Mensaje)
        {
            return obj_inscriplis.Agregar(obj, out Mensaje);
        }
    }
}
