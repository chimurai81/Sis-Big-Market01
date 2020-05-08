using MensajesPersonalizados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sis_Supermercado_TallerV.RegistroUsers
{
    public class modulo
    {
        public static MySqlConnection conexion;
        public static string ErrorDB;

        public static void AbrirConexion()
        {
            try
            {
                conexion = new MySqlConnection();
                conexion.ConnectionString = "Server=localhost;" +
                                              "Database=sis_supermercado;" +
                                              "Uid=root;" +
                                              "Pwd=;";
                conexion.Open();

            }
            catch (MySqlException ex)
            {
                MensajeDeError frmError = new MensajeDeError();

                frmError.labelerrro.Text = "MYSQL ERROR";

                frmError.ShowDialog();
                //MessageBox.Show(ex.Message);
            }
        }
        public static void CerraConexion()
        {
            try
            {
                conexion = new MySqlConnection();
                conexion.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
