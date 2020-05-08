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

namespace Prod_Provee_Marc_Categ.Formularios_De_Productos
{
    public partial class FrmBusqueda_Interna_Proveedores : Form
    {
        public FrmBusqueda_Interna_Proveedores()
        {
            InitializeComponent();
        }
        public void GetAll(string condicion)
        {
            string sql;
            MySqlDataAdapter consulta;
            DataSet resultado;
            sql = "SELECT * FROM db_proveedores " + condicion;

            try
            {
                modulo.AbrirConexion();
                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                resultado = new DataSet();
                consulta.Fill(resultado, "rsresultado");
                DataGridView1.DataSource = resultado.Tables["rsresultado"];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FrmBusqueda_Interna_Proveedores_Load(object sender, EventArgs e)
        {
            GetAll("");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if(txtBuscar.Text == "Buscar")
            {
                txtBuscar.Text = "";
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar";
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string operacion;
            operacion = "WHERE  RazonSocial LIKE '%" + txtBuscar.Text + "%' OR Ruc LIKE '%" + txtBuscar.Text + "%'";
            GetAll(operacion);
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FrmNuevoProductos FrmPadre = (FrmNuevoProductos)Owner;
            FrmPadre.txtProveedor.Text = Convert.ToString(DataGridView1.CurrentRow.Cells[0].Value);
            this.Close();
        }
    }
}
