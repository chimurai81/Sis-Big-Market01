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

namespace Clientes.Formularios
{
    public partial class FrmEditarConBoton : Form
    {
        public FrmEditarConBoton()
        {
            InitializeComponent();
        }
        public void EditarClientes(string id)
        {
            string sql;
            //MySqlCommand comando;
            sql = "update db_clientes set Nombre=@Nombre, Apellido=@Apellido, CiNro=@CiNro, Ruc=@Ruc, NroTelef=@NroTelef, FechaNac=@FechaNac, Direccion=@Direccion where id_Clientes=@id_Clientes";
            MySqlCommand comando;
            try
            {
                modulo.AbrirConexion();
                comando = new MySqlCommand(sql, modulo.conexion);

                comando.Parameters.AddWithValue("@Nombre", txtnombre.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@Apellido", txtApellido.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@CiNro", Convert.ToInt32(txtCiNro.Text));
                comando.Parameters.AddWithValue("@Ruc", txtRuc.Text.ToString());
                comando.Parameters.AddWithValue("@NroTelef", txtNroTel.Text.ToString());
                comando.Parameters.AddWithValue("@FechaNac", dtpFechaNac.Value);
                comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@id_Clientes", id);
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
                sql = "select * from db_clientes where id_Clientes= " + id;
                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                consulta.Fill(resultado, "rsProveedor");
                int n;
                n = resultado.Tables["rsProveedor"].Rows.Count;

                txtId.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["id_Clientes"]);
                txtnombre.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Nombre"]);
                txtApellido.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Apellido"]);
                txtCiNro.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["CiNro"]);
                txtRuc.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Ruc"]);
                txtNroTel.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["NroTelef"]);
                dtpFechaNac.Value = Convert.ToDateTime(resultado.Tables["rsProveedor"].Rows[0]["FechaNac"]);
                txtDireccion.Text = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Direccion"]);

                modulo.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            EditarClientes(id);
            FrmMenuPrincipalParaClientes frm3 = (FrmMenuPrincipalParaClientes)Owner;
            frm3.GetAll("");
            this.Close();
        }

        private void FrmEditarConBoton_Load(object sender, EventArgs e)
        {
            string valordeid = FrmMenuPrincipalParaClientes.valor;
            cargarRegistro(valordeid);
            txtDireccion.Font = new Font("Arial", txtDireccion.Font.Size * 0.6f);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
