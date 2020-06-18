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

namespace Prod_Provee_Marc_Categ.Formularios_de_Categoria
{
    public partial class FrmAgregarNuevaCategoria : Form
    {
        public FrmAgregarNuevaCategoria()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void InsertarCategoria()
        {
            string sql;
            //MySqlCommand comando;
            sql = "insert into db_categoria (Descripcion, Estado) values (@Descripcion, 1)";
            MySqlCommand comando;
            try
            {
                modulo.AbrirConexion();
                comando = new MySqlCommand(sql, modulo.conexion);
                comando.Parameters.AddWithValue("@Descripcion", txtNombreProveedor.Text.ToUpperInvariant().ToString());

                comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            InsertarCategoria();
            this.Close();
        }

        private void FrmAgregarNuevaCategoria_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtNombreProveedor.Text != "")
                {
                    InsertarCategoria();
                    this.Close();
                    e.Handled = true;
                }
            }
        }
    }
}
