using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MenuPrincipal;
using Sis_Supermercado_TallerV.RegistroUsers;
using MySql.Data.MySqlClient;
using Sis_Supermercado_TallerV.Login;
using MensajesPersonalizados;
using Prod_Provee_Marc_Categ.Formularios_De_Productos;

namespace Sis_Supermercado_TallerV
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        { 
            pictureBox1.Visible = false;
            bunifuTransition1.Show(pictureBox1);
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USUARIO")
            {
                txtusuario.Text = "";
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO";
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        internal string valor()
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      
        public void InicioDeSesion_db_usuarios(string condicion)
        {
            string sql;
            string passEncrip;
            passEncrip = Usuarios.Encriptar.EncryptData(txtpass.Text, txtusuario.Text);
            //MySqlCommand comando;
            sql = "select * from db_usuarios where usuario = '"+txtusuario.Text+"' and password = '"+ passEncrip+"'" + condicion;
           
            
            MySqlCommand comando;
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            DataSet resultado = new DataSet();
            try
            {
                modulo.AbrirConexion();

                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                consulta.Fill(resultado, "rsProveedor");
                string TipoDeAcceso;
                
      
                comando = new MySqlCommand(sql, modulo.conexion);
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        TipoDeAcceso = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Accesos"]);
                        if (TipoDeAcceso == "ADMINISTRADOR")
                        {
                       
                            FrmMenuPrincipal3 menu = new FrmMenuPrincipal3(txtusuario.Text.ToUpperInvariant());
                            menu.Show();
                            this.Hide();
                        }
                        else if (TipoDeAcceso == "VENDEDOR")
                        {

                            FrmMenuPrincipal3 menu = new FrmMenuPrincipal3(txtusuario.Text.ToUpperInvariant());
                            
                            menu.Show();
                            menu.btnUsuarios.Enabled = false;
                            this.Hide();
                        }
                        else if (TipoDeAcceso == "CAJERO")
                        {

                            FrmMenuPrincipal3 menu = new FrmMenuPrincipal3(txtusuario.Text.ToUpperInvariant());
                            menu.Show();
                            menu.btnUsuarios.Enabled = false;
                            menu.btnReportes.Enabled = false;
                            this.Hide();
                        }

                    }
                }
               
                else
                {
                    MensajeDeError show = new MensajeDeError();
                    show.ShowDialog();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            InicioDeSesion_db_usuarios("");
        }


    }
}