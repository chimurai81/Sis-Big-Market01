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
    public partial class frmInformeCliente : Form
    {
        public frmInformeCliente()
        {
            InitializeComponent();
        }

        private void frmInformeCliente_Load(object sender, EventArgs e)
        {
            this.contenedorRPT.RefreshReport();
            cbxCompra.SelectedIndex = 1;
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
                sql = "select b.Nombre, b.Apellido, b.NroTelef, a.TotalNeto, a.FechaDeVenta from db_ventas a inner join db_clientes b on Id_Cliente = b.id_Clientes" + condicion;
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(dsVenta, "xVenta");

                Conexion_DB.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar venta para impresion de ticket. " + ex.Message);
            }

            contenedorRPT.LocalReport.ReportEmbeddedResource = "Modulo_Reportes.RDLCReporteCliente.rdlc";

            ReportDataSource rptDataVenta = new ReportDataSource("cdReporteCliente", dsVenta.Tables["xVenta"]);

            contenedorRPT.LocalReport.DataSources.Clear();
            contenedorRPT.LocalReport.DataSources.Add(rptDataVenta);
            this.contenedorRPT.RefreshReport();
        }
        public string FiltroDeBusqueda()
        {
            string condicion = "";
            if (cbxCompra.SelectedIndex == 0)
            {
                condicion = " where a.FechaDeVenta between date('" + dtpDesde.Value.ToString("yyyy/MM/dd") + "') and date('" + dtpHasta.Value.ToString("yyyy/MM/dd") + "')";
            }
            else if (cbxCompra.SelectedIndex == 1)
            {
                condicion = " where b.Nombre like '%" + txtNombreCliente.Text + "%'";
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
                lblCliente.Visible = true;
                txtNombreCliente.Visible = true;
            }
            else
            {
                lblCliente.Visible = false;
                txtNombreCliente.Visible = false;
            }
        }
    }
}
