using CapaDatos;
using CapadeEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Provincia
    {

        private CD_Provincia objCD_Provincia = new CD_Provincia();

        public List<Provincia> ListarProvinciasPorDepartamento(int departamentoId)
        {
            return objCD_Provincia.ListarProvinciasPorDepartamento(departamentoId);
        }


    }
}
