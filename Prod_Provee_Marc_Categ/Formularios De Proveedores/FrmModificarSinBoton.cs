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

namespace Prod_Provee_Marc_Categ.Formularios
{
    public partial class FrmModificarSinBoton : Form
    {
        public FrmModificarSinBoton()
        {
            InitializeComponent();
        }
        public void cargarRegistro(string id)
        {

            string sql;
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            DataSet resultado = new DataSet();

            try
            {
                modulo.AbrirConexion();
                sql = "select * from db_proveedores where id_Clientes= " + id;
                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                consulta.Fill(resultado, "rsProveedor");
                int n;
                n = resultado.Tables["rsProveedor"].Rows.Count;

                txtId.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["id"]);
                txtNombreProveedor.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["RazonSocial"]);
                txtRuc.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["NroTelef"]);
                txtNroTelef.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Ruc"]);
                txtDireccion.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Direccion"]);


                modulo.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmModificarSinBoton_Load(object sender, EventArgs e)
        {
            FrmMenuProveedores frm = (FrmMenuProveedores)Owner;
            txtId.Text = Convert.ToString(frm.dataGridView1.CurrentRow.Cells[0].Value);
            txtNombreProveedor.Text = Convert.ToString(frm.dataGridView1.CurrentRow.Cells[1].Value);
            txtNroTelef.Text = Convert.ToString(frm.dataGridView1.CurrentRow.Cells[2].Value);
            txtRuc.Text = Convert.ToString(frm.dataGridView1.CurrentRow.Cells[3].Value);
            txtDireccion.Text = Convert.ToString(frm.dataGridView1.CurrentRow.Cells[4].Value);
        }

        //para editar
        public void EditarProveedor(string id)
        {
            string sql;
            //MySqlCommand comando;
            sql = "update db_proveedores set RazonSocial=@RazonSocial, NroTelef=@NroTelef, Ruc=@Ruc, Direccion=@Direccion where id=@id";
            MySqlCommand comando;
            try
            {
                modulo.AbrirConexion();
                comando = new MySqlCommand(sql, modulo.conexion);

                comando.Parameters.AddWithValue("@RazonSocial", txtNombreProveedor.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@NroTelef", txtNroTelef.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@Ruc", txtRuc.Text.ToString());
                comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text.ToString());
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            EditarProveedor(id);
            FrmMenuProveedores frm = (FrmMenuProveedores)Owner;
            frm.GetAll("");
            this.Close();
        }
    }
}
