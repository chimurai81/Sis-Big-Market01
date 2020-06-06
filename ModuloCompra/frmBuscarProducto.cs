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

namespace ModuloCompra
{
    public partial class frmBuscarProducto : Form
    {
        public frmBuscarProducto()
        {
            InitializeComponent();
        }

        private void frmBuscarProducto_Load(object sender, EventArgs e)
        {
            modProducto modProducto = new modProducto();
            grilla.DataSource = modProducto.cargarProductoTabla("").Tables["rsProducto"];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void buscar()
        {
            modProducto modProducto = new modProducto();
            try
            {
                string operacion;
                operacion = "WHERE Barra LIKE '%" + txtBuscar.Text + "%' OR Descripcion LIKE '%" + txtBuscar.Text + "%' OR Marca like '%" + txtBuscar.Text + "%' OR Categoria like '%" + txtBuscar.Text + "%'";
                grilla.DataSource = modProducto.cargarProductoTabla(operacion).Tables["rsProducto"];

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
            modSesion modSesion = new modSesion();

            frmCompra.lblCodigo.Text = Convert.ToString(grilla[0, grilla.CurrentRow.Index].Value);
            frmCompra.lblDescricion.Text = Convert.ToString(grilla[2, grilla.CurrentRow.Index].Value);
            frmCompra.txtCosto.Text = Convert.ToString(modSesion.mascaraCosto(grilla[3, grilla.CurrentRow.Index].Value));
            frmCompra.txtCostoMedio.Text = Convert.ToString(modSesion.mascaraCosto(grilla[4, grilla.CurrentRow.Index].Value));
            frmCompra.txtCostoReal.Text = Convert.ToString(modSesion.mascaraCosto(grilla[3, grilla.CurrentRow.Index].Value));
            frmCompra.txtStock.Text = Convert.ToString(modSesion.mascaraCantidad(grilla[5, grilla.CurrentRow.Index].Value));
            frmCompra.txtCodigoProducto.Text = Convert.ToString(grilla[0, grilla.CurrentRow.Index].Value);

            this.Close();
        }
    }
}
