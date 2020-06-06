using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloCompra
{
    public partial class FrmMenuCompra : Form
    {
        public FrmMenuCompra()
        {
            InitializeComponent();
        }
        /*VARIABLES GLOBALES*/
        DataSet productoAComprar;
        decimal vSubtotal, vTotalNeto, vTotalIVa, vIva5, vIva10, vIva0;


        private void FrmMenuCompra_Load(object sender, EventArgs e)
        {
            modSesion modSesion = new modSesion();
            modSesion.cargarConfiguraciones();
            iniciarCompra();
            vIva0 = 0;
            vIva10 = 0;
            vIva5 = 0;

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void cargarItem()
        {
            modSesion modSesion = new modSesion();
            int n;
            decimal subtotalProducto;
            grilla.Rows.Add();
            n = grilla.Rows.Count - 1;
            grilla[0, n].Value = n + 1; // items
            grilla[1, n].Value =Convert.ToString(productoAComprar.Tables["rsProducto"].Rows[0]["id"]); // codigo
            grilla[2, n].Value = Convert.ToString(productoAComprar.Tables["rsProducto"].Rows[0]["Descripcion"]); // descripcion
            grilla[3, n].Value = txtCantidad.Text; // cantidad
            grilla[4, n].Value = Convert.ToString(modSesion.mascaraCosto(txtCosto.Text)); // costo
            subtotalProducto = Convert.ToDecimal(modSesion.convertirDecimal(txtCantidad.Text) * modSesion.convertirDecimal(txtCosto.Text)); // calculando subtotal del producto
            grilla[5, n].Value = Convert.ToString(modSesion.mascaraCosto(subtotalProducto)); // subttotal
            grilla[6, n].Value = Convert.ToString(modSesion.mascaraCosto(calcularCostoMedio())); // costo medio
            grilla[7, n].Value = Convert.ToString(productoAComprar.Tables["rsProducto"].Rows[0]["Iva"]); // iva
            grilla[8, n].Value = Convert.ToString(modSesion.mascaraCosto(calcularIva())); // calcula monto iva incluido
            vTotalNeto = Convert.ToDecimal(vTotalNeto + modSesion.convertirDecimal(txtCantidad.Text) * modSesion.convertirDecimal(txtCosto.Text)); // calcula total neto
            vSubtotal = Convert.ToDecimal(vTotalNeto - vTotalIVa); // calcula subtotal que es total neto menos iva incluido
            txtTotalNeto.Text = Convert.ToString(modSesion.mascaraCosto(vTotalNeto));
            txtSubtotal.Text = Convert.ToString(modSesion.mascaraCosto(vSubtotal));
            limpiarItems();
            txtCodigoProducto.Focus();
        }
        /*MODULO CALCULAR COSTO MEDIO*/
        private decimal calcularCostoMedio()
        {
            modSesion modSesion = new modSesion();
            decimal costoMedioActual, stockActual, subtotalActual; // antes de la compra
            decimal costoNuevoCompra, cantidadCompra, subtotalCompra; // subtotal de la compra
            decimal nuevoCostoMedio;

            // se calcula subtotal del item antes de la compra--------------------------------------
            costoMedioActual = Convert.ToDecimal(productoAComprar.Tables["rsProducto"].Rows[0]["costomedio"]); // 33
            stockActual = Convert.ToDecimal(productoAComprar.Tables["rsProducto"].Rows[0]["stock"]); // 10
            subtotalActual = costoMedioActual * stockActual; // 330

            // se calcula subtotal de la compra actual----------------------------------------------
            costoNuevoCompra = Convert.ToDecimal(modSesion.convertirDecimal(txtCosto.Text));
            cantidadCompra = Convert.ToDecimal(modSesion.convertirDecimal(txtCantidad.Text));
            subtotalCompra = costoNuevoCompra * cantidadCompra; // 33 * 20 = 660

            // se calcula costo medio para el producto----------------------------------------------
            if (stockActual > 0)
            {
                nuevoCostoMedio = (subtotalActual + subtotalCompra) / (stockActual + cantidadCompra); // 330 + 660 / 10 + 20 = 990 / 30 = 33
            }
            else
            {
                nuevoCostoMedio = costoNuevoCompra;
            }

            return nuevoCostoMedio;
        }

        /*MODULO CALCULO IVA*/
        private decimal calcularIva()
        {
            modSesion modSesion = new modSesion();
            var montoIva = default(decimal);
            decimal valor;
            int iva;
            iva = Convert.ToInt32(productoAComprar.Tables["rsProducto"].Rows[0]["iva"]);
            valor = Convert.ToInt32(modSesion.convertirDecimal(txtCantidad.Text) * modSesion.convertirDecimal(txtCosto.Text));
            if (iva == 0)
            {
                montoIva = 0;
                vIva0 = vIva0 + valor; // acumulando total iva exenta
            }
            else if (iva == 5)
            {
                montoIva = valor / 21; // calculando importe iva incluido 5%
                vIva5 = vIva5 + montoIva; // acumulando total iva 5%
            }
            else if (iva == 10)
            {
                montoIva = valor / 11; // calculadon importe iva incluido 10%
                vIva10 = vIva10 + montoIva;
            }

            vTotalIVa = vIva5 + vIva10; // sumando total iva solo 5 y 10%
            txtIva0.Text = Convert.ToString(modSesion.mascaraCosto(vIva0));
            txtIva5.Text = Convert.ToString(modSesion.mascaraCosto(vIva5));
            txtIva10.Text = Convert.ToString(modSesion.mascaraCosto(vIva10));
            txtTotalIva.Text = Convert.ToString(modSesion.mascaraCosto(vTotalIVa));
            return montoIva;
        }
        /*LIMPIEZA DE CAMPOS*/
        private void limpiarItems()
        {
            txtCodigoProducto.Text = "";
            txtCantidad.Text = "";
            txtCosto.Text = "";
            txtCostoMedio.Text = "";
            txtCostoReal.Text = "";
            txtStock.Text = "";
            lblCodigo.Text = "";
            lblDescricion.Text = "";
        }



        private void bunifuCustomTextbox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdProveedor_KeyUp(object sender, KeyEventArgs e)
        {
           

            if (e.KeyCode == Keys.F5)
            {
                buscarProveedor();
            }
        }

        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtCodigoProducto.Text != "")
                {
                    buscarProducto();
                    e.Handled = true;
                }
            }
        }
        /*modulo buscar producto*/
        modSesion modSesion;
        public void buscarProducto()
        {
            modProducto modProducto = new modProducto();
            
            productoAComprar = new DataSet();
            string condicion = "";
            if (IsNumeric(txtCodigoProducto.Text) == true)
            {
                condicion = " where id = " + txtCodigoProducto.Text + " or CodigoDeBarra = '" + txtCodigoProducto.Text + "'";
            }
            else
            {
                condicion = " where  CodigoDeBarra = '" + txtCodigoProducto.Text + "'";
            }
                
            productoAComprar = modProducto.cargarProducto(condicion);
            if (Convert.ToInt32(productoAComprar.Tables["rsProducto"].Rows.Count) == 0)
            {
                Interaction.MsgBox("Producto No existente");
                txtCodigoProducto.Focus();
            }
            else
            {
                modSesion= new modSesion();
                lblCodigo.Text = Convert.ToString(productoAComprar.Tables["rsProducto"].Rows[0]["id"]);
                lblDescricion.Text = Convert.ToString(productoAComprar.Tables["rsProducto"].Rows[0]["Descripcion"]);
                string costomedio;
                costomedio = Convert.ToString(productoAComprar.Tables["rsProducto"].Rows[0]["CostoMedio"]);
                txtCosto.Text = Convert.ToString(modSesion.mascaraCosto(costomedio));
                txtCostoMedio.Text = Convert.ToString(modSesion.mascaraCosto(productoAComprar.Tables["rsProducto"].Rows[0]["CostoMedio"]));
                txtCostoReal.Text = Convert.ToString(modSesion.mascaraCosto(productoAComprar.Tables["rsProducto"].Rows[0]["Costo"]));
                txtStock.Text = Convert.ToString(modSesion.mascaraCantidad(productoAComprar.Tables["rsProducto"].Rows[0]["Stock"]));
                txtCantidad.Focus();
            }
        }

        private void txtCodigoProducto_KeyUp(object sender, KeyEventArgs e)
        {
            frmBuscarProducto x = new frmBuscarProducto();

            if ((e.KeyCode == Keys.F6))
            {

                AddOwnedForm(x);
                x.ShowDialog();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            modSesion modSesion = new modSesion();

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (IsNumeric(txtCantidad.Text))
                {
                    txtCantidad.Text = Convert.ToString( modSesion.mascaraCantidad(txtCantidad.Text));
                    txtCosto.Focus();
                    e.Handled = true;
                }
                else
                {
                    MessageBox.Show("Ingrese Cantidad en numeros");
                    txtCantidad.Text = "";
                    txtCantidad.Focus();
                }
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (Information.IsNumeric(txtCosto.Text))
                {
                    cargarItem();
                    e.Handled = true;
                }
                else
                {
                    MessageBox.Show("Ingrese costo en numeros");
                    txtCosto.Text = "";
                    txtCosto.Focus();
                }
            }
        }

        /*MODULO PARA INICIAR LA COMPRA*/
        public void iniciarCompra()
        {
            // verificar compras para generar nuevo o capturar en caso de existir compra pendiente
            DataSet regCompra = new DataSet(); // almacena los registros 
            DataSet regProveedor = new DataSet();
            modCompra modcompra = new modCompra();
            modProveedor modProveedor = new modProveedor();
            modSesion modSesion = new modSesion();
            if (modcompra.verificarCompraPendiente() == "no")
            {
                if (modcompra.generarNuevaCompra() == true)
                {
                    regCompra = modcompra.capturarCompraPendiente();
                }
                 
            }
            else if (modcompra.verificarCompraPendiente() == "si")
            {
                regCompra = modcompra.capturarCompraPendiente();
            }
                

            // se recorrera resultado de la tabla compra
            if (Convert.ToInt32(regCompra.Tables["rsCompra"].Rows.Count) > 0)
            {
                txtCompraID.Text = Convert.ToString(regCompra.Tables["rsCompra"].Rows[0]["Id"]);
                txtIdProveedor.Text = Convert.ToString(regCompra.Tables["rsCompra"].Rows[0]["Id_Proveedor"]).PadLeft(3, '0');
                regProveedor = modProveedor.cargarProveedor(txtIdProveedor.Text); // busca datos del proveedor seleccionado
                if (Convert.ToInt32(regProveedor.Tables["rsProveedor"].Rows.Count) > 0)
                {
                    txtNombreProveedor.Text = Convert.ToString(regProveedor.Tables["rsProveedor"].Rows[0]["RazonSocial"]);
                }
                else
                {
                    txtNombreProveedor.Text = "";
                }

                    txtFactura.Text = Convert.ToString(regCompra.Tables["rsCompra"].Rows[0]["FacturaNro"]);
                    string TipoDeCompra = (Convert.ToString(regCompra.Tables["rsCompra"].Rows[0]["TipoDeCompra"]));

                    txtSubtotal.Text = Convert.ToString(modSesion.mascaraCosto(regCompra.Tables["rsCompra"].Rows[0]["subtotal"]));
                    txtIva0.Text = Convert.ToString(modSesion.mascaraCosto(regCompra.Tables["rsCompra"].Rows[0]["Iva0"]));
                    txtIva5.Text = Convert.ToString(modSesion.mascaraCosto(regCompra.Tables["rsCompra"].Rows[0]["Iva5"]));
                    txtIva10.Text = Convert.ToString(modSesion.mascaraCosto(regCompra.Tables["rsCompra"].Rows[0]["Iva10"]));
                    // total iva calculo
                    decimal totalIva;
                    decimal a, b;
                    a = Convert.ToDecimal(regCompra.Tables["rsCompra"].Rows[0]["Iva5"]);
                    b= Convert.ToDecimal(regCompra.Tables["rsCompra"].Rows[0]["Iva10"]);
                    totalIva = a + b;
                    txtTotalIva.Text = Convert.ToString(modSesion.mascaraCosto(totalIva));
                    txtTotalNeto.Text = Convert.ToString(modSesion.mascaraCosto(regCompra.Tables["rsCompra"].Rows[0]["TotalNeto"]));
                    cbxfecha.Value = Convert.ToDateTime(regCompra.Tables["rsCompra"].Rows[0]["FechaDeCompra"]);

            }
        }

        private void txtIdProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                buscarProveedor();
                e.Handled = true;
            }
        }

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

        /*MODULO BUSCAR PROVEEDOR*/
       
        public void buscarProveedor()
        {
            DataSet resultado = new DataSet();
            modProveedor modProveedor = new modProveedor();
            frmBuscarProveedor frmBuscarProveedor = new frmBuscarProveedor();
            if (IsNumeric(txtIdProveedor.Text) == true)
            {
                resultado = modProveedor.cargarProveedor(txtIdProveedor.Text); // aca nos quedamos, falta crear modulo cargarproveedor
                if (resultado.Tables["rsProveedor"].Rows.Count > 0)
                {
                    txtNombreProveedor.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["RazonSocial"]);
                    txtCodigoProducto.Focus();
                }
                else
                {
                    AddOwnedForm(frmBuscarProveedor);
                    frmBuscarProveedor.ShowDialog();
                }

            }
            else
            {
                AddOwnedForm(frmBuscarProveedor);
                frmBuscarProveedor.ShowDialog();
            }

        }

    }
}
