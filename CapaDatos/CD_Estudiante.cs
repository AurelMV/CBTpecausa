using CapaDatos1;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapadeEntidad;

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
                    query.AppendLine("SELECT e.idEstudiante, e.nombres, e.aPaterno, e.aMaterno, e.sexo, e.celularestudiante, ");
                    query.AppendLine("e.celularapoderado, e.fechaNacimiento, e.email, e.anoculminado, e.Nrodocumento, ");
                    query.AppendLine("e.tipodocumento, e.direccion, e.foto, e.idcolegios, c.nombrecolegio AS nombrecolegio ");
                    query.AppendLine("FROM estudiantes e ");
                    query.AppendLine("INNER JOIN colegios c ON e.idcolegios = c.idcolegios");

                    using (SqlCommand cmd = new SqlCommand(query.ToString(), conexion))
                    {
                        cmd.CommandType = CommandType.Text;
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
                                    Sexo = Convert.ToChar(dr["sexo"]),
                                    CelularEstudiante = dr["celularestudiante"].ToString(),
                                    CelularApoderado = dr["celularapoderado"].ToString(),
                                    FechaNacimiento = Convert.ToDateTime(dr["fechaNacimiento"]),
                                    Email = dr["email"].ToString(),
                                    AnoCulminado = dr["anoculminado"].ToString(),
                                    Documneto = dr["Nrodocumento"].ToString(),
                                    TipoDocumento = dr["tipodocumento"].ToString(),
                                    Direccion = dr["direccion"].ToString(),

                                    foto = dr["foto"] != DBNull.Value ? (byte[])dr["foto"] : null,


                                    oColegio = new Colegio { idcolegio = Convert.ToInt32(dr["idcolegios"]),
                                        nombrecolegio = Convert.ToString(dr["nombrecolegio"])

                                    }
                                    
                                };

                                lista.Add(estudiante);
                            }
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                   
                    Console.WriteLine($"Error de SQL: {sqlEx.Message}");
                    lista = new List<Estudiante>();
                }
                catch (InvalidOperationException invalidOpEx)
                {
                    
                    Console.WriteLine($"Operación inválida: {invalidOpEx.Message}");
                    lista = new List<Estudiante>();
                }
                catch (Exception ex)
                {
                    
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
                    using (SqlCommand cmd = new SqlCommand("ModificarEstudiante", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Parámetros de entrada
                        cmd.Parameters.AddWithValue("@idEstudiante", obj.IdEstudiante);
                        cmd.Parameters.AddWithValue("@nombres", obj.Nombres);
                        cmd.Parameters.AddWithValue("@aPaterno", obj.APaterno);
                        cmd.Parameters.AddWithValue("@aMaterno", obj.AMaterno);
                        cmd.Parameters.AddWithValue("@celularestudiante", obj.CelularEstudiante);
                        cmd.Parameters.AddWithValue("@celularapoderado", obj.CelularApoderado);
                        cmd.Parameters.AddWithValue("@email", obj.Email);
                        cmd.Parameters.AddWithValue("@Nrodocumento", obj.Documneto);

                        if (obj.foto != null)
                        {
                            cmd.Parameters.Add("@Foto", SqlDbType.VarBinary, -1).Value = obj.foto;
                        }
                        else
                        {
                            cmd.Parameters.Add("@Foto", SqlDbType.VarBinary, -1).Value = DBNull.Value;
                        }
                        // Manejo de null para la foto

                        // Parámetro de salida


                        conexion.Open();
                        cmd.ExecuteNonQuery();

                       
                        exito = true;
                    }
                }
            }
            catch (Exception ex)
            {
                exito = false;
                Mensaje = "Error en el método Modificar: " + ex.Message;
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
                    using (SqlCommand cmd = new SqlCommand("RegistrarEstudiante", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetros
                        cmd.Parameters.AddWithValue("@idEstudiante", nuevoEstudiante.IdEstudiante);
                        cmd.Parameters.AddWithValue("@nombres", nuevoEstudiante.Nombres);
                        cmd.Parameters.AddWithValue("@aPaterno", nuevoEstudiante.APaterno);
                        cmd.Parameters.AddWithValue("@aMaterno", nuevoEstudiante.AMaterno);
                        cmd.Parameters.AddWithValue("@sexo", nuevoEstudiante.Sexo);
                        cmd.Parameters.AddWithValue("@celularestudiante", nuevoEstudiante.CelularEstudiante);
                        cmd.Parameters.AddWithValue("@celularapoderado", nuevoEstudiante.CelularEstudiante);
                        cmd.Parameters.AddWithValue("@fechaNacimiento", nuevoEstudiante.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@email", nuevoEstudiante.Email);
                        cmd.Parameters.AddWithValue("@anoculminado", nuevoEstudiante.AnoCulminado);

                        cmd.Parameters.AddWithValue("@Nrodocumento", nuevoEstudiante.Documneto);
                      
                        cmd.Parameters.AddWithValue("@tipodocumento", nuevoEstudiante.TipoDocumento);
                        cmd.Parameters.AddWithValue("@direccion", nuevoEstudiante.Direccion);
                       
                        cmd.Parameters.AddWithValue("@foto", nuevoEstudiante.foto);
                        cmd.Parameters.AddWithValue("@idcolegios", nuevoEstudiante.oColegio.idcolegio);

                        

                        conexion.Open();
                        cmd.ExecuteNonQuery();

                       
                    }
                }
                catch (Exception ex)
                {
                    mensaje = "Error al intentar agregar el estudiante: " + ex.Message;
                    exito = false;
                }
            }

            return exito=true;
        }

    }
}
