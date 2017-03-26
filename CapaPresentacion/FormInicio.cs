using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{    
    public partial class FormInicio : Form
    {
        public static string PcUsuario;
        public string NUsuario;      
        public static Usuario User = new Usuario();
        //public Form F1;
        public FormInicio()
        {
            InitializeComponent();
        }
        
        public void BuscarUsuario()
        {
            PcUsuario = SystemInformation.ComputerName;
            
            if (PcUsuario == "ROBERT")
            {
                LbUsuario.Text = Convert.ToString(NInicio.buscarUsuario("rarancibiar@minvu.cl"));
                //LbUsuario.Text = "Roberto";
            }
            else  
            {
                LbUsuario.Text = Convert.ToString(NInicio.buscarUsuario(PcUsuario));
                //if (LbUsuario.Text == "")
                
            }           
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void AddFormInPanel(Form fh)
        {
            if (this.PALL.Controls.Count != 0)
                this.PALL.Controls.RemoveAt(0);
           
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PALL.Controls.Add(fh);
            this.PALL.Tag = fh;
            fh.Show();
        }

        #region Indice
        private void BtnInspeccion_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FormInspeccion>().FirstOrDefault();
            FormInspeccion F1 = form ?? new FormInspeccion();
            AddFormInPanel(F1);
        }
        private void BtnInformacion_Click(object sender, EventArgs e)
        {      
            var form = Application.OpenForms.OfType<FormInformacion>().FirstOrDefault();
            FormInformacion F1 = form ?? new FormInformacion();
            AddFormInPanel(F1);
        }
        private void BtnPendientes_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FormPendientes>().FirstOrDefault();
            FormPendientes F1 = form ?? new FormPendientes();
            AddFormInPanel(F1);
        }
        private void BtnProyectos_Click(object sender, EventArgs e)
        {

        }
        #endregion Indice

        private void LbUsuario_Load(object sender, EventArgs e)
        {
            BuscarUsuario();
        }     
    }
}
