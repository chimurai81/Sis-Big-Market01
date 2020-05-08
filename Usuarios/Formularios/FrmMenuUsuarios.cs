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
    public partial class FrmMenuUsuarios : Form
    {
        public FrmMenuUsuarios()
        {
            InitializeComponent();
        }

        private void chotaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            FrmNuevoRegistro frm = new FrmNuevoRegistro();
            frm.ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            FrmUsuariosRegistrados frm = new FrmUsuariosRegistrados();
            frm.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            FrmAjusteDeUsuarios frm = new FrmAjusteDeUsuarios();
            frm.ShowDialog();
        }
    }
}
