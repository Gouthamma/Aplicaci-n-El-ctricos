using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DITO
    {
        #region Editar ITO
        public  string DEditar(ITO EITO)
        {
            String rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ITOEditar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Value = EITO.ID;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 30;
                ParNombre.Value = EITO.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParProvincia = new SqlParameter();
                ParProvincia.ParameterName = "@ID_Provincia";
                ParProvincia.SqlDbType = SqlDbType.Int;
                ParProvincia.Size = 5;
                ParProvincia.Value = EITO.ID_Provincia;
                SqlCmd.Parameters.Add(ParProvincia);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@Correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 30;
                ParCorreo.Value = EITO.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 30;
                ParTelefono.Value = EITO.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

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
        #endregion Editar Comuna

        #region Insertar ITO
        public string DInsertar(ITO EITO)
        {
            String rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ITOInsertar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 30;
                ParNombre.Value = EITO.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParProvincia = new SqlParameter();
                ParProvincia.ParameterName = "@ID_Provincia";
                ParProvincia.SqlDbType = SqlDbType.Int;
                ParProvincia.Value = EITO.ID_Provincia;
                SqlCmd.Parameters.Add(ParProvincia);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@ID_Tipo";
                if (EITO.ID_Tipo == 0)
                    SqlCmd.Parameters.AddWithValue("@ID_Tipo", DBNull.Value);
                else
                    SqlCmd.Parameters.AddWithValue("@ID_Tipo", ParTipo);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@Correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 30;
                ParCorreo.Value = EITO.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 12;
                ParTelefono.Value = EITO.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingresa el Registro";
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
        #endregion Insertar ITO
    }
}
