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
    public partial class FrmNuevoRegistroCliente : Form
    {
        //handlder FORM 2
 
        public FrmNuevoRegistroCliente()
        {
            InitializeComponent();
          
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            if (txtnombre.Text == "NOMBRE")
            {
                txtnombre.Text = "";
            }
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                txtnombre.Text = "NOMBRE";
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {

            if (txtApellido.Text == "APELLIDO")
            {
                txtApellido.Text = "";
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {

            if (txtApellido.Text == "")
            {
                txtApellido.Text = "APELLIDO";
            }
        }

        private void txtCiNro_Enter(object sender, EventArgs e)
        {
            
            if (txtCiNro.Text == "C.I. NRO")
            {
                txtCiNro.Text = "";
            }
        }

        private void txtCiNro_Leave(object sender, EventArgs e)
        {

            if (txtCiNro.Text == "")
            {
                txtCiNro.Text = "C.I. NRO";
            }
        }

        private void txtRuc_Enter(object sender, EventArgs e)
        {
            if (txtRuc.Text == "RUC NRO")
            {
                txtRuc.Text = "";
            }
        }

        private void txtRuc_Leave(object sender, EventArgs e)
        {
            if (txtRuc.Text == "")
            {
                txtRuc.Text = "RUC NRO";
            }
        }

        private void txtNroTel_Enter(object sender, EventArgs e)
        {
            if (txtNroTel.Text == "TELEFONO")
            {
                txtNroTel.Text = "";
            }
        }

        private void txtNroTel_Leave(object sender, EventArgs e)
        {
            if (txtNroTel.Text == "")
            {
                txtNroTel.Text = "TELEFONO";
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "DIRECCION")
            {
                txtDireccion.Text = "";
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "DIRECCION";
            }
        }

        //METODO PARA INSERTAR NUEVO CLIENTE
        public void InsertarClientes()
        {
            string sql;
            //MySqlCommand comando;
            sql = "insert into db_clientes (Nombre, Apellido, CiNro, Ruc, NroTelef, FechaNac, Direccion) values (@Nombre, @Apellido,@CiNro,@Ruc,@NroTelef,@FechaNac,@Direccion)";
            MySqlCommand comando;
            try
            {
                modulo.AbrirConexion();
                comando = new MySqlCommand(sql, modulo.conexion);
                comando.Parameters.AddWithValue("@Nombre", txtnombre.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@Apellido", txtApellido.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@CiNro", Convert.ToInt32(txtCiNro.Text));
                comando.Parameters.AddWithValue("@RUC", txtRuc.Text.ToString());
                comando.Parameters.AddWithValue("@NroTelef", txtNroTel.Text.ToString());
                comando.Parameters.AddWithValue("@FechaNac", dtpFechaNac.Value);
                comando.Parameters.AddWithValue("@Direccion", txtDireccion.Text.ToUpperInvariant().ToString());
                comando.ExecuteNonQuery();
            
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            InsertarClientes();
            FrmMenuPrincipalParaClientes frm = new FrmMenuPrincipalParaClientes();
            frm.GetAll("");
        }

        private void FrmNuevoRegistroCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }


        private void FrmNuevoRegistroCliente_Load(object sender, EventArgs e)
        {
           
        }
    }
}
