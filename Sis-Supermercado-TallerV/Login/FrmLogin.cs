using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Sis_Supermercado_TallerV.RegistroUsers;
using MySql.Data.MySqlClient;
using MensajesPersonalizados;
using MenuPrincipal;
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

        public string EstadoActivoVariable;
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
                        EstadoActivoVariable = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["id"]);
                        if (TipoDeAcceso == "ADMINISTRADOR")
                        {
                       
                            FrmMenuPrincipal3 menu = new FrmMenuPrincipal3(txtusuario.Text.ToUpperInvariant());
                            menu.Show();
                            this.Hide();
                        }
                        else if (TipoDeAcceso == "VENDEDOR")
                        {
                            FrmNuevoProductos nuevoproducto = new FrmNuevoProductos();
                            FrmMenuPrincipal3 menu = new FrmMenuPrincipal3(txtusuario.Text.ToUpperInvariant());
                            
                            menu.Show();
                            menu.btnUsuarios.Enabled = false;
                            nuevoproducto.txtCosto.Enabled = false;
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

        //insertar si esta activo el usuario
        //para editar
        public void EstadoActivo(string id)
        {
            string sql;
            //MySqlCommand comando;
            sql = "update db_usuarios set Activo=@Activo where id=@id";
            MySqlCommand comando;
            try
            {
                modulo.AbrirConexion();
                comando = new MySqlCommand(sql, modulo.conexion);

                comando.Parameters.AddWithValue("@Activo", "1".ToString());
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            InicioDeSesion_db_usuarios("");
            EstadoActivo(EstadoActivoVariable);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           if(txtpass.PasswordChar == '*')
            {
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                InicioDeSesion_db_usuarios("");
                EstadoActivo(EstadoActivoVariable);
                e.Handled = true;
            }
           
        }
    }
}