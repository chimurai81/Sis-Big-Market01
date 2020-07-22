using MySql.Data.MySqlClient;
using Prod_Provee_Marc_Categ.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prod_Provee_Marc_Categ.Formularios_De_Proveedores
{
    public partial class FrmModificarConBoton : Form
    {
        public FrmModificarConBoton()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //para editar
        public void EditarProveedor(string id)
        {
            string sql;
            //MySqlCommand comando;
            sql = "update db_proveedores set RazonSocial=@RazonSocial, NroTelef=@NroTelef, Ruc=@Ruc, Direccion=@Direccion, Estado=@Estado where id=@id";
            MySqlCommand comando;
            try
            {
                modulo.AbrirConexion();
                comando = new MySqlCommand(sql, modulo.conexion);

                comando.Parameters.AddWithValue("@RazonSocial", txtNombreProveedor.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@NroTelef", txtNroTelef.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@Ruc", txtRuc.Text.ToString());
                comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text.ToString());
                comando.Parameters.AddWithValue("@Estado", estadosw);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cargarRegistro(string id)
        {

            string sql;
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            DataSet resultado = new DataSet();

            try
            {
                modulo.AbrirConexion();
                sql = "select * from db_proveedores where id= " + id;
                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                consulta.Fill(resultado, "rsProveedor");
                int n;
                n = resultado.Tables["rsProveedor"].Rows.Count;

                txtId.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["id"]);
                txtNombreProveedor.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["RazonSocial"]);
                txtRuc.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Ruc"]);
                txtNroTelef.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["NroTelef"]);
                txtDireccion.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Direccion"]);
                string estado = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Estado"]);

                if (estado == "1")
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
                MessageBox.Show(ex.Message);

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            EditarProveedor(id);
            FrmMenuProveedores frm3 = (FrmMenuProveedores)Owner;
            frm3.bunifuiOSSwitch1.Value = true;
            frm3.GetAll("");
            this.Close();
        }

        private void FrmModificarConBoton_Load(object sender, EventArgs e)
        {
            string valordeid = FrmMenuProveedores.valor;
            cargarRegistro(valordeid);
        }

        public static string estadosw;
        private void bunifuiOSSwitch1_Click(object sender, EventArgs e)
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
