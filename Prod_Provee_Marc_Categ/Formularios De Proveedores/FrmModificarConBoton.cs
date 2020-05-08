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
            sql = "update db_proveedores set RazonSocial=@RazonSocial, NroTelef=@NroTelef, Ruc=@Ruc, Direccion=@Direccion where id=@id";
            MySqlCommand comando;
            try
            {
                modulo.AbrirConexion();
                comando = new MySqlCommand(sql, modulo.conexion);

                comando.Parameters.AddWithValue("@RazonSocial", txtNombreProveedor.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@NroTelef", txtNroTelef.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@Ruc", txtRuc.Text.ToString());
                comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text.ToString());
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
                txtRuc.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["NroTelef"]);
                txtNroTelef.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Ruc"]);
                txtDireccion.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Direccion"]);


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
            frm3.GetAll("");
            this.Close();
        }

        private void FrmModificarConBoton_Load(object sender, EventArgs e)
        {
            string valordeid = FrmMenuProveedores.valor;
            cargarRegistro(valordeid);
        }
    }
}
