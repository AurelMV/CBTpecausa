using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pago
    {
        public string IdPago { get; set; }
        public DateTime Fecha { get; set; }
        public int Monto { get; set; }
        public string MedioPago { get; set; }
        public string NroVoucher { get; set; }
        public int IdInscripcion { get; set; }
        public Inscripcion oInscripcion { get; set; }
    }
}
