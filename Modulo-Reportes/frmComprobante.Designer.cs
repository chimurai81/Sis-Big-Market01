namespace Modulo_Reportes
{
    partial class frmComprobante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprobante));
            this.contenedorRPT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // contenedorRPT
            // 
            this.contenedorRPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorRPT.LocalReport.ReportEmbeddedResource = "Modulo_Reportes.DiseñoComprobante.rdlc";
            this.contenedorRPT.Location = new System.Drawing.Point(0, 0);
            this.contenedorRPT.Name = "contenedorRPT";
            this.contenedorRPT.ServerReport.BearerToken = null;
            this.contenedorRPT.Size = new System.Drawing.Size(589, 861);
            this.contenedorRPT.TabIndex = 0;
            // 
            // frmComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 861);
            this.Controls.Add(this.contenedorRPT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmComprobante";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresion De Comprobante";
            this.Load += new System.EventHandler(this.frmComprobante_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer contenedorRPT;
    }
}