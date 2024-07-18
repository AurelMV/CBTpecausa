using CapaDatos;
using CapadeEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_DIstrito
    {
        private CD_DIstrito objCD_Distrito = new CD_DIstrito();

        public List<Distrito> ListarDistritosPorProvincia(int provinciaId)
        {
            return objCD_Distrito.ListarDistritosPorProvincia(provinciaId);
        }

    }
}
