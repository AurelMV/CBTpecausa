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
    public class CD_Grupo
    {
        public List<Grupo> Listar()
        {
            List<Grupo> lista = new List<Grupo>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT idGrupos, nombreGrupo, aforo, fechaGrupos, estado FROM Grupos");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            Grupo grupo = new Grupo
                            {
                                IdGrupos = Convert.ToInt32(dr["idGrupos"]),
                                NombreGrupo = dr["nombreGrupo"].ToString(),
                                Aforo = Convert.ToInt32(dr["aforo"]),
                                FechaGrupos = Convert.ToDateTime(dr["fechaGrupos"]),
                                Estado = Convert.ToBoolean(dr["estado"])
                            };

                            lista.Add(grupo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Grupo>();


                }
            }

            return lista;
        }
        public List<Grupo> ListarGrupoActivo()
        {
            List<Grupo> lista = new List<Grupo>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT idGrupos, nombreGrupo, aforo, fechaGrupos, estado FROM Grupos WHERE estado = 1");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            Grupo grupo = new Grupo
                            {
                                IdGrupos = Convert.ToInt32(dr["idGrupos"]),
                                NombreGrupo = dr["nombreGrupo"].ToString(),
                                Aforo = Convert.ToInt32(dr["aforo"]),
                                FechaGrupos = Convert.ToDateTime(dr["fechaGrupos"]),
                                Estado = Convert.ToBoolean(dr["estado"])
                            };

                            lista.Add(grupo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Grupo>();
                }
            }

            return lista;
        }
        public int Registrar(Grupo obj, out String Mensaje)
        {
            int exito = 0;
            Mensaje = String.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarGrupo", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros de entrada
                    cmd.Parameters.AddWithValue("nombreGrupo", obj.NombreGrupo);
                    cmd.Parameters.AddWithValue("aforo", obj.Aforo);
                    cmd.Parameters.AddWithValue("fechaGrupos", obj.FechaGrupos);
                    cmd.Parameters.AddWithValue("estado", obj.Estado);

                    // Agregar parámetros de salida
                    SqlParameter paramExito = new SqlParameter("exito", SqlDbType.Bit);
                    paramExito.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramExito);

                    SqlParameter paramMensaje = new SqlParameter("mensaje", SqlDbType.NVarChar, 100);
                    paramMensaje.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramMensaje);

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    exito = Convert.ToInt32(cmd.Parameters["exito"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                exito = 0;
                Mensaje = ex.Message;
            }

            return exito;
        }

        public bool Modificar(Grupo obj, out String Mensaje)
        {
            bool exito = false;
            Mensaje = String.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ModificarGrupo", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros de entrada
                    cmd.Parameters.AddWithValue("idGrupos", obj.IdGrupos);
                    cmd.Parameters.AddWithValue("nombreGrupo", obj.NombreGrupo);
                    cmd.Parameters.AddWithValue("aforo", obj.Aforo);
                    cmd.Parameters.AddWithValue("fechaGrupos", obj.FechaGrupos);
                    cmd.Parameters.AddWithValue("estado", obj.Estado);

                    // Agregar parámetros de salida
                    SqlParameter paramExito = new SqlParameter("exito", SqlDbType.Bit);
                    paramExito.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramExito);

                    SqlParameter paramMensaje = new SqlParameter("mensaje", SqlDbType.NVarChar, 100);
                    paramMensaje.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramMensaje);

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    exito = Convert.ToBoolean(cmd.Parameters["exito"].Value);
                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                exito = false;
                Mensaje = ex.Message;
            }

            return exito;
        }
        public List<Grupo> Listar2()
        {
            List<Grupo> lista = new List<Grupo>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT idGrupos, nombreGrupo, aforo, fechaGrupos, estado FROM Grupos WHERE estado= 1");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            Grupo grupo = new Grupo
                            {
                                IdGrupos = Convert.ToInt32(dr["idGrupos"]),
                                NombreGrupo = dr["nombreGrupo"].ToString(),
                                Aforo = Convert.ToInt32(dr["aforo"]),
                                FechaGrupos = Convert.ToDateTime(dr["fechaGrupos"]),
                                Estado = Convert.ToBoolean(dr["estado"])
                            };

                            lista.Add(grupo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Grupo>();
                }
            }
            return lista;
        }
    }
}
