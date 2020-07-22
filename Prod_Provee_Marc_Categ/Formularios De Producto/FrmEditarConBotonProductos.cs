using MensajesPersonalizados;
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

namespace Prod_Provee_Marc_Categ.Formularios_De_Productos
{
    public partial class FrmEditarConBotonProductos : Form
    {
        public FrmEditarConBotonProductos()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog AbriImagen = new OpenFileDialog();
            AbriImagen.InitialDirectory = @"C:\Users\Mauricio\Pictures";
            AbriImagen.Filter = "Archivos de Imagen(*.jpg, *.jpeg, *.jpe, *.png, *.jfif) | *.jpg; *.jpeg; *.jpe; *.png; *.jfif";
            AbriImagen.ShowDialog();

            if (AbriImagen.FileName != "")
            {
                ptbImagenProducto.Image = Image.FromFile(AbriImagen.FileName);
            }
            else
            {
                ptbImagenProducto.Image = null;

            }
        }
        //ESTE MODULO SIRVE PARA PODER CONVERTIR LAS IMAGENES EN BYTES.
        public static byte[] Image2Bytes(Image Img)
        {
            if (Img == null)
            {
                return null;
            }
            else
            {
                ImageConverter converter = new ImageConverter();
                return (byte[])converter.ConvertTo(Img, typeof(byte[]));
            }
        }
        public void EditatProducto(string id)
        {
            string sql;
            //MySqlCommand comando;
            sql = "update db_productos set Descripcion=@Descripcion, Costo=@Costo, PrecioUnitario=@PrecioUnitario, FechaDeVencimiento=@FechaDeVencimiento, ImagenDelProducto=@ImagenDelProducto, CodigoDeBarra=@CodigoDeBarra, Id_Proveedor=@Id_Proveedor, Id_Marca=@Id_Marca, Id_Categoria=@Id_Categoria, CodigoProducto=@CodigoProducto, Tipo=@Tipo, Iva=@Iva, PrecioMayorista=@PrecioMayorista, Estado=@Estado,CostoMedio=@CostoMedio, id_usuario_Producto=@id_usuario where id=@id";
            MySqlCommand comando;
            try
            {
                modulo.AbrirConexion();
                comando = new MySqlCommand(sql, modulo.conexion);
                comando.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text.ToUpperInvariant().ToString());
                comando.Parameters.AddWithValue("@Costo", Convert.ToDecimal(txtCosto.Text));
                comando.Parameters.AddWithValue("@PrecioUnitario", Convert.ToDecimal(txtPrecioUnitario.Text));
                comando.Parameters.AddWithValue("@FechaDeVencimiento", dtpFechaVencimiento.Value);
                comando.Parameters.AddWithValue("@ImagenDelProducto", Image2Bytes(ptbImagenProducto.Image));
                if (txtCodigoDeBarra.Text == "Codigo de Barra")
                {
                    txtCodigoDeBarra.Text = "0";
                }
                comando.Parameters.AddWithValue("@CodigoDeBarra", Convert.ToString(txtCodigoDeBarra.Text));
                comando.Parameters.AddWithValue("@Id_Proveedor", int.Parse(txtProveedor.Text));
                comando.Parameters.AddWithValue("@Id_Marca", int.Parse(txtMarca.Text));
                comando.Parameters.AddWithValue("@Id_Categoria", int.Parse(txtCategoria.Text));
                comando.Parameters.AddWithValue("@CodigoProducto", txtCodigoProducto.Text.ToString());
                comando.Parameters.AddWithValue("@Tipo", (cbxTipo.SelectedItem.ToString()));
                comando.Parameters.AddWithValue("@Iva", (cbxIva.SelectedItem.ToString()));
                comando.Parameters.AddWithValue("@PrecioMayorista", Convert.ToDecimal(txtPrecioMayorista.Text));
                //estado aqui
                comando.Parameters.AddWithValue("@Estado", switchCambiado.ToString());

                comando.Parameters.AddWithValue("@CostoMedio", Convert.ToDecimal(txtCostoMedio.Text));
                ModUsuarioActivo modUsuarioActivo = new ModUsuarioActivo();
                comando.Parameters.AddWithValue("@id_usuario", Convert.ToString(modUsuarioActivo.VerificarIdUsuarioActivo()));
                comando.Parameters.AddWithValue("@id", id);

                comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //cargar registros
        public void cargarRegistro(string id)
        {

            string sql;
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            DataSet resultado = new DataSet();

            try
            {
                modulo.AbrirConexion();
                sql = "select * from db_productos where id= " + id;
                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                consulta.Fill(resultado, "rsproducto");
                int n;
                n = resultado.Tables["rsproducto"].Rows.Count;

                txtCodigoProducto.Text = Convert.ToString(resultado.Tables["rsproducto"].Rows[0]["CodigoProducto"]);
                txtDescripcion.Text = Convert.ToString(resultado.Tables["rsproducto"].Rows[0]["Descripcion"]);
                txtCategoria.Text = Convert.ToString(resultado.Tables["rsproducto"].Rows[0]["Id_Categoria"]);
                txtMarca.Text = Convert.ToString(resultado.Tables["rsproducto"].Rows[0]["Id_Marca"]);
                txtProveedor.Text = Convert.ToString(resultado.Tables["rsproducto"].Rows[0]["Id_Proveedor"]);
                txtCodigoDeBarra.Text = Convert.ToString(resultado.Tables["rsproducto"].Rows[0]["CodigoDeBarra"]);
                dtpFechaVencimiento.Value = Convert.ToDateTime(resultado.Tables["rsproducto"].Rows[0]["FechaDeVencimiento"]);
                txtCosto.Text = Convert.ToString(resultado.Tables["rsproducto"].Rows[0]["Costo"]);
                txtCostoMedio.Text = Convert.ToString(resultado.Tables["rsproducto"].Rows[0]["Costomedio"]);
                txtPrecioUnitario.Text = Convert.ToString(resultado.Tables["rsproducto"].Rows[0]["PrecioUnitario"]);
                txtPrecioMayorista.Text = Convert.ToString(resultado.Tables["rsproducto"].Rows[0]["PrecioMayorista"]);
                char valorEstado= Convert.ToChar(resultado.Tables["rsproducto"].Rows[0]["Estado"]);
                if(valorEstado == 1)
                {
                    bunifuiOSSwitch1.Value = true;
                }
                else
                {
                    bunifuiOSSwitch1.Value = false;
                }
                cbxIva.SelectedItem  = Convert.ToString(resultado.Tables["rsproducto"].Rows[0]["Iva"]);
                cbxTipo.SelectedItem = Convert.ToString(resultado.Tables["rsproducto"].Rows[0]["Tipo"]);



                modulo.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void FrmEditarConBotonProductos_Load(object sender, EventArgs e)
        {
            bunifuiOSSwitch1.Value = true;
            string valordeid = FrmMenuProductos.valor33;
            cargarRegistro(valordeid);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            string valordeid = FrmMenuProductos.valor33;

            string id = valordeid;
            EditatProducto(id);
            MensajeDeCheck mensajeDeCheck = new MensajeDeCheck("REGISTRO EXITOSO");
            mensajeDeCheck.ShowDialog();
            limpiar();
            FrmMenuProductos frm3 = (FrmMenuProductos)Owner;
            frm3.bunifuiOSSwitch1.Value = true;
            frm3.GetAll("");
            this.Close();

        }
        public void limpiar()
        {
            txtCodigoProducto.Text = "Codigo";
            txtDescripcion.Text = "Descripcion";
            txtCategoria.Text = "Categoria";
            txtCategoria2.Text = "";
            txtMarca.Text = "Marca";
            txtmarca2.Text = "";
            txtProveedor.Text = "Proveedor";
            txtProveedor2.Text = "";
            txtCodigoDeBarra.Text = "Codigo de Barra";
            dtpFechaVencimiento.Value = DateTime.Today;
            txtCosto.Text = "Costo";
            txtCostoMedio.Text = "Costo Medio";
            ptbImagenProducto.Image = null;
            txtPrecioUnitario.Text = "Precio Unitario";
            txtPrecioMayorista.Text = "Precio Mayorista";
            cbxIva.SelectedIndex = -1;
            cbxTipo.SelectedIndex = -1;
        }
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnElegirCategoria_Click(object sender, EventArgs e)
        {
            FrmBusqueda_Interna_EditarCategoria frm10 = new FrmBusqueda_Interna_EditarCategoria();
            AddOwnedForm(frm10);
            frm10.ShowDialog();
        }

        private void btnElegirMarca_Click(object sender, EventArgs e)
        {
            FrmBusqueda_Interna_EditarMarca frm10 = new FrmBusqueda_Interna_EditarMarca();
            AddOwnedForm(frm10);
            frm10.ShowDialog();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            FrmBusqueda_Interna_EditarProveedor frm10 = new FrmBusqueda_Interna_EditarProveedor();
            AddOwnedForm(frm10);
            frm10.ShowDialog();
        }

        public char switchCambiado;
        private void bunifuiOSSwitch1_Click(object sender, EventArgs e)
        {
            if(bunifuiOSSwitch1.Value == true)
            {
                switchCambiado = '1';
            }
            else
            {
                switchCambiado = '0';
            }
        }

        private void FrmEditarConBotonProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMenuProductos frmMenuProductos = new FrmMenuProductos();
            frmMenuProductos.bunifuiOSSwitch1.Value = false;
        }
    }
}
