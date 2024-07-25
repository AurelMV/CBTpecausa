using CapaDatos1;
using CapadeEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Colegio
    {
        public List<Colegio> ListarColegiosPorDistrito(int distritoId)
        {
            List<Colegio> colegios = new List<Colegio>();

            // Implementa la lógica para consultar y devolver la lista de colegios filtrados por distritoId
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT idcolegios, nombrecolegio, Distrito_idDistrito FROM colegios WHERE Distrito_idDistrito = @DistritoId";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@DistritoId", distritoId);
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Colegio colegio = new Colegio
                            {
                                idcolegio = Convert.ToInt32(dr["idcolegios"]),
                                nombrecolegio = dr["nombrecolegio"].ToString(),
                                odistrito = new Distrito
                                {

                                    iddistrito = Convert.ToInt32(dr["Distrito_idDistrito"])
                                }


                            };
                            colegios.Add(colegio);
                        }
                    }
                }
            }

            return colegios;
        }


      

        public bool AgregarColegio(Colegio colegio)
        {
            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("SP_AgregarColegio", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", colegio.nombrecolegio);
                cmd.Parameters.AddWithValue("@IdDistrito", colegio.odistrito.iddistrito);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
    }
}
