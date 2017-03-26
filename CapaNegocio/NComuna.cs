using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class NComuna
    {
        #region Agregar Comuna
        public static string AgregarComuna(string nombre, int? Provincia)//No necesita el id         {
        { 
            Comuna Obj = new Comuna();
            Obj.Nombre = nombre;
            Obj.ID_Provincia = Provincia;
            
            return DComuna.DAgregar(Obj);
        }
        #endregion Agregar Comuna

        #region Editar Comuna
        public static string EditarComuna(int ID, string nombre, int? Provincia)//Necesita el id 
        {
            Comuna Obj = new Comuna();
            Obj.ID = ID;
            Obj.Nombre = nombre;
            Obj.ID_Provincia = Provincia;

            return DComuna.DEditar(Obj);
        }
        #endregion Editar Comuna
    }
}
