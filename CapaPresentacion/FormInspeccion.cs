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
using Microsoft.VisualStudio.Modeling.Diagrams;
using System.IO;

namespace CapaPresentacion
{
    public partial class FormInspeccion : Form
    {
        private static string Tp;
        private static string El;
        private static string Pv;
        
        public FormInspeccion()
        {
            InitializeComponent();
        }
        private void Mostrar()
        {
            DGV1.DataSource = NInspeccion.Mostrar();
            this.label5.Text = Convert.ToString(DGV1.Rows.Count);//realiza conteo de filas
        }
        private void FormInspeccion_Load(object sender, EventArgs e)
        {
            this.DGV1.DataError += new DataGridViewDataErrorEventHandler(this.DGV1_DataError);
            CargarElectricos();
            CargarProvincia();
            CargarTipo();
            this.Mostrar();
            this.DGV1.Columns[0].Visible = false;
            this.DGV1.Columns[1].Visible = false;
            this.DGV1.Columns[2].Visible = false;
            this.DGV1.Columns[8].Visible = false;
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            FormAgInspeccion FAI = new FormAgInspeccion();
            FAI.Show();//Muestra FormAgInspeccion
            CapaEntidad.Boton.Btn = false;           
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            if (DGV1.Columns[0].Visible == false)
            this.DGV1.Columns[0].Visible = true;
            else this.DGV1.Columns[0].Visible = false;
            CapaEntidad.Boton.Btn = true;
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            #region traspaso de datos a otro form para editar informacion
            if (this.DGV1.Columns[e.ColumnIndex].Name.Equals("Editar"))
            {
                FormAgInspeccion FI = new FormAgInspeccion();

                FI.Show();
                FI.CbNombre.Text = Convert.ToString(this.DGV1.CurrentRow.Cells["Obra"].Value);
                FI.CbElectrico.Text = Convert.ToString(this.DGV1.CurrentRow.Cells["Eléctrico"].Value);
                FI.DtFecha.Value = Convert.ToDateTime(this.DGV1.CurrentRow.Cells["F. Visita"].Value);
                //FI.PbFolio.BackgroundImage = this.PbFolio.BackgroundImage;
                FI.LbID.Text = Convert.ToString(this.DGV1.CurrentRow.Cells["ID"].Value);
                string nombre;
                //llamar folio del datagrid
                byte[] pdf;
                pdf = (byte[])DGV1.CurrentRow.Cells["Pdf"].Value;
                nombre = Convert.ToString(DGV1.CurrentRow.Cells["Obra"].Value);
                FI.PdfAg.LoadFile(nombre);
                //FI.PbFolio.Image = ImageHelper.GetImage((byte[])DGV1.CurrentRow.Cells["Folio"].Value);
            }

            else if (this.DGV1.Columns[e.ColumnIndex].Name.Equals("F. Visita"))//para visualizar folio de la visita
            {
                //if(DGV1.CurrentRow.Cells["Folio"].Value != DBNull.Value)
                //{
                //    if(PbFolio.Image != null)
                //        { 
                //            this.PbFolio.Image.Dispose();
                //        this.PbFolio.Image = null;
            
                //        }
                //    this.PbFolio.SizeMode = PictureBoxSizeMode.Zoom;
                //    PbFolio.Image = ImageHelper.GetImage((byte[])DGV1.CurrentRow.Cells["Folio"].Value); ;
                    
                //}
                if (DGV1.CurrentRow.Cells["Pdf"].Value != DBNull.Value)
                {
                    if (Pdf.src != null)
                    {
                        this.Pdf.Dispose();
                    }
                    
                    byte[] pdf;
                    string nombre;
                    //string cargar = null;
                    pdf = (byte[])DGV1.CurrentRow.Cells["Pdf"].Value;
                    nombre = Convert.ToString(DGV1.CurrentRow.Cells["Obra"].Value);
                   

                    File.WriteAllBytes(System.Windows.Forms.Application.StartupPath + @"\" + nombre, pdf);

                    //System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + @"\" + nombre);
                    Pdf.setShowToolbar(true);
                    Pdf.LoadFile(nombre);


                    //File.WriteAllBytes(cargar, pdf);
                    //Pdf.src = cargar;
                    //this.Pdf.src = System.IO.File.WriteAllBytes("Folio.pdf", System.IO.File.WriteAllBytes((byte[])DGV1.CurrentRow.Cells["Folio"].Value));
                    //this.Pdf.LoadFile(System.Windows.Forms.Application.StartupPath, File.WriteAllBytes(pdf);
                    //PbFolio.Image = ImageHelper.GetImage((byte[])DGV1.CurrentRow.Cells["Folio"].Value);

                }
            }
            #endregion traspaso de datos a otro form para editar informacion
        }

        private void BtDescarga_Click(object sender, EventArgs e)
        {
            //SaveFileDialog Guardar = new SaveFileDialog();
            //Guardar.Filter = "PDF(*.pdf)";
            //Image Imagen = this.PbFolio.BackgroundImage;
            //Guardar.ShowDialog();

            
            //PbFolio.Image.Save(Guardar.FileName);
        }

        #region Cargar Combobox
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
        private void CargarElectricos()
        {
            CbElectrico.DisplayMember = "Nombre";
            CbElectrico.ValueMember = "ID";
            CbElectrico.DataSource = NObras.CbElectrico();
            CbElectrico.SelectedItem = null;            
        }

        #endregion Cargar Combobox

        #region buscar 
        private void BuscarObra()            
        {
            if (DGV1.ColumnCount >= 3)
            {
                if (this.CbTipo.Text != "") Tp = this.CbTipo.Text; else Tp = null;
                if (this.CbElectrico.Text != "") El = this.CbElectrico.Text; else El = null;
                if (this.CbProvincia.Text != "") Pv = this.CbProvincia.Text; else Pv = null;
                this.DGV1.DataSource = NInspeccion.Buscar(this.TbObra.Text, Tp, El, Pv);
                label5.Text = Convert.ToString(DGV1.Rows.Count);//realiza conteo de filas
            }
        }
        private void TbObra_TextChanged(object sender, EventArgs e)
        {
           this.BuscarObra();
        }
        private void CbTipo_TextChanged(object sender, EventArgs e)
        {
            this.BuscarObra();
        }
        private void CbProvincia_TextChanged(object sender, EventArgs e)
        {
            this.BuscarObra();
        }
        private void CbElectrico_TextChanged(object sender, EventArgs e)
        {
            this.BuscarObra();
        }
        #endregion buscar

        private void DGV1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
 
        }
    }
}
