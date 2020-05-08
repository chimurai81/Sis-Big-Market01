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
    public partial class FrmModificarAcceso : Form
    {
        public FrmModificarAcceso()
        {
            InitializeComponent();
        }

        private void FrmModificarAcceso_Load(object sender, EventArgs e)
        {
            string valordeid = FrmAjusteDeUsuarios.valor;
            cargarRegistro(valordeid);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ModificarUsuario(string id)
        {
            string sql;
            //MySqlCommand comando;
            sql = "update db_usuarios set Nombre=@Nombre, Accesos=@Accesos where id=@id";
            MySqlCommand comando;
            try
            {
                modulo.AbrirConexion();
                comando = new MySqlCommand(sql, modulo.conexion);
                comando.Parameters.AddWithValue("@Nombre", txtnombre.Text.ToString());
                comando.Parameters.AddWithValue("@Accesos", cboAccesos.SelectedItem.ToString());
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
                cboAccesos.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Accesos"]);

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

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
