using Clientes.Formularios;
using MySql.Data.MySqlClient;
using Sis_Supermercado_TallerV.RegistroUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes
{
    public partial class FrmMenuPrincipalParaClientes : Form
    {

        public FrmMenuPrincipalParaClientes()
        {
            InitializeComponent();
        }
        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //obtener todos los clientes
        public void GetAll(string condicion)
        {
            string sql;
            MySqlDataAdapter consulta;
            DataSet resultado;
            sql = "select * from db_clientes " + condicion;

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

        private void FrmRegistroCliente_Load(object sender, EventArgs e)
        {

            GetAll("");

        }

        //INSERTAR NUEVO CLIENTE
       
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FrmNuevoRegistroCliente form = new FrmNuevoRegistroCliente();
            form.ShowDialog();
            GetAll("");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        FrmEditarConBoton frm2;
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            frm2 = new FrmEditarConBoton();
            AddOwnedForm(frm2);
            frm2.ShowDialog();
        }

        /// <inicio>
        FrmEditarRegistroClientes frm;
        public void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            frm = new FrmEditarRegistroClientes();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }
        /// </fin pasar dato>
        /// 
 
        public static string valor;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow == null)
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
                sql = "delete from db_clientes where id_Clientes=@id_Clientes";
                comando = new MySqlCommand(sql, modulo.conexion);
                comando.Parameters.AddWithValue("@id_Clientes", codigo);
                comando.ExecuteNonQuery();
                GetAll("");

            }
            catch (MySqlException)
            {
                
            }
        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string operacion;
                operacion = "WHERE Nombre LIKE '%" + txtBuscar.Text + "%' OR Apellido LIKE '%" + txtBuscar.Text + "%' OR Ruc like '%" + txtBuscar.Text + "%'";
                GetAll(operacion);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if(txtBuscar.Text == "Buscar")
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
    }
}
