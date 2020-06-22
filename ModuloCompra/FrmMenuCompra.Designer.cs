namespace ModuloCompra
{
    partial class FrmMenuCompra
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCompraID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtFactura = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuWebClient1 = new Bunifu.Framework.UI.BunifuWebClient(this.components);
            this.cbxCondicion = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.cbxfecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.grilla = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoMedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStock = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtCostoMedio = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtCostoReal = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtIdProveedor = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtNombreProveedor = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblCodigo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDescricion = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCosto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSubtotal = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtIva0 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtTotalNeto = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtTotalIva = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtIva10 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtIva5 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtCodigoProducto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCompraID
            // 
            this.txtCompraID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompraID.Enabled = false;
            this.txtCompraID.Font = new System.Drawing.Font("Futura Bk BT", 12F);
            this.txtCompraID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.txtCompraID.HintForeColor = System.Drawing.Color.Empty;
            this.txtCompraID.HintText = "";
            this.txtCompraID.isPassword = false;
            this.txtCompraID.LineFocusedColor = System.Drawing.Color.DarkTurquoise;
            this.txtCompraID.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.txtCompraID.LineMouseHoverColor = System.Drawing.Color.DarkTurquoise;
            this.txtCompraID.LineThickness = 3;
            this.txtCompraID.Location = new System.Drawing.Point(198, 33);
            this.txtCompraID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCompraID.Name = "txtCompraID";
            this.txtCompraID.Size = new System.Drawing.Size(319, 29);
            this.txtCompraID.TabIndex = 7;
            this.txtCompraID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(67, 43);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(114, 24);
            this.txt.TabIndex = 0;
            this.txt.Text = "Compra ID:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(114, 98);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(67, 24);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Fecha:";
            // 
            // txtFactura
            // 
            this.txtFactura.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFactura.Font = new System.Drawing.Font("Futura Bk BT", 12F);
            this.txtFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.txtFactura.HintForeColor = System.Drawing.Color.Empty;
            this.txtFactura.HintText = "";
            this.txtFactura.isPassword = false;
            this.txtFactura.LineFocusedColor = System.Drawing.Color.DarkTurquoise;
            this.txtFactura.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.txtFactura.LineMouseHoverColor = System.Drawing.Color.DarkTurquoise;
            this.txtFactura.LineThickness = 3;
            this.txtFactura.Location = new System.Drawing.Point(705, 33);
            this.txtFactura.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(348, 29);
            this.txtFactura.TabIndex = 9;
            this.txtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFactura.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(600, 43);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(80, 24);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Factura:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(547, 98);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(133, 24);
            this.bunifuCustomLabel3.TabIndex = 11;
            this.bunifuCustomLabel3.Text = "Tipo De Pago:";
            // 
            // bunifuWebClient1
            // 
            this.bunifuWebClient1.AllowReadStreamBuffering = false;
            this.bunifuWebClient1.AllowWriteStreamBuffering = false;
            this.bunifuWebClient1.BaseAddress = "";
            this.bunifuWebClient1.CachePolicy = null;
            this.bunifuWebClient1.Credentials = null;
            this.bunifuWebClient1.Encoding = ((System.Text.Encoding)(resources.GetObject("bunifuWebClient1.Encoding")));
            this.bunifuWebClient1.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("bunifuWebClient1.Headers")));
            this.bunifuWebClient1.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("bunifuWebClient1.QueryString")));
            this.bunifuWebClient1.UseDefaultCredentials = false;
            // 
            // cbxCondicion
            // 
            this.cbxCondicion.BackColor = System.Drawing.Color.Transparent;
            this.cbxCondicion.BorderRadius = 3;
            this.cbxCondicion.Font = new System.Drawing.Font("Futura Bk BT", 12F);
            this.cbxCondicion.ForeColor = System.Drawing.Color.White;
            this.cbxCondicion.Items = new string[] {
        "CONTADO",
        "CREDITO"};
            this.cbxCondicion.Location = new System.Drawing.Point(689, 86);
            this.cbxCondicion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxCondicion.Name = "cbxCondicion";
            this.cbxCondicion.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cbxCondicion.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cbxCondicion.selectedIndex = 0;
            this.cbxCondicion.Size = new System.Drawing.Size(364, 36);
            this.cbxCondicion.TabIndex = 20;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // cbxfecha
            // 
            this.cbxfecha.BackColor = System.Drawing.Color.SeaGreen;
            this.cbxfecha.BorderRadius = 0;
            this.cbxfecha.Font = new System.Drawing.Font("Futura Bk BT", 12F);
            this.cbxfecha.ForeColor = System.Drawing.Color.White;
            this.cbxfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cbxfecha.FormatCustom = null;
            this.cbxfecha.Location = new System.Drawing.Point(187, 86);
            this.cbxfecha.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxfecha.Name = "cbxfecha";
            this.cbxfecha.Size = new System.Drawing.Size(330, 36);
            this.cbxfecha.TabIndex = 21;
            this.cbxfecha.Value = new System.DateTime(2020, 6, 1, 15, 23, 29, 465);
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grilla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grilla.BackgroundColor = System.Drawing.Color.MintCream;
            this.grilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seq,
            this.Codigo,
            this.Descripcion,
            this.Cantidad,
            this.CostoReal,
            this.SubTotal,
            this.CostoMedio,
            this.iva,
            this.montoIva});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Futura Bk BT", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilla.DefaultCellStyle = dataGridViewCellStyle3;
            this.grilla.DoubleBuffered = true;
            this.grilla.EnableHeadersVisualStyles = false;
            this.grilla.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.grilla.HeaderForeColor = System.Drawing.Color.White;
            this.grilla.Location = new System.Drawing.Point(34, 262);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grilla.RowHeadersWidth = 50;
            this.grilla.RowTemplate.Height = 24;
            this.grilla.Size = new System.Drawing.Size(1690, 474);
            this.grilla.TabIndex = 30;
            // 
            // Seq
            // 
            this.Seq.HeaderText = "#";
            this.Seq.Name = "Seq";
            this.Seq.ReadOnly = true;
            this.Seq.Width = 40;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 120;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 30;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 330;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 120;
            // 
            // CostoReal
            // 
            this.CostoReal.HeaderText = "Costo Real";
            this.CostoReal.Name = "CostoReal";
            this.CostoReal.ReadOnly = true;
            this.CostoReal.Width = 150;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 130;
            // 
            // CostoMedio
            // 
            this.CostoMedio.HeaderText = "Costo Medio";
            this.CostoMedio.Name = "CostoMedio";
            this.CostoMedio.ReadOnly = true;
            this.CostoMedio.Width = 160;
            // 
            // iva
            // 
            this.iva.HeaderText = "IVA";
            this.iva.Name = "iva";
            this.iva.ReadOnly = true;
            this.iva.Width = 50;
            // 
            // montoIva
            // 
            this.montoIva.HeaderText = "Monto IVA";
            this.montoIva.Name = "montoIva";
            this.montoIva.ReadOnly = true;
            this.montoIva.Width = 140;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.txtCostoMedio);
            this.groupBox1.Controls.Add(this.txtCostoReal);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox1.Font = new System.Drawing.Font("Futura Bk BT", 12F);
            this.groupBox1.Location = new System.Drawing.Point(1193, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 200);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Actual de Producto";
            // 
            // txtStock
            // 
            this.txtStock.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtStock.Location = new System.Drawing.Point(153, 151);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(257, 31);
            this.txtStock.TabIndex = 30;
            // 
            // txtCostoMedio
            // 
            this.txtCostoMedio.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCostoMedio.Location = new System.Drawing.Point(153, 95);
            this.txtCostoMedio.Name = "txtCostoMedio";
            this.txtCostoMedio.Size = new System.Drawing.Size(257, 31);
            this.txtCostoMedio.TabIndex = 29;
            // 
            // txtCostoReal
            // 
            this.txtCostoReal.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCostoReal.Location = new System.Drawing.Point(153, 40);
            this.txtCostoReal.Name = "txtCostoReal";
            this.txtCostoReal.Size = new System.Drawing.Size(257, 31);
            this.txtCostoReal.TabIndex = 28;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(71, 153);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(61, 24);
            this.bunifuCustomLabel4.TabIndex = 25;
            this.bunifuCustomLabel4.Text = "Stock:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(6, 102);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(126, 24);
            this.bunifuCustomLabel5.TabIndex = 26;
            this.bunifuCustomLabel5.Text = "Costo Medio:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(23, 52);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(109, 24);
            this.bunifuCustomLabel6.TabIndex = 27;
            this.bunifuCustomLabel6.Text = "Costo Real:";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(36, 150);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(143, 24);
            this.bunifuCustomLabel7.TabIndex = 25;
            this.bunifuCustomLabel7.Text = "Proveedor - F5:";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtIdProveedor.Font = new System.Drawing.Font("Futura Bk BT", 12F);
            this.txtIdProveedor.Location = new System.Drawing.Point(187, 147);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(209, 31);
            this.txtIdProveedor.TabIndex = 31;
            this.txtIdProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProveedor_KeyPress);
            this.txtIdProveedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIdProveedor_KeyUp);
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtNombreProveedor.Font = new System.Drawing.Font("Futura Bk BT", 12F);
            this.txtNombreProveedor.Location = new System.Drawing.Point(402, 147);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(651, 31);
            this.txtNombreProveedor.TabIndex = 32;
            this.txtNombreProveedor.TextChanged += new System.EventHandler(this.bunifuCustomTextbox5_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Futura Bk BT", 15F);
            this.lblCodigo.ForeColor = System.Drawing.Color.Green;
            this.lblCodigo.Location = new System.Drawing.Point(35, 215);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(119, 30);
            this.lblCodigo.TabIndex = 33;
            this.lblCodigo.Text = "CODIGO";
            this.lblCodigo.Click += new System.EventHandler(this.bunifuCustomLabel8_Click);
            // 
            // lblDescricion
            // 
            this.lblDescricion.AutoSize = true;
            this.lblDescricion.Font = new System.Drawing.Font("Futura Bk BT", 15F);
            this.lblDescricion.ForeColor = System.Drawing.Color.Green;
            this.lblDescricion.Location = new System.Drawing.Point(397, 215);
            this.lblDescricion.Name = "lblDescricion";
            this.lblDescricion.Size = new System.Drawing.Size(365, 30);
            this.lblDescricion.TabIndex = 34;
            this.lblDescricion.Text = "DESCRIPCION DEL PRODUCTO";
            // 
            // txtCosto
            // 
            this.txtCosto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCosto.Font = new System.Drawing.Font("Futura Bk BT", 12F);
            this.txtCosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.txtCosto.HintForeColor = System.Drawing.Color.Empty;
            this.txtCosto.HintText = "";
            this.txtCosto.isPassword = false;
            this.txtCosto.LineFocusedColor = System.Drawing.Color.DarkTurquoise;
            this.txtCosto.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.txtCosto.LineMouseHoverColor = System.Drawing.Color.DarkTurquoise;
            this.txtCosto.LineThickness = 3;
            this.txtCosto.Location = new System.Drawing.Point(495, 771);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(205, 29);
            this.txtCosto.TabIndex = 38;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Font = new System.Drawing.Font("Futura Bk BT", 12F);
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.txtCantidad.HintForeColor = System.Drawing.Color.Empty;
            this.txtCantidad.HintText = "";
            this.txtCantidad.isPassword = false;
            this.txtCantidad.LineFocusedColor = System.Drawing.Color.DarkTurquoise;
            this.txtCantidad.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.txtCantidad.LineMouseHoverColor = System.Drawing.Color.DarkTurquoise;
            this.txtCantidad.LineThickness = 3;
            this.txtCantidad.Location = new System.Drawing.Point(268, 771);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(205, 29);
            this.txtCantidad.TabIndex = 39;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(491, 804);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(60, 24);
            this.bunifuCustomLabel10.TabIndex = 40;
            this.bunifuCustomLabel10.Text = "Costo";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(264, 804);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(90, 24);
            this.bunifuCustomLabel11.TabIndex = 41;
            this.bunifuCustomLabel11.Text = "Cantidad";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(49, 807);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(196, 24);
            this.bunifuCustomLabel12.TabIndex = 42;
            this.bunifuCustomLabel12.Text = "Codigo Producto - F6";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(1037, 752);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(257, 39);
            this.txtSubtotal.TabIndex = 31;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(926, 852);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(105, 24);
            this.bunifuCustomLabel13.TabIndex = 43;
            this.bunifuCustomLabel13.Text = "Total Neto:";
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(990, 807);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(41, 24);
            this.bunifuCustomLabel14.TabIndex = 44;
            this.bunifuCustomLabel14.Text = "Iva:";
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(926, 762);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(90, 24);
            this.bunifuCustomLabel15.TabIndex = 45;
            this.bunifuCustomLabel15.Text = "SubTotal:";
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(1340, 852);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(86, 24);
            this.bunifuCustomLabel16.TabIndex = 46;
            this.bunifuCustomLabel16.Text = "Iva 10%:";
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.AutoSize = true;
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(1350, 804);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(74, 24);
            this.bunifuCustomLabel17.TabIndex = 47;
            this.bunifuCustomLabel17.Text = "Iva 5%:";
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(1352, 762);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(72, 24);
            this.bunifuCustomLabel18.TabIndex = 48;
            this.bunifuCustomLabel18.Text = "Exenta:";
            // 
            // txtIva0
            // 
            this.txtIva0.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtIva0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva0.Location = new System.Drawing.Point(1436, 754);
            this.txtIva0.Name = "txtIva0";
            this.txtIva0.Size = new System.Drawing.Size(257, 39);
            this.txtIva0.TabIndex = 49;
            // 
            // txtTotalNeto
            // 
            this.txtTotalNeto.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTotalNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNeto.Location = new System.Drawing.Point(1037, 842);
            this.txtTotalNeto.Name = "txtTotalNeto";
            this.txtTotalNeto.Size = new System.Drawing.Size(257, 39);
            this.txtTotalNeto.TabIndex = 50;
            // 
            // txtTotalIva
            // 
            this.txtTotalIva.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTotalIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalIva.Location = new System.Drawing.Point(1037, 797);
            this.txtTotalIva.Name = "txtTotalIva";
            this.txtTotalIva.Size = new System.Drawing.Size(257, 39);
            this.txtTotalIva.TabIndex = 51;
            // 
            // txtIva10
            // 
            this.txtIva10.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtIva10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva10.Location = new System.Drawing.Point(1436, 844);
            this.txtIva10.Name = "txtIva10";
            this.txtIva10.Size = new System.Drawing.Size(257, 39);
            this.txtIva10.TabIndex = 52;
            // 
            // txtIva5
            // 
            this.txtIva5.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtIva5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva5.Location = new System.Drawing.Point(1436, 799);
            this.txtIva5.Name = "txtIva5";
            this.txtIva5.Size = new System.Drawing.Size(257, 39);
            this.txtIva5.TabIndex = 53;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Firebrick;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Firebrick;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "CANCELAR";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.IndianRed;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.IndianRed;
            this.bunifuThinButton22.Location = new System.Drawing.Point(259, 869);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton22.TabIndex = 56;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ModuloCompra.Properties.Resources.close__2_;
            this.pictureBox1.Location = new System.Drawing.Point(1668, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "COMPRAR";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(40, 869);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton21.TabIndex = 54;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Futura Bk BT", 12F);
            this.txtCodigoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.txtCodigoProducto.HintForeColor = System.Drawing.Color.Empty;
            this.txtCodigoProducto.HintText = "";
            this.txtCodigoProducto.isPassword = false;
            this.txtCodigoProducto.LineFocusedColor = System.Drawing.Color.DarkTurquoise;
            this.txtCodigoProducto.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.txtCodigoProducto.LineMouseHoverColor = System.Drawing.Color.DarkTurquoise;
            this.txtCodigoProducto.LineThickness = 3;
            this.txtCodigoProducto.Location = new System.Drawing.Point(40, 771);
            this.txtCodigoProducto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(205, 29);
            this.txtCodigoProducto.TabIndex = 57;
            this.txtCodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProducto_KeyPress_1);
            this.txtCodigoProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoProducto_KeyUp_2);
            this.txtCodigoProducto.Leave += new System.EventHandler(this.txtCodigoProducto_Leave_1);
            // 
            // FrmMenuCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1769, 941);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.txtIva5);
            this.Controls.Add(this.txtIva10);
            this.Controls.Add(this.txtTotalIva);
            this.Controls.Add(this.txtTotalNeto);
            this.Controls.Add(this.txtIva0);
            this.Controls.Add(this.bunifuCustomLabel18);
            this.Controls.Add(this.bunifuCustomLabel17);
            this.Controls.Add(this.bunifuCustomLabel16);
            this.Controls.Add(this.bunifuCustomLabel15);
            this.Controls.Add(this.bunifuCustomLabel14);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.bunifuCustomLabel11);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblDescricion);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.cbxfecha);
            this.Controls.Add(this.cbxCondicion);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtCompraID);
            this.Controls.Add(this.txt);
            this.Name = "FrmMenuCompra";
            this.Text = "FrmMenuCompra";
            this.Load += new System.EventHandler(this.FrmMenuCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel txt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuWebClient bunifuWebClient1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCompraID;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtFactura;
        public Bunifu.Framework.UI.BunifuDropdown cbxCondicion;
        public Bunifu.Framework.UI.BunifuDatepicker cbxfecha;
        public Bunifu.Framework.UI.BunifuCustomDataGrid grilla;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtStock;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtCostoMedio;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtCostoReal;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtIdProveedor;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtNombreProveedor;
        public Bunifu.Framework.UI.BunifuCustomLabel lblCodigo;
        public Bunifu.Framework.UI.BunifuCustomLabel lblDescricion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoMedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoIva;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCosto;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCantidad;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtSubtotal;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtIva0;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtTotalNeto;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtTotalIva;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtIva10;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox txtIva5;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoProducto;
    }
}