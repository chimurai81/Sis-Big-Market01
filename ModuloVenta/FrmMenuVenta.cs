using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloVenta
{
    public partial class FrmMenuVenta : Form
    {
        public FrmMenuVenta()
        {
            InitializeComponent();
        }
        DataSet productoAVender;
        DataSet cotizacion;
        decimal vSubtotal, vTotalNeto, vTotalIVa, vIva5, vIva10, vIva0, vTotalCosto;
        decimal cotRs, cotGs, cotUs, cotPa;
        //metodo para validar si los valores son numericos
        private bool IsNumeric(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void buscarCliente()
        {
            DataSet resultado = new DataSet();
            modCliente modCliente = new modCliente();
            frmBuscarCliente frmBuscarCliente = new frmBuscarCliente();
            if (IsNumeric(txtIdCliente.Text) == true)
            {
                resultado = modCliente.cargarCliente(txtIdCliente.Text);
                if (resultado.Tables["rsCliente"].Rows.Count > 0)
                {
                    txtNombreCliente.Text = Convert.ToString(resultado.Tables["rsCliente"].Rows[0]["Nombre"]);
                    txtCodigoProducto.Focus();
                }
                else
                {
                     AddOwnedForm(frmBuscarCliente);
                     frmBuscarCliente.ShowDialog();
                }
            }
            else
            {

                AddOwnedForm(frmBuscarCliente);
                frmBuscarCliente.ShowDialog();
            }
        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                buscarCliente();
                e.Handled = true;
            }
        }

        

        public void iniciarVenta()
        {
            // verificar Ventas para generar nuevo o capturar en caso de existir Venta pendiente
            DataSet regVenta = new DataSet(); // almacena los registros 
            DataSet regCliente = new DataSet();
            moduloVenta moduloVenta = new moduloVenta();
            modCliente modCliente = new modCliente();
            modSesion modSesion = new modSesion();
            if (moduloVenta.verificarVentaPendiente() == "no")
            {
                if (moduloVenta.generarNuevaVenta() == true)
                {
                    regVenta = moduloVenta.capturarVentaPendiente();
                }
            }
            else if (moduloVenta.verificarVentaPendiente() == "si")
            {
                regVenta = moduloVenta.capturarVentaPendiente();
            }

            // se recorrera resultado de la tabla Venta
            if (regVenta.Tables["rsVenta"].Rows.Count > 0)
            {
                txtVentaID.Text = Convert.ToString(regVenta.Tables["rsVenta"].Rows[0]["id"]);
                txtIdCliente.Text = Convert.ToString(regVenta.Tables["rsVenta"].Rows[0]["id_Cliente"]);
                regCliente = modCliente.cargarCliente(txtIdCliente.Text); // busca datos del Cliente seleccionado
                if (regCliente.Tables["rsCliente"].Rows.Count > 0)
                {
                    txtNombreCliente.Text = Convert.ToString(regCliente.Tables["rsCliente"].Rows[0]["Nombre"]);
                }
                else
                {
                    txtNombreCliente.Text = "";
                }

                txtFactura.Text = Convert.ToString(regVenta.Tables["rsVenta"].Rows[0]["FacturaNro"]);
                //cbxCondicion.SelectedItem = regVenta.Tables("rsVenta").Rows(0).Item("tipo_Venta");
                txtSubtotal.Text = Convert.ToString(modSesion.mascaraPrecio(regVenta.Tables["rsVenta"].Rows[0]["subtotal"]));
                txtIva0.Text = Convert.ToString(regVenta.Tables["rsVenta"].Rows[0]["iva0"]);
                txtIva5.Text = Convert.ToString(modSesion.mascaraPrecio(regVenta.Tables["rsVenta"].Rows[0]["iva5"]));
                txtIva10.Text = Convert.ToString(modSesion.mascaraPrecio(regVenta.Tables["rsVenta"].Rows[0]["iva10"]));
                // total iva calculo
                decimal totalIva;
                totalIva = Convert.ToDecimal(regVenta.Tables["rsVenta"].Rows[0]["iva5"]) + Convert.ToDecimal(regVenta.Tables["rsVenta"].Rows[0]["iva10"]);
                txtTotalIva.Text = Convert.ToString(modSesion.mascaraPrecio(totalIva));
                txtTotalNeto.Text = Convert.ToString(modSesion.mascaraPrecio(regVenta.Tables["rsVenta"].Rows[0]["totalneto"]));
                cbxfecha.Value = Convert.ToDateTime(regVenta.Tables["rsVenta"].Rows[0]["FechaDeVenta"]);
            }
        }

        private void FrmMenuVenta_Load(object sender, EventArgs e)
        {
            modSesion modSesion = new modSesion();
            modCotizacion modCotizacion = new modCotizacion();
            modSesion.cargarConfiguraciones(); // carga las configuriones del sistema, la cantidad de decimal, las mascaras
            iniciarVenta(); // inicia el proceso de Ventas
            cotizacion = modCotizacion.cargarCotizacion();
            // se inicializa las cotizaciones capturada desde la base de datos
            cotUs = Convert.ToDecimal(cotizacion.Tables["rsCotizacion"].Rows[0]["US"]);
            cotGs = Convert.ToDecimal(cotizacion.Tables["rsCotizacion"].Rows[0]["GS"]);
            cotRs = Convert.ToDecimal(cotizacion.Tables["rsCotizacion"].Rows[0]["RS"]);
            cotPa = Convert.ToDecimal(cotizacion.Tables["rsCotizacion"].Rows[0]["PS"]);
            vIva0 = 0;
            vIva10 = 0;
            vIva5 = 0;
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
