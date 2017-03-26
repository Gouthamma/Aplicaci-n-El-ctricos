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
using System.IO;
using System.Web;


namespace CapaPresentacion
{    
    public partial class FormAgInspeccion : Form
    {
        string ruta;
        public FormAgInspeccion()
        {
            InitializeComponent();
        }
       
        private void DtFecha_Enter(object sender, EventArgs e)
        {
            DtFecha.Value = DateTime.Now.AddDays(1);
        }
        #region CargarCombo
        private void CargarElectricos()
        {
            this.CbElectrico.DisplayMember = "Nombre";
            this.CbElectrico.ValueMember = "ID";
            this.CbElectrico.DataSource = NObras.CbElectrico();
            this.CbElectrico.SelectedItem = null;
        }

        private void CargarObra()
        {
            this.CbNombre.DisplayMember = "Obra";
            this.CbNombre.ValueMember = "ID Obra";
            this.CbNombre.DataSource = NObras.CbObra();
            this.CbNombre.SelectedItem = null;
        }
        #endregion CargarCombo
        private void FormAgInspeccion_Load(object sender, EventArgs e)
        {
            if (CapaEntidad.Boton.Btn)
            {
                BtEditar.Visible = true;
                BtAgregar.Visible = false;
            }
            else
            {
                BtEditar.Visible = false;
                BtAgregar.Visible = true;
            }
            BtEditar.Visible = CapaEntidad.Boton.Btn;
            BtAgregar.Visible = !CapaEntidad.Boton.Btn;
            CargarElectricos();
            CargarObra();
        }

        private void BtFolio_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dialog = new OpenFileDialog();
            
            //DialogResult resultado = dialog.ShowDialog();
            
            //if (resultado == DialogResult.OK)
            //{
            //    this.PbFolio.SizeMode = PictureBoxSizeMode.Zoom;
            //    this.PbFolio.Image = Image.FromFile(dialog.FileName);
            //}
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult resultado = dialog.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ruta = dialog.FileName;
                this.PdfAg.src = ruta;
            }
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
        
        private void BtAgregar_Click(object sender, EventArgs e)
        {
            {
                if (CapaEntidad.Boton.Btn)
                {
                    try
                    {
                        string rpta = "";
                        if (this.CbNombre.Text == string.Empty || this.DtFecha.Text == string.Empty || this.CbElectrico.Text == string.Empty)
                        {
                            MensajeError("Falta ingresar datos, Los datos con * son Obligatorios");
                        }
                        else
                        {
                            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
                            //this.PbFolio.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            //byte[] image = ms.GetBuffer();
                            FileStream pdf = File.OpenRead(ruta);
                            byte[] contenidoPdf = new byte[pdf.Length];
                            pdf.Read(contenidoPdf, 0, (int)pdf.Length);
                            pdf.Close();

                            rpta = NAgInspeccion.Editar(Convert.ToInt32(this.LbID.Text), Convert.ToInt16(this.CbNombre.SelectedValue),
                                Convert.ToInt32(this.CbElectrico.SelectedValue), Convert.ToDateTime(this.DtFecha.Value), contenidoPdf);

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
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                else
                {

                    try
                    {
                        string rpta = "";
                        if (this.CbNombre.Text == string.Empty || this.DtFecha.Text == string.Empty || this.CbElectrico.Text == string.Empty)
                        {
                            MensajeError("Falta ingresar datos, Los datos con * son Obligatorios");
                        }
                        else
                        {
                            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
                            ////System.IO.MemoryStream ms2 = new System.IO.MemoryStream();
                            //this.PbFolio.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                            FileStream pdf = File.OpenRead(ruta);
                            byte[] contenidoPdf = new byte[pdf.Length];
                            pdf.Read(contenidoPdf, 0, (int)pdf.Length);
                            pdf.Close();
                            //byte[] image = ms.GetBuffer();                                                                               

                            rpta = NAgInspeccion.Agregar(Convert.ToInt16(this.CbNombre.SelectedValue),
                                Convert.ToInt32(this.CbElectrico.SelectedValue), Convert.ToDateTime(this.DtFecha.Value), contenidoPdf);

                            if (this.CkOutlook.Checked == true)
                            {
                                // usar el objeto de outlook para crear el recordatorio
                                Outlook._Application App = (Outlook._Application)new Outlook.Application();
                                Outlook._AppointmentItem apt = (Outlook._AppointmentItem)
                                App.CreateItem(Outlook.OlItemType.olAppointmentItem);
                                // algunas propiedades
                                apt.Subject = "Inspeccion obra" + this.CbNombre.Text;
                                apt.Body = "reminderComment";
                                apt.Start = this.DtFecha.Value;
                                apt.End = this.DtFecha.Value.AddHours(6);
                                apt.ReminderMinutesBeforeStart = 1;
                                apt.BusyStatus = Outlook.OlBusyStatus.olTentative;
                                apt.AllDayEvent = false;
                                apt.Save();
                            }
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
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
            }
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string User = FormInicio.PcUsuario;
            if (User == "ROBERT") User = "rarancibiar@minvu.cl";

            Electricos El = NAgInspeccion.Datos(User).First();
            string RUT = El.RUT;
            string PASS = El.Contraseña;

            if (WB.Document.Url.OriginalString == "http://intranet08.minvu.cl/ServiuVIII/login.aspx")
            {
                WB.Document.GetElementById("txt_login").InnerText = RUT.ToString();
                
                WB.Document.GetElementById("txt_pass").InnerText = PASS.ToString();
                //System.Threading.Thread.Sleep(5000);
                WB.Document.GetElementById("Aceptar").InvokeMember("click");
                WB.Navigate("http://intranet08.minvu.cl/ServiuVIII/sys_serviu/cometidofuncionario/grilla_solicitudes.aspx?id=qvuqusyuqrstuvwxypq&id_grupo=0&id_calidad_jefe=1");
            }
            //if (WB.Document.Url.OriginalString == "http://intranet08.minvu.cl/ServiuVIII/login.aspx") MessageBox.Show("Compuebe su contraseña", "Aplicación Eléctricos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //System.Threading.Thread.Sleep(5000);
         
        }
    }
}
