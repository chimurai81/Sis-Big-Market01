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
    public partial class FrmAgregarNuevoProveedor : Form
    {
        public FrmAgregarNuevoProveedor()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAgregarNuevoProveedor_Load(object sender, EventArgs e)
        {

        }
        //METODO PARA INSERTAR NUEVO PROVEEDOR
        public void InsertarProveedor()
        {
            string sql;
            //MySqlCommand comando;
            sql = "insert into db_proveedores (RazonSocial, NroTelef, Ruc, Direccion) values (@RazonSocial, @NroTelef, @Ruc, @Direccion)";
            MySqlCommand comando;
            try
            {
                modulo.AbrirConexion();
                comando = new MySqlCommand(sql, modulo.conexion);
                comando.Parameters.AddWithValue("@RazonSocial", txtNombreProveedor.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@NroTelef", txtRuc.Text.ToString());
                comando.Parameters.AddWithValue("@Ruc", txtNroTelef.Text.ToString());
                comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text.ToUpperInvariant().ToString());
                comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            InsertarProveedor();
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
