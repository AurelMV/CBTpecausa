﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Grupo
    {
        public int IdGrupos { get; set; }
        public string NombreGrupo { get; set; }
        public int Aforo { get; set; }
        public bool Estado { get; set; }
        public CicloInscripcion oCicloinscripcion { get; set; }
        public int InscripcionesRealizadas { get; set; }
    }
}
