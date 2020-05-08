using MySql.Data.MySqlClient;
using Prod_Provee_Marc_Categ.Formularios_De_Productos;
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
    public partial class FrmMenuProductos : Form
    {
        public FrmMenuProductos()
        {
            InitializeComponent();
        }
        //obtener todos los productos
        public void GetAll(string condicion)
        {
            string sql;
            MySqlDataAdapter consulta;
            DataSet resultado;
            sql = "select  a.CodigoProducto, a.Descripcion, b.Descripcion As 'categoria', c.Descripcion As 'Marca', d.RazonSocial As 'Razon Social', a.Stock, a.StockMinimo, a.FechaDeVencimiento, a.Costo, a.CostoMedio, a.Iva, a.PrecioUnitario, a.PrecioMayorista, a.Tipo from db_productos a join db_categoria b ON a.Id_Categoria = b.id " +
              "join db_marca c On a.Id_Marca = c.id join db_proveedores d On a.Id_Proveedor = d.id" + condicion;

            try
            {
                modulo.AbrirConexion();
                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                resultado = new DataSet();
                consulta.Fill(resultado, "rsresultado");
                DataGridView1.DataSource = resultado.Tables["rsresultado"];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            //panelsuperior.Height = 30;
            //pictureBox2.Visible = true;
            GetAll("");
        }

  

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblNuevoProducto_MouseEnter(object sender, EventArgs e)
        {
            lblNuevoProducto.ForeColor = Color.LightCyan;
            lblNuevoProducto.Font = new Font("Century Gothic", 16, FontStyle.Regular, GraphicsUnit.Pixel);
        }

        private void lblNuevoProducto_MouseLeave(object sender, EventArgs e)
        {
            
            lblNuevoProducto.ForeColor = Color.White;
            lblNuevoProducto.Font = new Font("Century Gothic", 14, FontStyle.Bold, GraphicsUnit.Pixel);
        }

        private void lblModificarProducto_MouseEnter(object sender, EventArgs e)
        {
            lblModificarProducto.ForeColor = Color.LightCyan;
            lblModificarProducto.Font = new Font("Century Gothic", 16, FontStyle.Regular, GraphicsUnit.Pixel);
        }

        private void lblModificarProducto_MouseLeave(object sender, EventArgs e)
        {
            lblModificarProducto.ForeColor = Color.White;
            lblModificarProducto.Font = new Font("Century Gothic", 14, FontStyle.Bold, GraphicsUnit.Pixel);
        }

        private void lblEliminarProducto_MouseEnter(object sender, EventArgs e)
        {
            lblEliminarProducto.ForeColor = Color.LightCyan;
            lblEliminarProducto.Font = new Font("Century Gothic", 16, FontStyle.Regular, GraphicsUnit.Pixel);
        }

        private void lblEliminarProducto_MouseLeave(object sender, EventArgs e)
        {
            lblEliminarProducto.ForeColor = Color.White;
            lblEliminarProducto.Font = new Font("Century Gothic", 14, FontStyle.Bold, GraphicsUnit.Pixel);
        }

        private void bunifuCustomLabel1_MouseEnter(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.LightCyan;
            lblCerrar.Font = new Font("Century Gothic", 16, FontStyle.Regular, GraphicsUnit.Pixel);
        }

        private void bunifuCustomLabel1_MouseLeave(object sender, EventArgs e)
        {
            lblCerrar.ForeColor = Color.White;
            lblCerrar.Font = new Font("Century Gothic", 14, FontStyle.Bold, GraphicsUnit.Pixel);
        }


        private void txtBuscar_OnValueChanged(object sender, EventArgs e)
        {

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

        private void lblNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmNuevoProductos frm = new FrmNuevoProductos();
            frm.ShowDialog();
        }



        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
