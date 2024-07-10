using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Collections;

namespace CapaDatos1
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spGestionarUsuarios", conexion)) {
                    try
                    {  
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@metodo", "3");
                        cmd.Parameters.AddWithValue("@idusuarios", DBNull.Value);
                        cmd.Parameters.AddWithValue("@user", DBNull.Value);
                        cmd.Parameters.AddWithValue("@password", DBNull.Value);
                        cmd.Parameters.AddWithValue("@tipo",    DBNull.Value);
                        cmd.Parameters.AddWithValue("@estado", DBNull.Value);
                        cmd.Parameters.AddWithValue("@nombre", DBNull.Value);
                        cmd.Parameters.AddWithValue("@aPaterno", DBNull.Value);
                        cmd.Parameters.AddWithValue("@aMaterno", DBNull.Value);
                        conexion.Open();
                        cmd.ExecuteNonQuery();

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Usuario usuario = new Usuario();
                                usuario.idusuarios = dr["idusuarios"].ToString();
                                usuario.user = dr["user"].ToString();
                                usuario.password = dr["password"].ToString();
                                usuario.tipo = dr["tipo"].ToString();
                                usuario.estado = dr["estado"].ToString();
                                usuario.nombre = dr["nombre"].ToString();
                                usuario.aPaterno = dr["aPaterno"].ToString();
                                usuario.aMaterno = dr["aMaterno"].ToString();

                                lista.Add(usuario);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al intentar listar usuarios: " + ex.Message);
                    }
                }
            }
            return lista;
        }

        public void insertarUsuarios(Usuario usuario) {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena)) {
                using (SqlCommand cmd = new SqlCommand("spGestionarUsuarios", conexion)) {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@metodo", "1");
                        cmd.Parameters.AddWithValue("@idusuarios", usuario.idusuarios);
                        cmd.Parameters.AddWithValue("@user", usuario.user);
                        cmd.Parameters.AddWithValue("@password", usuario.password);
                        cmd.Parameters.AddWithValue("@tipo", usuario.tipo);
                        cmd.Parameters.AddWithValue("@estado", usuario.estado);
                        cmd.Parameters.AddWithValue("@nombre", usuario.nombre);
                        cmd.Parameters.AddWithValue("@aPaterno", usuario.aPaterno);
                        cmd.Parameters.AddWithValue("@aMaterno", usuario.aMaterno);
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        public void actualizarUsuarios(Usuario usuario) {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spGestionarUsuarios", conexion)) {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@metodo", "2");
                        cmd.Parameters.AddWithValue("@idusuarios", usuario.idusuarios);
                        cmd.Parameters.AddWithValue("@user", usuario.user);
                        cmd.Parameters.AddWithValue("@password", usuario.password);
                        cmd.Parameters.AddWithValue("@tipo", usuario.tipo);
                        cmd.Parameters.AddWithValue("@estado", usuario.estado);
                        cmd.Parameters.AddWithValue("@nombre", usuario.nombre);
                        cmd.Parameters.AddWithValue("@aPaterno", usuario.aPaterno);
                        cmd.Parameters.AddWithValue("@aMaterno", usuario.aMaterno);
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
        public Usuario ObtenerUsuario(string usuario, string contrasena)
        {
            Usuario usuarioEncontrado = null;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT idusuarios, [user], password, tipo, estado, nombre, aPaterno, aMaterno " +
                                   "FROM usuarios " +
                                   "WHERE [user] = @Usuario AND password = @Contraseña";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Contraseña", contrasena);
                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            usuarioEncontrado = new Usuario
                            {
                                idusuarios = dr["idusuarios"].ToString(),
                                user = dr["user"].ToString(),
                                password = dr["password"].ToString(),
                                tipo = dr["tipo"].ToString(),
                                estado = dr["estado"].ToString(),
                                nombre = dr["nombre"].ToString(),
                                aPaterno = dr["aPaterno"].ToString(),
                                aMaterno = dr["aMaterno"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al intentar obtener usuario: " + ex.Message);
                }
            }

            return usuarioEncontrado;
        }
    }
}