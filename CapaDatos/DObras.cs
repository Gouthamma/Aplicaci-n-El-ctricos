using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class DObras
    {
        #region Llenar Combobox
        public DataTable CBTipo()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "TipoVer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }
        public DataTable CBProvincia()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ProvinciaVer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }
        public DataTable CBComunaE()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ComunaVer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }
        public DataTable CBComuna(Obra Ob)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ComunaFiltrar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParProvincia = new SqlParameter(); //este parametro va asociado al parametro del procedimineto SQL buscar
                ParProvincia.ParameterName = "@Provincia";
                ParProvincia.SqlDbType = SqlDbType.Int;
                ParProvincia.Value = Ob.ID_Provincia;//TextoBuscar es Parametro de esta clase
                SqlCmd.Parameters.Add(ParProvincia);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }
        public DataTable CBITOE()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ITOVer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }
        public DataTable CBITO(Obra Ob)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ITOFiltrar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParProvincia = new SqlParameter(); //este parametro va asociado al parametro del procedimineto SQL buscar
                ParProvincia.ParameterName = "@Provincia";
                ParProvincia.SqlDbType = SqlDbType.Int;
                ParProvincia.Value = Ob.ID_Provincia;//TextoBuscar es Parametro de esta clase
                SqlCmd.Parameters.Add(ParProvincia);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }
        public DataTable CBElectrico()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ElectricosVer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }
        public DataTable CBConstructora()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ConstructoraVer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }
        public DataTable CBEP()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "EPVer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }
        public DataTable CBInstalador()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "InstaladorVer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }
        public DataTable CBFT()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "FTVer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }
        public DataTable CBObra()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ObrasVer";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }
        #endregion llenar Combobox

        #region Insertar Obra
        public static string DInsertar(Obra EObra)
        {
            String rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ObraInsertar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = EObra.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParIDTipo = new SqlParameter();
                ParIDTipo.ParameterName = "@ID_Tipo";
                ParIDTipo.SqlDbType = SqlDbType.Int;
                ParIDTipo.Value = EObra.ID_Tipo;
                SqlCmd.Parameters.Add(ParIDTipo);

                SqlParameter ParIDProvincia = new SqlParameter();
                ParIDProvincia.ParameterName = "@ID_Provincia";
                ParIDProvincia.SqlDbType = SqlDbType.Int;
                ParIDProvincia.Value = EObra.ID_Provincia;
                SqlCmd.Parameters.Add(ParIDProvincia);

                SqlParameter ParIDComuna = new SqlParameter();
                ParIDComuna.ParameterName = "@ID_Comuna";
                ParIDComuna.SqlDbType = SqlDbType.Int;
                ParIDComuna.Value = EObra.ID_Comuna;
                SqlCmd.Parameters.Add(ParIDComuna);

                SqlParameter ParIDITO = new SqlParameter();
                ParIDITO.ParameterName = "@ID_ITO";
                ParIDITO.SqlDbType = SqlDbType.Int;
                if (EObra.ID_ITO == 0)
                    SqlCmd.Parameters.AddWithValue("@ID_ITO", DBNull.Value);
                else
                    SqlCmd.Parameters.AddWithValue("@ID_ITO", ParIDITO.Value);
                //ParIDITO.Value = EObra.ID_ITO;
                //SqlCmd.Parameters.AddWithValue(ParIDITO.IsNullable);

                SqlParameter ParIDElectrico = new SqlParameter();
                ParIDElectrico.ParameterName = "@ID_Electrico";
                ParIDElectrico.SqlDbType = SqlDbType.Int;
                ParIDElectrico.Value = EObra.ID_Electricos;
                SqlCmd.Parameters.Add(ParIDElectrico);

                SqlParameter ParIDConstructora = new SqlParameter();
                ParIDConstructora.ParameterName = "@ID_Constructora";
                ParIDConstructora.SqlDbType = SqlDbType.Int;
                if (EObra.ID_Constructora == 0)
                    SqlCmd.Parameters.AddWithValue("@ID_Constructora", DBNull.Value);
                else
                    SqlCmd.Parameters.AddWithValue("@ID_Constructora", ParIDConstructora.Value);
                //ParIDConstructora.Value = EObra.ID_Constructora;
                //SqlCmd.Parameters.Add(ParIDConstructora.IsNullable);

                SqlParameter ParIDEP = new SqlParameter();
                ParIDEP.ParameterName = "@ID_EP";
                ParIDEP.SqlDbType = SqlDbType.Int;
                if (EObra.ID_EP == 0)
                    SqlCmd.Parameters.AddWithValue("@ID_EP", DBNull.Value);
                else
                    SqlCmd.Parameters.AddWithValue("@ID_EP", ParIDEP.Value);
                //ParIDEP.Value = EObra.ID_EP;
                //SqlCmd.Parameters.Add(ParIDEP.IsNullable);

                SqlParameter ParIDInstalador = new SqlParameter();
                ParIDInstalador.ParameterName = "@ID_Instalador";
                ParIDInstalador.SqlDbType = SqlDbType.Int;
                if (EObra.ID_Instalador == 0)
                    SqlCmd.Parameters.AddWithValue("@ID_Instalador", DBNull.Value);
                else
                    SqlCmd.Parameters.AddWithValue("@ID_Instalador", ParIDInstalador.Value);
                //ParIDInstalador.Value = EObra.ID_Instalador;
                //SqlCmd.Parameters.Add(ParIDInstalador.IsNullable);

                SqlParameter ParF_Inicio = new SqlParameter();
                ParF_Inicio.ParameterName = "@F_Inicio";
                ParF_Inicio.SqlDbType = SqlDbType.Date;
                DateTime t0 = new DateTime(2010, 01, 01);
                if (EObra.F_Inicio == t0)
                    SqlCmd.Parameters.AddWithValue("@F_Inicio", DBNull.Value);
                else
                    SqlCmd.Parameters.AddWithValue("@F_Inicio", ParF_Inicio.Value);
                //ParF_Inicio.Value = EObra.F_Inicio;
                //SqlCmd.Parameters.Add(ParF_Inicio);

                SqlParameter ParPlazo = new SqlParameter();
                ParPlazo.ParameterName = "@Plazo";
                ParPlazo.SqlDbType = SqlDbType.Int;
                if (EObra.Plazo == 0) // solo en parametros de tipo Int ya que no indican null de forma automatica
                    SqlCmd.Parameters.AddWithValue("@Plazo", DBNull.Value);
                else
                    SqlCmd.Parameters.AddWithValue("@Plazo", ParPlazo.Value);
                //ParPlazo.Value = EObra.Plazo;
                //SqlCmd.Parameters.Add(ParPlazo.IsNullable);

                SqlParameter ParGeo = new SqlParameter();
                ParGeo.ParameterName = "@GeoReferencia";
                ParGeo.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 25;
                ParGeo.Value = EObra.GeoReferencia;//No es necesario usar AddWhitValue por ser String 
                SqlCmd.Parameters.Add(ParGeo);

                SqlParameter ParRukan = new SqlParameter();
                ParRukan.ParameterName = "@Rukan";
                ParRukan.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 6;
                ParRukan.Value = EObra.Rukan;
                SqlCmd.Parameters.Add(ParRukan);

                SqlParameter ParIDFT = new SqlParameter();
                ParIDFT.ParameterName = "@ID_FT";
                ParIDFT.SqlDbType = SqlDbType.Int;
                ParIDFT.Value = EObra.ID_FT;
                SqlCmd.Parameters.Add(ParIDFT);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingresó el Registro";
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
        #endregion Insertar Obra

        #region Editar Obra
        public string DEditar(Obra EObra)
        {
            String rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ObraEditar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@ID";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Value = EObra.ID;
                SqlCmd.Parameters.Add(ParID);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = EObra.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParIDTipo = new SqlParameter();
                ParIDTipo.ParameterName = "@ID_Tipo";
                ParIDTipo.SqlDbType = SqlDbType.Int;
                ParIDTipo.Value = EObra.ID_Tipo;
                SqlCmd.Parameters.Add(ParIDTipo);

                SqlParameter ParIDProvincia = new SqlParameter();
                ParIDProvincia.ParameterName = "@ID_Provincia";
                ParIDProvincia.SqlDbType = SqlDbType.Int;
                ParIDProvincia.Value = EObra.ID_Provincia;
                SqlCmd.Parameters.Add(ParIDProvincia);

                SqlParameter ParIDComuna = new SqlParameter();
                ParIDComuna.ParameterName = "@ID_Comuna";
                ParIDComuna.SqlDbType = SqlDbType.Int;
                ParIDComuna.Value = EObra.ID_Comuna;
                SqlCmd.Parameters.Add(ParIDComuna);

                SqlParameter ParIDITO = new SqlParameter();
                ParIDITO.ParameterName = "@ID_ITO";
                ParIDITO.SqlDbType = SqlDbType.Int;
                if (EObra.ID_ITO == 0)
                    SqlCmd.Parameters.AddWithValue("@ID_ITO", DBNull.Value);
                else
                    SqlCmd.Parameters.AddWithValue("@ID_ITO", ParIDITO.Value);
                //ParIDITO.Value = EObra.ID_ITO;
                //SqlCmd.Parameters.Add(ParIDITO);

                SqlParameter ParIDElectrico = new SqlParameter();
                ParIDElectrico.ParameterName = "@ID_Electrico";
                ParIDElectrico.SqlDbType = SqlDbType.Int;
                ParIDElectrico.Value = EObra.ID_Electricos;
                SqlCmd.Parameters.Add(ParIDElectrico);

                SqlParameter ParIDConstructora = new SqlParameter();
                ParIDConstructora.ParameterName = "@ID_Constructora";
                ParIDConstructora.SqlDbType = SqlDbType.Int;
                if (EObra.ID_Constructora == 0)
                    SqlCmd.Parameters.AddWithValue("@ID_Constructora", DBNull.Value);
                else
                    SqlCmd.Parameters.AddWithValue("@ID_Constructora", ParIDConstructora.Value);
                //ParIDConstructora.Value = EObra.ID_Constructora;
                //SqlCmd.Parameters.Add(ParIDConstructora);

                SqlParameter ParIDEP = new SqlParameter();
                ParIDEP.ParameterName = "@ID_EP";
                ParIDEP.SqlDbType = SqlDbType.Int;
                if (EObra.ID_EP == 0)
                    SqlCmd.Parameters.AddWithValue("@ID_EP", DBNull.Value);
                else
                    SqlCmd.Parameters.AddWithValue("@ID_EP", ParIDEP.Value);
                //ParIDEP.Value = EObra.ID_EP;
                //SqlCmd.Parameters.Add(ParIDEP);

                SqlParameter ParIDInstalador = new SqlParameter();
                ParIDInstalador.ParameterName = "@ID_Instalador";
                ParIDInstalador.SqlDbType = SqlDbType.Int;
                if (EObra.ID_Instalador == 0)
                    SqlCmd.Parameters.AddWithValue("@ID_Instalador", DBNull.Value);
                else
                    SqlCmd.Parameters.AddWithValue("@ID_Instalador", ParIDInstalador.Value);
                //ParIDInstalador.Value = EObra.ID_Instalador;
                //SqlCmd.Parameters.Add(ParIDInstalador);

                SqlParameter ParF_Inicio = new SqlParameter();
                ParF_Inicio.ParameterName = "@F_Inicio";
                ParF_Inicio.SqlDbType = SqlDbType.Date;
                DateTime t0 = new DateTime(2010, 01, 01);
                if (EObra.F_Inicio == t0)
                    SqlCmd.Parameters.AddWithValue("@F_Inicio", DBNull.Value);
                else
                    SqlCmd.Parameters.AddWithValue("@F_Inicio", ParF_Inicio.Value);
                //ParF_Inicio.Value = EObra.F_Inicio;
                //SqlCmd.Parameters.Add(ParF_Inicio);

                SqlParameter ParPlazo = new SqlParameter();
                ParPlazo.ParameterName = "@Plazo";
                ParPlazo.SqlDbType = SqlDbType.Int;
                //ParPlazo.Value = EObra.Plazo;
                //SqlCmd.Parameters.Add(ParPlazo);
                if (EObra.Plazo == 0)
                    SqlCmd.Parameters.AddWithValue("@Plazo", DBNull.Value);
                else
                    SqlCmd.Parameters.AddWithValue("@Plazo", ParPlazo.Value);

                SqlParameter ParGeo = new SqlParameter();
                ParGeo.ParameterName = "@GeoReferencia";
                ParGeo.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 25;
                ParGeo.Value = EObra.GeoReferencia;
                SqlCmd.Parameters.Add(ParGeo);

                SqlParameter ParRukan = new SqlParameter();
                ParRukan.ParameterName = "@Rukan";
                ParRukan.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParRukan.Value = EObra.Rukan;
                SqlCmd.Parameters.Add(ParRukan);

                SqlParameter ParIDFT = new SqlParameter();
                ParIDFT.ParameterName = "@ID_FT";
                ParIDFT.SqlDbType = SqlDbType.Int;
                if (EObra.ID_FT == 0)
                    SqlCmd.Parameters.AddWithValue("@ID_FT", DBNull.Value);
                else
                    SqlCmd.Parameters.AddWithValue("@ID_FT", ParIDFT.Value);
                //ParIDFT.Value = EObra.ID_FT;
                //SqlCmd.Parameters.Add(ParIDFT);

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
        #endregion

    }
}
