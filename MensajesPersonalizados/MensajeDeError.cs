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
    public partial class MensajeDeError : Form
    {
        public MensajeDeError()
        {
            InitializeComponent();
            
        }

        private void MensajeDeError_Load(object sender, EventArgs e)
        {
            //bunifuFormTransicion.ShowAsyc(this);
            labelerrro.Visible = false;
            
        }
        int c = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            while (c<3)
            {
                pictureBox1.Visible = false;
                bunifuTransition1.Show(pictureBox1);
                c++;
            }
        }

        private void btnreintentar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            labelerrro.Visible = true;
        }

    }
}
