using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Reportes
{
    public partial class frmMenuReportes : Form
    {
        public frmMenuReportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frmInformeVenta frmVenta = new frmInformeVenta();
            frmVenta.ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            frmInformeCompra frmcompra = new frmInformeCompra();
            frmcompra.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            frmInformeCliente frmcliente = new frmInformeCliente();
            frmcliente.ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            frmInformeStock frmstock = new frmInformeStock();
            frmstock.ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            frmInformecotizacion frmcotizacion = new frmInformecotizacion();
            frmcotizacion.ShowDialog();
        }
    }
}
