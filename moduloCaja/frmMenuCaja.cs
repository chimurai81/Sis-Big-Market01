using MensajesPersonalizados;
using Microsoft.VisualBasic;
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

namespace moduloCaja
{
    public partial class frmMenuCaja : Form
    {
        DataSet dsCotizacion = new DataSet();
        DataSet dsVentaPendiente = new DataSet();
        decimal cotGs, cotRs, cotPs, cotCr, cotUs;
        decimal pagoGs, pagoRs, pagoPs, pagoCr, pagoUs;
        decimal vueltoGs, vueltoRs, vueltoPs, vueltoCr, vueltoUs;

        decimal totalPrincipal, pagoPrincipal, saldoPrincipal, descuentoPrincipal;
        /******COBRO EN DOLARES************/

        private void cobrarDolaresCaja()
        {
            modSesion modSesion = new modSesion();
            if (txtpagous.Text != "")
            {
                try
                {
                    decimal pago;
                    pago = modSesion.convertirDecimal(txtpagous.Text); // se convierte a decimal valor de la caja de texto
                    saldoPrincipal = saldoPrincipal + pagoUs;    // suma pagoUs al saldoPrincipal antes de aplicar nuevo pago en Us
                    if (modSesion.config_moneda == "US")
                    {
                        pagoUs = pago * cotUs;                       // se convierte nuevo monto a pagar en la moneda principal del sistema 
                    }
                    else if (modSesion.config_moneda == "GS")
                    {
                        pagoUs = pago * cotUs;                       // se convierte nuevo monto a pagar en la moneda principal del sistema  
                    }

                    saldoPrincipal = saldoPrincipal - pagoUs;    // se resta pagoUs  al saldo principal del sistema
                    txtpagous.Text = Convert.ToString(modSesion.mascaraCotizacion(pago));        // se aplica mascara a la caja de texto
                    mostrarSaldoCobrar();                   // se recalcula saldoPrincipal en las distintas monedas 
                }
                catch (Exception ex)
                {
                    // se limpia caja de texto en caso de ingresar letras en el pago
                    MessageBox.Show(ex.Message);
                    txtpagous.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
                    txtpagous.Focus();
                }
            }
            else
            {
                // se aplica mascara en caso de que se quede vacio el pago
                txtpagous.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
            }
        }

        private void txtpagous_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter & Information.IsNumeric(txtpagous.Text) == true)
            {
                cobrarDolaresCaja();
                e.Handled = true;
            }
        }

        private void txtpagous_Leave(object sender, EventArgs e)
        {
            cobrarDolaresCaja();
        }
        /***************PAGO EN REALES**************************/
        private void CobrarRsCaja()
        {
            modSesion modSesion = new modSesion();
            if (txtpagors.Text != "")
            {
                try
                {
                    decimal pago;
                    pago = modSesion.convertirDecimal(txtpagors.Text);         // se convierte a decimal valor de la caja de texto
                    saldoPrincipal = saldoPrincipal + pagoRs;        // suma pagoRs al saldoPrincipal antes de aplicar nuevo pago en Rs
                    if (modSesion.config_moneda == "US")
                    {
                        pagoRs = pago / cotRs;                       // se convierte nuevo monto a pagar en la moneda principal del sistema  
                    }
                    else if (modSesion.config_moneda == "GS")
                    {
                        pagoRs = pago * cotRs;                       // se convierte nuevo monto a pagar en la moneda principal del sistema  
                    }

                    saldoPrincipal = saldoPrincipal - pagoRs;    // se resta pagoRs  al saldo principal del sistema
                    txtpagors.Text = Convert.ToString(modSesion.mascaraCotizacion(pago));        // se aplica mascara a la caja de texto
                    mostrarSaldoCobrar();                   // se recalcula saldoPrincipal en las distintas monedas 
                }
                catch (Exception ex)
                {
                    // se limpia caja de texto en caso de ingresar letras en el pago
                    MessageBox.Show(ex.Message);
                    txtpagors.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
                    txtpagors.Focus();
                }
            }
            else
            {
                // se aplica mascara en caso de que se quede vacio el pago
                txtpagors.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
            }
        }

        private void txtpagors_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter & Information.IsNumeric(txtpagors.Text) == true)
            {
                CobrarRsCaja();
                txtpagops.Focus();
                e.Handled = true;
            }
        }

        private void txtpagors_Leave(object sender, EventArgs e)
        {
            CobrarRsCaja();
            txtpagops.Focus();
        }
        /******************************/
        private void cobrarPScaja()
        {
            modSesion modSesion = new modSesion();
            if (txtpagops.Text != "")
            {
                try
                {
                    decimal pago;
                    pago = modSesion.convertirDecimal(txtpagops.Text);         // se convierte a decimal valor de la caja de texto
                    saldoPrincipal = saldoPrincipal + pagoPs;    // suma pagoPs al saldoPrincipal antes de aplicar nuevo pago en Ps
                    if (modSesion.config_moneda == "US")
                    {
                        pagoPs = pago / cotPs;                       // se convierte nuevo monto a pagar en la moneda principal del sistema  
                    }
                    else if (modSesion.config_moneda == "GS")
                    {
                        pagoPs = pago * cotPs;                       // se convierte nuevo monto a pagar en la moneda principal del sistema  
                    }

                    saldoPrincipal = saldoPrincipal - pagoPs;    // se resta pagoPs  al saldo principal del sistema
                    txtpagops.Text = Convert.ToString(modSesion.mascaraCotizacion(pago));       // se aplica mascara a la caja de texto
                    mostrarSaldoCobrar();                   // se recalcula saldoPrincipal en las distintas monedas 
                }
                catch (Exception ex)
                {
                    // se limpia caja de texto en caso de ingresar letras en el pago
                    MessageBox.Show(ex.Message);
                    txtpagops.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
                    txtpagops.Focus();
                }
            }
            else
            {
                // se aplica mascara en caso de que se quede vacio el pago
                txtpagops.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
            }
        }
        private void txtpagops_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter & Information.IsNumeric(txtpagops.Text) == true)
            {
                cobrarPScaja();
                txtpagoCr.Focus();
                e.Handled = true;
            }
        }

        private void txtpagops_Leave(object sender, EventArgs e)
        {
            cobrarPScaja();
        }
        /************COBRAR EURO CAJA*******************************/
        private void cobrarEUROcaja()
        {
            modSesion modSesion = new modSesion();
            if (txtpagoCr.Text != "")
            {
                try
                {
                    decimal pago;
                    pago = modSesion.convertirDecimal(txtpagoCr.Text);             // se convierte a decimal valor de la caja de texto
                    saldoPrincipal = saldoPrincipal + pagoCr;            // suma pagoCr al saldoPrincipal antes de aplicar nuevo pago en Cr
                    if (modSesion.config_moneda == "US")
                    {
                        pagoCr = pago / cotCr;                           // se convierte nuevo monto a pagar en la moneda principal del sistema 
                    }
                    else if (modSesion.config_moneda == "GS")
                    {
                        pagoCr = pago * cotCr;                            // se convierte nuevo monto a pagar en la moneda principal del sistema 
                    }

                    saldoPrincipal = saldoPrincipal - pagoCr;            // se resta pagoCr  al saldo principal del sistema
                    txtpagoCr.Text = Convert.ToString(modSesion.mascaraCotizacion(pago));                // se aplica mascara a la caja de texto
                    mostrarSaldoCobrar();                           // se recalcula saldoPrincipal en las distintas monedas 
                }
                catch (Exception ex)
                {
                    // se limpia caja de texto en caso de ingresar letras en el pago
                    MessageBox.Show(ex.Message);
                    txtpagoCr.Focus();
                    txtpagoCr.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
                }
            }
            else
            {
                // se aplica mascara en caso de que se quede vacio el pago
                txtpagoCr.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
            }
        }

        private void txtpagoCr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter & Information.IsNumeric(txtpagoCr.Text) == true)
            {
                cobrarEUROcaja();
                e.Handled = true;
            }
        }

        private void txtpagoCr_Leave(object sender, EventArgs e)
        {
            cobrarEUROcaja();
        }
        /************VUELTO EN GUARANIES**************/
        private void vueltoGS()
        {
            modSesion modSesion = new modSesion();
            if (txtvueltogs.Text != "")
            {
                try
                {
                    decimal vuelto;
                    vuelto = modSesion.convertirDecimal(txtvueltogs.Text);                 // se convierte a decimal valor de la caja de texto
                    saldoPrincipal = saldoPrincipal - vueltoGs;              // resta vueltoGs al saldoPrincipal antes de aplicar nuevo vuelto en Gs
                    if (modSesion.config_moneda == "US")
                    {
                        vueltoGs = vuelto / cotGs;                               // se convierte nuevo monto vuelto en la moneda principal del sistema 
                    }
                    else if (modSesion.config_moneda == "GS")
                    {
                        vueltoGs = vuelto * cotGs;                               // se convierte nuevo monto vuelto en la moneda principal del sistema 
                    }

                    saldoPrincipal = saldoPrincipal + vueltoGs;              // se suma vuelto  al saldo principal del sistema (Saldo Negativo)
                    txtvueltogs.Text = Convert.ToString(modSesion.mascaraCotizacionGuaranies(vuelto));   // se aplica mascara a la caja de texto
                    mostrarSaldoCobrar();                               // se recalcula saldoPrincipal en las distintas monedas 
                }
                catch (Exception ex)
                {
                    // se limpia caja de texto en caso de ingresar letras en el vuelto
                    MessageBox.Show(ex.Message);
                    txtvueltogs.Focus();
                    txtvueltogs.Text = Convert.ToString(modSesion.mascaraCotizacionGuaranies("0"));
                }
            }
            else
            {
                // se aplica mascara en caso de que se quede vacio el pago
                txtvueltogs.Text = Convert.ToString(modSesion.mascaraCotizacionGuaranies("0"));
            }
        }

        private void txtvueltogs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter & Information.IsNumeric(txtvueltogs.Text) == true)
            {
                vueltoGS();
                txtvueltous.Focus();
                e.Handled = true;
            }
        }

        private void txtvueltogs_Leave(object sender, EventArgs e)
        {
            vueltoGS();
        }
        /**********************VUELTO US**************************/
        private void vueltoUS()
        {
            modSesion modSesion = new modSesion();
            if (txtvueltous.Text != "")
            {
                try
                {
                    decimal vuelto;
                    vuelto = modSesion.convertirDecimal(txtvueltous.Text);                 // se convierte a decimal valor de la caja de texto
                    saldoPrincipal = saldoPrincipal - vueltoUs;              // resta vueltoUs al saldoPrincipal antes de aplicar nuevo vuelto en us
                    if (modSesion.config_moneda == "US")
                    {
                        vueltoUs = vuelto * cotUs;                               // se convierte nuevo monto vuelto en la moneda principal del sistema 
                    }
                    else if (modSesion.config_moneda == "GS")
                    {
                        vueltoUs = vuelto * cotUs;                               // se convierte nuevo monto vuelto en la moneda principal del sistema 
                    }

                    saldoPrincipal = saldoPrincipal + vueltoUs;              // se suma vuelto  al saldo principal del sistema (Saldo Negativo)
                    txtvueltous.Text = Convert.ToString(modSesion.mascaraCotizacion(vuelto));   // se aplica mascara a la caja de texto
                    mostrarSaldoCobrar();                               // se recalcula saldoPrincipal en las distintas monedas 
                }
                catch (Exception ex)
                {
                    // se limpia caja de texto en caso de ingresar letras en el vuelto
                    MessageBox.Show(ex.Message);
                    txtvueltous.Focus();
                    txtvueltous.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
                }
            }
            else
            {
                // se aplica mascara en caso de que se quede vacio el pago
                txtvueltous.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
            }
        }
        private void txtvueltous_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter & Information.IsNumeric(txtvueltous.Text) == true)
            {
                vueltoUS();
                txtpagors.Focus();
                e.Handled = true;
            }
        }

        private void txtvueltous_Leave(object sender, EventArgs e)
        {
            vueltoUS();
        }
        /**************************VUELTO EN REALES********************************************/
        private void vueltoRS()
        {
            modSesion modSesion = new modSesion();
            if (txtvueltors.Text != "")
            {
                try
                {
                    decimal vuelto;
                    vuelto = modSesion.convertirDecimal(txtvueltors.Text);                 // se convierte a decimal valor de la caja de texto
                    saldoPrincipal = saldoPrincipal - vueltoRs;              // resta vueltors al saldoPrincipal antes de aplicar nuevo vuelto en rs
                    if (modSesion.config_moneda == "US")
                    {
                        vueltoRs = vuelto / cotRs;                               // se convierte nuevo monto vuelto en la moneda principal del sistema 
                    }
                    else if (modSesion.config_moneda == "GS")
                    {
                        vueltoRs = vuelto * cotRs;                               // se convierte nuevo monto vuelto en la moneda principal del sistema 
                    }

                    saldoPrincipal = saldoPrincipal + vueltoRs;              // se suma vuelto  al saldo principal del sistema (Saldo Negativo)
                    txtvueltors.Text = Convert.ToString(modSesion.mascaraCotizacion(vuelto));                // se aplica mascara a la caja de texto
                    mostrarSaldoCobrar();                               // se recalcula saldoPrincipal en las distintas monedas 
                }
                catch (Exception ex)
                {
                    // se limpia caja de texto en caso de ingresar letras en el vuelto
                    MessageBox.Show(ex.Message);
                    txtvueltors.Focus();
                    txtvueltors.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
                }
            }
            else
            {
                // se aplica mascara en caso de que se quede vacio el pago
                txtvueltors.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
            }
        }

        private void txtvueltors_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter & Information.IsNumeric(txtvueltors.Text) == true)
            {
                vueltoRS();
                txtvueltops.Focus();
                e.Handled = true;
            }
        }

        private void txtvueltors_Leave(object sender, EventArgs e)
        {
            vueltoRS();
        }
        /*********VUELTOS EN PESOS***************/
        public void vueltoPesos()
        {
            modSesion modSesion = new modSesion();
            if (txtvueltops.Text != "")
            {
                try
                {
                    decimal vuelto;
                    vuelto = modSesion.convertirDecimal(txtvueltops.Text);                 // se convierte a decimal valor de la caja de texto
                    saldoPrincipal = saldoPrincipal - vueltoPs;              // resta vueltors al saldoPrincipal antes de aplicar nuevo vuelto en ps
                    if (modSesion.config_moneda == "US")
                    {
                        vueltoPs = vuelto / cotPs;                               // se convierte nuevo monto vuelto en la moneda principal del sistema 
                    }
                    else if (modSesion.config_moneda == "GS")
                    {
                        vueltoPs = vuelto * cotPs;                               // se convierte nuevo monto vuelto en la moneda principal del sistema 
                    }

                    saldoPrincipal = saldoPrincipal + vueltoPs;              // se suma vuelto  al saldo principal del sistema (Saldo Negativo)
                    txtvueltops.Text = Convert.ToString(modSesion.mascaraCotizacion(vuelto));                // se aplica mascara a la caja de texto
                    mostrarSaldoCobrar();                               // se recalcula saldoPrincipal en las distintas monedas 
                }
                catch (Exception ex)
                {
                    // se limpia caja de texto en caso de ingresar letras en el vuelto
                    MessageBox.Show(ex.Message);
                    txtvueltops.Focus();
                    txtvueltops.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
                }
            }
            else
            {
                // se aplica mascara en caso de que se quede vacio el pago
                txtvueltops.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
            }
        }

        private void txtvueltops_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter & Information.IsNumeric(txtvueltops.Text) == true)
            {
                vueltoPesos();
                txtvueltoCr.Focus();
                e.Handled = true;
            }
        }

        private void txtvueltops_Leave(object sender, EventArgs e)
        {
            vueltoPesos();
        }
        /**********VUELTO EN EUROS**********/
        public void vueltoEuros()
        {
            modSesion modSesion = new modSesion();
            if (txtvueltoCr.Text != "")
            {
                try
                {
                    decimal vuelto;
                    vuelto = modSesion.convertirDecimal(txtvueltoCr.Text);                 // se convierte a decimal valor de la caja de texto
                    saldoPrincipal = saldoPrincipal - vueltoCr;              // resta vueltors al saldoPrincipal antes de aplicar nuevo vuelto en cr
                    if (modSesion.config_moneda == "US")
                    {
                        vueltoCr = vuelto / cotCr;                               // se convierte nuevo monto vuelto en la moneda principal del sistema 
                    }
                    else if (modSesion.config_moneda == "GS")
                    {
                        vueltoCr = vuelto * cotCr;                               // se convierte nuevo monto vuelto en la moneda principal del sistema 
                    }

                    saldoPrincipal = saldoPrincipal + vueltoCr;              // se suma vuelto  al saldo principal del sistema (Saldo Negativo)
                    txtvueltoCr.Text = Convert.ToString(modSesion.mascaraCotizacion(vuelto));                // se aplica mascara a la caja de texto
                    mostrarSaldoCobrar();                               // se recalcula saldoPrincipal en las distintas monedas 
                }
                catch (Exception ex)
                {
                    // se limpia caja de texto en caso de ingresar letras en el vuelto
                    MessageBox.Show(ex.Message);
                    txtvueltoCr.Focus();
                    txtvueltoCr.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
                }
            }
            else
            {
                // se aplica mascara en caso de que se quede vacio el pago
                txtvueltoCr.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
            }
        }

        private void txtvueltoCr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter & Information.IsNumeric(txtvueltoCr.Text) == true)
            {
                vueltoEuros();
                e.Handled = true;
            }
        }

        private void txtvueltoCr_Leave(object sender, EventArgs e)
        {
            vueltoEuros();
        }

        
        private void txtpagogs_Leave(object sender, EventArgs e)
        {
            pagoGSCobro();
        }

        int idCotizacion;
        DateTime fecha;
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            decimal monto;
            string id;
            monto = Convert.ToDecimal(grillaVentas[4, grillaVentas.CurrentRow.Index].Value);
            id = Convert.ToString(grillaVentas[2, grillaVentas.CurrentRow.Index].Value);
            seleccionarNotaAcobrar(monto, id);
            totalPrincipal = monto;
            pagoPrincipal = 0;
            saldoPrincipal = monto;
            mostrarTotalCobrar();
            mostrarSaldoCobrar();
            limpiarPago();
            txtpagogs.Focus();
        }

       

        private void txtpagogs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter & Information.IsNumeric(txtpagogs.Text) == true)
            {
                pagoGSCobro();
                txtpagous.Focus();
                e.Handled = true;
            }
        }

        public frmMenuCaja()
        {
            InitializeComponent();
        }
        /*****************************************************/
        private void iniciarCobroVenta()
        {
            // se captura fecha del computador
            fecha = DateAndTime.Today;
            txtFechaCaja.Text = fecha.ToShortDateString().ToString();
            // se captura nuevo numero de caja
            modCaja modcajax = new modCaja();
            txtId_Caja.Text = Convert.ToString(modcajax.capturarNuevoNumeroCaja());

            // se capturar notas de ventas a cobrar del dia con estado 0
            dsVentaPendiente = modcajax.verNotaAcobrar(fecha);
            grillaVentas.DataSource = dsVentaPendiente.Tables["rsVentaPendiente"];
            modSesion modSesion = new modSesion();
            grillaVentas.Columns["Total Neto"].DefaultCellStyle.Format = modSesion.formato_precio;
            grillaVentas.Columns["Total Neto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void mostrarCotizacion()
        {
            modCotizacion modCotizacion = new modCotizacion();
            modSesion modSesion = new modSesion();
            dsCotizacion = modCotizacion.cargarCotizacion();
            if (dsCotizacion.Tables["rsCotizacion"].Rows.Count > 0)
            {
                cotRs = Convert.ToDecimal(dsCotizacion.Tables["rsCotizacion"].Rows[0]["rs"]);
                cotUs = Convert.ToDecimal(dsCotizacion.Tables["rsCotizacion"].Rows[0]["us"]);
                cotPs = Convert.ToDecimal(dsCotizacion.Tables["rsCotizacion"].Rows[0]["ps"]);
                cotCr = Convert.ToDecimal(dsCotizacion.Tables["rsCotizacion"].Rows[0]["cr"]);
                cotGs = Convert.ToDecimal(dsCotizacion.Tables["rsCotizacion"].Rows[0]["gs"]);
                txtCot_Gs.Text = Convert.ToString(modSesion.mascaraCotizacionGuaranies(cotGs));
                txtCot_Us.Text = Convert.ToString(modSesion.mascaraCotizacion(cotUs));
                txtCot_Rs.Text = Convert.ToString(modSesion.mascaraCotizacion(cotRs));
                txtCot_Ps.Text = Convert.ToString(modSesion.mascaraCotizacion(cotPs));
                txtCot_cr.Text = Convert.ToString(modSesion.mascaraCotizacion(cotCr));
                idCotizacion = Convert.ToInt32(dsCotizacion.Tables["rsCotizacion"].Rows[0]["id"]);
            }
        }


        private void frmMenuCaja_Load(object sender, EventArgs e)
        {
            modSesion modSesion = new modSesion();
            modSesion.cargarConfiguraciones();

            iniciarCobroVenta();
            mostrarCotizacion();
        }

        private void mostrarTotalCobrar()
        {
            modSesion modSesion = new modSesion();

            if (modSesion.config_moneda == "US")
            {
                txtTotalUs.Text = Convert.ToString(modSesion.mascaraCotizacion(totalPrincipal));
                txtTotalRs.Text = Convert.ToString(modSesion.mascaraCotizacion(totalPrincipal * cotRs));
                txtTotalPs.Text = Convert.ToString(modSesion.mascaraCotizacion(totalPrincipal * cotPs));
                txtTotalGs.Text = Convert.ToString(modSesion.mascaraCotizacionGuaranies(totalPrincipal * cotGs));
                txttotalcr.Text = Convert.ToString(modSesion.mascaraCotizacion(totalPrincipal * cotCr));
            }
            else if (modSesion.config_moneda == "GS")
            {
                txtTotalGs.Text = Convert.ToString(modSesion.mascaraCotizacionGuaranies(totalPrincipal));
                txttotalcr.Text = Convert.ToString(modSesion.mascaraCotizacion(totalPrincipal * cotCr));
                txtTotalUs.Text = Convert.ToString(modSesion.mascaraCotizacion(totalPrincipal / cotUs));
                txtTotalRs.Text = Convert.ToString(modSesion.mascaraCotizacion(totalPrincipal / cotRs));
                txtTotalPs.Text = Convert.ToString(modSesion.mascaraCotizacion(totalPrincipal / cotPs));
            }
        }

        private void mostrarSaldoCobrar()
        {
            modSesion modSesion = new modSesion();
            if (modSesion.config_moneda == "US")
            {
                txtsaldors.Text = Convert.ToString(modSesion.mascaraCotizacion(saldoPrincipal * cotRs));
                txtsaldops.Text = Convert.ToString(modSesion.mascaraCotizacion(saldoPrincipal * cotPs));
                txtsaldous.Text = Convert.ToString(modSesion.mascaraCotizacion(saldoPrincipal));
                txtsaldogs.Text = Convert.ToString(modSesion.mascaraCotizacionGuaranies(saldoPrincipal * cotGs));
                txtSaldoCr.Text = Convert.ToString(modSesion.mascaraCotizacion(saldoPrincipal * cotCr));
            }
            else if (modSesion.config_moneda == "GS")
            {
                txtsaldogs.Text = Convert.ToString(modSesion.mascaraCotizacionGuaranies(saldoPrincipal));
                txtSaldoCr.Text = Convert.ToString(modSesion.mascaraCotizacion(saldoPrincipal * cotCr));
                txtsaldous.Text = Convert.ToString(modSesion.mascaraCotizacion(saldoPrincipal / cotUs));
                txtsaldors.Text = Convert.ToString(modSesion.mascaraCotizacion(saldoPrincipal / cotRs));
                txtsaldops.Text = Convert.ToString(modSesion.mascaraCotizacion(saldoPrincipal / cotPs));
            }
        }
        private void seleccionarNotaAcobrar(decimal monto, string idoperacion)
        {
            modSesion modSesion = new modSesion();
            txtMonto.Text = Convert.ToString(modSesion.mascaraPrecio(monto));
            txtId_operacion.Text = idoperacion;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void limpiarPago()
        {
            modSesion modSesion = new modSesion();
            txtpagogs.Text = Convert.ToString(modSesion.mascaraCotizacionGuaranies("0"));
            txtpagors.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
            txtpagous.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
            txtpagops.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
            txtpagoCr.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
            txtvueltogs.Text = Convert.ToString(modSesion.mascaraCotizacionGuaranies("0"));
            txtvueltops.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
            txtvueltors.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
            txtvueltous.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
            txtvueltoCr.Text = Convert.ToString(modSesion.mascaraCotizacion("0"));
        }
        /*METODO PARA COBRO EN GS*/
        public void pagoGSCobro()
        {
            modSesion modSesion = new modSesion();

            if (txtpagogs.Text != "")
            {
                try
                {
                    decimal pago;
                    pago = modSesion.convertirDecimal(txtpagogs.Text); // se convierte a decimal valor de la caja de texto     
                    saldoPrincipal = saldoPrincipal + pagoGs;  // suma pagoGs al saldoPrincipal antes de aplicar nuevo pago en Gs
                    if (modSesion.config_moneda == "US")
                    {
                        pagoGs = pago / cotGs;  // se convierte nuevo monto a pagar en la moneda principal del sistema
                    }
                    else if (modSesion.config_moneda == "GS")
                    {
                        pagoGs = pago * cotGs;  // se convierte nuevo monto a pagar en la moneda principal del sistema
                    }

                    saldoPrincipal = saldoPrincipal - pagoGs; // se resta pagoGs  al saldo principal del sistema
                    txtpagogs.Text = Convert.ToString(modSesion.mascaraCotizacionGuaranies(pago)); // se aplica mascara a la caja de texto
                    mostrarSaldoCobrar();
                }
                catch (Exception ex)
                {
                    // se limpia caja de texto en caso de ingresar letras en el pago
                    MessageBox.Show(ex.Message);
                    txtpagogs.Focus();
                    txtpagogs.Text = Convert.ToString(modSesion.mascaraPrecio("0"));
                }
            }
            else
            {
                // se aplica mascara en caso de que se quede vacio el pago
                txtpagogs.Text = Convert.ToString(modSesion.mascaraCotizacionGuaranies("0"));
            }
        }
        /*************METODOS PARA EL INSERT DE LA CAJA**************/
        public void cobrarVenta()
        {
            modSesion modSesion = new modSesion();
            modUsuario modUsuario = new modUsuario();
            if (Math.Round(saldoPrincipal, 2) != 0)
            {
                MessageBox.Show("Complete monto a pagar o verifique vuelto");
            }
            else
            {
                MySqlCommand comando;
                MySqlTransaction transaccion;
                string sqlCaja;
                string sqlStock;
                string sqlventa;
                modCaja modCaja = new modCaja();
                Conexion_DB.AbrirConexion(); // se abre una conexion con la base de datos
                MySqlConnection con = Conexion_DB.conexion;
                transaccion = con.BeginTransaction();  // se inicia una transaccion con la base de datos, acontinuacion se inicia procesos multiples
                try
                {
                    // se inicia proceso 1 :  insertar registro en la tabla caja-----------------------------------------
                    sqlCaja = "INSERT INTO db_cajaregistro (Fecha,Movimiento,Operacion,id_Operacion,SubTotal,Descuento,TotalNeto,GS, US, RS, PA, CH, TJ, CR,Id_Cotizacion,Estado,Id_Usuarios) value " + "(current_timestamp,@mov,@operacion,@id_op,@subtotal,@descuento,@totalneto,@gs,@us,@rs,@pa,@ch,@tj,@cr,@id_cotizacion,@estado,@user)";
                    comando = new MySqlCommand(sqlCaja, con);
                    comando.Parameters.AddWithValue("@mov", "E");
                    comando.Parameters.AddWithValue("@operacion", "VENTA");
                    comando.Parameters.AddWithValue("@id_op", txtId_operacion.Text);
                    comando.Parameters.AddWithValue("@subtotal", totalPrincipal);
                    comando.Parameters.AddWithValue("@descuento", descuentoPrincipal);
                    comando.Parameters.AddWithValue("@totalneto", totalPrincipal - descuentoPrincipal);
                    comando.Parameters.AddWithValue("@gs", modSesion.convertirDecimal(txtpagogs.Text) - modSesion.convertirDecimal(txtvueltogs.Text));
                    comando.Parameters.AddWithValue("@us", modSesion.convertirDecimal(txtpagous.Text) - modSesion.convertirDecimal(txtvueltous.Text));
                    comando.Parameters.AddWithValue("@rs", modSesion.convertirDecimal(txtpagors.Text) - modSesion.convertirDecimal(txtvueltors.Text));
                    comando.Parameters.AddWithValue("@pa", modSesion.convertirDecimal(txtpagops.Text) - modSesion.convertirDecimal(txtvueltops.Text));
                    comando.Parameters.AddWithValue("@ch", 0);
                    comando.Parameters.AddWithValue("@tj", 0);
                    comando.Parameters.AddWithValue("@cr", modSesion.convertirDecimal(txtpagoCr.Text) - modSesion.convertirDecimal(txtvueltoCr.Text));
                    comando.Parameters.AddWithValue("@id_cotizacion", idCotizacion);
                    comando.Parameters.AddWithValue("@estado", "1");
                    int usr = Convert.ToInt32(modUsuario.VerificarIdUsuarioActivo());

                    comando.Parameters.AddWithValue("@user", usr);
                    comando.ExecuteNonQuery();

                    // se inicia proceso 2: Actualizar estado de venta y saldo de venta
                    decimal saldoVenta;
                    string tipo_venta;
                    if (modSesion.convertirDecimal(txtpagoCr.Text) == 0) // se verifica si pago no fue a credito
                    {
                        saldoVenta = 0;
                        tipo_venta = "Contado";
                    }
                    else
                    {
                        saldoVenta = modSesion.convertirDecimal(txtpagoCr.Text) - modSesion.convertirDecimal(txtvueltoCr.Text);
                        tipo_venta = "Credito";
                    }

                    sqlventa = "update db_ventas set Estado=2, TotalSaldo=@saldo,TipoDeVenta=@tipo where id= @id";
                    comando = new MySqlCommand(sqlventa, con);
                    comando.Parameters.AddWithValue("@saldo", saldoVenta);
                    comando.Parameters.AddWithValue("@id", txtId_operacion.Text);
                    comando.Parameters.AddWithValue("@tipo", tipo_venta);
                    comando.ExecuteNonQuery();

                    // se inicia proceso 3: Descontar stock de la venta cobrada
                    int c, n;
                    var consulta = new MySqlDataAdapter();
                    var resultado = new DataSet();
                    decimal cantidad;
                    int idproducto;
                    c = 0;
                    sqlventa = "";
                    // se genera sql para capturar productos de la venta cobrada 
                    sqlventa = "select * from db_ventaitems where Id_Ventas = " + txtId_operacion.Text;
                    consulta = new MySqlDataAdapter(sqlventa, con);
                    consulta.Fill(resultado, "rsVenta");
                    while (c < resultado.Tables["rsVenta"].Rows.Count)
                    {
                        // se captura cantidad y codigo de producto de la consulta de la venta
                        cantidad = Convert.ToDecimal(resultado.Tables["rsVenta"].Rows[c]["cantidad"]);
                        idproducto = Convert.ToInt32(resultado.Tables["rsVenta"].Rows[c]["id_producto"]);
                        // se genera sql para actualizar stock y se envia parametros
                        sqlStock = "update db_productos set Stock = Stock - @cantidad where id=@idproducto";
                        comando = new MySqlCommand(sqlStock, con);
                        comando.Parameters.AddWithValue("@cantidad", cantidad);
                        comando.Parameters.AddWithValue("@idproducto", idproducto);
                        comando.ExecuteNonQuery();
                        c = c + 1;
                    }

                    MensajeDeCheck mensajeDeCheck = new MensajeDeCheck("   Cobro Efectuado con exito");
                    mensajeDeCheck.ShowDialog();

                    transaccion.Commit(); // finaliza procesos y aplica cambios en la base de datos
                    Conexion_DB.CerraConexion();
                    preparaNuevaCaja();
                    modCaja.capturarNuevoNumeroCaja();
                    iniciarCobroVenta();
                    mostrarCotizacion();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al procesar cobro " + ex.Message);
                    transaccion.Rollback();
                } // si ocurre algun error no aplica cambios en la base de datos
            }
        }
        private void preparaNuevaCaja()
        {
            // se limpia variables
            cotGs = 0;
            cotRs = 0;
            cotPs = 0;
            cotUs = 0;
            cotCr = 0;
            pagoGs = 0;
            pagoRs = 0;
            pagoUs = 0;
            pagoPs = 0;
            pagoCr = 0;
            vueltoGs = 0;
            vueltoRs = 0;
            vueltoPs = 0;
            vueltoUs = 0;
            vueltoCr = 0;
            totalPrincipal = 0;
            pagoPrincipal = 0;
            saldoPrincipal = 0;
            descuentoPrincipal = 0;
            txtCot_cr.Text = "";
            txtCot_Gs.Text = "";
            txtCot_Ps.Text = "";
            txtCot_Us.Text = "";
            txtCot_Ps.Text = "";
            txtTotalGs.Text = "";
            txtTotalUs.Text = "";
            txtTotalRs.Text = "";
            txtTotalPs.Text = "";
            txttotalcr.Text = "";
            txtpagogs.Text = "";
            txtpagors.Text = "";
            txtpagops.Text = "";
            txtpagoCr.Text = "";
            txtpagous.Text = "";
            txtsaldogs.Text = "";
            txtsaldous.Text = "";
            txtsaldops.Text = "";
            txtsaldors.Text = "";
            txtSaldoCr.Text = "";
            txtvueltous.Text = "";
            txtvueltors.Text = "";
            txtvueltogs.Text = "";
            txtvueltops.Text = "";
            txtvueltoCr.Text = "";
            txtId_operacion.Text = "";
            txtMonto.Text = "";
            dsCotizacion = new DataSet();
            dsVentaPendiente = new DataSet();
        }

        private void btnProcesarCobro_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text != "")
            {
                cobrarVenta();
            }
            else
            {
                MessageBox.Show("Seleccione operacion a realizar");
            }
        }

    }
}
