﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Inscripcion
    {
        private CD_Inscripcion obj_inscriplis = new CD_Inscripcion();
        public List<Inscripcion> Listar()
        {
            return obj_inscriplis.Listar();
        }

        public List<Inscripcion> Listar3(int idciclo)
        {
            return obj_inscriplis.Listar3(idciclo);
        }
        public List<Inscripcion> Listar2(int idciclo)
        {
            return obj_inscriplis.Listar2(idciclo);
        }

        public bool Editar(Inscripcion obj, out String Mensaje)
        {
            return obj_inscriplis.Modificar(obj, out Mensaje);
        }

        public bool Registrar(Inscripcion obj, out String Mensaje, string dni)
        {
            return obj_inscriplis.Agregar(obj, out Mensaje, dni);
        }
    }
}
