using CapaDatos;
using CapadeEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Operaciones
    {
        private CD_Operaciones cdOperaciones = new CD_Operaciones();

        public List<Departamento> ObtenerDepartamentos()
        {
            return cdOperaciones.Obtenerdepartamentos();
        }

        public List<Provincia> ObtenerProvincias(int iddeparetment)
        {
            return cdOperaciones.obtenerprovincias(iddeparetment);
        }

        public List<Distrito> ObtenerDistritos(int idprove)
        {
            return cdOperaciones.obtenerdistrito(idprove);
        }

        public List<Colegio> ObtenerColegios(int iddistri)
        {
            return cdOperaciones.obtenercolegio(iddistri);
        }
    }
}
