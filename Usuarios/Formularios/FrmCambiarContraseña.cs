using MySql.Data.MySqlClient;
using Sis_Supermercado_TallerV.RegistroUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuarios.Formularios
{
    public partial class FrmCambiarContraseña : Form
    {
        public FrmCambiarContraseña()
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
            sql = "update db_usuarios set Usuario=@Usuario, password=@password where id=@id";
            MySqlCommand comando;
            try
            {
                modulo.AbrirConexion();
                comando = new MySqlCommand(sql, modulo.conexion);
                comando.Parameters.AddWithValue("@Usuario", txtusuario.Text.ToString());
                string PassEncriptada;
                PassEncriptada = Encriptar.EncryptData(txtcontraseña.Text, txtusuario.Text);
                comando.Parameters.AddWithValue("@password", PassEncriptada.ToString());
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
                txtusuario.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Usuario"]);
                txtcontraseña.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["password"]);


                modulo.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            ModificarUsuario(id);
            FrmAjusteDeUsuarios frm3 = (FrmAjusteDeUsuarios)Owner;
            frm3.GetAll("");
            this.Close();
        }

        private void FrmCambiarContraseña_Load(object sender, EventArgs e)
        {

            string valordeid = FrmAjusteDeUsuarios.valor;
            cargarRegistro(valordeid);
        }
    }
}
