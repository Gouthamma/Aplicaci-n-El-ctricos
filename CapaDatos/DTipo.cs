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
    public class DTipo
    {
     
        #region Insertar Tipo
        public static string DInsertarTipo(Tipo ETipo)
        {
            String rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "TipoInsertar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 10;
                ParNombre.Value = ETipo.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParCoordProy = new SqlParameter();
                ParCoordProy.ParameterName = "@CoordProy";
                ParCoordProy.SqlDbType = SqlDbType.VarChar;
                ParCoordProy.Value = ETipo.CoordProy;
                SqlCmd.Parameters.Add(ParCoordProy);

                SqlParameter PaCoordInspec = new SqlParameter();
                PaCoordInspec.ParameterName = "@CoordInspec";
                PaCoordInspec.SqlDbType = SqlDbType.Int;
                PaCoordInspec.Value = ETipo.CoordInspec;
                SqlCmd.Parameters.Add(PaCoordInspec);

                SqlParameter ParCorreoProy = new SqlParameter();
                ParCorreoProy.ParameterName = "@CoordInspec";
                ParCorreoProy.SqlDbType = SqlDbType.VarChar;
                ParCorreoProy.Value = ETipo.CorreoProy;
                SqlCmd.Parameters.Add(ParCorreoProy);

                SqlParameter ParCorreoInsp = new SqlParameter();
                ParCorreoInsp.ParameterName = "@CoordInspec";
                ParCorreoInsp.SqlDbType = SqlDbType.VarChar;
                ParCorreoInsp.Value = ETipo.CorreoInsp;
                SqlCmd.Parameters.Add(ParCorreoInsp);

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

        public string DEditarTipo(Tipo ETipo)
        {
            String rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "TipoEditar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Value = ETipo.ID;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 30;
                ParNombre.Value = ETipo.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParCoordProy = new SqlParameter();
                ParCoordProy.ParameterName = "@CoordProy";
                ParCoordProy.SqlDbType = SqlDbType.VarChar;
                ParCoordProy.Value = ETipo.CoordProy;
                SqlCmd.Parameters.Add(ParCoordProy);

                SqlParameter ParCoordInsp = new SqlParameter();
                ParCoordInsp.ParameterName = "@CoordInspec";
                ParCoordInsp.SqlDbType = SqlDbType.VarChar;
                ParCoordInsp.Value = ETipo.CoordInspec;
                SqlCmd.Parameters.Add(ParCoordInsp);

                SqlParameter ParCorreoProy = new SqlParameter();
                ParCorreoProy.ParameterName = "@CoordInspec";
                ParCorreoProy.SqlDbType = SqlDbType.VarChar;
                ParCorreoProy.Value = ETipo.CorreoProy;
                SqlCmd.Parameters.Add(ParCorreoProy);

                SqlParameter ParCorreoInsp = new SqlParameter();
                ParCorreoInsp.ParameterName = "@CoordInspec";
                ParCorreoInsp.SqlDbType = SqlDbType.VarChar;
                ParCorreoInsp.Value = ETipo.CorreoInsp;
                SqlCmd.Parameters.Add(ParCorreoInsp);

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
