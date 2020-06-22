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

        private void txtCodigoProducto_KeyUp(object sender, KeyEventArgs e)
        {
            frmBuscarProducto x = new frmBuscarProducto();

            if ((e.KeyCode == Keys.F6))
            {
                AddOwnedForm(x);
                x.ShowDialog();
            }
        }

        private void txtCodigoProducto_Leave(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text != "")
            {
                buscarProducto();
            }
        }
        // metodo para txtcantidad  por que uso en el evento keypress y en el leave
        public void cantidadDobleUso()
        {
            if (IsNumeric(txtCantidad.Text))
            {
                modSesion modSesion = new modSesion();
                modUsuario modUsuario = new modUsuario();
                DataSet resultado2 = modUsuario.ControlDeAcceso(); 
                // se verifica si usuario puede vender stock insuficiente
                if (Convert.ToString(resultado2.Tables["rsUsuario"].Rows[0]["StockInsuficiente"]) == "si")
                {
                    txtCantidad.Text = Convert.ToString(modSesion.mascaraCantidad(txtCantidad.Text));
                    txtPrecio.Focus();
                }
                // si usuario no puede vender stock insuficiente verifica stock
                else if (modSesion.convertirDecimal(txtStock.Text) >= modSesion.convertirDecimal(txtCantidad.Text))
                {
                    txtCantidad.Text = Convert.ToString(modSesion.mascaraCantidad(txtCantidad.Text));
                    txtPrecio.Focus();
                }
                else
                {
                    MessageBox.Show("Stock Insuficiente");
                }
            }
            else
            {
                MessageBox.Show("Ingrese Cantidad en numeros");
                txtCantidad.Text = "";
                txtCantidad.Focus();
            }
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == (char)Keys.Enter)
            {
                cantidadDobleUso();
                e.Handled = true;
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            cantidadDobleUso();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            modUsuario modUsuario = new modUsuario();
            DataSet resultado2 = modUsuario.ControlDeAcceso();
            modSesion modSesion = new modSesion();
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (IsNumeric(txtPrecio.Text))
                {
                   
                    if (Convert.ToString(resultado2.Tables["rsUsuario"].Rows[0]["venderHasta"]) == "bajoCosto") // verificando permiso si usuario puede vender hasta cero----------------------------------------
                    {
                        cargarItem();
                        e.Handled = true;
                    }
                    else if (Convert.ToString(resultado2.Tables["rsUsuario"].Rows[0]["venderHasta"]) == "costo") // verificando permiso si usuario puede vender hasta costo---------------------------------------
                    {
                        if (Convert.ToDecimal(modSesion.convertirDecimal(txtPrecio.Text)) >= Convert.ToDecimal(productoAVender.Tables["rsProducto"].Rows[0]["costomedio"]))
                        {
                            cargarItem();
                            e.Handled = true;
                        }
                        else
                        {
                            MessageBox.Show("Precio fuera de limite, Precio es menor que costo ");
                        }
                    }
                    else if (Convert.ToString(resultado2.Tables["rsUsuario"].Rows[0]["venderHasta"]) == "precioMay") // verificando permiso si usuario puede vender hasta costo-------------------------------------
                    {
                        if (Convert.ToDecimal(modSesion.convertirDecimal(txtPrecio.Text)) >= Convert.ToDecimal(productoAVender.Tables["rsProducto"].Rows[0]["precioMayorista"]))
                        {
                            cargarItem();
                            e.Handled = true;
                        }
                        else
                        {
                            MessageBox.Show("Precio fuera de limite, Precio es menor que Precio Mayorista ");
                        }
                    }
                    else if (Convert.ToString(resultado2.Tables["rsUsuario"].Rows[0]["venderHasta"]) == "precioUni") // verificando permiso si usuario puede vender hasta costo
                    {
                        if (Convert.ToDecimal(modSesion.convertirDecimal(txtPrecio.Text)) >= Convert.ToDecimal(productoAVender.Tables["rsProducto"].Rows[0]["PrecioUnitario"]))
                        {
                            cargarItem();
                            e.Handled = true;
                        }
                        else
                        {
                            MessageBox.Show("Precio fuera de limite, Precio es menor que Precio Unitario ");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese costo en numeros");
                    txtPrecio.Text = "";
                    txtPrecio.Focus();
                }
            }
        }
        //metodo para cargar en la grilla
        private void cargarItem()
        {
            modSesion modSesion = new modSesion();
            int n;
            decimal subtotalProducto;
            grilla.Rows.Add();
            n = grilla.Rows.Count - 1;
            grilla[0, n].Value = n + 1; // items
            grilla[1, n].Value = productoAVender.Tables["rsProducto"].Rows[0]["id"]; // codigo
            grilla[2, n].Value = productoAVender.Tables["rsProducto"].Rows[0]["descripcion"]; // descripcion
            grilla[3, n].Value = txtCantidad.Text; // cantidad
            grilla[4, n].Value = modSesion.mascaraPrecio(txtPrecio.Text); // costo
            subtotalProducto = modSesion.convertirDecimal(txtCantidad.Text) * modSesion.convertirDecimal(txtPrecio.Text); // calculando subtotal del producto
            grilla[5, n].Value = modSesion.mascaraPrecio(subtotalProducto); // subttotal
            grilla[6, n].Value = productoAVender.Tables["rsProducto"].Rows[0]["iva"]; // iva
            grilla[7, n].Value = modSesion.mascaraPrecio(calcularIva()); // calcula monto iva incluido
            grilla[8, n].Value = modSesion.mascaraPrecio(productoAVender.Tables["rsProducto"].Rows[0]["costomedio"]); // costo medio del producto
            vTotalCosto = vTotalCosto + Convert.ToDecimal(productoAVender.Tables["rsProducto"].Rows[0]["costomedio"]) * modSesion.convertirDecimal(txtCantidad.Text);
            vTotalNeto = vTotalNeto + modSesion.convertirDecimal(txtCantidad.Text) * modSesion.convertirDecimal(txtPrecio.Text); // calcula total neto IVA INCLUIDO  
            vSubtotal = vTotalNeto - vTotalIVa; // calcula subtotal que es total neto menos iva incluido
            txttotalNetoGrande.Text = Convert.ToString(modSesion.mascaraPrecio(vTotalNeto));
            txtTotalNeto.Text = Convert.ToString(modSesion.mascaraPrecio(vTotalNeto));
            txtSubtotal.Text = Convert.ToString(modSesion.mascaraPrecio(vSubtotal));
            actualiarTotalMonedas(vTotalNeto); // se envia total neto para convertir en monedas
            limpiarItems();
            txtCodigoProducto.Focus();
        }
        //limpiar campos 
        private void limpiarItems()
        {
            txtCodigoProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtPrecioMay.Text = "";
            txtPrecioUnit.Text = "";
            txtStock.Text = "";
            lblCodigo.Text = "";
            lblDescricion.Text = "";
        }

        // <metodo-CalculoIva>
        private decimal calcularIva()
        {
            modSesion modSesion = new modSesion();
            var montoIva = default(decimal);
            decimal valor;
            int iva;
            iva = Convert.ToInt32(productoAVender.Tables["rsProducto"].Rows[0]["iva"]);
            valor = modSesion.convertirDecimal(txtCantidad.Text) * modSesion.convertirDecimal(txtPrecio.Text);
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
                montoIva = valor / 11; // calculando importe iva incluido 5%        
                vIva10 = vIva10 + montoIva;
            }

            vTotalIVa = vIva5 + vIva10; // sumando total iva solo 5 y 10%
            txtIva0.Text = Convert.ToString(modSesion.mascaraPrecio(vIva0));
            txtIva5.Text = Convert.ToString(modSesion.mascaraPrecio(vIva5));
            txtIva10.Text = Convert.ToString(modSesion.mascaraPrecio(vIva10));
            txtTotalIva.Text = Convert.ToString(modSesion.mascaraPrecio(vTotalIVa));
            return montoIva;
        }

        /// <procesar_la_compra>
        public bool procesarVenta()
        {
            MySqlCommand comando;
            MySqlTransaction transaccion;
            string sqlVenta;
            string sqlVentaItems;
            modSesion modSesion = new modSesion();
            modUsuario modUsuario = new modUsuario();
            Conexion_DB.AbrirConexion(); // se abre una conexion con la base de datos
            MySqlConnection con = Conexion_DB.conexion;
            transaccion = con.BeginTransaction();  // se inicia una transaccion con la base de datos, acontinuacion se inicia procesos multiples
            try
            {
                // se inicia proceso 1 :  actualizar tabla Venta
                sqlVenta = "update db_ventas set FacturaNro=@fac, Id_Cliente=@cli, TipoDeVenta=@tipo ,FechaDeVenta=@fecha ,SubTotal=@sub ,Iva0=@iva0 ,Iva5=@iva5 ,Iva10=@iva10 ,TotalNeto=@total, TotalPago=0,TotalDescuento=0 ,TotalSaldo=@ttlsaldo,Id_Usuario=@user,estado=@Estado, TotalCosto=@ttlcosto where id=@id";
                comando = new MySqlCommand(sqlVenta, con);

                comando.Parameters.AddWithValue("@fac", txtFactura.Text);
                comando.Parameters.AddWithValue("@cli", txtIdCliente.Text);
                if(cbxCondicion.selectedValue == "")
                {
                    MessageBox.Show("Contado o credito?");
                }
                comando.Parameters.AddWithValue("@tipo", cbxCondicion.selectedValue.ToString());
                comando.Parameters.AddWithValue("@fecha", cbxfecha.Value);
                comando.Parameters.AddWithValue("@sub", modSesion.convertirDecimal(txtSubtotal.Text));
                comando.Parameters.AddWithValue("@iva0", modSesion.convertirDecimal(txtIva0.Text));
                comando.Parameters.AddWithValue("@iva5", modSesion.convertirDecimal(txtIva5.Text));
                comando.Parameters.AddWithValue("@iva10", modSesion.convertirDecimal(txtIva10.Text));
                comando.Parameters.AddWithValue("@total", modSesion.convertirDecimal(txtTotalNeto.Text));
                comando.Parameters.AddWithValue("@ttlsaldo", modSesion.convertirDecimal(txtTotalNeto.Text));
                int usr = Convert.ToInt32(modUsuario.VerificarIdUsuarioActivo());
                comando.Parameters.AddWithValue("@user",usr);
                comando.Parameters.AddWithValue("@estado", 1);
                comando.Parameters.AddWithValue("@ttlcosto", vTotalCosto);
                comando.Parameters.AddWithValue("@id", Convert.ToInt32(txtVentaID.Text));
                comando.ExecuteNonQuery();

                // inicia proceso 2 :  insertar registros en tabla Venta_items
                int c;
                c = 0;
                while (c < grilla.Rows.Count)
                {
                    sqlVentaItems = "insert into db_ventaitems(Id_Ventas,Id_Producto,CostoMedio,Precio,Cantidad,Iva,Estado)values(@idcom,@idprod,@costomedio,@precio,@cantidad,@iva,@estado) ";
                    comando = new MySqlCommand(sqlVentaItems, con);
                    comando.Parameters.AddWithValue("@idcom", txtVentaID.Text);
                    int idprocut1 = Convert.ToInt32(grilla[1, c].Value);
                    comando.Parameters.AddWithValue("@idprod", idprocut1);
                    comando.Parameters.AddWithValue("@costomedio", modSesion.convertirDecimal(grilla[8, c].Value));
                    comando.Parameters.AddWithValue("@precio", modSesion.convertirDecimal(grilla[4, c].Value));
                    comando.Parameters.AddWithValue("@cantidad", modSesion.convertirDecimal(grilla[3, c].Value));
                    comando.Parameters.AddWithValue("@iva", Convert.ToInt32(grilla[6, c].Value));
                    comando.Parameters.AddWithValue("@estado", 1);
                    comando.ExecuteNonQuery();
                    c = c + 1;
                }


                // finaliza transaccion y aplica cambios en todas las tablas 
                transaccion.Commit();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al procesar Venta, No se efectuaron cambios " + ex.Message);
                transaccion.Rollback();
                return false;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (procesarVenta() == true)
            {
                MessageBox.Show("venta procesada con exito");
                limpiarVenta();
                iniciarVenta();
                txtFactura.Focus();
            }
            else
            {
                MessageBox.Show("error al processar venta");
            }
        }
        //limpiar campo despues de la venta
        private void limpiarVenta()
        {
            // limpiando caja de textos-------------------
            txtCodigoProducto.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtPrecioMay.Text = "";
            txtPrecioUnit.Text = "";
            txtStock.Text = "";
            lblCodigo.Text = "";
            lblDescricion.Text = "";
            txtTotalIva.Text = "";
            txtSubtotal.Text = "";
            txtTotalNeto.Text = "";
            txtIva0.Text = "";
            txtIva5.Text = "";
            txtIva10.Text = "";
            txtVentaID.Text = "";
            txtFactura.Text = "";
            txtIdCliente.Text = "";
            txtNombreCliente.Text = "";
            txttotalNetoGrande.Text = "";
            txtTotalGs.Text = "";
            txtTotalPa.Text = "";
            txtTotalRs.Text = "";
            txtTotalUs.Text = "";
            //cbxCondicion.selectedValue.ToString();
            grilla.Rows.Clear();



            // limpiando variables globales-------------
            vSubtotal = 0;
            vTotalNeto = 0;
            vTotalIVa = 0;
            vIva5 = 0;
            vIva10 = 0;
            vIva0 = 0;
            vTotalCosto = 0;
            productoAVender = new DataSet();
            txtIdCliente.Focus();
        }

        //inicio metodo actualizar tablas con el total de monedas
        private void actualiarTotalMonedas(decimal valor)
        {
            modSesion modSesion = new modSesion();
            decimal totalRs, totalGs, totalUs, totalPa;
            if (modSesion.config_moneda == "GS")
            {
                // se convierte el valor total en las monedas correspondiente usando la cotizacion capturada
                totalUs = valor / cotUs;
                totalGs = valor;
                totalRs = valor / cotRs;
                totalPa = valor / cotPa;
                // se carga resultado en las cajas de texto

                txtTotalGs.Text = Convert.ToString(modSesion.mascaraCotizacionGuaranies(totalGs));
                txtTotalUs.Text = Convert.ToString(modSesion.mascaraCotizacion(totalUs));
                txtTotalRs.Text = Convert.ToString(modSesion.mascaraCotizacion(totalRs));
                txtTotalPa.Text = Convert.ToString(modSesion.mascaraCotizacion(totalPa));
            }

            if (modSesion.config_moneda == "US")
            {
                // se convierte el valor total en las monedas correspondiente usando la cotizacion capturada
                totalUs = valor;
                totalGs = valor * cotGs;
                totalRs = valor * cotRs;
                totalPa = valor * cotPa;
                // se carga resultado en las cajas de texto

                txtTotalGs.Text = Convert.ToString(modSesion.mascaraCotizacionGuaranies(totalGs));
                txtTotalUs.Text = Convert.ToString(modSesion.mascaraCotizacion(totalUs));
                txtTotalRs.Text = Convert.ToString(modSesion.mascaraCotizacion(totalRs));
                txtTotalPa.Text = Convert.ToString(modSesion.mascaraCotizacion(totalPa));
            }
        }
        public void buscarProducto()
        {
            modProducto modProducto = new modProducto();
            modSesion modSesion = new modSesion();
            string condicion = "";
            if (IsNumeric(txtCodigoProducto.Text) == true)
            {
                condicion = " where id = " + txtCodigoProducto.Text + " or CodigoDeBarra = '" + txtCodigoProducto.Text + "'";
            }
            else
            {
                condicion = " where  CodigoDeBarra = '" + txtCodigoProducto.Text + "'";
            }

            productoAVender = new DataSet();
            productoAVender = modProducto.cargarProducto(condicion);
            if (productoAVender.Tables["rsProducto"].Rows.Count == 0)
            {
                MessageBox.Show("Producto No existente");
                txtFactura.Focus();
            }
            else
            {
                lblCodigo.Text = Convert.ToString(productoAVender.Tables["rsProducto"].Rows[0]["id"]);
                lblDescricion.Text = Convert.ToString(productoAVender.Tables["rsProducto"].Rows[0]["Descripcion"]);
                txtPrecio.Text = Convert.ToString(modSesion.mascaraPrecio(productoAVender.Tables["rsProducto"].Rows[0]["PrecioUnitario"]));
                txtPrecioMay.Text = Convert.ToString(modSesion.mascaraPrecio(productoAVender.Tables["rsProducto"].Rows[0]["PrecioMayorista"]));
                txtPrecioUnit.Text = Convert.ToString(modSesion.mascaraPrecio(productoAVender.Tables["rsProducto"].Rows[0]["PrecioUnitario"]));
                txtStock.Text = Convert.ToString(modSesion.mascaraCantidad(productoAVender.Tables["rsProducto"].Rows[0]["Stock"]));
                txtCantidad.Focus();
            }
        }

        private void txtIdCliente_KeyUp(object sender, KeyEventArgs e)
        {
            frmBuscarCliente frmBuscarCliente = new frmBuscarCliente();
            if (e.KeyCode == Keys.F5)
            {
                AddOwnedForm(frmBuscarCliente);
                frmBuscarCliente.ShowDialog();
            }
        }

        private void txtIdCliente_Leave(object sender, EventArgs e)
        {
            buscarCliente();
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
            txtFactura.Focus();
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
