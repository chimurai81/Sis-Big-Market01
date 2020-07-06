using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloCotizacion
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
                db_Conexion.AbrirConexion();

                sql = "select count(*)as pendiente, id from db_usuarios where Activo=1";
                consulta = new MySqlDataAdapter(sql, db_Conexion.conexion);
                consulta.Fill(resultado, "rsUsuario");

                if (Convert.ToInt32(resultado.Tables["rsUsuario"].Rows[0]["pendiente"]) == 1)
                {
                    IdUsuarioActivo = Convert.ToString(resultado.Tables["rsUsuario"].Rows[0]["id"]);
                    db_Conexion.CerraConexion();
                    return IdUsuarioActivo;
                }
                else
                {
                    db_Conexion.CerraConexion();
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
