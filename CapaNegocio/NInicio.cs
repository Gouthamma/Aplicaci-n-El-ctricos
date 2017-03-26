using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaNegocio
{
    public class NInicio
    {
        //Mostrar CNT Pendientes
        public static string buscarUsuario(string login)
        {
            Usuario User = new Usuario();
            User.Nombre = login;
            DInicio DI = new DInicio();
            return DI.BuscarUsuario(User);
        }

        //Mostrar CNT Pendientes
        public static DataTable mostrarcnt(Usuario User)
        {            
            DInicio DI = new DInicio();            
            return DI.MostrarCNT(User);
        }
        //Mostrar CSP Pendientes
        public static DataTable mostrarcsp(Usuario User)
        {
            DInicio DI = new DInicio();
            return DI.MostrarCSP(User);
        }
        //Mostrar PPPF Pendientes
        public static DataTable mostrarpppf(Usuario User)
        {
            DInicio DI = new DInicio();
            return DI.MostrarPPPF(User);
        }
        //Mostrar Folio Pendientes
        public static DataTable mostrarfolio(Usuario User)
        {
            DInicio DI = new DInicio();
            return DI.MostrarFolio(User);
        }

    }

}