namespace Prod_Provee_Marc_Categ.Formularios_De_Productos
{
    partial class FrmNuevoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoProductos));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dtpFechaVencimiento = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtCodigoProducto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDescripcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrecioUnitario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrecioMayorista = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCategoria = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMarca = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtProveedor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCodigoDeBarra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ptbImagenProducto = new System.Windows.Forms.PictureBox();
            this.btnElegirImagenProducto = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnElegirCategoria = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnElegirMarca = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnProveedor = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtCosto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCostoMedio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.cbxIva = new Bunifu.Framework.UI.BunifuDropdown();
            this.cbxTipo = new Bunifu.Framework.UI.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnElegirCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnElegirMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpFechaVencimiento.BackgroundImage = global::Prod_Provee_Marc_Categ.Properties.Resources.a68832c79725180370fa5e147b19b8c5;
            this.dtpFechaVencimiento.BorderRadius = 0;
            this.dtpFechaVencimiento.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.FormatCustom = "Fecha De Vencimiento";
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(13, 479);
            this.dtpFechaVencimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(511, 55);
            this.dtpFechaVencimiento.TabIndex = 7;
            this.toolTip1.SetToolTip(this.dtpFechaVencimiento, "Fecha De Vencimiento");
            this.toolTip2.SetToolTip(this.dtpFechaVencimiento, "Fecha De Vencimiento");
            this.dtpFechaVencimiento.Value = new System.DateTime(2020, 4, 16, 19, 6, 52, 585);
            this.dtpFechaVencimiento.Click += new System.EventHandler(this.dtpFechaNac_Click);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodigoProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtCodigoProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoProducto.HintForeColor = System.Drawing.Color.Empty;
            this.txtCodigoProducto.HintText = "";
            this.txtCodigoProducto.isPassword = false;
            this.txtCodigoProducto.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCodigoProducto.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCodigoProducto.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCodigoProducto.LineThickness = 3;
            this.txtCodigoProducto.Location = new System.Drawing.Point(13, 127);
            this.txtCodigoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(511, 55);
            this.txtCodigoProducto.TabIndex = 0;
            this.txtCodigoProducto.Text = "Codigo";
            this.txtCodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoProducto.Enter += new System.EventHandler(this.txtProducto_Enter);
            this.txtCodigoProducto.Leave += new System.EventHandler(this.txtCodigoProducto_Leave);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.HintForeColor = System.Drawing.Color.Empty;
            this.txtDescripcion.HintText = "";
            this.txtDescripcion.isPassword = false;
            this.txtDescripcion.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDescripcion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDescripcion.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDescripcion.LineThickness = 3;
            this.txtDescripcion.Location = new System.Drawing.Point(13, 185);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(511, 55);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Text = "Descripcion";
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrecioUnitario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrecioUnitario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioUnitario.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrecioUnitario.HintText = "";
            this.txtPrecioUnitario.isPassword = false;
            this.txtPrecioUnitario.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrecioUnitario.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrecioUnitario.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrecioUnitario.LineThickness = 3;
            this.txtPrecioUnitario.Location = new System.Drawing.Point(617, 444);
            this.txtPrecioUnitario.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(511, 55);
            this.txtPrecioUnitario.TabIndex = 12;
            this.txtPrecioUnitario.Text = "Precio Unitario";
            this.txtPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecioUnitario.Enter += new System.EventHandler(this.txtPrecioUnitario_Enter);
            this.txtPrecioUnitario.Leave += new System.EventHandler(this.txtPrecioUnitario_Leave);
            // 
            // txtPrecioMayorista
            // 
            this.txtPrecioMayorista.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrecioMayorista.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioMayorista.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrecioMayorista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioMayorista.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrecioMayorista.HintText = "";
            this.txtPrecioMayorista.isPassword = false;
            this.txtPrecioMayorista.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrecioMayorista.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrecioMayorista.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrecioMayorista.LineThickness = 3;
            this.txtPrecioMayorista.Location = new System.Drawing.Point(617, 502);
            this.txtPrecioMayorista.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioMayorista.Name = "txtPrecioMayorista";
            this.txtPrecioMayorista.Size = new System.Drawing.Size(511, 55);
            this.txtPrecioMayorista.TabIndex = 13;
            this.txtPrecioMayorista.Text = "Precio Mayorista";
            this.txtPrecioMayorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecioMayorista.Enter += new System.EventHandler(this.txtPrecioMayorista_Enter);
            this.txtPrecioMayorista.Leave += new System.EventHandler(this.txtPrecioMayorista_Leave);
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCategoria.HintForeColor = System.Drawing.Color.Empty;
            this.txtCategoria.HintText = "";
            this.txtCategoria.isPassword = false;
            this.txtCategoria.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCategoria.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCategoria.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCategoria.LineThickness = 3;
            this.txtCategoria.Location = new System.Drawing.Point(13, 243);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(511, 55);
            this.txtCategoria.TabIndex = 2;
            this.txtCategoria.Text = "Categoria";
            this.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCategoria.Enter += new System.EventHandler(this.txtCategoria_Enter);
            this.txtCategoria.Leave += new System.EventHandler(this.txtCategoria_Leave);
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMarca.HintForeColor = System.Drawing.Color.Empty;
            this.txtMarca.HintText = "";
            this.txtMarca.isPassword = false;
            this.txtMarca.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMarca.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMarca.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMarca.LineThickness = 3;
            this.txtMarca.Location = new System.Drawing.Point(13, 302);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(511, 55);
            this.txtMarca.TabIndex = 3;
            this.txtMarca.Text = "Marca";
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMarca.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox7_OnValueChanged);
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProveedor.HintForeColor = System.Drawing.Color.Empty;
            this.txtProveedor.HintText = "";
            this.txtProveedor.isPassword = false;
            this.txtProveedor.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtProveedor.LineIdleColor = System.Drawing.Color.Gray;
            this.txtProveedor.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtProveedor.LineThickness = 3;
            this.txtProveedor.Location = new System.Drawing.Point(13, 361);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(511, 55);
            this.txtProveedor.TabIndex = 4;
            this.txtProveedor.Text = "Proveedor";
            this.txtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCodigoDeBarra
            // 
            this.txtCodigoDeBarra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodigoDeBarra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoDeBarra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigoDeBarra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoDeBarra.HintForeColor = System.Drawing.Color.Empty;
            this.txtCodigoDeBarra.HintText = "";
            this.txtCodigoDeBarra.isPassword = false;
            this.txtCodigoDeBarra.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCodigoDeBarra.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCodigoDeBarra.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCodigoDeBarra.LineThickness = 3;
            this.txtCodigoDeBarra.Location = new System.Drawing.Point(13, 420);
            this.txtCodigoDeBarra.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoDeBarra.Name = "txtCodigoDeBarra";
            this.txtCodigoDeBarra.Size = new System.Drawing.Size(511, 55);
            this.txtCodigoDeBarra.TabIndex = 5;
            this.txtCodigoDeBarra.Text = "Codigo De Barra";
            this.txtCodigoDeBarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoDeBarra.Enter += new System.EventHandler(this.bunifuMaterialTextbox9_Enter);
            this.txtCodigoDeBarra.Leave += new System.EventHandler(this.bunifuMaterialTextbox9_Leave);
            // 
            // ptbImagenProducto
            // 
            this.ptbImagenProducto.Location = new System.Drawing.Point(693, 127);
            this.ptbImagenProducto.Name = "ptbImagenProducto";
            this.ptbImagenProducto.Size = new System.Drawing.Size(348, 254);
            this.ptbImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagenProducto.TabIndex = 10;
            this.ptbImagenProducto.TabStop = false;
            // 
            // btnElegirImagenProducto
            // 
            this.btnElegirImagenProducto.ActiveBorderThickness = 1;
            this.btnElegirImagenProducto.ActiveCornerRadius = 15;
            this.btnElegirImagenProducto.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnElegirImagenProducto.ActiveForecolor = System.Drawing.Color.White;
            this.btnElegirImagenProducto.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnElegirImagenProducto.BackColor = System.Drawing.SystemColors.Control;
            this.btnElegirImagenProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnElegirImagenProducto.BackgroundImage")));
            this.btnElegirImagenProducto.ButtonText = "Seleccionar Imagen";
            this.btnElegirImagenProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElegirImagenProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirImagenProducto.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnElegirImagenProducto.IdleBorderThickness = 1;
            this.btnElegirImagenProducto.IdleCornerRadius = 15;
            this.btnElegirImagenProducto.IdleFillColor = System.Drawing.Color.White;
            this.btnElegirImagenProducto.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnElegirImagenProducto.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnElegirImagenProducto.Location = new System.Drawing.Point(1900, 520);
            this.btnElegirImagenProducto.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnElegirImagenProducto.Name = "btnElegirImagenProducto";
            this.btnElegirImagenProducto.Size = new System.Drawing.Size(334, 76);
            this.btnElegirImagenProducto.TabIndex = 13;
            this.btnElegirImagenProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnElegirImagenProducto.Click += new System.EventHandler(this.btnElegirImagenProducto_Click);
            // 
            // btnElegirCategoria
            // 
            this.btnElegirCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnElegirCategoria.Image = global::Prod_Provee_Marc_Categ.Properties.Resources.category;
            this.btnElegirCategoria.ImageActive = null;
            this.btnElegirCategoria.Location = new System.Drawing.Point(531, 244);
            this.btnElegirCategoria.Name = "btnElegirCategoria";
            this.btnElegirCategoria.Size = new System.Drawing.Size(59, 55);
            this.btnElegirCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnElegirCategoria.TabIndex = 17;
            this.btnElegirCategoria.TabStop = false;
            this.toolTip1.SetToolTip(this.btnElegirCategoria, "Agregar Categoria Existentes");
            this.btnElegirCategoria.Zoom = 10;
            this.btnElegirCategoria.Click += new System.EventHandler(this.btnElegirCategoria_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Prod_Provee_Marc_Categ.Properties.Resources.close__2_;
            this.pictureBox2.Location = new System.Drawing.Point(1137, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnElegirMarca
            // 
            this.btnElegirMarca.BackColor = System.Drawing.Color.Transparent;
            this.btnElegirMarca.Image = global::Prod_Provee_Marc_Categ.Properties.Resources._12533601;
            this.btnElegirMarca.ImageActive = null;
            this.btnElegirMarca.Location = new System.Drawing.Point(531, 304);
            this.btnElegirMarca.Name = "btnElegirMarca";
            this.btnElegirMarca.Size = new System.Drawing.Size(59, 55);
            this.btnElegirMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnElegirMarca.TabIndex = 27;
            this.btnElegirMarca.TabStop = false;
            this.toolTip1.SetToolTip(this.btnElegirMarca, "Agregar Marca Existentes");
            this.btnElegirMarca.Zoom = 10;
            this.btnElegirMarca.Click += new System.EventHandler(this.btnElegirMarca_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnProveedor.Image = global::Prod_Provee_Marc_Categ.Properties.Resources.icono_proveedor_png_51;
            this.btnProveedor.ImageActive = null;
            this.btnProveedor.Location = new System.Drawing.Point(531, 364);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(59, 52);
            this.btnProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProveedor.TabIndex = 28;
            this.btnProveedor.TabStop = false;
            this.toolTip1.SetToolTip(this.btnProveedor, "Agregar Proveedor Existente");
            this.btnProveedor.Zoom = 10;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::Prod_Provee_Marc_Categ.Properties.Resources.barcode;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(531, 420);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(59, 55);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 29;
            this.bunifuImageButton1.TabStop = false;
            this.toolTip1.SetToolTip(this.bunifuImageButton1, "Escanear Codigo");
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(188)))), ((int)(((byte)(67)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = global::Prod_Provee_Marc_Categ.Properties.Resources.a68832c79725180370fa5e147b19b8c5;
            this.bunifuImageButton2.Location = new System.Drawing.Point(617, 691);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(255, 109);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 35;
            this.bunifuImageButton2.TabStop = false;
            this.toolTip2.SetToolTip(this.bunifuImageButton2, "Guardar");
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(2)))), ((int)(((byte)(57)))));
            this.bunifuImageButton3.Image = global::Prod_Provee_Marc_Categ.Properties.Resources.close_white_25x25px;
            this.bunifuImageButton3.ImageActive = global::Prod_Provee_Marc_Categ.Properties.Resources.gif_icons_menu_transition_animations_animated_3_dotted;
            this.bunifuImageButton3.Location = new System.Drawing.Point(891, 691);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(237, 109);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButton3.TabIndex = 36;
            this.bunifuImageButton3.TabStop = false;
            this.toolTip2.SetToolTip(this.bunifuImageButton3, "Salir");
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 2000;
            this.toolTip2.InitialDelay = 500;
            this.toolTip2.ReshowDelay = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 21);
            this.label1.TabIndex = 37;
            this.label1.Text = "Fecha De Vencimiento";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // txtCosto
            // 
            this.txtCosto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCosto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCosto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCosto.HintForeColor = System.Drawing.Color.Empty;
            this.txtCosto.HintText = "";
            this.txtCosto.isPassword = false;
            this.txtCosto.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCosto.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCosto.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCosto.LineThickness = 3;
            this.txtCosto.Location = new System.Drawing.Point(13, 539);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(511, 55);
            this.txtCosto.TabIndex = 8;
            this.txtCosto.Text = "Costo";
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCosto.Enter += new System.EventHandler(this.txtCosto_Enter);
            this.txtCosto.Leave += new System.EventHandler(this.txtCosto_Leave);
            // 
            // txtCostoMedio
            // 
            this.txtCostoMedio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCostoMedio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCostoMedio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCostoMedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCostoMedio.HintForeColor = System.Drawing.Color.Empty;
            this.txtCostoMedio.HintText = "";
            this.txtCostoMedio.isPassword = false;
            this.txtCostoMedio.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCostoMedio.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCostoMedio.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCostoMedio.LineThickness = 3;
            this.txtCostoMedio.Location = new System.Drawing.Point(13, 599);
            this.txtCostoMedio.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostoMedio.Name = "txtCostoMedio";
            this.txtCostoMedio.Size = new System.Drawing.Size(511, 55);
            this.txtCostoMedio.TabIndex = 9;
            this.txtCostoMedio.Text = "Costo Medio";
            this.txtCostoMedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCostoMedio.Enter += new System.EventHandler(this.txtCostoMedio_Enter);
            this.txtCostoMedio.Leave += new System.EventHandler(this.txtCostoMedio_Leave);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(84)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = null;
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 30;
            this.bunifuTileButton1.LabelText = "...";
            this.bunifuTileButton1.Location = new System.Drawing.Point(818, 390);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(110, 32);
            this.bunifuTileButton1.TabIndex = 10;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 0;
            this.bunifuElipse2.TargetControl = this.ptbImagenProducto;
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.IndianRed;
            this.bunifuTileButton2.color = System.Drawing.Color.IndianRed;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = null;
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 27;
            this.bunifuTileButton2.LabelText = "x";
            this.bunifuTileButton2.Location = new System.Drawing.Point(931, 390);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(110, 32);
            this.bunifuTileButton2.TabIndex = 11;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // cbxIva
            // 
            this.cbxIva.BackColor = System.Drawing.Color.Transparent;
            this.cbxIva.BorderRadius = 3;
            this.cbxIva.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbxIva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            this.cbxIva.Items = new string[] {
        "0",
        "5",
        "10"};
            this.cbxIva.Location = new System.Drawing.Point(617, 560);
            this.cbxIva.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbxIva.Name = "cbxIva";
            this.cbxIva.NomalColor = System.Drawing.Color.White;
            this.cbxIva.onHoverColor = System.Drawing.Color.White;
            this.cbxIva.selectedIndex = -1;
            this.cbxIva.Size = new System.Drawing.Size(511, 55);
            this.cbxIva.TabIndex = 38;
            // 
            // cbxTipo
            // 
            this.cbxTipo.BackColor = System.Drawing.Color.Transparent;
            this.cbxTipo.BorderRadius = 3;
            this.cbxTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbxTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(74)))), ((int)(((byte)(127)))));
            this.cbxTipo.Items = new string[] {
        "Producto",
        "Delivery"};
            this.cbxTipo.Location = new System.Drawing.Point(617, 624);
            this.cbxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.NomalColor = System.Drawing.Color.White;
            this.cbxTipo.onHoverColor = System.Drawing.Color.White;
            this.cbxTipo.selectedIndex = -1;
            this.cbxTipo.Size = new System.Drawing.Size(511, 55);
            this.cbxTipo.TabIndex = 39;
            // 
            // FrmNuevoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prod_Provee_Marc_Categ.Properties.Resources.FondoAggProducto3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1174, 812);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.cbxIva);
            this.Controls.Add(this.bunifuTileButton2);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.txtCostoMedio);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnElegirMarca);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnElegirCategoria);
            this.Controls.Add(this.btnElegirImagenProducto);
            this.Controls.Add(this.txtCodigoDeBarra);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtPrecioMayorista);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.ptbImagenProducto);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoProductos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmNuevoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnElegirCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnElegirMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoProducto;
        private Bunifu.Framework.UI.BunifuDatepicker dtpFechaVencimiento;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigoDeBarra;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrecioMayorista;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrecioUnitario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDescripcion;
        private System.Windows.Forms.PictureBox ptbImagenProducto;
        private Bunifu.Framework.UI.BunifuThinButton2 btnElegirImagenProducto;
        private Bunifu.Framework.UI.BunifuImageButton btnElegirCategoria;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuImageButton btnElegirMarca;
        private Bunifu.Framework.UI.BunifuImageButton btnProveedor;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCostoMedio;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCosto;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCategoria;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtMarca;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtProveedor;
        private Bunifu.Framework.UI.BunifuDropdown cbxIva;
        private Bunifu.Framework.UI.BunifuDropdown cbxTipo;
        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}