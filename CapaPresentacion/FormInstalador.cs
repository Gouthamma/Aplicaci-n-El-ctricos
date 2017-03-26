using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormInstalador : Form
    {
        public FormInstalador()
        {
            InitializeComponent();
        }        
        //Mensaje de Confirmación
        private void MensajeOk(String mensaje)
        {
            MessageBox.Show(mensaje, "Aplicación Eléctricos", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (this.LbNombre.Text == string.Empty)
                {
                    MensajeError("Falta ingresar datos, Los datos con * son Obligatorios");
                }
                else
                {
                    if (CapaEntidad.Boton.Btn)
                    {
                        rpta = NInstalador.EditarInstalador(Convert.ToInt32(this.ID.Text), this.LbNombre.Text, this.LbClase.Text,
                            this.LbCorreo.Text, this.LbTelefono.Text);

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
                        rpta = NInstalador.AgregarInstalador(this.LbNombre.Text, this.LbClase.Text,
                           this.LbCorreo.Text, this.LbTelefono.Text);

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
