using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NITO
    {
        #region editar ITO
        public static string EditarITO(int ID, string Nombre, int ID_Tipo, int ID_Provincia, string Correo, string Telefono)//No necesita el id 
        {
            ITO Obj = new ITO();
            Obj.ID = ID;
            Obj.Nombre = Nombre;
            Obj.ID_Tipo = ID_Tipo;
            Obj.ID_Provincia = ID_Provincia;
            Obj.Correo = Correo;
            Obj.Telefono = Telefono;
            DITO DI = new DITO();
            return DI.DEditar(Obj);
        }
        #endregion Editar Obra

        #region insertar ITO
        public static string InsertarITO(string Nombre, int ID_Tipo, int ID_Provincia, string Correo, string Telefono)//No necesita el id 
        {
            ITO Obj = new ITO();           
            Obj.Nombre = Nombre;
            Obj.ID_Tipo = ID_Tipo;
            Obj.ID_Provincia = ID_Provincia;
            Obj.Correo = Correo;
            Obj.Telefono = Telefono;
            DITO DI = new DITO();
            return DI.DInsertar(Obj);
        }
        #endregion Insertar Obra
    }
}
