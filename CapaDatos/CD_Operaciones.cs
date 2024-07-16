using CapaDatos1;
using CapadeEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Operaciones
    {
        public List<Departamento> Obtenerdepartamentos() { 
        List <Departamento> olistardepartamento= new   List<Departamento>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("obtenerregiones", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 600;
                oConexion.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    olistardepartamento.Add(new Departamento

                    {
                        iddepartamento = Convert.ToInt32(dr["idDepartamento"]),
                        nombredepartamento = Convert.ToString(dr["nombredepartamento"].ToString())

                    });
                
                
                }
                dr.Close();
            
            
            }
            return olistardepartamento;
        
        
        }

        public List<Provincia> obtenerprovincias(int iddeparetment)
        {
            List<Provincia> olistarprovincia = new List<Provincia>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("ontenerobtenerprovincias", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Departamento_idDepartamento",iddeparetment);
                cmd.CommandTimeout = 600;
                oConexion.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    olistarprovincia.Add(new Provincia

                    {
                        idprovincia = Convert.ToInt32(dr["idProvincia"]),
                        nombreprovincia = Convert.ToString(dr["nombreprovincia"].ToString())

                    });


                }
                dr.Close();


            }
            return olistarprovincia;


        }



        public List<Distrito> obtenerdistrito(int idprove)
        {
            List<Distrito> olistardistri = new List<Distrito>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("obtenerdistritos", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Provincia_idProvincia", idprove);
                cmd.CommandTimeout = 600;
                oConexion.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    olistardistri.Add(new Distrito

                    {
                        iddistrito = Convert.ToInt32(dr["idDistritos"]),
                        nombredistrito = Convert.ToString(dr["nombredistrito"].ToString())

                    });


                }
                dr.Close();


            }
            return olistardistri;


        }


        public List<Colegio> obtenercolegio(int iddistri)
        {
            List<Colegio> olistardistri = new List<Colegio>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("obtenercolegio", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Distritos_idDistritos", iddistri);
                cmd.CommandTimeout = 600;
                oConexion.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    olistardistri.Add(new Colegio

                    {
                        idcolegio = Convert.ToInt32(dr["idcolegios"]),
                        nombrecolegio = Convert.ToString(dr["nombrecolegio"].ToString())

                    });


                }
                dr.Close();


            }
            return olistardistri;


        }

    }
}
