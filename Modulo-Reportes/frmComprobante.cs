using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Modulo_Reportes
{
    public partial class frmComprobante : Form
    {
        public string idOperacion;
        public frmComprobante(string id)
        {
            InitializeComponent();
            idOperacion = id;
        }

        private void frmComprobante_Load(object sender, EventArgs e)
        {
            this.contenedorRPT.RefreshReport();
            modSesion modSesion = new modSesion();
            modSesion.cargarConfiguraciones();

            imprimirVenta(idOperacion);



        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        public void imprimirVenta(string idVenta)
        {
            string sql;
            DataSet dsVenta = new DataSet();
            DataSet dsVentaItems = new DataSet();
            MySqlDataAdapter consulta;
            modSesion modSesion = new modSesion();
            try
            {
                Conexion_DB.AbrirConexion();
                string Decimalprecio = Convert.ToString(modSesion.dec_precio);
                string decimalcantidad = Convert.ToString(modSesion.dec_cantidad);

                // consulta  para capturar venta con detalles del cliente---------------------------------------------------------------------
                sql = "select a.id, a.FacturaNro, b.Nombre as 'Cliente', b.RUC, c.Nombre as 'Caja', a.FechaDeVenta as 'Fecha', round(a.SubTotal,0) as subtotal,round(a.Iva0,0) as Iva0, round(a.Iva5,0) as Iva5, round(a.Iva10,0) as Iva10, round(a.totalneto,0) as totalneto, round((Iva5 + Iva10),0) as total_iva from db_ventas a inner join db_clientes b on Id_cliente = b.id_Clientes inner join db_Usuarios c on id_Usuario = c.id where a.id ="+ idVenta +"";  
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(dsVenta, "xVenta");
                //------------------------------------------

                sql= "SELECT  a.id_Producto, b.Descripcion, round(a.Cantidad," + decimalcantidad + ")as cantidad, round(a.Precio," + Decimalprecio + ")as precio, a.Iva,round(if (a.Iva = 0,a.Cantidad* a.Precio,0),"+ Decimalprecio + ") as iva0, round(if (a.Iva = 5,(a.Cantidad * a.Precio), 0)," + Decimalprecio + ") as iva5, round(if (a.Iva = 10,(a.Cantidad * a.Precio), 0), " + Decimalprecio + ") as iva10,round((a.Cantidad * a.Precio), " + Decimalprecio + ") as subtotal, a.id_Ventas from  db_ventaitems a inner join db_productos b on a.id_producto = b.id where a.id_Ventas =" + idVenta + "";
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(dsVenta, "xVentaItems");

                Conexion_DB.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar venta para impresion de ticket. " + ex.Message);
            }

            contenedorRPT.LocalReport.ReportEmbeddedResource = "Modulo_Reportes.DiseñoComprobante.rdlc";
            
            ReportDataSource rptDataVenta = new ReportDataSource("cdVentas", dsVenta.Tables["xVenta"]);
            ReportDataSource rptDataVentaItems = new ReportDataSource("cdVentaItems", dsVenta.Tables["xVentaItems"]);

            contenedorRPT.LocalReport.DataSources.Clear();
            contenedorRPT.LocalReport.DataSources.Add(rptDataVenta);
            contenedorRPT.LocalReport.DataSources.Add(rptDataVentaItems);
            this.contenedorRPT.RefreshReport();


        }

    }
}
