using MySql.Data.MySqlClient;
using Sis_Supermercado_TallerV.RegistroUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuarios.Formularios
{
    public partial class FrmModificarUsuario : Form
    {
        public FrmModificarUsuario()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ModificarUsuario(string id)
        {
            string sql;
            //MySqlCommand comando;
            sql = "update db_usuarios set Nombre=@Nombre, FechaNac=@FechaNac, Sexo=@Sexo where id=@id";
            MySqlCommand comando;
            try
            {
                modulo.AbrirConexion();
                comando = new MySqlCommand(sql, modulo.conexion);
                comando.Parameters.AddWithValue("@Nombre", txtnombre.Text.ToString());
                comando.Parameters.AddWithValue("@FechaNac", dtpFechaNac.Value.Date);
                comando.Parameters.AddWithValue("@Sexo", cobSexo.SelectedItem.ToString());
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cargarRegistro(string id)
        {

            string sql;
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            DataSet resultado = new DataSet();

            try
            {
                modulo.AbrirConexion();
                sql = "select * from db_usuarios where id= " + id;
                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                consulta.Fill(resultado, "rsProveedor");
                int n;
                n = resultado.Tables["rsProveedor"].Rows.Count;

                txtid.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["id"]);
                txtnombre.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Nombre"]);
                dtpFechaNac.Value = Convert.ToDateTime(resultado.Tables["rsProveedor"].Rows[0]["FechaNac"]);
                cobSexo.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Sexo"]);

                modulo.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            string id = txtid.Text;
            ModificarUsuario(id);
            FrmAjusteDeUsuarios frm3 = (FrmAjusteDeUsuarios)Owner;
            frm3.GetAll("");
            this.Close();
        }

        private void FrmModificarUsuario_Load(object sender, EventArgs e)
        {
            string valordeid = FrmAjusteDeUsuarios.valor;
            cargarRegistro(valordeid);

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
