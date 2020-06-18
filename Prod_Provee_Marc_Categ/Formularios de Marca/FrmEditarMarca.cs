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
    public partial class FrmEditarMarca : Form
    {
        public FrmEditarMarca()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void cargarRegistro(string id)
        {

            string sql;
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            DataSet resultado = new DataSet();

            try
            {
                modulo.AbrirConexion();
                sql = "select * from db_marca where id = " + id;
                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                consulta.Fill(resultado, "rsProveedor");
                //int n;
                //n = resultado.Tables["rsProveedor"].Rows.Count;
                //txtId.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["id"]);
                txtNombreProveedor.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Descripcion"]);
                string estado = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Estado"]);
                if(estado == "1")
                {
                    bunifuiOSSwitch1.Value = true;
                }
                else
                {
                    bunifuiOSSwitch1.Value = false;
                }
                modulo.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());

            }
        }
        public void EditarMarca(string id)
        {
            string sql;
            //MySqlCommand comando;
            sql = "update db_marca set Descripcion=@Descripcion, Estado=@Estado where id=@id";
            MySqlCommand comando;
            try
            {
                modulo.AbrirConexion();
                comando = new MySqlCommand(sql, modulo.conexion);

                comando.Parameters.AddWithValue("@Descripcion", txtNombreProveedor.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@Estado", estadosw);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FrmEditarMarca_Load(object sender, EventArgs e)
        {
            string valordeid = FrmMenuMarca.valor;
            cargarRegistro(valordeid);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            string id = FrmMenuMarca.valor;
            EditarMarca(id);
            FrmMenuMarca frm3 = (FrmMenuMarca)Owner;
            frm3.GetAll("");
            this.Close();
        }

        public static string estadosw;
        private void bunifuiOSSwitch1_Click(object sender, EventArgs e)
        {
            

        }

        private void bunifuiOSSwitch1_KeyUp(object sender, KeyEventArgs e)
        {

            if (bunifuiOSSwitch1.Value == true)
            {
                estadosw = "1";
            }
            else if (bunifuiOSSwitch1.Value == false)
            {
                estadosw = "0";

            }

        }
    }
}
