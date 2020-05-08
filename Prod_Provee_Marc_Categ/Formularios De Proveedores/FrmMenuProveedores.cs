using MySql.Data.MySqlClient;
using Prod_Provee_Marc_Categ.Formularios_De_Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prod_Provee_Marc_Categ.Formularios
{
    public partial class FrmMenuProveedores : Form
    {
        public FrmMenuProveedores()
        {
            InitializeComponent();
        }

        public void GetAll(string condicion)
        {
            string sql;
            MySqlDataAdapter consulta;
            DataSet resultado;
            sql = "select * from db_proveedores " + condicion;

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

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            GetAll("");
            comboBox1.SelectedIndex = 0;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FrmAgregarNuevoProveedor frm = new FrmAgregarNuevoProveedor();
            frm.ShowDialog();
            GetAll("");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        FrmModificarSinBoton modifSinBtn;
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            modifSinBtn = new FrmModificarSinBoton();
            AddOwnedForm(modifSinBtn);
            modifSinBtn.ShowDialog();
        }

        FrmModificarConBoton frm10;
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            frm10 = new FrmModificarConBoton();
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

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            MySqlCommand comando;
            string sql;
            string codigo;
            codigo = Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            try
            {
                modulo.AbrirConexion();
                sql = "delete from db_proveedores where id=@id";
                comando = new MySqlCommand(sql, modulo.conexion);
                comando.Parameters.AddWithValue("@id", codigo);
                comando.ExecuteNonQuery();
                GetAll("");

            }
            catch (MySqlException ex)
            {

            }
            MensajesPersonalizados.MensajeDeCheck frm = new MensajesPersonalizados.MensajeDeCheck();
            frm.ShowDialog();
        }

        private void txtBuscar_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string condicion;
            condicion = "";

            if (comboBox1.SelectedItem.ToString() == "PROVEEDOR")
            {
                condicion = " where Nombre like '%" + txtBuscar.Text.ToUpperInvariant() + "%'";
            }


            if (comboBox1.SelectedItem.ToString() == "RUC")
            {
                condicion = " where Ruc like '%" + txtBuscar.Text + "%'";
            }

            GetAll(condicion);
        }
    }
}
