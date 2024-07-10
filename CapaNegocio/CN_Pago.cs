using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Pago
    {
        private CD_Pago obj_pago = new CD_Pago();
        public List<Pago> Listar()
        {
            return obj_pago.Listar();
        }

        public bool Registrar(Pago obj, out String Mensaje)
        {
            Mensaje = String.Empty;


            return obj_pago.Registrar(obj, out Mensaje);

        }
        public bool Editar(Pago obj, out String Mensaje)
        {
            return obj_pago.Modificar(obj, out Mensaje);
        }
    }
}
