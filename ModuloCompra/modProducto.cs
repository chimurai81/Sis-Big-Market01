using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloCompra
{
    public class modProducto
    {
        public DataSet cargarProductoTabla(string condicion)
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            DataSet resultado = new DataSet();
            string sql;
            try
            {
                Conexion_DB.AbrirConexion();
                sql = "select * from vistaproductocompra " + condicion;
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(resultado, "rsProducto");
                Conexion_DB.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar Producto " + ex.Message);
            }
            return resultado;
        }



        public DataSet cargarProducto(string condicion)
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            DataSet resultado = new DataSet();
            string sql;
            try
            {
                Conexion_DB.AbrirConexion();
                sql = "select * from db_productos " + condicion;
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(resultado, "rsProducto");
                Conexion_DB.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar db_productos " + ex.StackTrace);
            }

            return resultado;
        }
    }
}
