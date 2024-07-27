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
    public class CD_Inscripcion
    {
        public List<Inscripcion> Listar()
        {
            List<Inscripcion> lista = new List<Inscripcion>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT i.idInscripcion, i.turno, i.fechaInscripcion, i.estadopago, ");
                    query.AppendLine("e.idEstudiante, e.nombres AS NombreEstudiante, e.aPaterno, e.aMaterno, ");
                    query.AppendLine("c.idciclo, c.nombreCiclo AS NombreCiclo, ");
                    query.AppendLine("p.idprogramaestudios, p.nombre AS NombreProgramaEstudios, ");
                    query.AppendLine("u.idusuarios, u.nombre AS Usuario, ");
                    query.AppendLine("g.idGrupos, g.nombreGrupo AS NombreGrupo ");
                    query.AppendLine("FROM Inscripcion i ");
                    query.AppendLine("JOIN estudiantes e ON i.idEstudiante = e.idEstudiante ");
                    query.AppendLine("JOIN cicloInscripcion c ON i.idciclo = c.idciclo ");
                    query.AppendLine("JOIN programaestudios p ON i.idprogramaestudios = p.idprogramaestudios ");
                    query.AppendLine("JOIN usuarios u ON i.idusuarios = u.idusuarios ");
                    query.AppendLine("JOIN Grupos g ON i.idGrupos = g.idGrupos;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Inscripcion inscripcion = new Inscripcion
                            {
                                IdInscripcion = Convert.ToInt32(dr["idInscripcion"]),
                                Turno = dr["turno"].ToString(),
                                FechaInscripcion = Convert.ToDateTime(dr["fechaInscripcion"]),
                                EstadoPago = Convert.ToBoolean(dr["estadopago"]),
                                oEstudiante = new Estudiante
                                {
                                    IdEstudiante = dr["idEstudiante"].ToString(),
                                    Nombres = dr["NombreEstudiante"].ToString(),
                                    APaterno = dr["aPaterno"].ToString(),
                                    AMaterno = dr["aMaterno"].ToString()
                                },
                                oCicloInscripcion = new CicloInscripcion { idciclo = Convert.ToInt32(dr["idciclo"]), nombreCiclo = dr["NombreCiclo"].ToString() },
                                oProgramaEstudios = new ProgramaEstudios { idprogramaestudios = Convert.ToInt32(dr["idprogramaestudios"]), nombre = dr["NombreProgramaEstudios"].ToString() },
                                oUsuario = new Usuario { idusuarios = dr["idusuarios"].ToString(), nombre = dr["Usuario"].ToString() },
                                oGrupo = new Grupo { IdGrupos = Convert.ToInt32(dr["idGrupos"]), NombreGrupo = dr["NombreGrupo"].ToString() }
                            };

                            lista.Add(inscripcion);
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Inscripcion>();
                }
            }

            return lista;
        }



        public bool Modificar(Inscripcion obj, out string Mensaje)
        {
            bool exito = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ModificarInscripcion", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("idInscripcion", obj.IdInscripcion);
                    cmd.Parameters.AddWithValue("turno", obj.Turno);
                    cmd.Parameters.AddWithValue("estadopago", obj.EstadoPago);
                    cmd.Parameters.AddWithValue("idEstudiante", obj.oEstudiante.IdEstudiante);
                    cmd.Parameters.AddWithValue("idciclo", obj.oCicloInscripcion.idciclo);
                    cmd.Parameters.AddWithValue("idprogramaestudios", obj.oProgramaEstudios.idprogramaestudios);
                    cmd.Parameters.AddWithValue("idusuarios", obj.oUsuario.idusuarios);
                    cmd.Parameters.AddWithValue("idGrupos", obj.oGrupo.IdGrupos);


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


        public bool Agregar(Inscripcion obj, out string Mensaje)
        {
            bool exito = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarInscripcion", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros de entrada
                    cmd.Parameters.AddWithValue("turno", obj.Turno);
                    cmd.Parameters.AddWithValue("estadopago", obj.EstadoPago);
                    cmd.Parameters.AddWithValue("idEstudiante", obj.oEstudiante.IdEstudiante);
                    cmd.Parameters.AddWithValue("idciclo", obj.oCicloInscripcion.idciclo);
                    cmd.Parameters.AddWithValue("idprogramaestudios", obj.oProgramaEstudios.idprogramaestudios);
                    cmd.Parameters.AddWithValue("idusuarios", obj.oUsuario.idusuarios);
                    cmd.Parameters.AddWithValue("idGrupos", obj.oGrupo.IdGrupos);

                    // Agregar parámetro opcional para la fecha
                    if (obj.FechaInscripcion != DateTime.MinValue)
                    {
                        cmd.Parameters.AddWithValue("fechaInscripcion", obj.FechaInscripcion);
                    }

                    // Agregar parámetros de salida
                    SqlParameter paramIdInscripcion = new SqlParameter("idInscripcion", SqlDbType.Int);
                    paramIdInscripcion.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramIdInscripcion);

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    obj.IdInscripcion = Convert.ToInt32(cmd.Parameters["idInscripcion"].Value);
                    exito = true;
                }
            }
            catch (Exception ex)
            {
                exito = false;
                Mensaje = ex.Message;
            }

            return exito;
        }

        public List<Inscripcion> Listar2(int idCiclo)
        {
            List<Inscripcion> lista = new List<Inscripcion>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ListarInscripcionesPorCiclo", conexion);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdCiclo", idCiclo);

                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Inscripcion inscripcion = new Inscripcion
                            {
                                oEstudiante = new Estudiante
                                {
                                    IdEstudiante = dr["idEstudiante"].ToString(),
                                    Nombres = dr["nombres_estudiante"].ToString(),
                                    APaterno = dr["Apellido_Paterno"].ToString(),
                                    AMaterno = dr["Apellido_Materno"].ToString(),
                                    Edad = Convert.ToInt32(dr["Edad"])
                                },
                                oProgramaEstudios = new ProgramaEstudios { nombre = dr["nombre_programa"].ToString() },
                                oGrupo = new Grupo { NombreGrupo = dr["nombreGrupo"].ToString() },
                                oCicloInscripcion = new CicloInscripcion { nombreCiclo = dr["nombreCiclo"].ToString() }
                            };

                            lista.Add(inscripcion);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción según tu lógica de negocio
                    lista = new List<Inscripcion>();
                    // Aquí podrías registrar la excepción o realizar alguna acción adecuada
                }
            }

            return lista;
        }



    }
}
