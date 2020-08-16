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
    public partial class frmInformeStock : Form
    {
        public frmInformeStock()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
                sql = "select a.Descripcion, a.Costo, a.PrecioUnitario, Stock from db_productos a" + condicion;
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(dsVenta, "xVenta");

                Conexion_DB.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar venta para impresion de ticket. " + ex.Message);
            }

            contenedorRPT.LocalReport.ReportEmbeddedResource = "Modulo_Reportes.RDLCReporteStock.rdlc";

            ReportDataSource rptDataVenta = new ReportDataSource("cdReporteStock", dsVenta.Tables["xVenta"]);

            contenedorRPT.LocalReport.DataSources.Clear();
            contenedorRPT.LocalReport.DataSources.Add(rptDataVenta);
            this.contenedorRPT.RefreshReport();
        }


        public string FiltroDeBusqueda()
        {
            string condicion = "";
            if (comboBox1.SelectedIndex == 0)
            {
                condicion = " where stock <= 0";
            }else if (comboBox1.SelectedIndex == 1)
            {
                condicion = " where stock <= "+ txtNombreCliente.Text + "" ;
            }
            return condicion;
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            /* */
            this.contenedorRPT.RefreshReport();
            string parametro = FiltroDeBusqueda();

            impimirCompra(parametro);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                lblStock.Visible = true;
                txtNombreCliente.Visible = true;
            }
            else
            {
                lblStock.Visible = false;
                txtNombreCliente.Visible = false;
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void frmInformeStock_Load(object sender, EventArgs e)
        {
            this.contenedorRPT.RefreshReport();
        }
    }
}
