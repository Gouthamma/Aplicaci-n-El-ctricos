using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class NInformacion
    {
        public static DataTable mostrarinfo(Proc a)
        {
            DInformacion di = new DInformacion();
            return di.MostrarInfo(a);
        }

        public static string eliminarinfo(string Nombre, int ID)
        {
            Proc Obj = new Proc();
            Obj.Nombre = Nombre;
            Obj.ID = ID;

            DInformacion DI = new DInformacion();
            return DI.EliminarInfo(Obj);
        }
        #region Obra      
        //#region Borrar Obra
        //public static string Borrar(int ID)
        //{
        //    Obra Obj = new Obra();
        //    Obj.ID = ID;

        //    DInformacion DI = new DInformacion();
        //    return DI.DEliminar(Obj);
        //}
        //#endregion Borrar Obra

        #region Buscar Obra
        public static DataTable BuscarObra(string BObra, string BTipo, string BElec)
        {
            Obra Ob = new Obra();
            Ob.BuscarObra = BObra;

            Tipo Tp = new Tipo();
            Tp.BuscarTipo = BTipo;

            Electricos El = new Electricos();
            El.BuscarElectricos = BElec;

            DInformacion DI = new DInformacion();
            return DI.DBuscarObra(Ob, Tp, El);
        }
        #endregion
        #endregion Obra

        #region Tipo         
        //#region Insertar Tipo      
        //public static string InsertarTipo(string Nombre, string CoordProyect, string CoordInspec)//No necesita el id 
        //{
        //    Tipo Obj = new Tipo();
        //    Obj.Nombre = Nombre; //Se repite con cada parametro de metodo insertar
        //    Obj.CoordProy = CoordProyect;
        //    Obj.CoordInspec = CoordInspec;

        //    return DInformacion.DInsertarTipo(Obj);
        //}
        //#endregion Insertar Tipo

        //#region Editar Tipo
        //public static string EditarTipo(int ID, string Nombre, string CoordProy, string CoordInsp)//No necesita el id 
        //{
        //    Tipo Obj = new Tipo();
        //    Obj.ID = ID;
        //    Obj.Nombre = Nombre;
        //    Obj.CoordProy = CoordProy;
        //    Obj.CoordInspec = CoordInsp;
            
        //    DInformacion DI = new DInformacion();
        //    return DI.DEditarTipo(Obj);
        //}

        //#endregion Editar Tipo

        //#region Eliminar Tipo
        //public static string BorrarTipo(int ID)
        //{
        //    Tipo Obj = new Tipo();
        //    Obj.ID = ID;

        //    DInformacion DI = new DInformacion();
        //    return DI.DEliminarTipo(Obj);
        //}
        //#endregion Eliminar Tipo

        #region Buscar Tipo
        //public static DataTable BuscarTipo(string buscar)
        //{
        //    Tipo Obj = new Tipo();
        //    Obj.BuscarTipo = buscar;

        //    DInformacion DI = new DInformacion();
        //    return DI.DBuscarTipo(Obj);
        //}
        #endregion Buscar Tipo
        #endregion Tipo

        //#region Borrar ITO
        //public static string Borrar(int ID)
        //{
        //    ITO Obj = new ITO();
        //    Obj.ID = ID;

        //    DInformacion DI = new DInformacion();
        //    return DI.DEliminar(Obj);
        //}
        //#endregion Borrar Obra

    }
}
