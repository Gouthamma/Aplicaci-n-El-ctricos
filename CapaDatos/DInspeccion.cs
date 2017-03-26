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
    public class DInspeccion
    {
        #region Mostrar Inspeccion
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "InspeccionVer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
                 {
                    DtResultado = null;
                 }       
            return DtResultado;
        }
        #endregion Mostrar Inspeccion

        #region Eliminar 
        public string Eliminar(Inspeccion I)
        {
            String rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Eliminar_Inspeccion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Value = I.ID;
                SqlCmd.Parameters.Add(ParID);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se eliminó el Registro";
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
        #endregion Eliminar

        #region Buscar Inspeccion
        public DataTable DBuscar(Obra Ob, Tipo Tp, Electricos El, Provincia Pv)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "InspeccionBuscar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParObra = new SqlParameter(); //este parametro va asociado al parametro del procedimineto SQL buscar
                ParObra.ParameterName = "@obra";
                ParObra.SqlDbType = SqlDbType.VarChar;                
                ParObra.Value = Ob.BuscarObra;//TextoBuscar es Parametro de esta clase
                SqlCmd.Parameters.Add(ParObra);

                SqlParameter ParTipo = new SqlParameter(); //este parametro va asociado al parametro del procedimineto SQL buscar
                ParTipo.ParameterName = "@tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Value = Tp.BuscarTipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParElectrico = new SqlParameter(); //este parametro va asociado al parametro del procedimineto SQL buscar
                ParElectrico.ParameterName = "@electrico";
                ParElectrico.SqlDbType = SqlDbType.VarChar;
                ParElectrico.Value = El.BuscarElectricos;
                SqlCmd.Parameters.Add(ParElectrico);

                SqlParameter ParProvincia = new SqlParameter(); //este parametro va asociado al parametro del procedimineto SQL buscar
                ParProvincia.ParameterName = "@provincia";
                ParProvincia.SqlDbType = SqlDbType.VarChar;
                ParProvincia.Value = Pv.BuscarProv;
                SqlCmd.Parameters.Add(ParProvincia);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        #endregion BuscarInspeccion
    }
}
