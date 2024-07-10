﻿using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Grupo
    {
        private CD_Grupo objcd_grupo = new CD_Grupo();
        public List<Grupo> Listar()
        {
            return objcd_grupo.Listar();
        }
        public List<Grupo> ListarGrupoActivo()
        {
            return objcd_grupo.ListarGrupoActivo();
        }
        public int Registrar(Grupo obj, out String Mensaje)
        {
            Mensaje = String.Empty;

            if (obj.NombreGrupo == null)
            {
                Mensaje += "Es nesesario colocar un nombre al grupo";
            }
            if (obj.Aforo <= 0)
            {
                Mensaje += "Es nesesario ingresar un valor positivo  ";

            }
            if (obj.FechaGrupos == null)
            {
                Mensaje += "Es nesesario elegir una fecha del Calendario  ";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_grupo.Registrar(obj, out Mensaje);
            }
        }
        public bool Editar(Grupo obj, out String Mensaje)
        {
            return objcd_grupo.Modificar(obj, out Mensaje);
        }

        public List<Grupo> Listar2()
        {
            return objcd_grupo.Listar2();
        }
    }
}
