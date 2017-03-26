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
using CapaEntidad;
namespace CapaPresentacion
{
    public partial class FormITO : Form
    {
        int? VTipo = default(int);
        
        public FormITO()
        {
            InitializeComponent();
        }

        #region Cargar ComboBox
        private void CargarTipo()
        {
            CbTipo.DisplayMember = "Nombre";
            CbTipo.ValueMember = "ID";
            CbTipo.DataSource = NObras.CbTipo();
            CbTipo.SelectedItem = null;
        }
        private void CargarProvincia()
        {
            CbProvincia.DisplayMember = "Nombre";
            CbProvincia.ValueMember = "ID";
            CbProvincia.DataSource = NObras.CbProvincia();
            CbProvincia.SelectedItem = null;
        }
        #endregion Cargar Combobox

        private void FormITO_Load(object sender, EventArgs e)
        {
            CargarProvincia();
            CargarTipo();
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
            if (this.CbTipo.Text != string.Empty) VTipo = Convert.ToInt16(CbTipo.SelectedValue); 
            if (CapaEntidad.Boton.Btn)
            {
                if (CbTipo.Text != string.Empty) VTipo = Convert.ToInt16(CbTipo.SelectedValue);             

                try
                {
                    string rpta = "";
                    if (this.LbNombre.Text == string.Empty || this.CbProvincia.Text == string.Empty)
                    {
                        MensajeError("Falta ingresar datos, Los datos con * son Obligatorios");
                    }
                    else
                    {
                        rpta = NITO.EditarITO(Convert.ToInt32(this.ID.Text), this.LbNombre.Text,
                            VTipo.Value, Convert.ToInt32(this.CbProvincia.SelectedValue),
                            Convert.ToString(this.LbCorreo.Text.Trim()), Convert.ToString(this.LbTelefono.Text.Trim()));

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
             if (CbTipo.Text != string.Empty) VTipo = Convert.ToInt16(CbTipo.SelectedValue);

             try
             {
                string rpta = "";
                    if (this.LbNombre.Text == string.Empty || this.CbProvincia.Text == string.Empty)
                    {
                    MensajeError("Falta ingresar datos, Los datos con * son Obligatorios");
                }
                else
                {
                    rpta = NITO.InsertarITO(this.LbNombre.Text,
                            Convert.ToInt32(this.CbTipo.SelectedValue), Convert.ToInt32(this.CbProvincia.SelectedValue),
                            Convert.ToString(this.LbCorreo.Text.Trim()), Convert.ToString(this.LbTelefono.Text.Trim()));

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
