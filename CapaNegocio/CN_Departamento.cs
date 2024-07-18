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
        private CD_Departamento objCD_Departamento = new CD_Departamento();

        public List<Departamento> ListarDepartamentos()
        {
            return objCD_Departamento.ListarDepartamentos();
        }
    }
}
