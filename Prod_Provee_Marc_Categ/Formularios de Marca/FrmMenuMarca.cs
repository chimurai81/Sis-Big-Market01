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

namespace Prod_Provee_Marc_Categ.Formularios_de_Marca
{
    public partial class FrmMenuMarca : Form
    {
        public FrmMenuMarca()
        {
            InitializeComponent();
        }
        public void GetAll(string condicion)
        {
            string sql;
            MySqlDataAdapter consulta;
            DataSet resultado;
            sql = "select * from db_marca" + condicion;

            try
            {
                modulo.AbrirConexion();
                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                resultado = new DataSet();
                consulta.Fill(resultado, "rsresultado");
                dataGridView1.DataSource = resultado.Tables["rsresultado"];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FrmMenuMarca_Load(object sender, EventArgs e)
        {
            GetAll("");
            comboBox1.SelectedIndex = 0;
        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            FrmAgregarNuevaMarca frm = new FrmAgregarNuevaMarca();
            frm.ShowDialog();
            GetAll("");
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            FrmEditarMarca frm10 = new FrmEditarMarca();
            AddOwnedForm(frm10);
            frm10.ShowDialog();
        }
        public static string valor;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }
            valor = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar")
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

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string condicion;
            condicion = "";

            if (comboBox1.SelectedItem.ToString() == "ID")
            {
                condicion = " where id like '%" + txtBuscar.Text + "%'";
            }
            if (comboBox1.SelectedItem.ToString() == "DESCRIPCION")
            {
                condicion = " where Descripcion like '%" + txtBuscar.Text.ToUpperInvariant() + "%'";
            }

            GetAll(condicion);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
