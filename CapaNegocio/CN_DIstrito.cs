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
        private CD_DIstrito datosDistritos = new CD_DIstrito();
        public List<Distrito> ObtenerDistritosPorProvincia(int provinciaId)
        {
            return datosDistritos.ListarDistritosPorProvincia(provinciaId);
        }

    }
}
