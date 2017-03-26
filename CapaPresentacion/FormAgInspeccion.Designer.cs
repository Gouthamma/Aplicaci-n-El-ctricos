namespace CapaPresentacion
{
    partial class FormAgInspeccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgInspeccion));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbElectrico = new System.Windows.Forms.ComboBox();
            this.DtFecha = new System.Windows.Forms.DateTimePicker();
            this.CbNombre = new System.Windows.Forms.ComboBox();
            this.LbID = new System.Windows.Forms.Label();
            this.CkOutlook = new System.Windows.Forms.CheckBox();
            this.BtAgregar = new System.Windows.Forms.Button();
            this.BtEditar = new System.Windows.Forms.Button();
            this.WB = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PdfAg = new AxAcroPDFLib.AxAcroPDF();
            this.BtFolio = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PdfAg)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.43859F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.56141F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CbElectrico, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DtFecha, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.CbNombre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LbID, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CkOutlook, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(496, 99);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = "I. Eléctrico*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 49);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre Obra*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(276, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CbElectrico
            // 
            this.CbElectrico.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CbElectrico.FormattingEnabled = true;
            this.CbElectrico.Location = new System.Drawing.Point(154, 63);
            this.CbElectrico.Name = "CbElectrico";
            this.CbElectrico.Size = new System.Drawing.Size(116, 21);
            this.CbElectrico.TabIndex = 9;
            // 
            // DtFecha
            // 
            this.DtFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DtFecha.Location = new System.Drawing.Point(366, 14);
            this.DtFecha.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.DtFecha.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DtFecha.Name = "DtFecha";
            this.DtFecha.Size = new System.Drawing.Size(115, 20);
            this.DtFecha.TabIndex = 10;
            this.DtFecha.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DtFecha.Enter += new System.EventHandler(this.DtFecha_Enter);
            // 
            // CbNombre
            // 
            this.CbNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CbNombre.FormattingEnabled = true;
            this.CbNombre.Location = new System.Drawing.Point(154, 14);
            this.CbNombre.Name = "CbNombre";
            this.CbNombre.Size = new System.Drawing.Size(116, 21);
            this.CbNombre.TabIndex = 12;
            // 
            // LbID
            // 
            this.LbID.AutoSize = true;
            this.LbID.Location = new System.Drawing.Point(276, 49);
            this.LbID.Name = "LbID";
            this.LbID.Size = new System.Drawing.Size(35, 13);
            this.LbID.TabIndex = 11;
            this.LbID.Text = "label4";
            this.LbID.Visible = false;
            // 
            // CkOutlook
            // 
            this.CkOutlook.AutoSize = true;
            this.CkOutlook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CkOutlook.Location = new System.Drawing.Point(366, 52);
            this.CkOutlook.Name = "CkOutlook";
            this.CkOutlook.Size = new System.Drawing.Size(127, 44);
            this.CkOutlook.TabIndex = 13;
            this.CkOutlook.Text = "Recordatorio Calendario";
            this.CkOutlook.UseVisualStyleBackColor = true;
            // 
            // BtAgregar
            // 
            this.BtAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BtAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtAgregar.BackgroundImage")));
            this.BtAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtAgregar.FlatAppearance.BorderSize = 0;
            this.BtAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAgregar.Location = new System.Drawing.Point(430, 297);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Size = new System.Drawing.Size(75, 68);
            this.BtAgregar.TabIndex = 1;
            this.BtAgregar.Text = "Agregar";
            this.BtAgregar.UseVisualStyleBackColor = false;
            this.BtAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // BtEditar
            // 
            this.BtEditar.BackColor = System.Drawing.Color.Transparent;
            this.BtEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtEditar.BackgroundImage")));
            this.BtEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtEditar.FlatAppearance.BorderSize = 0;
            this.BtEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEditar.Location = new System.Drawing.Point(433, 297);
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Size = new System.Drawing.Size(75, 68);
            this.BtEditar.TabIndex = 4;
            this.BtEditar.Text = "Editar";
            this.BtEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtEditar.UseVisualStyleBackColor = false;
            // 
            // WB
            // 
            this.WB.Location = new System.Drawing.Point(514, 12);
            this.WB.MinimumSize = new System.Drawing.Size(20, 20);
            this.WB.Name = "WB";
            this.WB.Size = new System.Drawing.Size(488, 424);
            this.WB.TabIndex = 5;
            this.WB.Url = new System.Uri("http://intranet08.minvu.cl/ServiuVIII/login.aspx", System.UriKind.Absolute);
            this.WB.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 52);
            this.label2.TabIndex = 7;
            this.label2.Text = "Folio";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.PdfAg, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 126);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(415, 313);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // PdfAg
            // 
            this.PdfAg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PdfAg.Enabled = true;
            this.PdfAg.Location = new System.Drawing.Point(3, 55);
            this.PdfAg.Name = "PdfAg";
            this.PdfAg.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PdfAg.OcxState")));
            this.PdfAg.Size = new System.Drawing.Size(409, 255);
            this.PdfAg.TabIndex = 9;
            // 
            // BtFolio
            // 
            this.BtFolio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtFolio.Location = new System.Drawing.Point(433, 402);
            this.BtFolio.Name = "BtFolio";
            this.BtFolio.Size = new System.Drawing.Size(38, 34);
            this.BtFolio.TabIndex = 3;
            this.BtFolio.Text = "...";
            this.BtFolio.UseVisualStyleBackColor = true;
            this.BtFolio.Click += new System.EventHandler(this.BtFolio_Click);
            // 
            // FormAgInspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 469);
            this.Controls.Add(this.WB);
            this.Controls.Add(this.BtEditar);
            this.Controls.Add(this.BtFolio);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.BtAgregar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormAgInspeccion";
            this.Text = "FormAgInspeccion";
            this.Load += new System.EventHandler(this.FormAgInspeccion_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PdfAg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtAgregar;
        public System.Windows.Forms.ComboBox CbElectrico;
        public System.Windows.Forms.DateTimePicker DtFecha;
        private System.Windows.Forms.Button BtEditar;
        public System.Windows.Forms.Label LbID;
        public System.Windows.Forms.ComboBox CbNombre;
        private System.Windows.Forms.WebBrowser WB;
        private System.Windows.Forms.CheckBox CkOutlook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public AxAcroPDFLib.AxAcroPDF PdfAg;
        private System.Windows.Forms.Button BtFolio;
    }
}