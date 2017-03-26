using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public static class NInstalador
    {
        #region Agregar Instalador      
        public static string AgregarInstalador(string nombre, string Clase, string Telefono, string Correo)//No necesita el id 
        {
            Instalador Obj = new Instalador();
            Obj.Nombre = nombre;
            Obj.Clase = Clase;
            Obj.Telefono = Telefono;
            Obj.Correo = Correo;           

            return DInstalador.DAgregar(Obj);
        }
        #endregion Agregar Instalador

        #region Editar Instalador
        public static string EditarInstalador(int ID, string nombre, string Clase, string Telefono, string Correo)//Necesita el id 
        {
            Instalador Obj = new Instalador();
            Obj.ID = ID;
            Obj.Nombre = nombre;
            Obj.Clase = Clase;
            Obj.Telefono = Telefono;
            Obj.Correo = Correo;

            return DInstalador.DEditar(Obj);
        }
        #endregion Editar Instalador
    }
}
