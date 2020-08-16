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
    public partial class frmInformecotizacion : Form
    {
        public frmInformecotizacion()
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
                sql = "select a.Fecha, b.Nombre, a.Gs, a.Us, a.RS, a.PS, a.TJ, a.CR from db_cotizacion a inner join db_usuarios b on Id_Usuario = a.id " + condicion;
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(dsVenta, "xVenta");

                Conexion_DB.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar venta para impresion de ticket. " + ex.Message);
            }

            contenedorRPT.LocalReport.ReportEmbeddedResource = "Modulo_Reportes.RDLCReporteCotizacion.rdlc";

            ReportDataSource rptDataVenta = new ReportDataSource("cdReporteCotizacion", dsVenta.Tables["xVenta"]);

            contenedorRPT.LocalReport.DataSources.Clear();
            contenedorRPT.LocalReport.DataSources.Add(rptDataVenta);
            this.contenedorRPT.RefreshReport();
        }
        public string FiltroDeBusqueda()
        {
            string condicion = "";

                condicion = " where a.Fecha between date('" + dtpDesde.Value.ToString("yyyy/MM/dd") + "') and date('" + dtpHasta.Value.ToString("yyyy/MM/dd") + "')";
            return condicion;
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.contenedorRPT.RefreshReport();
            string parametro = FiltroDeBusqueda();

            impimirCompra(parametro);

        }
    }
}
