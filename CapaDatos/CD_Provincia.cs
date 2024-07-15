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
    public class CD_Provincia
    {
        public List<Provincia> ListarProvinciasPorDepartamento(int departamentoId)
        {
            List<Provincia> provincias = new List<Provincia>();

            // Implementa la lógica para consultar y devolver la lista de provincias filtradas por departamentoId
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT idProvincia, nombreprovincia, Departamento_idDepartamento FROM Provincia WHERE Departamento_idDepartamento = @DepartamentoId";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@DepartamentoId", departamentoId);
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Provincia provincia = new Provincia
                            {
                                idprovincia = Convert.ToInt32(dr["idProvincia"]),
                                nombreprovincia = dr["nombreprovincia"].ToString(),
                                odepartamento = new Departamento { 
                                iddepartamento =  Convert.ToInt32(dr["Departamento_idDepartamento"])

                                }  
                            };
                            provincias.Add(provincia);
                        }
                    }
                }
            }

            return provincias;
        }
    }
}
