using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaNegocio
{
    public static class NObras
    {
        #region Cargar ComboBox
        public static DataTable CbObra()
        {
            DObras DO = new DObras();
            return DO.CBObra();
        }
        public static DataTable CbTipo()
        {
            DObras DO = new DObras();
            return DO.CBTipo();
        }
        public static DataTable CbProvincia()
        {
            DObras DO = new DObras();
            return DO.CBProvincia();
        }
        public static DataTable CbComunaE()
        {            
            DObras DO = new DObras();
            return DO.CBComunaE();
        }
        public static DataTable CbComuna(int Provincia)
        {
            Obra obj = new Obra();
            obj.ID_Provincia = Provincia;
            DObras DO = new DObras();
            return DO.CBComuna(obj);
        }
        public static DataTable CbITOE()
        {
            DObras DO = new DObras();
            return DO.CBITOE();
        }
        public static DataTable CbITO(int Provincia)
        {
            Obra obj = new Obra();
            obj.ID_Provincia = Provincia;
            DObras DO = new DObras();
            return DO.CBITO(obj);
        }
        public static DataTable CbElectrico()
        {
            DObras DO = new DObras();
            return DO.CBElectrico();
        }
        public static DataTable CbConstructora()
        {
            DObras DO = new DObras();
            return DO.CBConstructora();
        }
        public static DataTable CbEP()
        {
            DObras DO = new DObras();
            return DO.CBEP();
        }
        public static DataTable CbInstalador()
        {
            DObras DO = new DObras();
            return DO.CBInstalador();
        }
        public static DataTable CbFT()
        {
            DObras DO = new DObras();
            return DO.CBFT();
        }
        #endregion cargar Combobox

        #region Insertar Obra      
        public static string Insertar(string Nombre, int ID_Tipo, int ID_Provincia, int ID_Comuna, 
        int? ID_ITO, int ID_Electrico, int? ID_Constructora, int? ID_EP, int? ID_Instalador, DateTime? F_Inicio, 
        int? Plazo, int ID_FT, string GeoReferencia, string Rukan)//No necesita el id 
        {
            Obra Obj = new Obra();
            Obj.Nombre = Nombre;
            Obj.ID_Tipo = ID_Tipo;
            Obj.ID_Provincia = ID_Provincia;
            Obj.ID_Comuna = ID_Comuna;
            Obj.ID_ITO = ID_ITO;
            Obj.ID_Electricos = ID_Electrico;
            Obj.ID_Constructora = ID_Constructora;
            Obj.ID_EP = ID_EP;
            Obj.ID_Instalador = ID_Instalador;
            Obj.F_Inicio = F_Inicio;
            Obj.Plazo = Plazo;
            Obj.ID_FT = ID_FT;
            Obj.GeoReferencia = GeoReferencia;
            Obj.Rukan = Rukan;

            return DObras.DInsertar(Obj);
        }
        #endregion Insertar Obra

        #region Editar Obra
        public static string EditarObra(int ID, string Nombre, int ID_Tipo, int ID_Provincia, int ID_Comuna, int? ID_ITO, int ID_Electrico, int? ID_Constructora, int? ID_EP, int? ID_Instalador, DateTime F_Inicio, int? Plazo, int ID_FT, string GeoReferencia, string Rukan)//No necesita el id 
        {
            Obra Obj = new Obra();
            Obj.ID = ID;
            Obj.Nombre = Nombre;
            Obj.ID_Tipo = ID_Tipo;
            Obj.ID_Provincia = ID_Provincia;
            Obj.ID_Comuna = ID_Comuna;
            Obj.ID_ITO = ID_ITO;
            Obj.ID_Electricos = ID_Electrico;
            Obj.ID_Constructora = ID_Constructora;
            Obj.ID_EP = ID_EP;
            Obj.ID_Instalador = ID_Instalador;
            Obj.F_Inicio = F_Inicio;
            Obj.Plazo = Plazo;
            Obj.ID_FT = ID_FT;
            Obj.GeoReferencia = GeoReferencia;
            Obj.Rukan = Rukan;

            DObras DO = new DObras();
            return DO.DEditar(Obj);
        }
        #endregion Editar Obra
    }
}
