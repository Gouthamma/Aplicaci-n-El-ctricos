using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Security.Principal;



namespace CapaEntidad
{
    public class Comuna
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int? ID_Provincia { get; set; }
        public string ID_Doble { get; set; }
        public string BuscarComuna { get; set; }
    }
    public class Provincia
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string BuscarProv { get; set; }
    }
    public class Constructora
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Representante { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string BuscarConstructora { get; set; }
    }
    public class Electricos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string RUT { get; set; }
        public string Contraseña { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string BuscarElectricos { get; set; }
    } 
    public class EP
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Representante { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string BuscarEP { get; set; }
    }
    public class FactorTrabajo
    {
        public int ID { get; set; }
        public int FT { get; set; }
    }
    public class Inspeccion
    {
        public int ID { get; set; }
        public int ID_Obra { get; set; }
        public int ID_Electrico { get; set; }
        public DateTime F_Visita { get; set; }
        public byte[] Folio { get; set; }
        public byte[] Pdf { get; set; }
        public string BuscarFolio { get; set; }
    }
    public class Instalador
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Clase { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
    }
    public class ITO
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int ID_Provincia { get; set; }
        public int ID_Tipo { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Buscar { get; set; }
    }
    public class Obra
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int ID_Tipo { get; set; }
        public int ID_Provincia { get; set; }
        public int ID_Comuna { get; set; }
        public int? ID_ITO { get; set; }
        public int ID_Electricos { get; set; }
        public int? ID_Constructora { get; set; }
        public int? ID_EP { get; set; }
        public int? ID_Instalador { get; set; }
        public DateTime? F_Inicio { get; set; }
        public int? Plazo { get; set; }
        public int? Cant_Viv { get; set; }
        public int ID_Inspeccion { get; set; }
        public int ID_FT { get; set; }
        public string GeoReferencia { get; set; }
        public string Rukan { get; set; }
        public DateTime F_Termino { get; set; }
        public string BuscarObra { get; set; }
    }
    public class Proc
    {
        public string Nombre { get; set; }
        public int ID { get; set; }
    }
    public class Tipo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string CoordProy { get; set; }
        public string CoordInspec { get; set; }
        public string CorreoProy { get; set; }
        public string CorreoInsp { get; set; }
        public string BuscarTipo { get; set; }
    }
    public class Usuario
    {
        public string Nombre { get; set; }
    }
    public static class Boton
    {
        public static bool Btn { get; set; }
    }
}