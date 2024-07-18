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

        private CD_Colegio objCD_Colegio = new CD_Colegio();

        public List<Colegio> ListarColegiosPorDistrito(int distritoId)
        {
            return objCD_Colegio.ListarColegiosPorDistrito(distritoId);
        }
    }
}
