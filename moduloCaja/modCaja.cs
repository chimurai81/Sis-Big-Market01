using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moduloCaja
{
    public class modCaja
    {
        public DataSet verNotaAcobrar(DateTime fecha)
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            string sql;
            var resultado = new DataSet();
            string xFecha = Strings.Format(fecha, "yyyy/MM/dd");
            sql = " select date(a.FechaDeVenta)as Venta,a.id as Operacion,b.Nombre as Cliente, a.TotalNeto As 'Total Neto' from db_ventas a  inner join db_clientes b on a.id_cliente = b.id_clientes where date(a.FechaDeVenta) = '" + xFecha + "' and a.estado = 1";
            try
            {
                Conexion_DB.AbrirConexion();
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(resultado, "rsVentaPendiente");
                Conexion_DB.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al ver compra Pendiente" + ex.Message);
            }

            return resultado; 
        }

        public int capturarNuevoNumeroCaja() 
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            string sql;
            DataSet resultado = new DataSet();
            int nuevoNumero = 0;
            try
            {
                sql = "select if(max(id)is null,1,max(id+1))as ultimoNumero from db_cajaregistro";
                Conexion_DB.AbrirConexion();
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(resultado, "rs");
                nuevoNumero = Convert.ToInt32(resultado.Tables["rs"].Rows[0]["ultimoNumero"]);
                Conexion_DB.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al capturar numero de caja" + ex);
            }

            return nuevoNumero;
        }
    }
}
