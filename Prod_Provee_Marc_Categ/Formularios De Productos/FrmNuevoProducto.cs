﻿using MensajesPersonalizados;
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

namespace Prod_Provee_Marc_Categ.Formularios_De_Productos
{
    public partial class FrmNuevoProductos : Form
    {
        public FrmNuevoProductos()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox7_OnValueChanged(object sender, EventArgs e)
        {

        }

        /*VERIFICACION DE USUARIO*/
        private int EstadoActivoVariable;
        private string TipoDeAcceso;
        public void RECUPERAR_ESTADOS_ACTIVOS_DE_LOS_USUARIOS(string condicion)
        {
            string sql;

            sql = "select * from db_usuarios where Activo = '1'" + condicion;


            MySqlCommand comando;
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            DataSet resultado = new DataSet();
            try
            {
                modulo.AbrirConexion();

                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                consulta.Fill(resultado, "rsProveedor");
                


                comando = new MySqlCommand(sql, modulo.conexion);
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {

                        TipoDeAcceso = Convert.ToString(resultado.Tables["rsProveedor"].Rows[0]["Accesos"]);
                        EstadoActivoVariable = Convert.ToInt32(resultado.Tables["rsProveedor"].Rows[0]["Activo"]);

                    }
                }

                else
                {
                    MensajeDeError show = new MensajeDeError();
                    show.ShowDialog();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmNuevoProducto_Load(object sender, EventArgs e)
        {
            RECUPERAR_ESTADOS_ACTIVOS_DE_LOS_USUARIOS("");

            if (TipoDeAcceso == "ADMINISTRADOR" && EstadoActivoVariable == 1)
            {
                txtCosto.Enabled = true;
                txtCostoMedio.Enabled = true;
                txtPrecioMayorista.Enabled = true;
                txtPrecioUnitario.Enabled = true;
            }
            else
            {
                txtCosto.Enabled = false;
                txtCostoMedio.Enabled = false;
                txtPrecioMayorista.Enabled = false;
                txtPrecioUnitario.Enabled = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnElegirImagenProducto_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpFechaNac_MouseHover(object sender, EventArgs e)
        {
           
            toolTip1.SetToolTip(dtpFechaVencimiento, "Fecha de Vencimiento");
        }

        private void dtpFechaNac_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Visible = false;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnElegirCategoria_Click(object sender, EventArgs e)
        {
            FrmBusqueda_Interna_Categoria frm10 = new FrmBusqueda_Interna_Categoria();
            AddOwnedForm(frm10);
            frm10.ShowDialog();
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
          
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


        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            ptbImagenProducto.Image = null;
        }

        private void txtProducto_Enter(object sender, EventArgs e)
        {
            if(txtCodigoProducto.Text == "Codigo")
            {
                txtCodigoProducto.Text = "";
            }
        }

        private void txtCodigoProducto_Leave(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text == "")
            {
                txtCodigoProducto.Text = "Codigo";
            }
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Descripcion")
            {
                txtDescripcion.Text = "";
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.Text = "Descripcion";
            }
        }

        private void txtCategoria_Enter(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "Categoria")
            {
                txtCategoria.Text = "";
            }
        }

        private void txtCategoria_Leave(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "")
            {
                txtCategoria.Text = "Categoria";
            }
        }

        private void bunifuMaterialTextbox9_Enter(object sender, EventArgs e)
        {
            if (txtCodigoDeBarra.Text == "Codigo De Barra")
            {
                txtCodigoDeBarra.Text = "";
            }
            
        }

        private void bunifuMaterialTextbox9_Leave(object sender, EventArgs e)
        {
            if (txtCodigoDeBarra.Text == "")
            {
                txtCodigoDeBarra.Text = "Codigo De Barra";
            }
        }

      
        private void txtCosto_Enter(object sender, EventArgs e)
        {
            if (txtCosto.Text == "Costo")
            {
                txtCosto.Text = "";
            }
        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            if (txtCosto.Text == "")
            {
                txtCosto.Text = "Costo";
            }
        }

        private void txtCostoMedio_Enter(object sender, EventArgs e)
        {
            if (txtCostoMedio.Text == "Costo Medio")
            {
                txtCostoMedio.Text = "";
            }
        }

        private void txtCostoMedio_Leave(object sender, EventArgs e)
        {
            if (txtCostoMedio.Text == "")
            {
                txtCostoMedio.Text = "Costo Medio";
            }
        }

        private void txtPrecioUnitario_Enter(object sender, EventArgs e)
        {
            if (txtPrecioUnitario.Text == "Precio Unitario")
            {
                txtPrecioUnitario.Text = "";
            }
            
        }

        private void txtPrecioUnitario_Leave(object sender, EventArgs e)
        {
            if (txtPrecioUnitario.Text == "")
            {
                txtPrecioUnitario.Text = "Precio Unitario";
            }
        }

        private void txtPrecioMayorista_Enter(object sender, EventArgs e)
        {
            if (txtPrecioMayorista.Text == "Precio Mayorista")
            {
                txtPrecioMayorista.Text = "";
            }
        }

        private void txtPrecioMayorista_Leave(object sender, EventArgs e)
        {
            if (txtPrecioMayorista.Text == "")
            {
                txtPrecioMayorista.Text = "Precio Mayorista";
            }
        }


        private void btnElegirMarca_Click(object sender, EventArgs e)
        {
            FrmBusqueda_Interna_Marca frmHijo = new FrmBusqueda_Interna_Marca(); //instanciar un objeto del formulario hijo
            AddOwnedForm(frmHijo);
            frmHijo.ShowDialog();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            FrmBusqueda_Interna_Proveedores frmHijo = new FrmBusqueda_Interna_Proveedores(); //instanciar un objeto del formulario hijo
            AddOwnedForm(frmHijo); //pasar las propiedades del formulario hijo al formulario padre.
            frmHijo.ShowDialog();
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

        //INGRESAR NUEVO PRODUCTO CON LA ENTIDAD DEL PROVEEDOR, MARCA, CATEGORI
        public void InsertarProducto()
        {
            string sql;
            //MySqlCommand comando;
            sql = "insert into db_productos (Descripcion, Costo, PrecioUnitario, FechaDeVencimiento, ImagenDelProducto, CodigoDeBarra, Id_Proveedor, Id_Marca, Id_Categoria, CodigoProducto, Tipo, Iva, PrecioMayorista, CostoMedio, id_usuario_Producto) values (@Descripcion, @Costo, @PrecioUnitario, @FechaDeVencimiento, @ImagenDelProducto, @CodigoDeBarra, @Id_Proveedor, @Id_Marca, @Id_Categoria, @CodigoProducto, @Tipo, @Iva, @PrecioMayorista, @CostoMedio, @id_usuario)";
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
                if(txtCodigoDeBarra.Text == "Codigo de Barra")
                {
                    txtCodigoDeBarra.Text = "0";
                }
                comando.Parameters.AddWithValue("@CodigoDeBarra", Convert.ToString(txtCodigoDeBarra.Text));
                comando.Parameters.AddWithValue("@Id_Proveedor", int.Parse(txtProveedor.Text));
                comando.Parameters.AddWithValue("@Id_Marca", int.Parse(txtMarca.Text));
                comando.Parameters.AddWithValue("@Id_Categoria", int.Parse(txtCategoria.Text));
                comando.Parameters.AddWithValue("@CodigoProducto", txtCodigoProducto.Text.ToString());
                comando.Parameters.AddWithValue("@Tipo", (cbxTipo.selectedValue.ToString()));
                comando.Parameters.AddWithValue("@Iva", (cbxIva.selectedValue.ToString()));
                comando.Parameters.AddWithValue("@PrecioMayorista", Convert.ToDecimal(txtPrecioMayorista.Text));
                comando.Parameters.AddWithValue("@CostoMedio", Convert.ToDecimal(txtCostoMedio.Text));
                comando.Parameters.AddWithValue("@id_usuario", 1);

                comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            cbxIva.Clear();
            cbxTipo.Clear();
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
           
            InsertarProducto();
            MensajeDeCheck mensajeDeCheck = new MensajeDeCheck();
            mensajeDeCheck.ShowDialog();
            limpiar();

        }
    }
}
