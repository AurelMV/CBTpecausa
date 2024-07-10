using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Utilidades
{
    public class OpcionCombo
    {
        public String Texto { get; set; }
        public Object Valor { get; set; }
        public override string ToString()
        {
            return Texto;
        }
    }
}
