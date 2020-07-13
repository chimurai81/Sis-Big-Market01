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
    public class modUsuario
    {
        public string VerificarIdUsuarioActivo()
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            string sql;
            DataSet resultado = new DataSet();
            string IdUsuarioActivo;
            try
            {
                Conexion_DB.AbrirConexion();

                sql = "select count(*)as pendiente, id from db_usuarios where Activo=1";
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(resultado, "rsUsuario");

                if (Convert.ToInt32(resultado.Tables["rsUsuario"].Rows[0]["pendiente"]) == 1)
                {
                    IdUsuarioActivo = Convert.ToString(resultado.Tables["rsUsuario"].Rows[0]["id"]);
                    Conexion_DB.CerraConexion();
                    return IdUsuarioActivo;
                }
                else
                {
                    Conexion_DB.CerraConexion();
                    return "no";
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Comprobar id activo de usuario" + ex.Message);
                return "error";
            }
        }
    }
}
