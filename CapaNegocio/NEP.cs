using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    class NEP
    {
        #region Insertar Tipo      
        public static string InsertarTipo(string Nombre, string CoordProyect, string CoordInspec, string CorreoProyect, string CorreoInspec)//No necesita el id 
        {
            Tipo Obj = new Tipo();
            Obj.Nombre = Nombre; //Se repite con cada parametro de metodo insertar
            Obj.CoordProy = CoordProyect;
            Obj.CoordInspec = CoordInspec;
            Obj.CorreoProy = CorreoProyect;
            Obj.CorreoInsp = CorreoInspec;

            return DTipo.DInsertarTipo(Obj);
        }
        #endregion Insertar Tipo

        #region Editar Tipo
        public static string EditarTipo(int ID, string Nombre, string CoordProy, string CoordInsp, string CorreoProyect, string CorreoInspec)//No necesita el id 
        {
            Tipo Obj = new Tipo();
            Obj.ID = ID;
            Obj.Nombre = Nombre;
            Obj.CoordProy = CoordProy;
            Obj.CoordInspec = CoordInsp;
            Obj.CorreoProy = CorreoProyect;
            Obj.CorreoInsp = CorreoInspec;

            DTipo DT = new DTipo();
            return DT.DEditarTipo(Obj);
        }

        #endregion Editar Tipo
    }
}
