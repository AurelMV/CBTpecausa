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
    public class CD_Departamento
    {
        public List<Departamento> ListarDepartamentos()
        {
            List<Departamento> departamentos = new List<Departamento>();

            // Implementa la lógica para consultar y devolver la lista de departamentos desde la base de datos
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT idDepartamento, nombredepartamento FROM Departamento";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Departamento departamento = new Departamento
                            {
                                iddepartamento = Convert.ToInt32(dr["idDepartamento"]),
                                nombredepartamento = dr["nombredepartamento"].ToString()
                            };
                            departamentos.Add(departamento);
                        }
                    }
                }
            }

            return departamentos;
        }
    }
}
