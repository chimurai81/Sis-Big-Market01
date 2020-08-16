namespace Modulo_Reportes
{
    partial class frmInformeCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformeCompra));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.contenedorRPT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbxCompra = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpHasta = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dtpDesde = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.txtProv = new System.Windows.Forms.TextBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtFact = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(217)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(792, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(17, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Buscar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(102, 165);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(106, 32);
            this.bunifuFlatButton1.TabIndex = 15;
            this.bunifuFlatButton1.Text = "Buscar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // contenedorRPT
            // 
            this.contenedorRPT.Location = new System.Drawing.Point(0, 214);
            this.contenedorRPT.Name = "contenedorRPT";
            this.contenedorRPT.ServerReport.BearerToken = null;
            this.contenedorRPT.Size = new System.Drawing.Size(815, 531);
            this.contenedorRPT.TabIndex = 13;
            // 
            // cbxCompra
            // 
            this.cbxCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(81)))), ((int)(((byte)(93)))));
            this.cbxCompra.FormattingEnabled = true;
            this.cbxCompra.Items.AddRange(new object[] {
            "Fecha",
            "Factura",
            "Proveedor"});
            this.cbxCompra.Location = new System.Drawing.Point(57, 128);
            this.cbxCompra.Name = "cbxCompra";
            this.cbxCompra.Size = new System.Drawing.Size(195, 32);
            this.cbxCompra.TabIndex = 12;
            this.cbxCompra.SelectedIndexChanged += new System.EventHandler(this.cbxCompra_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // dtpHasta
            // 
            this.dtpHasta.BackColor = System.Drawing.Color.SteelBlue;
            this.dtpHasta.BorderRadius = 0;
            this.dtpHasta.ForeColor = System.Drawing.Color.White;
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpHasta.FormatCustom = null;
            this.dtpHasta.Location = new System.Drawing.Point(382, 148);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(339, 26);
            this.dtpHasta.TabIndex = 36;
            this.dtpHasta.Value = new System.DateTime(2020, 8, 15, 9, 54, 15, 204);
            this.dtpHasta.Visible = false;
            this.dtpHasta.onValueChanged += new System.EventHandler(this.dtpHasta_onValueChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.BackColor = System.Drawing.Color.CadetBlue;
            this.dtpDesde.BorderRadius = 0;
            this.dtpDesde.ForeColor = System.Drawing.Color.White;
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDesde.FormatCustom = null;
            this.dtpDesde.Location = new System.Drawing.Point(381, 111);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(340, 26);
            this.dtpDesde.TabIndex = 35;
            this.dtpDesde.Value = new System.DateTime(2020, 8, 15, 9, 54, 15, 204);
            this.dtpDesde.Visible = false;
            this.dtpDesde.onValueChanged += new System.EventHandler(this.dtpDesde_onValueChanged);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDesde.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDesde.Location = new System.Drawing.Point(316, 117);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(60, 20);
            this.lblDesde.TabIndex = 27;
            this.lblDesde.Text = "Desde:";
            this.lblDesde.Visible = false;
            this.lblDesde.Click += new System.EventHandler(this.lblDesde_Click);
            // 
            // txtProv
            // 
            this.txtProv.Location = new System.Drawing.Point(423, 148);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(217, 20);
            this.txtProv.TabIndex = 33;
            this.txtProv.Visible = false;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.lblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFactura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFactura.Location = new System.Drawing.Point(429, 117);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(211, 20);
            this.lblFactura.TabIndex = 34;
            this.lblFactura.Text = "Favor Inserte el Nro. Factura";
            this.lblFactura.Visible = false;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHasta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHasta.Location = new System.Drawing.Point(321, 148);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(56, 20);
            this.lblHasta.TabIndex = 28;
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.Visible = false;
            this.lblHasta.Click += new System.EventHandler(this.lblHasta_Click);
            // 
            // txtFact
            // 
            this.txtFact.Location = new System.Drawing.Point(433, 150);
            this.txtFact.Name = "txtFact";
            this.txtFact.Size = new System.Drawing.Size(217, 20);
            this.txtFact.TabIndex = 26;
            this.txtFact.Visible = false;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProveedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProveedor.Location = new System.Drawing.Point(429, 117);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(195, 20);
            this.lblProveedor.TabIndex = 32;
            this.lblProveedor.Text = "Favor Inserte el Proveedor";
            this.lblProveedor.Visible = false;
            // 
            // frmInformeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 745);
            this.Controls.Add(this.txtProv);
            this.Controls.Add(this.txtFact);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.contenedorRPT);
            this.Controls.Add(this.cbxCompra);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformeCompra";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmInformeCompra";
            this.Load += new System.EventHandler(this.frmInformeCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Microsoft.Reporting.WinForms.ReportViewer contenedorRPT;
        private System.Windows.Forms.ComboBox cbxCompra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDatepicker dtpHasta;
        private Bunifu.Framework.UI.BunifuDatepicker dtpDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.TextBox txtProv;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.TextBox txtFact;
        private System.Windows.Forms.Label lblProveedor;
    }
}