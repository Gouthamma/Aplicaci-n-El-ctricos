            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using CapaEntidad;

namespace CapaNegocio
{
    public class NAgInspeccion
    {
        #region Agregar Inspeccion
        public static string Agregar(int ID_Obra, int ID_Electrico, DateTime F_Visita, byte[] Folio)//No necesita el id         {
        {
            Inspeccion Obj = new Inspeccion();
            Obj.ID_Obra = ID_Obra;
            Obj.ID_Electrico = ID_Electrico;
            Obj.F_Visita = F_Visita;
            Obj.Folio = Folio;


            return DAgInspeccion.DInsertar(Obj);
        }
        #endregion Agregar Inspeccion

        #region Editar Inspeccion
        public static string Editar(int ID, int ID_Obra, int ID_Electrico, DateTime F_Visita, byte[] Folio)//No necesita el id         {
        {
            Inspeccion Obj = new Inspeccion();
            Obj.ID = ID;
            Obj.ID_Obra = ID_Obra;
            Obj.ID_Electrico = ID_Electrico;
            Obj.F_Visita = F_Visita;
            Obj.Folio = Folio;

            return DAgInspeccion.DEditar(Obj);
        }
        #endregion Editar Inspeccion

        public static List<Electricos> Datos (string EUsurio)
            {
            Usuario us = new Usuario();
            us.Nombre = EUsurio;

            DAgInspeccion DAI = new DAgInspeccion();
            return DAI.Datos(us);       
            }
    }
}
