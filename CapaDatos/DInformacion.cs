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
    public class DInformacion
    {
        #region Mostrar todas las pantallas de Informacion
        public DataTable MostrarInfo(Proc a)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = a.Nombre;
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        #endregion Mostrar todas las pantallas de informacion 

        #region Eliminar cualquier registro de la pantalla seleccionada en informacion 
        public string EliminarInfo(Proc a)
        {
            String rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = a.Nombre;
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Value = a.ID;
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
        #endregion Eliminar cualquier registro de la pantalla seleccionada en informacion 

        #region Obra         
        #region Eliminar Obra (eliminado por procedimiento anterior)
        ////Borrar
        //public string DEliminar(Obra EObra)
        //{
        //    String rpta = "";
        //    SqlConnection SqlCon = new SqlConnection();
        //    try
        //    {
        //        SqlCon.ConnectionString = Conexion.Cn;
        //        SqlCon.Open();
        //        SqlCommand SqlCmd = new SqlCommand();
        //        SqlCmd.Connection = SqlCon;
        //        SqlCmd.CommandText = "EliminarObra";
        //        SqlCmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter ParID = new SqlParameter();
        //        ParID.ParameterName = "@ID";
        //        ParID.SqlDbType = SqlDbType.Int;
        //        ParID.Value = EObra.ID;
        //        SqlCmd.Parameters.Add(ParID);

        //        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se eliminó el Registro";
        //    }
        //    catch (Exception ex)
        //    {
        //        rpta = ex.Message;
        //    }
        //    finally
        //    {
        //        if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
        //    }
        //    return rpta;
        //}
        #endregion Eliminar Obra 

        #region Buscar Obra
        public DataTable DBuscarObra(Obra Ob, Tipo Tp, Electricos El)
        {           
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ObraBuscar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParObra = new SqlParameter(); //este parametro va asociado al parametro del procedimineto SQL buscar
                ParObra.ParameterName = "@obra";
                ParObra.SqlDbType = SqlDbType.VarChar;
                ParObra.Value = Ob.BuscarObra;
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

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        #endregion BuscarObra
        #endregion Obra

        #region Tipo    // Mover Insertar y Editar a DTipo
        //#region Insertar Tipo
        //public static string DInsertarTipo(Tipo ETipo)
        //{
        //    String rpta = "";
        //    SqlConnection SqlCon = new SqlConnection();
        //    try
        //    {
        //        SqlCon.ConnectionString = Conexion.Cn;
        //        SqlCon.Open();
        //        SqlCommand SqlCmd = new SqlCommand();
        //        SqlCmd.Connection = SqlCon;
        //        SqlCmd.CommandText = "InsertarTipo";
        //        SqlCmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter ParNombre = new SqlParameter();
        //        ParNombre.ParameterName = "@nombre";
        //        ParNombre.SqlDbType = SqlDbType.VarChar;
        //        ParNombre.Size = 10;
        //        ParNombre.Value = ETipo.Nombre;
        //        SqlCmd.Parameters.Add(ParNombre);

        //        SqlParameter ParCoordProy = new SqlParameter();
        //        ParCoordProy.ParameterName = "@CoordProy";
        //        ParCoordProy.SqlDbType = SqlDbType.VarChar;
        //        ParCoordProy.Value = ETipo.CoordProy;
        //        SqlCmd.Parameters.Add(ParCoordProy);

        //        SqlParameter PaCoordInspec = new SqlParameter();
        //        PaCoordInspec.ParameterName = "@CoordInspec";
        //        PaCoordInspec.SqlDbType = SqlDbType.Int;
        //        PaCoordInspec.Value = ETipo.CoordInspec;
        //        SqlCmd.Parameters.Add(PaCoordInspec);

        //        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el Registro";
        //    }
        //    catch (Exception ex)
        //    {
        //        rpta = ex.Message;
        //    }
        //    finally
        //    {
        //        if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
        //    }
        //    return rpta;
        //}
        //#endregion

        //#region Editar Tipo

        //public string DEditarTipo(Tipo ETipo)
        //{
        //    String rpta = "";
        //    SqlConnection SqlCon = new SqlConnection();
        //    try
        //    {
        //        SqlCon.ConnectionString = Conexion.Cn;
        //        SqlCon.Open();
        //        SqlCommand SqlCmd = new SqlCommand();
        //        SqlCmd.Connection = SqlCon;
        //        SqlCmd.CommandText = "EditarObra";
        //        SqlCmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter ParID = new SqlParameter();
        //        ParID.ParameterName = "@ID";
        //        ParID.SqlDbType = SqlDbType.Int;
        //        ParID.Value = ETipo.ID;
        //        SqlCmd.Parameters.Add(ParID);

        //        SqlParameter ParNombre = new SqlParameter();
        //        ParNombre.ParameterName = "@nombre";
        //        ParNombre.SqlDbType = SqlDbType.VarChar;
        //        ParNombre.Size = 30;
        //        ParNombre.Value = ETipo.Nombre;
        //        SqlCmd.Parameters.Add(ParNombre);

        //        SqlParameter ParCoordProy = new SqlParameter();
        //        ParCoordProy.ParameterName = "@CoordProy";
        //        ParCoordProy.SqlDbType = SqlDbType.Int;
        //        ParCoordProy.Value = ETipo.CoordProy;
        //        SqlCmd.Parameters.Add(ParCoordProy);

        //        SqlParameter ParCoordInsp = new SqlParameter();
        //        ParCoordInsp.ParameterName = "@CoordInspec";
        //        ParCoordInsp.SqlDbType = SqlDbType.Int;
        //        ParCoordInsp.Value = ETipo.CoordInspec;
        //        SqlCmd.Parameters.Add(ParCoordInsp);

        //        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Editó el Registro";
        //    }
        //    catch (Exception ex)
        //    {
        //        rpta = ex.Message;
        //    }
        //    finally
        //    {
        //        if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
        //    }
        //    return rpta;
        //}
        //#endregion Editar Tipo

        //#region Eliminar Tipo
        ////Borrar
        //public string DEliminarTipo(Tipo ETipo)
        //{
        //    String rpta = "";
        //    SqlConnection SqlCon = new SqlConnection();
        //    try
        //    {
        //        SqlCon.ConnectionString = Conexion.Cn;
        //        SqlCon.Open();
        //        SqlCommand SqlCmd = new SqlCommand();
        //        SqlCmd.Connection = SqlCon;
        //        SqlCmd.CommandText = "EliminarTipo";
        //        SqlCmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter ParID = new SqlParameter();
        //        ParID.ParameterName = "@ID";
        //        ParID.SqlDbType = SqlDbType.Int;
        //        ParID.Value = ETipo.ID;
        //        SqlCmd.Parameters.Add(ParID);

        //        rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se eliminó el Registro";
        //    }
        //    catch (Exception ex)
        //    {
        //        rpta = ex.Message;
        //    }
        //    finally
        //    {
        //        if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
        //    }
        //    return rpta;
        //}
        //#endregion    Eliminar Tipo

        #region Buscar Tipo
        //public DataTable DBuscarTipo(Tipo Obj)
        //{
        //    DataTable DtResultado = new DataTable("Tipo");
        //    SqlConnection SqlCon = new SqlConnection();
        //    try
        //    {
        //        SqlCon.ConnectionString = Conexion.Cn;
        //        SqlCommand SqlCmd = new SqlCommand();
        //        SqlCmd.Connection = SqlCon;
        //        SqlCmd.CommandText = "BuscarObra";
        //        SqlCmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter ParBuscar = new SqlParameter(); //este parametro va asociado al parametro del procedimineto SQL buscar
        //        ParBuscar.ParameterName = "@tipo";
        //        ParBuscar.SqlDbType = SqlDbType.Int;
        //        ParBuscar.Value = Obj.BuscarTipo;
        //        SqlCmd.Parameters.Add(ParBuscar);

        //        SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
        //        SqlDat.Fill(DtResultado);
        //    }
        //    catch (Exception ex)
        //    {
        //        DtResultado = null;
        //    }
        //    return DtResultado;
        //}

        #endregion BuscarObra
        #endregion Tipo 

        //#region ITO        
        //#region Eliminar ITO    
        //    public string DEliminar(ITO EITO)
        //    {
        //        String rpta = "";
        //        SqlConnection SqlCon = new SqlConnection();
        //        try
        //        {
        //            SqlCon.ConnectionString = Conexion.Cn;
        //            SqlCon.Open();
        //            SqlCommand SqlCmd = new SqlCommand();
        //            SqlCmd.Connection = SqlCon;
        //            SqlCmd.CommandText = "EliminarITO";
        //            SqlCmd.CommandType = CommandType.StoredProcedure;

        //            SqlParameter ParID = new SqlParameter();
        //            ParID.ParameterName = "@ID";
        //            ParID.SqlDbType = SqlDbType.Int;
        //            ParID.Value = EITO.ID;
        //            SqlCmd.Parameters.Add(ParID);

        //            rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se eliminó el Registro";
        //        }
        //        catch (Exception ex)
        //        {
        //            rpta = ex.Message;
        //        }
        //        finally
        //        {
        //            if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
        //        }
        //        return rpta;
        //    }
        //    #endregion Eliminar ITO


        //    #endregion ITO
        //}
    }
}