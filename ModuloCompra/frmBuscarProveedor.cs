using MySql.Data.MySqlClient;
using System;

using System.Windows.Forms;

namespace ModuloCompra
{
    public partial class frmBuscarProveedor : Form
    {
        public frmBuscarProveedor()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBuscarProveedor_Load(object sender, EventArgs e)
        {
            modProveedor modProveedor = new modProveedor();
            grilla.DataSource = modProveedor.cargarProveedorTabla("").Tables["rsProveedor"];

        }

        public void buscar()
        {
            modProveedor modProveedor = new modProveedor();
            try
            {
                string operacion;
                operacion = "WHERE id LIKE '%" + txtBuscar.Text + "%' OR RazonSocial LIKE '%" + txtBuscar.Text + "%' OR Ruc like '%" + txtBuscar.Text + "%'";
                grilla.DataSource = modProveedor.cargarProveedorTabla(operacion).Tables["rsProveedor"];
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.StackTrace);
            }

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            buscar();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FrmMenuCompra frmCompra = (FrmMenuCompra)Owner;
            frmCompra.txtIdProveedor.Text = Convert.ToString(grilla[0, grilla.CurrentRow.Index] .Value);
            frmCompra.txtNombreProveedor.Text = Convert.ToString(grilla[1, grilla.CurrentRow.Index].Value);
            frmCompra.txtCodigoProducto.Focus();
            this.Close();
   
        }
    }
}
