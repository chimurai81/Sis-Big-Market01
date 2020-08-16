using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Reportes
{
    public partial class frmInformeCompra : Form
    {
        public frmInformeCompra()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void impimirCompra(string condicion)
        {
            this.contenedorRPT.RefreshReport();
            string sql;
            DataSet dsVenta = new DataSet();
            MySqlDataAdapter consulta;
            try
            {
                Conexion_DB.AbrirConexion();
                sql = "select a.id, a.FacturaNro, a.FechaDeCompra, b.Nombre as 'Cajero', c.RazonSocial as 'Proveedor', a.TotalNeto,if(a.Estado = 1, 'Activo', 'Inactivo') as 'Estado' from db_compras a inner join db_usuarios b on a.Id_Usuario = b.id inner join db_proveedores c on a.Id_Proveedor = c.id" + condicion;
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(dsVenta, "xVenta");

                Conexion_DB.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar venta para impresion de ticket. " + ex.Message);
            }

            contenedorRPT.LocalReport.ReportEmbeddedResource = "Modulo_Reportes.RDLCReporteCompra.rdlc";

            ReportDataSource rptDataVenta = new ReportDataSource("cdReporteCompra", dsVenta.Tables["xVenta"]);

            contenedorRPT.LocalReport.DataSources.Clear();
            contenedorRPT.LocalReport.DataSources.Add(rptDataVenta);
            this.contenedorRPT.RefreshReport();
        }

        public string FiltroDeBusqueda()
        {
            string condicion = "";
            if (cbxCompra.SelectedIndex == 0)
            {

                condicion = " where a.FechaDeCompra between date('" + dtpDesde.Value.ToString("yyyy/MM/dd") + "') and date('" + dtpHasta.Value.ToString("yyyy/MM/dd") + "')";
            }
            else if (cbxCompra.SelectedIndex == 1)
            {
                condicion = " where a.FacturaNro like '%" + txtFact.Text + "%'";
            }
            else if (cbxCompra.SelectedIndex == 2)
            {
                condicion = " where c.RazonSocial like '%" + txtProv.Text + "%'";
            }


            return condicion;
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.contenedorRPT.RefreshReport();
            string parametro = FiltroDeBusqueda();

            impimirCompra(parametro);

        }

        private void cbxCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCompra.SelectedIndex == 0)
            {
                lblDesde.Visible = true;
                dtpDesde.Visible = true;

                lblHasta.Visible = true;
                dtpHasta.Visible = true;
            }
            else
            {
                lblDesde.Visible = false;
                dtpDesde.Visible = false;

                lblHasta.Visible = false;
                dtpHasta.Visible = false;
            }

            if (cbxCompra.SelectedIndex == 1)
            {
                lblFactura.Visible = true;
                txtFact.Visible = true;
            }
            else
            {
                lblFactura.Visible = false;
                txtFact.Visible = false;
            }

            if (cbxCompra.SelectedIndex == 2)
            {
                lblProveedor.Visible = true;
                txtProv.Visible = true;
            }
            else
            {
                lblProveedor.Visible = false;
                txtProv.Visible = false;
            }

        }

        private void dtpDesde_onValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpHasta_onValueChanged(object sender, EventArgs e)
        {

        }

        private void lblHasta_Click(object sender, EventArgs e)
        {

        }

        private void lblDesde_Click(object sender, EventArgs e)
        {

        }

        private void frmInformeCompra_Load(object sender, EventArgs e)
        {
            this.contenedorRPT.RefreshReport();
        }
    }
}
