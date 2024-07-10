using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Curso
    {
        private CD_Curso obj_curso = new CD_Curso();
        public List<Curso> Listar()
        {
            return obj_curso.Listar();
        }
        public int Registrar(Curso obj, out String Mensaje)
        {
            Mensaje = String.Empty;
            return obj_curso.Registrar(obj, out Mensaje);
        }
        public bool Editar(Curso obj, out String Mensaje)
        {
            return obj_curso.Modificar(obj, out Mensaje);
        }
    }

}
