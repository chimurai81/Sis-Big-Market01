using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloVenta
{
    public class moduloVenta
    {
        // contiene funciones asociadas a consultas a la tabla Venta
        public string verificarVentaPendiente()
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            string sql;
            var resultado = new DataSet();
            try
            {
                Conexion_DB.AbrirConexion();
                sql = "select count(*)as pendiente from db_ventas where Estado=0";
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(resultado, "rsVenta");
                if (Convert.ToInt32(resultado.Tables["rsVenta"].Rows[0]["pendiente"]) == 0)
                {
                    Conexion_DB.CerraConexion();
                    return "no";
                }
                else
                {
                    Conexion_DB.CerraConexion();
                    return "si";

                }

                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Comprobar Venta nueva" + ex.Message);
                Conexion_DB.CerraConexion();
                return "error";
            }

        }

        public bool generarNuevaVenta()
        {
            MySqlCommand comando = new MySqlCommand();
            string sql;
            try
            {
                Conexion_DB.AbrirConexion();
                sql = "insert into db_ventas(id_Cliente,FechaDeVenta,id_Usuario,Estado)values(@id,current_timestamp,@user,0)";
                comando = new MySqlCommand(sql, Conexion_DB.conexion);
                comando.Parameters.AddWithValue("@id", "3");
                comando.Parameters.AddWithValue("@user", 1);
                comando.ExecuteNonQuery();
                Conexion_DB.CerraConexion();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al generar nueva Venta " + ex.Message);
                Conexion_DB.CerraConexion();
                return false;
            }
        }

        public DataSet capturarVentaPendiente()
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            string sql;
            var resultado = new DataSet();
            try
            {
                Conexion_DB.AbrirConexion();
                sql = "select * from db_ventas where estado=0";
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(resultado, "rsVenta");
                Conexion_DB.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al recuperar Venta " + ex.Message);
            }

            return resultado;
        }
    }
}
