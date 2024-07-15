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
    public class CD_DIstrito
    {
        public List<Distrito> ListarDistritosPorProvincia(int provinciaId)
        {
            List<Distrito> distritos = new List<Distrito>();

            // Implementa la lógica para consultar y devolver la lista de distritos filtrados por provinciaId
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT idDistritos, nombredistrito, Provincia_idProvincia FROM Distritos WHERE Provincia_idProvincia = @ProvinciaId";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@ProvinciaId", provinciaId);
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Distrito distrito = new Distrito
                            {
                                iddistrito = Convert.ToInt32(dr["idDistritos"]),
                                nombredistrito = dr["nombredistrito"].ToString(),
                                oProvincia = new Provincia
                                {
                                    idprovincia = Convert.ToInt32(dr["Provincia_idProvincia"])
                                }

                            };
                                
                            distritos.Add(distrito);
                        }
                    }
                }
            }

            return distritos;
        }
    }
}