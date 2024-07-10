using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos1
{
    public class CD_CicloInscripcion
    {
        public List<CicloInscripcion> listar() {

            List<CicloInscripcion> lista = new List<CicloInscripcion>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena)) 
            {
                using (SqlCommand cmd = new SqlCommand("spGestionarCiclosInscripcion", conexion)) {
                    try 
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@metodo", "3");
                        cmd.Parameters.AddWithValue("@idciclo", DBNull.Value);
                        cmd.Parameters.AddWithValue("@nombreCiclo", DBNull.Value);
                        cmd.Parameters.AddWithValue("@fechainicio", DBNull.Value);
                        cmd.Parameters.AddWithValue("@fechafin", DBNull.Value);
                        conexion.Open();
                        cmd.ExecuteNonQuery();

                        using (SqlDataReader dr = cmd.ExecuteReader()) {
                            while (dr.Read())
                            {
                                CicloInscripcion ciclo = new CicloInscripcion();
                                ciclo.idciclo = Convert.ToInt32(dr["idciclo"]);
                                ciclo.nombreCiclo = dr["nombreCiclo"].ToString();
                                ciclo.fechainicio = DateTime.Parse(dr["fechainicio"].ToString());
                                ciclo.fechafin = DateTime.Parse(dr["fechafin"].ToString());

                                lista.Add(ciclo);
                            }
                        }
                    } catch (Exception ex) {
                        Console.WriteLine("Error al intentar listar ciclos: " + ex.Message);
                    }
                }
            }
            return lista;
        }

        public void registrarCiclos(CicloInscripcion nuevociclo) {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spGestionarCiclosInscripcion", conexion)) {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@metodo", "1");
                        cmd.Parameters.AddWithValue("@idciclo", DBNull.Value);
                        cmd.Parameters.AddWithValue("@nombreCiclo", nuevociclo.nombreCiclo);
                        cmd.Parameters.AddWithValue("@fechainicio", nuevociclo.fechainicio);
                        cmd.Parameters.AddWithValue("@fechafin", nuevociclo.fechafin);
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        public void actualizarCiclos(CicloInscripcion ciclo) {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spGestionarCiclosInscripcion", conexion)) {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@metodo", "2");
                        cmd.Parameters.AddWithValue("@idciclo", ciclo.idciclo);
                        cmd.Parameters.AddWithValue("@nombreCiclo", ciclo.nombreCiclo);
                        cmd.Parameters.AddWithValue("@fechainicio", ciclo.fechainicio);
                        cmd.Parameters.AddWithValue("@fechafin", ciclo.fechafin);
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
