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

        private CD_Provincia datosProvincia = new CD_Provincia();
        public List<Provincia> ObtenerProvinciasPorDepartamento(int departamentoId)
        {
            return datosProvincia.ListarProvinciasPorDepartamento(departamentoId);
        }


    }
}
