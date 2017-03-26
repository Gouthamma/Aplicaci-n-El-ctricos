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
    public partial class FormTipo : Form
    {
        public FormTipo()
        {
            InitializeComponent();
        }

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
            
            if (CapaEntidad.Boton.Btn)
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
                        rpta = NTipo.EditarTipo(Convert.ToInt32(this.ID.Text), Convert.ToString(this.LbNombre.Text),
                            Convert.ToString(this.LbCoorProy.Text), Convert.ToString(this.LbCoorIns.Text), 
                            Convert.ToString(this.LbCorreoProyec.Text), Convert.ToString(this.LbCorreoInsp.Text));

                        if (rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Modificó el registro correctamente");
                        }

                        else
                        {
                            this.MensajeError(rpta);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else
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
                        rpta = NTipo.InsertarTipo(this.LbNombre.Text, this.LbCoorProy.Text, 
                            this.LbCoorIns.Text, this.LbCorreoProyec.Text, this.LbCorreoInsp.Text);

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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }

            }
        }

    }
}
