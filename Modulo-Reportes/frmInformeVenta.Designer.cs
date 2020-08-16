namespace Modulo_Reportes
{
    partial class frmInformeVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformeVenta));
            this.contenedorRPT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbxVenta = new System.Windows.Forms.ComboBox();
            this.checkContado = new System.Windows.Forms.RadioButton();
            this.checkAmbos = new System.Windows.Forms.RadioButton();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.checkCredito = new System.Windows.Forms.RadioButton();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dtpDesde = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dtpHasta = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedorRPT
            // 
            this.contenedorRPT.Location = new System.Drawing.Point(1, 182);
            this.contenedorRPT.Name = "contenedorRPT";
            this.contenedorRPT.ServerReport.BearerToken = null;
            this.contenedorRPT.Size = new System.Drawing.Size(870, 565);
            this.contenedorRPT.TabIndex = 2;
            this.contenedorRPT.Load += new System.EventHandler(this.contenedorRPT_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, -111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(899, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(835, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDesde.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDesde.Location = new System.Drawing.Point(360, 108);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(60, 20);
            this.lblDesde.TabIndex = 8;
            this.lblDesde.Text = "Desde:";
            this.lblDesde.Visible = false;
            this.lblDesde.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHasta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHasta.Location = new System.Drawing.Point(365, 139);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(56, 20);
            this.lblHasta.TabIndex = 12;
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.Visible = false;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(114, 137);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(94, 32);
            this.bunifuFlatButton1.TabIndex = 14;
            this.bunifuFlatButton1.Text = "Buscar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // cbxVenta
            // 
            this.cbxVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(81)))), ((int)(((byte)(93)))));
            this.cbxVenta.FormattingEnabled = true;
            this.cbxVenta.Items.AddRange(new object[] {
            "Fecha",
            "Metodo de Pago",
            "Cliente",
            "Cajero",
            "Completo"});
            this.cbxVenta.Location = new System.Drawing.Point(56, 102);
            this.cbxVenta.Name = "cbxVenta";
            this.cbxVenta.Size = new System.Drawing.Size(199, 32);
            this.cbxVenta.TabIndex = 13;
            this.cbxVenta.SelectedIndexChanged += new System.EventHandler(this.cbxVenta_SelectedIndexChanged);
            // 
            // checkContado
            // 
            this.checkContado.AutoSize = true;
            this.checkContado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.checkContado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkContado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkContado.Location = new System.Drawing.Point(368, 108);
            this.checkContado.Name = "checkContado";
            this.checkContado.Size = new System.Drawing.Size(106, 28);
            this.checkContado.TabIndex = 17;
            this.checkContado.TabStop = true;
            this.checkContado.Text = "Contado";
            this.checkContado.UseVisualStyleBackColor = false;
            this.checkContado.Visible = false;
            this.checkContado.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkAmbos
            // 
            this.checkAmbos.AutoSize = true;
            this.checkAmbos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.checkAmbos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAmbos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkAmbos.Location = new System.Drawing.Point(581, 108);
            this.checkAmbos.Name = "checkAmbos";
            this.checkAmbos.Size = new System.Drawing.Size(93, 28);
            this.checkAmbos.TabIndex = 18;
            this.checkAmbos.TabStop = true;
            this.checkAmbos.Text = "Ambos";
            this.checkAmbos.UseVisualStyleBackColor = false;
            this.checkAmbos.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(447, 86);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(182, 20);
            this.lblUsuario.TabIndex = 20;
            this.lblUsuario.Text = "Favor Inserte el Cajero/a";
            this.lblUsuario.Visible = false;
            // 
            // checkCredito
            // 
            this.checkCredito.AutoSize = true;
            this.checkCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.checkCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCredito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkCredito.Location = new System.Drawing.Point(480, 109);
            this.checkCredito.Name = "checkCredito";
            this.checkCredito.Size = new System.Drawing.Size(95, 28);
            this.checkCredito.TabIndex = 19;
            this.checkCredito.TabStop = true;
            this.checkCredito.Text = "Credito";
            this.checkCredito.UseVisualStyleBackColor = false;
            this.checkCredito.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(427, 111);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(217, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Visible = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(416, 113);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(217, 20);
            this.txtCliente.TabIndex = 21;
            this.txtCliente.Visible = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(168)))), ((int)(((byte)(166)))));
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCliente.Location = new System.Drawing.Point(436, 88);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(172, 20);
            this.lblCliente.TabIndex = 22;
            this.lblCliente.Text = "Favor Inserte el Cliente";
            this.lblCliente.Visible = false;
            // 
            // dtpDesde
            // 
            this.dtpDesde.BackColor = System.Drawing.Color.CadetBlue;
            this.dtpDesde.BorderRadius = 0;
            this.dtpDesde.ForeColor = System.Drawing.Color.White;
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDesde.FormatCustom = null;
            this.dtpDesde.Location = new System.Drawing.Point(426, 102);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(340, 26);
            this.dtpDesde.TabIndex = 24;
            this.dtpDesde.Value = new System.DateTime(2020, 8, 15, 9, 54, 15, 204);
            this.dtpDesde.Visible = false;
            // 
            // dtpHasta
            // 
            this.dtpHasta.BackColor = System.Drawing.Color.SteelBlue;
            this.dtpHasta.BorderRadius = 0;
            this.dtpHasta.ForeColor = System.Drawing.Color.White;
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpHasta.FormatCustom = null;
            this.dtpHasta.Location = new System.Drawing.Point(427, 139);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(339, 26);
            this.dtpHasta.TabIndex = 25;
            this.dtpHasta.Value = new System.DateTime(2020, 8, 15, 9, 54, 15, 204);
            this.dtpHasta.Visible = false;
            // 
            // frmInformeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(869, 745);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.checkCredito);
            this.Controls.Add(this.checkAmbos);
            this.Controls.Add(this.checkContado);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.cbxVenta);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.contenedorRPT);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformeVenta";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmInformeVenta";
            this.Load += new System.EventHandler(this.frmInformeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer contenedorRPT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.ComboBox cbxVenta;
        private System.Windows.Forms.RadioButton checkContado;
        private System.Windows.Forms.RadioButton checkAmbos;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.RadioButton checkCredito;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private Bunifu.Framework.UI.BunifuDatepicker dtpDesde;
        private Bunifu.Framework.UI.BunifuDatepicker dtpHasta;
    }
}