using CapaDatos1;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Estudiante
    {
        public List<Estudiante> Listar()
        {
            List<Estudiante> lista = new List<Estudiante>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT e.idEstudiante, e.nombres, e.aPaterno, e.aMaterno, e.dni, e.sexo, e.celular, e.fechaNacimiento, e.email, e.colegio, e.anoculminado FROM estudiantes e");

                    using (SqlCommand cmd = new SqlCommand(query.ToString(), conexion))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        conexion.Open();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Estudiante estudiante = new Estudiante
                                {
                                    IdEstudiante = dr["idEstudiante"].ToString(),
                                    Nombres = dr["nombres"].ToString(),
                                    APaterno = dr["aPaterno"].ToString(),
                                    AMaterno = dr["aMaterno"].ToString(),
                                    Documneto = dr["dni"].ToString(),
                                    Sexo = Convert.ToChar(dr["sexo"]),
                                    Celular = dr["celular"].ToString(),
                                    FechaNacimiento = Convert.ToDateTime(dr["fechaNacimiento"]),
                                    Email = dr["email"].ToString(),
                                    Colegio = dr["colegio"].ToString(),
                                    AnoCulminado = dr["anoculminado"].ToString()
                                };

                                lista.Add(estudiante);
                            }
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    // Manejo específico para errores de SQL
                    Console.WriteLine($"Error de SQL: {sqlEx.Message}");
                    lista = new List<Estudiante>();
                }
                catch (InvalidOperationException invalidOpEx)
                {
                    // Manejo específico para errores de operación inválida
                    Console.WriteLine($"Operación inválida: {invalidOpEx.Message}");
                    lista = new List<Estudiante>();
                }
                catch (Exception ex)
                {
                    // Manejo general de errores
                    Console.WriteLine($"Error: {ex.Message}");
                    lista = new List<Estudiante>();
                }
            }

            return lista;
        }


        public bool Modificar(Estudiante obj, out string Mensaje)
        {
            bool exito = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ModificarEstudiante", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    cmd.Parameters.AddWithValue("@idEstudiante", obj.IdEstudiante);
                    cmd.Parameters.AddWithValue("@nombres", obj.Nombres);
                    cmd.Parameters.AddWithValue("@aPaterno", obj.APaterno);
                    cmd.Parameters.AddWithValue("@aMaterno", obj.AMaterno);
                    cmd.Parameters.AddWithValue("@dni", obj.Documneto);
                    cmd.Parameters.AddWithValue("@sexo", obj.Sexo);
                    cmd.Parameters.AddWithValue("@celular", obj.Celular);
                    cmd.Parameters.AddWithValue("@fechaNacimiento", obj.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@email", obj.Email);
                    cmd.Parameters.AddWithValue("@colegio", obj.Colegio);
                    cmd.Parameters.AddWithValue("@anoculminado", obj.AnoCulminado);

                    // Parámetros de salida
                    SqlParameter paramExito = new SqlParameter("@exito", SqlDbType.Bit);
                    paramExito.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramExito);

                    SqlParameter paramMensaje = new SqlParameter("@mensaje", SqlDbType.NVarChar, 100);
                    paramMensaje.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramMensaje);

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    exito = Convert.ToBoolean(cmd.Parameters["@exito"].Value);
                    Mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                exito = false;
                Mensaje = ex.Message;
            }

            return exito;
        }


        public bool Agregar(Estudiante nuevoEstudiante, out string mensaje)
        {
            bool exito = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_AgregarEstudiante", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetros
                        cmd.Parameters.AddWithValue("@idEstudiante", nuevoEstudiante.IdEstudiante);
                        cmd.Parameters.AddWithValue("@nombres", nuevoEstudiante.Nombres);
                        cmd.Parameters.AddWithValue("@aPaterno", nuevoEstudiante.APaterno);
                        cmd.Parameters.AddWithValue("@aMaterno", nuevoEstudiante.AMaterno);
                        cmd.Parameters.AddWithValue("@dni", nuevoEstudiante.Documneto);
                        cmd.Parameters.AddWithValue("@sexo", nuevoEstudiante.Sexo);
                        cmd.Parameters.AddWithValue("@celular", nuevoEstudiante.Celular);
                        cmd.Parameters.AddWithValue("@fechaNacimiento", nuevoEstudiante.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@email", nuevoEstudiante.Email);
                        cmd.Parameters.AddWithValue("@colegio", nuevoEstudiante.Colegio);
                        cmd.Parameters.AddWithValue("@anoculminado", nuevoEstudiante.AnoCulminado);

                        // Parámetros de salida
                        SqlParameter mensajeParam = new SqlParameter("@mensaje", SqlDbType.NVarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(mensajeParam);

                        SqlParameter exitoParam = new SqlParameter("@exito", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(exitoParam);

                        conexion.Open();
                        cmd.ExecuteNonQuery();

                        mensaje = mensajeParam.Value.ToString();
                        exito = Convert.ToBoolean(exitoParam.Value);
                    }
                }
                catch (Exception ex)
                {
                    mensaje = "Error al intentar agregar el estudiante: " + ex.Message;
                    exito = false;
                }
            }

            return exito;
        }

    }
}
