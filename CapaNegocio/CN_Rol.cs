﻿
using CapaDatos;
using CapadeEntidad;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Rol
    {
        private CD_Rol obj_rol = new CD_Rol();
        public List<Rol> Listar()
        {

            {
                return obj_rol.Listar();
            }
        }

    }
}