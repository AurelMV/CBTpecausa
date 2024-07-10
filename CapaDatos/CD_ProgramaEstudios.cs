using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos1;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_ProgramaEstudios
    {
        public List<ProgramaEstudios> listar()
        {
            List<ProgramaEstudios> lista = new List<ProgramaEstudios>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena)) 
            {
                using (SqlCommand cmd = new SqlCommand("spGestionarProgramasEstudio", conexion)) 
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@metodo", "3");
                        cmd.Parameters.AddWithValue("@idprogramaestudios", DBNull.Value);
                        cmd.Parameters.AddWithValue("@nombre", DBNull.Value);
                        conexion.Open();
                        cmd.ExecuteNonQuery();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                ProgramaEstudios programa = new ProgramaEstudios();
                                programa.idprogramaestudios = Convert.ToInt32(dr["idprogramaestudios"]);
                                programa.nombre = dr["nombre"].ToString();

                                lista.Add(programa);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al intentar listar programas de estudio: " + ex.Message);
                    }
                }
            }
            return lista;
        }
        public void registrarPrograma(ProgramaEstudios programa) 
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena)) 
            {
                using (SqlCommand cmd = new SqlCommand("spGestionarProgramasEstudio", conexion)) 
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@metodo", "1");
                        cmd.Parameters.AddWithValue("@idprogramaestudios", DBNull.Value);
                        cmd.Parameters.AddWithValue("@nombre", programa.nombre);
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
        public void actualizarPrograma(ProgramaEstudios programa)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spGestionarProgramasEstudio", conexion))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@metodo", "2");
                        cmd.Parameters.AddWithValue("@idprogramaestudios", programa.idprogramaestudios);
                        cmd.Parameters.AddWithValue("@nombre", programa.nombre);
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
