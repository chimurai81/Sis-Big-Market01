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

namespace ModuloVenta
{
    public partial class frmBuscarProducto : Form
    {
        public frmBuscarProducto()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBuscarProducto_Load(object sender, EventArgs e)
        {
            modProducto modProducto = new modProducto();
            grilla.DataSource = modProducto.cargarProductoTabla("").Tables["rsProducto"];
        }
        public void buscar()
        {
            modProducto modProducto = new modProducto();
            try
            {
                string operacion;
                operacion = "WHERE Codigo LIKE '%" + txtBuscar.Text + "%' OR Descripcion LIKE '%" + txtBuscar.Text + "%' OR Marca like '%" + txtBuscar.Text + "%' OR Categoria like '%" + txtBuscar.Text + "%'";
                grilla.DataSource = modProducto.cargarProductoTabla(operacion).Tables["rsProducto"];

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.StackTrace);
            }

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            buscar();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FrmMenuVenta frmCompra = (FrmMenuVenta)Owner;
            modSesion modSesion = new modSesion();
            frmCompra.txtCodigoProducto.Text = Convert.ToString(grilla[0, grilla.CurrentRow.Index].Value);

            this.Close();
        }
    }
}
