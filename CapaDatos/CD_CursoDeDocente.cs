using CapaDatos1;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_CursoDeDocente
    {
        public List<CursoDeDocente> listar()
        {
            List<CursoDeDocente> lista = new List<CursoDeDocente>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spGestionarDocenteCurso", conexion))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@metodo", "4");
                        cmd.Parameters.AddWithValue("@idcursodocente", DBNull.Value);
                        cmd.Parameters.AddWithValue("@idcurso", DBNull.Value);
                        cmd.Parameters.AddWithValue("@idDocente", DBNull.Value);
                        cmd.Parameters.AddWithValue("@idGrupos", DBNull.Value);
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                CursoDeDocente cdg = new CursoDeDocente();
                                cdg.IdCursoDeDocente = Convert.ToInt32(dr["idcursodocente"]);
                                cdg.oGrupo = new Grupo { IdGrupos = Convert.ToInt32(dr["idGrupos"]) };
                                cdg.nombreGrupo = dr["nombreGrupo"].ToString();
                                cdg.oDocente = new Docente { idDocente = dr["idDocente"].ToString() };
                                cdg.nombreDocente = dr["nombreDocente"].ToString();
                                cdg.oCurso = new Curso { IdCurso = Convert.ToInt32(dr["idcurso"]) };
                                cdg.nombreCurso = dr["nombreCurso"].ToString();

                                lista.Add(cdg);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al listar: " + ex.Message);
                    }
                }
            }
            return lista;
        }
        public void registrar(CursoDeDocente cursoDeDocente)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spGestionarDocenteCurso", conexion))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@metodo", "1");
                        cmd.Parameters.AddWithValue("@idcursodocente", DBNull.Value);
                        cmd.Parameters.AddWithValue("@idcurso", cursoDeDocente.oCurso.IdCurso);
                        cmd.Parameters.AddWithValue("@idDocente", cursoDeDocente.oDocente.idDocente);
                        cmd.Parameters.AddWithValue("@idGrupos", cursoDeDocente.oGrupo.IdGrupos);
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
        public void modificar(CursoDeDocente cursoDeDocente)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                using (SqlCommand cmd = new SqlCommand("spGestionarDocenteCurso", conexion))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@metodo", "2");
                        cmd.Parameters.AddWithValue("@idcursodocente", cursoDeDocente.IdCursoDeDocente);
                        cmd.Parameters.AddWithValue("@idcurso", cursoDeDocente.oCurso.IdCurso);
                        cmd.Parameters.AddWithValue("@idDocente", cursoDeDocente.oDocente.idDocente);
                        cmd.Parameters.AddWithValue("@idGrupos", cursoDeDocente.oGrupo.IdGrupos);
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
