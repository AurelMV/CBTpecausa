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
    public class CD_Pago
    {
        public List<Pago> Listar(int idCiclo)
        {
            List<Pago> lista = new List<Pago>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.idPagos, p.fecha AS fechaPago, p.monto, p.medioPago, p.nroVoucher, ");
                    query.AppendLine("i.idInscripcion, i.fechaInscripcion, i.estadopago, ");
                    query.AppendLine("e.idEstudiante, e.nombres, e.aPaterno, e.aMaterno ");
                    query.AppendLine("FROM pagos p ");
                    query.AppendLine("INNER JOIN Inscripcion i ON p.idInscripcion = i.idInscripcion ");
                    query.AppendLine("INNER JOIN estudiantes e ON i.idEstudiante = e.idEstudiante ");
                    query.AppendLine("WHERE i.idCiclo = @idCiclo;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@idCiclo", idCiclo);
                    conexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Pago pago = new Pago
                            {
                                IdPago = dr["idPagos"].ToString(),
                                Fecha = Convert.ToDateTime(dr["fechaPago"]),
                                Monto = Convert.ToInt32(dr["monto"]),
                                MedioPago = dr["medioPago"].ToString(),
                                NroVoucher = dr["nroVoucher"].ToString(),
                                oInscripcion = new Inscripcion
                                {
                                    IdInscripcion = Convert.ToInt32(dr["idInscripcion"]),
                                    FechaInscripcion = Convert.ToDateTime(dr["fechaInscripcion"]),
                                    EstadoPago = Convert.ToBoolean(dr["estadopago"]),
                                    oEstudiante = new Estudiante
                                    {
                                        IdEstudiante = dr["idEstudiante"].ToString(),
                                        Nombres = dr["nombres"].ToString(),
                                        APaterno = dr["aPaterno"].ToString(),
                                        AMaterno = dr["aMaterno"].ToString()
                                    }
                                }
                            };

                            lista.Add(pago);
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Pago>();
                }
            }

            return lista;
        }


        public bool Registrar(Pago obj, out String Mensaje)
        {
            bool exito = false;
            Mensaje = String.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_InsertarPago", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros de entrada
                    cmd.Parameters.AddWithValue("idPagos", obj.IdPago);
                    cmd.Parameters.AddWithValue("fecha", obj.Fecha);
                    cmd.Parameters.AddWithValue("monto", obj.Monto);
                    cmd.Parameters.AddWithValue("medioPago", obj.MedioPago);
                    cmd.Parameters.AddWithValue("nroVoucher", obj.NroVoucher);
                    cmd.Parameters.AddWithValue("idInscripcion", obj.IdInscripcion);

                    // Agregar parámetros de salida
                    SqlParameter paramExito = new SqlParameter("exito", SqlDbType.Bit);
                    paramExito.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramExito);

                    SqlParameter paramMensaje = new SqlParameter("mensaje", SqlDbType.NVarChar, 100);
                    paramMensaje.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(paramMensaje);

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    Mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                Mensaje = ex.Message;
            }

            return exito=true;
        }


        public bool Modificar(Pago obj, out string Mensaje)
        {
            bool exito = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ModificarPago", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de entrada
                    cmd.Parameters.AddWithValue("idPagos", obj.IdPago);
                    cmd.Parameters.AddWithValue("fecha", obj.Fecha);
                    cmd.Parameters.AddWithValue("monto", obj.Monto);
                    cmd.Parameters.AddWithValue("medioPago", obj.MedioPago);
                    cmd.Parameters.AddWithValue("nroVoucher", obj.NroVoucher);
                    cmd.Parameters.AddWithValue("idInscripcion", obj.IdInscripcion);


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

            return exito = true;
        }
    }
}
