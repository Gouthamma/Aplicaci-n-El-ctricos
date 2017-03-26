using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace CapaNegocio
{
    class NConstructora
    {
        #region Insertar Tipo      
        public static string Insertar(string Nombre, string Representante, string Correo, string Telefono)//No necesita el id 
        {
            Constructora Obj = new Constructora();
            Obj.Nombre = Nombre; //Se repite con cada parametro de metodo insertar
            Obj.Representante = Representante;
            Obj.Correo = Correo;
            Obj.Telefono = Telefono;
            

            return DConstructora.DInsertar(Obj);
        }
        #endregion Insertar Tipo

        #region Editar Constructora
        public static string Editar(int ID, string Nombre, string Representante, string Correo, string Telefono) 
        {
            Constructora Obj = new Constructora();
            Obj.ID = ID;
            Obj.Nombre = Nombre;
            Obj.Representante = Representante;
            Obj.Correo = Correo;
            Obj.Telefono = Telefono;

            DConstructora DT = new DTipo();
            return DT.DEditarTipo(Obj);
        }

        #endregion Editar Tipo
    }
}
