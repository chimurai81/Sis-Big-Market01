using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MensajesPersonalizados
{
    public partial class MensajeDeCheck : Form
    {
        public MensajeDeCheck()
        {
            InitializeComponent();
        }

        private void MensajeDeCheck_Load(object sender, EventArgs e)
        {

            button1.Visible = false;
            bunifuTransition1.Show(button1);

            pictureBox1.Visible = false;
            bunifuTransition2.Show(pictureBox1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // pictureBox1.Visible = true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
