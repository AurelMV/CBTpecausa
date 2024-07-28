using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapadeEntidad;
using System.Data;
using System.Data.SqlClient;
using CapaDatos1;

namespace CapaNegocio
{
    public class CN_Grupo
    {
        private CD_Grupo objcd_grupo = new CD_Grupo();
        public List<Grupo> Listar()
        {
            return objcd_grupo.Listar();
        }

        public List<Grupo> Listar2(int idciclo)
        {
            return objcd_grupo.Listarespecifico(idciclo);
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
        public List<Grupo> Listargrupconcicloyactivo(int idciclo)
        {
            return objcd_grupo.Listargrupconcicloyactivo(idciclo);
        }
        public bool IncrementarAforo(int idgrupo, int aforo) { 
        
        return objcd_grupo.IncrementarAforo(idgrupo, aforo);
        
        }

        public static DataTable ObtenerInscripcionesPorGrupo(int idGrupo)
        {
            return CD_Grupo.ObtenerInscripcionesPorGrupo(idGrupo);
        }
        public static DataTable ObtenerInscripcionesPorGrupoDeudores(int idGrupo)
        {
            return CD_Grupo.ObtenerInscripcionesPorGrupoDeudores(idGrupo);
        }


        public int ObtenerAforoDisponible(int idGrupo)
        {
            return objcd_grupo.ObtenerAforoDisponible(idGrupo);
        }
    }
}
