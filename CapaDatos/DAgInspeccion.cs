using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
namespace CapaDatos
{
    public class DAgInspeccion
    {
        #region Editar Inspeccion
        public static string DEditar(Inspeccion EInspeccion)
        {
            String rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "InspeccionEditar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Value = EInspeccion.ID;
                SqlCmd.Parameters.Add(ParID);            

                SqlParameter ParID_Obra = new SqlParameter();
                ParID_Obra.ParameterName = "@ID_Obra";
                ParID_Obra.SqlDbType = SqlDbType.Int;                
                ParID_Obra.Value = EInspeccion.ID_Obra;
                SqlCmd.Parameters.Add(ParID_Obra);

                SqlParameter ParID_Electrico = new SqlParameter();
                ParID_Electrico.ParameterName = "@ID_Electrico";
                ParID_Electrico.SqlDbType = SqlDbType.Int;
                ParID_Electrico.Value = EInspeccion.ID_Electrico;
                SqlCmd.Parameters.Add(ParID_Electrico);

                SqlParameter ParF_Visita = new SqlParameter();
                ParF_Visita.ParameterName = "@F_Visita";
                ParF_Visita.SqlDbType = SqlDbType.Date;
                ParF_Visita.Value = EInspeccion.F_Visita;
                SqlCmd.Parameters.Add(ParF_Visita);

                SqlParameter ParFolio = new SqlParameter();
                ParFolio.ParameterName = "@Folio";
                ParFolio.SqlDbType = SqlDbType.Image;
                ParFolio.Value = EInspeccion.Folio;
                SqlCmd.Parameters.Add(ParFolio);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Editó el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
        #endregion Editar Inspeccion

        #region Insertar Inspeccion
        public static string DInsertar(Inspeccion EInspeccion)
        {
            String rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "InspeccionInsertar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID_Obra = new SqlParameter();
                ParID_Obra.ParameterName = "@ID_Obra";
                ParID_Obra.SqlDbType = SqlDbType.Int;
                ParID_Obra.Value = EInspeccion.ID_Obra;
                SqlCmd.Parameters.Add(ParID_Obra);

                SqlParameter ParID_Electrico = new SqlParameter();
                ParID_Electrico.ParameterName = "@ID_Electrico";
                ParID_Electrico.SqlDbType = SqlDbType.Int;
                ParID_Electrico.Value = EInspeccion.ID_Electrico;
                SqlCmd.Parameters.Add(ParID_Electrico);

                SqlParameter ParF_Visita = new SqlParameter();
                ParF_Visita.ParameterName = "@F_Visita";
                ParF_Visita.SqlDbType = SqlDbType.Date;
                ParF_Visita.Value = EInspeccion.F_Visita;
                SqlCmd.Parameters.Add(ParF_Visita);

                SqlParameter ParFolio = new SqlParameter();
                ParFolio.ParameterName = "@Folio";
                ParFolio.SqlDbType = SqlDbType.Image;
                ParFolio.Value = EInspeccion.Folio;
                SqlCmd.Parameters.Add(ParFolio);

                //SqlParameter ParFolio2 = new SqlParameter();
                //ParFolio2.ParameterName = "@Folio2";
                //ParFolio2.SqlDbType = SqlDbType.VarBinary;
                //ParFolio2.Value = EInspeccion.Folio2;
                //SqlCmd.Parameters.Add(ParFolio2);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Insertó el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
        #endregion Insertar Inspeccion

        public List<Electricos> Datos(Usuario EUsuario)
        {
            SqlConnection SqlCon = new SqlConnection();
            List<Electricos> electricos = new List<Electricos>();

            SqlCon.ConnectionString = Conexion.Cn;
            SqlCon.Open();
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "Login";
            SqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter ParUsuario = new SqlParameter();
            ParUsuario.ParameterName = "@Usuario";//El usuario es el correo
            ParUsuario.SqlDbType = SqlDbType.VarChar;
            ParUsuario.Value =EUsuario.Nombre;
            SqlCmd.Parameters.Add(ParUsuario);

            SqlDataReader Leer = SqlCmd.ExecuteReader();
            
            if (Leer.HasRows)
            {
                while(Leer.Read())
                { 
                Electricos El = new Electricos();
                El.ID = Convert.ToInt32(Leer["ID"].ToString());
                El.Nombre = Leer["Nombre"].ToString();
                El.RUT = Leer["RUT"].ToString();
                El.Contraseña = Leer["Contraseña"].ToString();
                    electricos.Add(El);
                }
            }
            else
            {
                Console.WriteLine("No Se encuentran registros para este usuario");
            }
            Leer.Close();

            return electricos;

            //if (Leer.Read() == true) return Leer["Nombre"].ToString();
            //else return "".ToString();
        }
    }
}
