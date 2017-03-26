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
   public class DConstructora
    {
        #region Insertar Constructora
        public static string DInsertar(Constructora EConstructora)
        {
            String rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ConstructoraInsertar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 10;
                ParNombre.Value = EConstructora.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParCoordProy = new SqlParameter();
                ParCoordProy.ParameterName = "@Representante";
                ParCoordProy.SqlDbType = SqlDbType.VarChar;
                ParCoordProy.Value = EConstructora.Representante;
                SqlCmd.Parameters.Add(ParCoordProy);

                SqlParameter PaCoordInspec = new SqlParameter();
                PaCoordInspec.ParameterName = "@Correo";
                PaCoordInspec.SqlDbType = SqlDbType.Int;
                PaCoordInspec.Value = EConstructora.Correo;
                SqlCmd.Parameters.Add(PaCoordInspec);

                SqlParameter ParCorreoProy = new SqlParameter();
                ParCorreoProy.ParameterName = "@Telefono";
                ParCorreoProy.SqlDbType = SqlDbType.VarChar;
                ParCorreoProy.Value = EConstructora.Telefono;
                SqlCmd.Parameters.Add(ParCorreoProy);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el Registro";
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
        #endregion Insertar Tipo

        #region Editar Tipo

        public string DEditar(Constructora EConstructora)
        {
            String rpta = "";
            SqlConnection SqlCon = new SqlConnection();
         try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ConstructoraEditar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Value = EConstructora.ID;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 30;
                ParNombre.Value = EConstructora.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParCoordProy = new SqlParameter();
                ParCoordProy.ParameterName = "@Representante";
                ParCoordProy.SqlDbType = SqlDbType.VarChar;
                ParCoordProy.Value = EConstructora.Representante;
                SqlCmd.Parameters.Add(ParCoordProy);

                SqlParameter ParCoordInsp = new SqlParameter();
                ParCoordInsp.ParameterName = "@Correo";
                ParCoordInsp.SqlDbType = SqlDbType.VarChar;
                ParCoordInsp.Value = EConstructora.Correo;
                SqlCmd.Parameters.Add(ParCoordInsp);

                SqlParameter ParCorreoProy = new SqlParameter();
                ParCorreoProy.ParameterName = "@Telefono";
                ParCorreoProy.SqlDbType = SqlDbType.VarChar;
                ParCorreoProy.Value = EConstructora.Telefono;
                SqlCmd.Parameters.Add(ParCorreoProy);                

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
        #endregion Editar Tipo
    }
}
