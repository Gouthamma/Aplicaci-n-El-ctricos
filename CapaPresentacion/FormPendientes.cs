using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook;
using CapaEntidad;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class FormPendientes : Form
    {
        public FormPendientes()
        {
            InitializeComponent();
        }
        private void Mostrar()
        {
            DGVCNT.DataSource = NInicio.mostrarcnt(FormInicio.User);
            DGVCSP.DataSource = NInicio.mostrarcsp(FormInicio.User);
            DGVPPPF.DataSource = NInicio.mostrarpppf(FormInicio.User);
            DGVFolio.DataSource = NInicio.mostrarfolio(FormInicio.User);
        }

        private void FormPendientes_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
