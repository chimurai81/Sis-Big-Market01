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
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void buscar()
        {
            modCliente modCliente = new modCliente();
            try
            {
                string operacion;
                operacion = "WHERE id_Clientes LIKE '%" + txtBuscar.Text + "%' OR Nombre LIKE '%" + txtBuscar.Text + "%' OR CiNro like '%" + txtBuscar.Text + "%'";
                grilla.DataSource = modCliente.cargarClienteTabla(operacion).Tables["rsCliente"];
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.StackTrace);
            }

        }
        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            modCliente modCliente = new modCliente();
            grilla.DataSource = modCliente.cargarClienteTabla("").Tables["rsCliente"];
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            buscar();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FrmMenuVenta frmmenuVenta = (FrmMenuVenta)Owner;
            frmmenuVenta.txtIdCliente.Text = Convert.ToString(grilla[0, grilla.CurrentRow.Index].Value);
            frmmenuVenta.txtNombreCliente.Text = Convert.ToString(grilla[1, grilla.CurrentRow.Index].Value);
            frmmenuVenta.txtCodigoProducto.Focus();
            this.Close();
        }
    }
}
