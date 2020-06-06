using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ModuloCompra
{
    public class modCompra
    {

        // contiene funciones asociadas a consultas a la tabla compra
        public string verificarCompraPendiente()
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            string sql;
            DataSet resultado = new DataSet();
            try
            {
                Conexion_DB.AbrirConexion();
                
                sql = "select count(*)as pendiente from db_compras where estado=0";
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(resultado, "rsCompra");

                if (Convert.ToInt32(resultado.Tables["rsCompra"].Rows[0]["pendiente"]) == 0)
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
                MessageBox.Show("Error al Comprobar compra nueva" + ex.Message);
                return "error";
            }
        }


        public bool generarNuevaCompra()
        {
            MySqlCommand comando = new MySqlCommand();
            modSesion modSesion = new modSesion();
            string sql;
            try
            {
                Conexion_DB.AbrirConexion();
                sql = "insert into db_compras(Id_Proveedor,FechaDeCompra,Id_Usuario,Estado)values(@id,current_timestamp,@user,0)";
                comando = new MySqlCommand(sql, Conexion_DB.conexion);
                comando.Parameters.AddWithValue("@id", "1");
                comando.Parameters.AddWithValue("@user", modSesion.xCodigoUser);
                comando.ExecuteNonQuery();
                //Conexion_DB.CerraConexion();
                return true;
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al generar nueva Compra " + ex.Message);
                return false;
            }
        }




        public DataSet capturarCompraPendiente()
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            string sql;
            DataSet resultado = new DataSet();
            try
            {
                Conexion_DB.AbrirConexion();
                sql = "select * from db_compras where estado=0";
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(resultado, "rsCompra");
                Conexion_DB.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al recuperar compra " + ex.Message);
            }
            return resultado;
        }
    }
}
