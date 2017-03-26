using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormComuna : Form
    {
        int? Provincia;
        public FormComuna()
        {
            InitializeComponent();
        }
        private void CargarProvincia()
        {
            CbProvincia.DisplayMember = "Nombre";
            CbProvincia.ValueMember = "ID";
            CbProvincia.DataSource = NObras.CbProvincia();
        }
        private void FormComuna_Load(object sender, EventArgs e)
        {         
            CargarProvincia();
            if (CbProvincia.Text == "-1") Provincia = null; else Provincia = Convert.ToInt32(CbProvincia.SelectedValue);
        }
        //Mensaje de Confirmación
        private void MensajeOk(String mensaje)
        {
            MessageBox.Show(mensaje, "Aplicación Eléctricos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //Mensaje Error
        private void MensajeError(String mensaje)
        {
            MessageBox.Show(mensaje, "Aplicación Eléctricos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void BtGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.LbComuna.Text == string.Empty || this.CbProvincia.Text == string.Empty)
                {
                    MensajeError("Falta ingresar datos, Los datos con * son Obligatorios");
                }
                else
                {
                    if (CapaEntidad.Boton.Btn)
                    {
                        rpta = NComuna.EditarComuna(Convert.ToInt32(this.ID.Text), this.LbComuna.Text, Provincia);

                        if (rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Modificó el registro correctamente");
                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }
                    }
                    else
                    {
                        rpta = NComuna.EditarComuna(Convert.ToInt32(this.ID.Text), this.LbComuna.Text, Convert.ToInt32(this.CbProvincia.SelectedValue));

                        if (rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Agregó el registro correctamente");
                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
