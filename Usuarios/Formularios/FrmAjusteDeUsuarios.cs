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

namespace Usuarios.Formularios
{
    public partial class FrmAjusteDeUsuarios : Form
    {
        public FrmAjusteDeUsuarios()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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
        public void GetAll(string condicion)
        {
            string sql;
            MySqlDataAdapter consulta;
            DataSet resultado;
            sql = "select * from db_usuarios " + condicion;

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
        private void FrmAjusteDeUsuarios_Load(object sender, EventArgs e)
        {
            GetAll("");
        }

        FrmModificarUsuario frm;
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            frm = new FrmModificarUsuario();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            FrmModificarAcceso frm = new FrmModificarAcceso();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        FrmCambiarContraseña frm5;
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            frm5 = new FrmCambiarContraseña();
            AddOwnedForm(frm5);
            frm5.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MySqlCommand comando;
            string sql;
            string codigo;
            codigo = Convert.ToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            try
            {
                modulo.AbrirConexion();
                sql = "delete from db_usuarios where id=@id";
                comando = new MySqlCommand(sql, modulo.conexion);
                comando.Parameters.AddWithValue("@id", codigo);
                comando.ExecuteNonQuery();
                MensajesPersonalizados.MensajeDeCheck frm = new MensajesPersonalizados.MensajeDeCheck();
                frm.ShowDialog();
                GetAll("");

            }
            catch (MySqlException ex)
            {

            }
        }
    }
}
