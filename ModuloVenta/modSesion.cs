using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloVenta
{
    public class modSesion
    {
        /*VARIABLES GLOBALES PARA LA CONFIGURACION*/

        public static string formato_precio, formato_costo, formato_cantidad; // config decimales y separador de mil  para precio,cantidad  y costos 
        public static string formato_cotizacion = "###,##0.00";
        public static string formato_cotizacionGuaranies = "#,##0";
        public static string config_moneda; // config para venta 
        public static string config_regional;
        public static string xCodigoUser ="1";


        /* METODO DE CONFIGURACION PARA CUANDO SE EJECTUTE EL LOAD DEL FORMULARIO*/
        public void cargarConfiguraciones()
        {
            int dec_precio=0, dec_costo=0, dec_cantidad=0;
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            string sql;
            DataSet resultado = new DataSet();
            try
            {
                Conexion_DB.AbrirConexion();
                sql = "select * from config";

                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(resultado, "rsConfig");

                if (resultado.Tables["rsConfig"].Rows.Count > 0)
                {
                    dec_precio = Convert.ToInt32(resultado.Tables["rsConfig"].Rows[0]["dec_precio"]); // captura decimales para el precio
                    dec_costo = Convert.ToInt32(resultado.Tables["rsConfig"].Rows[0]["dec_costo"]); // captura decimales para el costo
                    dec_cantidad = Convert.ToInt32(resultado.Tables["rsConfig"].Rows[0]["dec_cantidad"]); // decimales para la cantidad
                    config_regional = Convert.ToString(resultado.Tables["rsConfig"].Rows[0]["config_reg"]); // configurarcion en_Us
                    config_moneda = Convert.ToString(resultado.Tables["rsConfig"].Rows[0]["config_moneda"]); // configuracion para moneda predeterminada del sistema
                }
                else
                {
                    dec_precio = 0;
                    dec_costo = 0;
                    dec_cantidad = 0;
                    config_regional = "en_Us";
                    config_moneda = "US";
                }

               // Conexion_DB.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar Configuracion " + ex.StackTrace);
            }

            // se prepara mascara para precios 
            if (dec_precio == 0)
            {
                formato_precio = "#,##0";
            }else if (dec_precio == 1)
            {
                formato_precio = "###,##0.0";
            }else if (dec_precio == 2)
            {
                formato_precio = "###,##0.00";
            }else if (dec_precio == 3)
            {
                formato_precio = "###,##0.000";
            }
                
            // se prepara mascara para costo
            if (dec_costo == 0)
            {
                formato_costo = "#,##0";
            }else if (dec_costo == 1)
            {
                formato_costo = "###,##0.0";
            }else if (dec_costo == 2)
            {
                formato_costo = "###,##0.00";
            }else if (dec_costo == 3)
            {
                formato_costo = "###,##0.000";
            }
            // se prepara mascara para cantidad
            if (dec_cantidad == 0)
            {
                formato_cantidad = "#,##0";
            }
            else if (dec_cantidad == 1)
            {
                formato_cantidad = "###,##0.0";
            }
            else if (dec_cantidad == 1)
            {
                formato_cantidad = "###,##0.00";
            }
            else if (dec_cantidad == 3)
            {
                formato_cantidad = "###,##0.000";
            }
        }


        /*MASCARA PRECIO*/
        public object mascaraPrecio(object numero)
        {
            numero = Conversion.Val(numero).ToString(formato_precio, System.Globalization.CultureInfo.CreateSpecificCulture(config_regional));
            return numero;
        }
        /*MASCARA Costo*/

        public object mascaraCosto(object numero)
        {
            
            numero = Conversion.Val(numero).ToString(formato_costo, CultureInfo.CreateSpecificCulture(config_regional));
            return numero;
        }
        /*MASCARA Cantidad*/
        public object mascaraCantidad(object numero)
        {
            numero = Conversion.Val(numero).ToString(formato_cantidad, System.Globalization.CultureInfo.CreateSpecificCulture(config_regional));
            return numero;
        }
        /*MASCARA Cotizacion*/
        public object mascaraCotizacion(object numero)
        {
            numero = Conversion.Val(numero).ToString(formato_cotizacion, System.Globalization.CultureInfo.CreateSpecificCulture(config_regional));
            return numero;
        }
        /*MASCARA CotizacionGuaranies*/
        public object mascaraCotizacionGuaranies(object numero)
        {
            numero = Conversion.Val(numero).ToString(formato_cotizacionGuaranies, System.Globalization.CultureInfo.CreateSpecificCulture(config_regional));
            return numero;
        }
        /*MASCARA Decimal*/
        public decimal convertirDecimal(object valor)
        {
            decimal numero;
            numero = Convert.ToDecimal(valor, System.Globalization.CultureInfo.CreateSpecificCulture(config_regional));
            return numero;
        }
    }
}
