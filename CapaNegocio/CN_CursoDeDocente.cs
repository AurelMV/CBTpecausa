using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_CursoDeDocente
    {
        private CD_CursoDeDocente CD_CursoDeDocente = new CD_CursoDeDocente();
        public List<CursoDeDocente> listar()
        {
            return CD_CursoDeDocente.listar();
        }
        public void registrar(CursoDeDocente cursoDeDocente)
        {
            CD_CursoDeDocente.registrar(cursoDeDocente);
        }
        public void modificar(CursoDeDocente cursoDeDocente)
        {
            CD_CursoDeDocente.modificar(cursoDeDocente);
        }
    }
}
