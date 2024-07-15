using CapaDatos1;
using CapadeEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Rol
    {

        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    string query = "SELECT idRol, nombre FROM Rol";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        conexion.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Rol rol = new Rol
                                {
                                    idrol = Convert.ToInt32(dr["idRol"]),
                                    nombrerol = dr["nombre"].ToString()
                                };

                                lista.Add(rol);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
          
                Console.WriteLine("Error al listar roles: " + ex.Message);
            }

            return lista;
        }
    }
}
