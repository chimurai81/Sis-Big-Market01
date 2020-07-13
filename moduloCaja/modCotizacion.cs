using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace moduloCaja
{
    public class modCotizacion
    {
        public static DataSet cargarCotizacion()
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            string sql;
            var resultado = new DataSet();
            try
            {
                Conexion_DB.AbrirConexion();
                sql = "select * from db_cotizacion order by Fecha desc limit 1";
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(resultado, "rsCotizacion");
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
