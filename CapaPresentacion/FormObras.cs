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
using System.Windows.Documents;
using System.Windows.Controls;

namespace CapaPresentacion
{
    public partial class FormObras : Form
    {
        int? VITO = default(int);
        int? VConstructora = default(int);
        int? VEP = default(int);
        int? VInstalador = default(int);
        int? VPlazo = default(int);
        public FormObras()
        {
            InitializeComponent();
        }
        private void FormObras_Load(object sender, EventArgs e)
        {
            BtEditar.Visible = CapaEntidad.Boton.Btn;
            BtAgregar.Visible = !CapaEntidad.Boton.Btn;
            CargarTipo();
            CargarProvincia();
            CargarComuna();
            CargarITO();
            CargarElectricos();
            CargarConstructora();
            CargarEP();
            CargarInstalador();
            CargarFT();
        }
        #region Botones 
        private void BtTipo_Click(object sender, EventArgs e)
        {
            CapaEntidad.Boton.Btn = false;
            FormTipo FT = new FormTipo();
            FT.Show();
        }

        private void BtProvincia_Click(object sender, EventArgs e)
        {
            CapaEntidad.Boton.Btn = false;
            FormProvincia FP = new FormProvincia();
            FP.Show();
        }
        
        private void BtComuna_Click(object sender, EventArgs e)
        {
            CapaEntidad.Boton.Btn = false;
            FormComuna FC = new FormComuna();
            FC.Show();
        }

        private void BtITO_Click(object sender, EventArgs e)
        {
            CapaEntidad.Boton.Btn = false;
            FormITO FI = new FormITO();
            FI.Show();
        }

        private void BtElectrico_Click(object sender, EventArgs e)
        {
            CapaEntidad.Boton.Btn = false;
            FormElectricos FE = new FormElectricos();
            FE.Show();
        }

        private void BtConstructora_Click(object sender, EventArgs e)
        {
            CapaEntidad.Boton.Btn = false;
            FormConstructora FC = new FormConstructora();
            FC.Show();
        }

        private void BtEP_Click(object sender, EventArgs e)
        {
            CapaEntidad.Boton.Btn = false;
            FormEP FE = new FormEP();
            FE.Show();
        }

        private void BtInstalador_Click(object sender, EventArgs e)
        {
            CapaEntidad.Boton.Btn = false;
            FormInstalador FI = new FormInstalador();
            FI.Show();
        }
        #endregion Botones +

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
        private void CargarComuna()
        {
            CbComuna.DisplayMember = "Nombre";
            CbComuna.ValueMember = "ID";
            CbComuna.DataSource = NObras.CbComunaE();
            CbComuna.SelectedItem = null;            
        }
        private void CargarITO()
        {
            CbITO.DisplayMember = "Nombre";
            CbITO.ValueMember = "ID";
            CbITO.DataSource = NObras.CbITOE();
            CbITO.SelectedItem = null;
        }
        private void CargarElectricos()
        {
            CbElectrico.DisplayMember = "Nombre";
            CbElectrico.ValueMember = "ID";
            CbElectrico.DataSource = NObras.CbElectrico();
            CbElectrico.SelectedItem = null;
        }
        private void CargarConstructora()
        {
            CbConstructora.DisplayMember = "Nombre";
            CbConstructora.ValueMember = "ID";
            CbConstructora.DataSource = NObras.CbConstructora();
            CbConstructora.SelectedItem = null;
        }
        private void CargarEP()
        {
            CbEP.DisplayMember = "Nombre";
            CbEP.ValueMember = "ID";
            CbEP.DataSource = NObras.CbEP();
            CbEP.SelectedItem = null;
        }
        private void CargarInstalador()
        {
            CbInstalador.DisplayMember = "Nombre";
            CbInstalador.ValueMember = "ID";
            CbInstalador.DataSource = NObras.CbInstalador();
            CbInstalador.SelectedItem = null;
        }
        private void CargarFT()
        {
            CbFTrabajo.DisplayMember = "FactorTrabajo";
            CbFTrabajo.ValueMember = "ID";
            CbFTrabajo.DataSource = NObras.CbFT();
            CbFTrabajo.SelectedItem = null;
        }
        #endregion Cargar ComboBox
        
        private void CbProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
            CbComuna.DisplayMember = "Nombre";
            CbComuna.ValueMember = "ID";
            CbComuna.DataSource = NObras.CbComuna(Convert.ToInt16(CbProvincia.SelectedValue));
            CbComuna.SelectedItem = null;

            CbITO.DisplayMember = "Nombre";
            CbITO.ValueMember = "ID";
            CbITO.DataSource = NObras.CbITO(Convert.ToInt16(CbProvincia.SelectedValue));
            CbITO.SelectedItem = null;
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
        private void BtEditar_Click(object sender, EventArgs e)
        {
            if (CbITO.Text != string.Empty) VITO = Convert.ToInt16(CbITO.SelectedValue);
            if (CbConstructora.Text != string.Empty) VConstructora = Convert.ToInt16(CbConstructora.SelectedValue);
            if (CbEP.Text != string.Empty) VEP = Convert.ToInt16(CbEP.SelectedValue);
            if (CbInstalador.Text != string.Empty) VInstalador = Convert.ToInt16(CbInstalador.SelectedValue);
            if (this.LbPlazo.Text != string.Empty) VPlazo = Convert.ToInt16(LbPlazo.Text);

            try
            {
                string rpta = "";
                if (this.LbNombreObra.Text == string.Empty || this.CbTipo.Text == string.Empty || this.CbElectrico.Text == string.Empty || this.CbProvincia.Text == string.Empty || this.CbComuna.Text == string.Empty || this.CbFTrabajo.Text == string.Empty)
                {
                    MensajeError("Falta ingresar datos, Los datos con * son Obligatorios");
                }
                else
                {
                    rpta = NObras.EditarObra(Convert.ToInt32(this.ID.Text), this.LbNombreObra.Text, 
                        Convert.ToInt32(this.CbTipo.SelectedValue),  Convert.ToInt32(this.CbProvincia.SelectedValue), 
                        Convert.ToInt32(this.CbComuna.SelectedValue), VITO.Value, 
                        Convert.ToInt32(this.CbElectrico.SelectedValue), VConstructora.Value, 
                        VEP.Value, VInstalador.Value, Convert.ToDateTime(this.DInicio.Value.Date), VPlazo.Value, 
                        Convert.ToInt32(this.CbFTrabajo.SelectedValue), Convert.ToString(this.LbGeoRef.Text.Trim()),
                        Convert.ToString(this.LbRukan.Text.Trim()));

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
        private void BtAgregar_Click(object sender, EventArgs e)
         {
            if (CbITO.Text != string.Empty) VITO = Convert.ToInt32(CbITO.SelectedValue);
            if (CbConstructora.Text != string.Empty) VConstructora = Convert.ToInt16(CbConstructora.SelectedValue);
            if (CbEP.Text != string.Empty) VEP = Convert.ToInt32(CbEP.SelectedValue);
            if (CbInstalador.Text != string.Empty) VInstalador = Convert.ToInt32(CbInstalador.SelectedValue);
            if (this.LbPlazo.Text != string.Empty) VPlazo = Convert.ToInt32(LbPlazo.Text);

            try
            {
                string rpta = "";
                if (this.LbNombreObra.Text == string.Empty || this.CbElectrico.Text == string.Empty || this.CbProvincia.Text == string.Empty || this.CbComuna.Text == string.Empty || this.CbFTrabajo.Text == string.Empty)
                {
                    MensajeError("Falta ingresar datos, Los datos con * son Obligatorios");
                }
                else
                {
                    rpta = NObras.Insertar(this.LbNombreObra.Text,
                        Convert.ToInt32(this.CbTipo.SelectedValue), Convert.ToInt32(this.CbProvincia.SelectedValue),
                        Convert.ToInt32(this.CbComuna.SelectedValue), VITO.Value,
                        Convert.ToInt32(this.CbElectrico.SelectedValue), VConstructora.Value,
                        VEP.Value, VInstalador.Value, Convert.ToDateTime(this.DInicio.Value.Date), VPlazo.Value,
                        Convert.ToInt32(this.CbFTrabajo.SelectedValue), Convert.ToString(this.LbGeoRef.Text.Trim()),
                        Convert.ToString(this.LbRukan.Text.Trim()));

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

        private void DInicio_EnabledChanged(object sender, EventArgs e)
        {
            DateTime d1 = DateTime.Now;
            DInicio.Value = d1;
        }
    }
}
