using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
   
    public class NInspeccion
    {
        //Mostrar
        public static DataTable Mostrar()
        {
            return new DInspeccion().Mostrar();
        }
        //Buscar
        #region Buscar Inspeccion
        public static DataTable Buscar(string BObra, string BTipo, string BElec, string BProv)
        {
            Obra Ob = new Obra();
            Ob.BuscarObra = BObra;

            Tipo Tp = new Tipo();
            Tp.BuscarTipo = BTipo;

            Electricos el = new Electricos();
            el.BuscarElectricos = BElec;

            Provincia Pv = new Provincia();
            Pv.BuscarProv = BProv;

            DInspeccion DI = new DInspeccion();
            return DI.DBuscar(Ob, Tp, el, Pv);
        }
        #endregion Buscar Inspeccion

    }
}
