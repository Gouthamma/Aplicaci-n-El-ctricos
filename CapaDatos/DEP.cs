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
   public class DEP
    {
        #region Insertar EP
        public static string DInsertar(EP EEP)
        {
            String rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "EPInsertar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 10;
                ParNombre.Value = EEP.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParRepresentante = new SqlParameter();
                ParRepresentante.ParameterName = "@Representante";
                ParRepresentante.SqlDbType = SqlDbType.VarChar;
                ParRepresentante.Value = EEP.Representante;
                SqlCmd.Parameters.Add(ParRepresentante);
                
                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@Correo";
                ParCorreo.SqlDbType = SqlDbType.Int;
                ParCorreo.Value = EEP.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Value = EEP.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

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

        public string DEditar(EP EEP)
        {
            String rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "EPEditar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Value = EEP.ID;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 30;
                ParNombre.Value = EEP.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParCoordProy = new SqlParameter();
                ParCoordProy.ParameterName = "@Representante";
                ParCoordProy.SqlDbType = SqlDbType.VarChar;
                ParCoordProy.Value = EEP.Representante;
                SqlCmd.Parameters.Add(ParCoordProy);

                SqlParameter ParCoordInsp = new SqlParameter();
                ParCoordInsp.ParameterName = "@Correo";
                ParCoordInsp.SqlDbType = SqlDbType.VarChar;
                ParCoordInsp.Value = EEP.Correo;
                SqlCmd.Parameters.Add(ParCoordInsp);

                SqlParameter ParCorreoProy = new SqlParameter();
                ParCorreoProy.ParameterName = "@Telefono";
                ParCorreoProy.SqlDbType = SqlDbType.VarChar;
                ParCorreoProy.Value = EEP.Telefono;
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
