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
    public class modCliente
    {
        public DataSet cargarCliente(string condicion)
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            string sql;
            DataSet resultado = new DataSet();
            try
            {
                Conexion_DB.AbrirConexion();
                sql = "select * from db_clientes where id_Clientes=" + condicion;
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(resultado, "rsCliente");
                Conexion_DB.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al seleccionar Cliente " + ex.Message);
            }

            return resultado;
        }

        public DataSet cargarClienteTabla(string condicion)
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            string sql;
            DataSet resultado = new DataSet();
            try
            {
                Conexion_DB.AbrirConexion();
                sql = "select id_Clientes as 'Codigo',Nombre as 'Razon Social',CiNro as 'Documento'  from db_clientes " + condicion;
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(resultado, "rsCliente");
                Conexion_DB.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al seleccionar Cliente " + ex.Message);
            }

            return resultado;
        }
    }
}
