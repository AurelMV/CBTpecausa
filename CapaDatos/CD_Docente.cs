using System;
using System.Collections;
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
    public class CD_Docente
    {
        public List<Docente> listar() { 
            List<Docente> lista = new List<Docente>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena)) {
                using (SqlCommand cmd = new SqlCommand("spGestionarDocentes", conexion))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@metodo", "3");
                        cmd.Parameters.AddWithValue("@idDocente", DBNull.Value);
                        cmd.Parameters.AddWithValue("@nombre", DBNull.Value);
                        cmd.Parameters.AddWithValue("@aPaterno", DBNull.Value);
                        cmd.Parameters.AddWithValue("@aMaterno", DBNull.Value);
                        cmd.Parameters.AddWithValue("@dni", DBNull.Value);
                        cmd.Parameters.AddWithValue("@sexo", DBNull.Value);
                        cmd.Parameters.AddWithValue("@celular", DBNull.Value);
                        cmd.Parameters.AddWithValue("@fechaNacimiento", DBNull.Value);
                        cmd.Parameters.AddWithValue("@email", DBNull.Value);
                        cmd.Parameters.AddWithValue("@estado", DBNull.Value);
                        conexion.Open();
                        cmd.ExecuteNonQuery();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Docente docente = new Docente();
                                docente.idDocente = dr["idDocente"].ToString();
                                docente.nombre = dr["nombre"].ToString();
                                docente.aPaterno = dr["aPaterno"].ToString();
                                docente.aMaterno = dr["aMaterno"].ToString();
                                docente.dni = dr["dni"].ToString();
                                docente.sexo = Convert.ToChar(dr["sexo"]);
                                docente.celular = dr["celular"].ToString();
                                docente.fechaNacimiento = DateTime.Parse(dr["fechaNacimiento"].ToString());
                                docente.email = dr["email"].ToString();
                                docente.estado = Convert.ToBoolean(dr["estado"]);

                                lista.Add(docente);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al intentar listar docentes: " + ex.Message);
                    }
                }
                return lista;
            }
        }
        public List<Docente> listarDocenteActivo()
        {
            List<Docente> lista = new List<Docente>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spGestionarDocentes", conexion))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@metodo", "4");
                        cmd.Parameters.AddWithValue("@idDocente", DBNull.Value);
                        cmd.Parameters.AddWithValue("@nombre", DBNull.Value);
                        cmd.Parameters.AddWithValue("@aPaterno", DBNull.Value);
                        cmd.Parameters.AddWithValue("@aMaterno", DBNull.Value);
                        cmd.Parameters.AddWithValue("@dni", DBNull.Value);
                        cmd.Parameters.AddWithValue("@sexo", DBNull.Value);
                        cmd.Parameters.AddWithValue("@celular", DBNull.Value);
                        cmd.Parameters.AddWithValue("@fechaNacimiento", DBNull.Value);
                        cmd.Parameters.AddWithValue("@email", DBNull.Value);
                        cmd.Parameters.AddWithValue("@estado", DBNull.Value);
                        conexion.Open();
                        cmd.ExecuteNonQuery();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Docente docente = new Docente();
                                docente.idDocente = dr["idDocente"].ToString();
                                docente.nombre = dr["nombre"].ToString();
                                docente.aPaterno = dr["aPaterno"].ToString();
                                docente.aMaterno = dr["aMaterno"].ToString();
                                docente.dni = dr["dni"].ToString();
                                docente.sexo = Convert.ToChar(dr["sexo"]);
                                docente.celular = dr["celular"].ToString();
                                docente.fechaNacimiento = DateTime.Parse(dr["fechaNacimiento"].ToString());
                                docente.email = dr["email"].ToString();
                                docente.estado = Convert.ToBoolean(dr["estado"]);

                                lista.Add(docente);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al intentar listar docentes: " + ex.Message);
                    }
                }
                return lista;
            }
        }
        public void registrarDocente(Docente docente)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena)) 
            {
                using (SqlCommand cmd = new SqlCommand("spGestionarDocentes", conexion))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@metodo", "1");
                        cmd.Parameters.AddWithValue("@idDocente", docente.idDocente);
                        cmd.Parameters.AddWithValue("@nombre", docente.nombre);
                        cmd.Parameters.AddWithValue("@aPaterno", docente.aPaterno);
                        cmd.Parameters.AddWithValue("@aMaterno", docente.aMaterno);
                        cmd.Parameters.AddWithValue("@dni", docente.dni);
                        cmd.Parameters.AddWithValue("@sexo", docente.sexo);
                        cmd.Parameters.AddWithValue("@celular", docente.celular);
                        cmd.Parameters.AddWithValue("@fechaNacimiento", docente.fechaNacimiento);
                        cmd.Parameters.AddWithValue("@email", docente.email);
                        cmd.Parameters.AddWithValue("@estado", docente.estado);
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
        public void actualizarDocente(Docente docente)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spGestionarDocentes", conexion))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@metodo", "2");
                        cmd.Parameters.AddWithValue("@idDocente", docente.idDocente);
                        cmd.Parameters.AddWithValue("@nombre", docente.nombre);
                        cmd.Parameters.AddWithValue("@aPaterno", docente.aPaterno);
                        cmd.Parameters.AddWithValue("@aMaterno", docente.aMaterno);
                        cmd.Parameters.AddWithValue("@dni", docente.dni);
                        cmd.Parameters.AddWithValue("@sexo", docente.sexo);
                        cmd.Parameters.AddWithValue("@celular", docente.celular);
                        cmd.Parameters.AddWithValue("@fechaNacimiento", docente.fechaNacimiento);
                        cmd.Parameters.AddWithValue("@email", docente.email);
                        cmd.Parameters.AddWithValue("@estado", docente.estado);
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
