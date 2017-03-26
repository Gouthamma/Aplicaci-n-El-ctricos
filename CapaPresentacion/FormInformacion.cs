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
    public partial class FormInformacion : Form
    {
        public static Proc a = new Proc();//Variable para mostrar en DGVALL
        public static string b;//Variable para eliminar
        private static string Tp;//Variable para filtro
        private static string El;//Variable para filtro
        public FormInformacion()
        {
            InitializeComponent();
        }
        private void FormInformacion_Load(object sender, EventArgs e)
        {
            this.DGVALL.Columns[0].Visible = false;
            this.DGVALL.Columns[1].Visible = false;
            CargarTipo();//ComboBox del Filtro
            CargarElectrico();
        }
        private void CargarTipo()
        {
            CbTipo.DisplayMember = "Nombre";
            CbTipo.ValueMember = "ID";
            CbTipo.DataSource = NObras.CbTipo();
            CbTipo.SelectedItem = null;
        }
        private void CargarElectrico()
        {
            CbElectrico.DisplayMember = "Nombre";
            CbElectrico.ValueMember = "ID";
            CbElectrico.DataSource = NObras.CbElectrico();
            CbElectrico.SelectedItem = null;
        }
        private void Mostrar()
        {
            this.DGVALL.DataSource = NInformacion.mostrarinfo(a);
            label5.Text = Convert.ToString(DGVALL.Rows.Count);//realiza conteo de filas
        }
        //Mensaje de Confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Aplicación Eléctricos", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        //Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Aplicación Eléctricos", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        #region Menu Bts_Click
        private void BtObras_Click(object sender, EventArgs e)
        {
            a.Nombre = "ObrasVer";
            b = "ObrasEliminar";
            this.LbPlanilla.Text = "Obras";
            Mostrar();
            this.DGVALL.Columns[2].Visible = false;
        }
        private void BtConstructoras_Click(object sender, EventArgs e)
        {
            a.Nombre = "ConstructoraVer";
            b = "ConstructoraEliminar";
            this.LbPlanilla.Text = "Constructoras";
            Mostrar();
            this.DGVALL.Columns[2].Visible = false;
        }
        private void BtEP_Click(object sender, EventArgs e)
        {
            a.Nombre = "EPVer";
            b = "EPEliminar";
            this.LbPlanilla.Text = "Entidades Patrocinantes";
            Mostrar();
            this.DGVALL.Columns[2].Visible = false;
        }

        private void BtInstalador_Click(object sender, EventArgs e)
        {
            a.Nombre = "InstaladorVer";
            b = "InstaladorEliminar";
            this.LbPlanilla.Text = "Instaladores";
            Mostrar();
            this.DGVALL.Columns[2].Visible = false;
        }

        private void BtITO_Click(object sender, EventArgs e)
        {
            a.Nombre = "ITOVer";
            b = "ITOsEliminar";
            this.LbPlanilla.Text = "ITOs";
            Mostrar();
            this.DGVALL.Columns[2].Visible = false;
        }

        private void BtElectrico_Click(object sender, EventArgs e)
        {
            a.Nombre = "ElectricosVer";
            b = "ElectricosEliminar";
            this.LbPlanilla.Text = "Eléctricos";
            Mostrar();
            this.DGVALL.Columns[2].Visible = false;
        }

        private void BtComunas_Click(object sender, EventArgs e)
        {
            a.Nombre = "ComunaVer";
            b = "ComunaEliminar";
            this.LbPlanilla.Text = "Comunas";
            Mostrar();
            this.DGVALL.Columns[2].Visible = false;
        }
        private void BtProvincias_Click(object sender, EventArgs e)
        {
            a.Nombre = "ProvinciaVer";
            b = "ProvinciaEliminar";
            this.LbPlanilla.Text = "Provincias";
            Mostrar();
            this.DGVALL.Columns[2].Visible = false;
        }
        private void BtTipos_Click(object sender, EventArgs e)
        {
            a.Nombre = "TipoVer";
            b = "TipoEliminar";
            this.LbPlanilla.Text = "Tipos";
            Mostrar();
            this.DGVALL.Columns[2].Visible = false;
        }
        #endregion Menu Bts_Click

        #region Filtros
        #region Buscar
        private void Buscar()
        {
            if (this.LbPlanilla.Text == "Obras")
            {
                if (this.CbTipo.Text != "") Tp = this.CbTipo.Text; else Tp = null;
                if (this.CbElectrico.Text != "") El = this.CbElectrico.Text; else El = null;
                this.DGVALL.DataSource = NInformacion.BuscarObra(this.textBox1.Text, Tp, El);
                label5.Text = Convert.ToString(DGVALL.Rows.Count);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }
        private void CbTipo_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void CbElectrico_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }
        #endregion BuscarObra

        #endregion Filtros

        private void ChkEliminar_CheckedChanged(object sender, EventArgs e)
        {           
                if (ChkEliminar.Checked)
                {
                    this.DGVALL.Columns[0].Visible = true;
                }
                else
                {
                    this.DGVALL.Columns[0].Visible = false;
                }
       }
      
        //Al hacer clic en una celda del DataGrid
        private void DGVALL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVALL.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DGVALL.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
            #region traspaso de datos a otro form para editar informacion
            if (this.DGVALL.Columns[e.ColumnIndex].Name.Equals("Editar"))
            {
                if (LbPlanilla.Text == "Obras")
                {
                    FormObras FO = new FormObras();
                    
                    FO.Show();
                    FO.ID.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["ID Obra"].Value);
                    FO.CbComuna.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Comuna"].Value);                                       
                    FO.CbProvincia.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Provincia"].Value);
                    FO.CbConstructora.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Constructora"].Value);
                    FO.CbElectrico.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Eléctrico"].Value);
                    FO.CbEP.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["EP"].Value);
                    FO.CbFTrabajo.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["FT"].Value);
                    FO.CbInstalador.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Instalador"].Value);
                    FO.CbITO.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["ITO"].Value);
                    FO.CbTipo.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Tipo"].Value);
                    FO.LbNombreObra.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Obra"].Value);
                    FO.LbPlazo.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Plazo"].Value);
                    FO.LbRukan.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Rukan"].Value);
                    FO.LbGeoRef.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["GeoReferencia"].Value);
                }
                else if (LbPlanilla.Text == "ITOs")
                {
                    FormITO FI = new FormITO();
                    FI.Show();
                    FI.ID.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["ID"].Value);
                    FI.LbNombre.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Nombre"].Value);
                    FI.CbProvincia.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Provincia"].Value);
                    FI.CbTipo.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Tipo"].Value);
                    FI.LbCorreo.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Correo"].Value);
                    FI.LbTelefono.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Telefono"].Value);
                }
                else if (LbPlanilla.Text == "Entidades Patrocinantes")
                {
                    FormEP FE = new FormEP();
                    FE.Show();
                    FE.ID.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["ID"].Value);
                    FE.LbNombre.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Nombre"].Value);
                    FE.LbRepresentante.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Representante"].Value);
                    FE.LbCorreo.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Correo"].Value);
                    FE.LbTelefono.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Telefono"].Value);
                }
                else if (LbPlanilla.Text == "Instaladores")
                {
                    FormInstalador FIN = new FormInstalador();
                    FIN.Show();
                    FIN.ID.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["ID"].Value);
                    FIN.LbNombre.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Nombre"].Value);
                    FIN.LbClase.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Clase"].Value);
                    FIN.LbTelefono.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Telefono"].Value);
                    FIN.LbCorreo.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Correo"].Value);
                }
                else if (LbPlanilla.Text == "Constructoras")
                {
                    FormConstructora FC = new FormConstructora();
                    FC.Show();
                    FC.ID.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["ID"].Value);
                    FC.LbNombre.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Nombre"].Value);
                    FC.LbRepresentante.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Representante"].Value);
                    FC.LbTelefono.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Telefono"].Value);
                    FC.LbCorreo.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Correo"].Value);
                }
                else if (LbPlanilla.Text == "Eléctricos")
                {
                    FormElectricos FEL = new FormElectricos();
                    FEL.Show();
                    FEL.ID.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["ID"].Value);
                    FEL.LbNombre.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Nombre"].Value);
                    FEL.LbRUT.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Rut"].Value);
                    FEL.LbContraseña.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Contraseña"].Value);
                    FEL.LbCorreo.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Correo"].Value);
                    FEL.LbTelefono.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Telefono"].Value);
                }
                else if(LbPlanilla.Text == "Provincias")
                {
                    FormProvincia FP = new FormProvincia();
                    FP.Show();
                    FP.ID.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["ID"].Value);
                    FP.LbProvincia.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Nombre"].Value);
                }
                else if(LbPlanilla.Text == "Comunas")
                {
                    FormComuna FCO = new FormComuna();
                    FCO.Show();
                    FCO.ID.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["ID"].Value);
                    FCO.LbComuna.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Comuna"].Value);
                    FCO.CbProvincia.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Provincia"].Value);
                }
                else if(LbPlanilla.Text == "Tipos")
                {
                    FormTipo FT = new FormTipo();
                    FT.Show();
                    FT.ID.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["ID"].Value);
                    FT.LbNombre.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Nombre"].Value);
                    FT.LbCoorProy.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Coord. Proyecto"].Value);
                    FT.LbCoorIns.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Coord. Inspección"].Value);
                    FT.LbCorreoProyec.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Correo CP"].Value);
                    FT.LbCorreoInsp.Text = Convert.ToString(this.DGVALL.CurrentRow.Cells["Correo CI"].Value);
                }
            }
            #endregion Copia Pega
        }

        #region Elimnimar
        private void BtEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea ELIMINAR los registros?", "Aplicación Eléctricos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in DGVALL.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[2].Value);
                            Rpta = NInformacion.eliminarinfo(b , Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Elimnó el registro Correctamente");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        #endregion Eliminar

        #region Boton Agregar
        private void BtAgregar_Click(object sender, EventArgs e)
        {
            CapaEntidad.Boton.Btn = false;
            if (LbPlanilla.Text == "Obras")
            {
                FormObras FO = new FormObras();
                FO.Show();
            }
            else if (LbPlanilla.Text == "Constructoras")
            {
                FormConstructora FC = new FormConstructora();
                FC.Show();
            }
            else if (LbPlanilla.Text == "Entidad Patrocinante")
            {
                FormEP FP = new FormEP();
                FP.Show();               
            }
            else if (LbPlanilla.Text == "Instaladores")
            {
                FormInstalador FI = new FormInstalador();
                FI.Show();
            }
            else if (LbPlanilla.Text == "ITOs")
            {
                FormITO FI = new FormITO();
                FI.Show();
            }
            else if (LbPlanilla.Text == "Eléctricos")
            {
                FormElectricos FE = new FormElectricos();
                FE.Show();
            }
            else if (LbPlanilla.Text == "Comunas")
            {
                FormComuna FC = new FormComuna();
                FC.Show();
            }
            else if (LbPlanilla.Text == "Provincias")
            {
                FormProvincia FP = new FormProvincia();
                FP.Show();
            }
            else if (LbPlanilla.Text == "Tipos")
            {
                FormTipo FT = new FormTipo();
                FT.Show();
            }
        }
        #endregion Boton Agregar

        private void ChkEditar_CheckedChanged(object sender, EventArgs e)
        {
            CapaEntidad.Boton.Btn = true;
            if (ChkEditar.Checked)
            {
                this.DGVALL.Columns[1].Visible = true;
            }
            else
            {
                this.DGVALL.Columns[1].Visible = false;
            }
        }
    }
}