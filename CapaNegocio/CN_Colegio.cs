using CapaDatos;
using CapadeEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Colegio
    {
      
        private CD_Colegio datosColegio = new CD_Colegio();
        public List<Colegio> ObtenerColegiosPorDistrito(int distritoId)
        {
            return datosColegio.ListarColegiosPorDistrito(distritoId);
        }
    }
}
