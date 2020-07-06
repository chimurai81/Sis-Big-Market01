using MensajesPersonalizados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloCotizacion
{
    public partial class FrmMenuCotizacion : Form
    {
        public FrmMenuCotizacion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.cambioschaco.com.py/");
            webBrowser2.Navigate("http://www.lamoneda.com.py/#cotizaciones");
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InsertarCotizacion()
        {
            string sql;
            //MySqlCommand comando;
            sql = "insert into db_cotizacion (Fecha, Id_Usuario, GS, US, RS, PS, TJ, CR) values (current_timestamp, @Id_Usuario, @GS, @US, @RS, @PS, @TJ, @CR)";
            MySqlCommand comando;
            try
            {
                db_Conexion.AbrirConexion();
                comando = new MySqlCommand(sql, db_Conexion.conexion);
                modUsuario modUsuario = new modUsuario();
                comando.Parameters.AddWithValue("@Id_Usuario", modUsuario.VerificarIdUsuarioActivo());
                comando.Parameters.AddWithValue("@GS", Convert.ToDecimal(txtguaranies.Text));
                comando.Parameters.AddWithValue("@US", Convert.ToDecimal(txtDolarAmericano.Text.ToString()));
                comando.Parameters.AddWithValue("@RS", Convert.ToDecimal(txtReal.Text.ToString()));
                comando.Parameters.AddWithValue("@PS", Convert.ToDecimal(txtPesoArgentino.Text.ToString()));
                comando.Parameters.AddWithValue("@TJ", Convert.ToDecimal(txtEuro.Text.ToString()));
                comando.Parameters.AddWithValue("@CR", Convert.ToDecimal(0.000));
                comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnRegistrarCotizacion_Click(object sender, EventArgs e)
        {
            InsertarCotizacion();
            MensajeDeCheck mensajeDeCheck = new MensajeDeCheck();
            mensajeDeCheck.ShowDialog();
            this.Close();
        }
    }
}
