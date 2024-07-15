using CapaDatos;
using CapadeEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Departamento
    {
        private CD_Departamento datosDepartamento = new CD_Departamento();

        public List<Departamento> ObtenerDepartamentos()
        {
            return datosDepartamento.ListarDepartamentos();
        }
    }
}
