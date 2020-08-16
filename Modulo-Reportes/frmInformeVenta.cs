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
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace Modulo_Reportes
{
    public partial class frmInformeVenta : Form
    {
        public frmInformeVenta()
        {
            InitializeComponent();
        }

        private void frmInformeVenta_Load(object sender, EventArgs e)
        {
            this.contenedorRPT.RefreshReport();
            cbxVenta.SelectedIndex = 4;
  
        }
       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void imprimirVenta(string condicion)
        {
            this.contenedorRPT.RefreshReport();
            string sql;
            DataSet dsVenta = new DataSet();
            MySqlDataAdapter consulta;
            try
            {
                Conexion_DB.AbrirConexion();
                sql = "select a.id, a.facturaNro, a.FechaDeVenta, b.Nombre, a.TotalCosto, a.TotalNeto,(a.TotalNeto - a.TotalCosto) as 'Ganancia',a.TipoDeVenta, a.TotalSaldo, c.Nombre as 'Cajero' from db_ventas a inner join db_clientes b on a.Id_cliente = b.id_Clientes inner join db_usuarios c on a.Id_Usuario = c.id" + condicion;
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(dsVenta, "xVenta");

                Conexion_DB.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar venta para impresion de ticket. " + ex.Message);
            }

            contenedorRPT.LocalReport.ReportEmbeddedResource = "Modulo_Reportes.RDLCReporteVenta.rdlc";

            ReportDataSource rptDataVenta = new ReportDataSource("cdReporteVenta", dsVenta.Tables["xVenta"]);

            contenedorRPT.LocalReport.DataSources.Clear();
            contenedorRPT.LocalReport.DataSources.Add(rptDataVenta);
            this.contenedorRPT.RefreshReport();


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string FiltroDeBusqueda()
        {
            string condicion = "";
            if(cbxVenta.SelectedIndex == 0)
            {
                condicion = " where a.FechaDeVenta between date('"+dtpDesde.Value.ToString("yyyy/MM/dd")+"') and date('"+ dtpHasta.Value.ToString("yyyy/MM/dd") + "')";

            }else if (cbxVenta.SelectedIndex == 2)
            {
                condicion = " where b.Nombre like '%" + txtCliente.Text + "%'";
            }
            else if (cbxVenta.SelectedIndex == 3)
            {
                condicion = " where c.Nombre like '%" + txtUsuario.Text + "%'";
            }
            else if (cbxVenta.SelectedIndex == 4)
            {
                condicion = "";
            }


            if (checkContado.Checked)
            {
                condicion = " where a.TipoDeVenta = 'Contado'";
            }else if (checkCredito.Checked)
            {
                condicion = " where a.TipoDeVenta = 'Credito'";
            }

            return condicion;
        } 

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            this.contenedorRPT.RefreshReport();
            string parametro = FiltroDeBusqueda();

            imprimirVenta(parametro);


        }

        private void contenedorRPT_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
         ;
        }

        private void cbxVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxVenta.SelectedIndex == 0)
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

            if (cbxVenta.SelectedIndex == 1)
            {
                checkContado.Visible = true;
                checkCredito.Visible = true;
                checkAmbos.Visible = true;
            }
            else
            {
                checkContado.Visible = false;
                checkCredito.Visible = false;
                checkAmbos.Visible = false;
            }
            if (cbxVenta.SelectedIndex == 2)
            {
                lblCliente.Visible = true;
                txtCliente.Visible = true;
            }
            else
            {
                lblCliente.Visible = false;
                txtCliente.Visible = false;
            }
            if (cbxVenta.SelectedIndex == 3)
            {
                lblUsuario.Visible = true;
                txtUsuario.Visible = true;
            }
            else
            {
                lblUsuario.Visible = false;
                txtUsuario.Visible = false;
            }
        }
    }
}
