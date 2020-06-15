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


        private void txtCodigoProducto_Leave(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text == "")
            {
                txtCodigoProducto.Text = "Codigo";
            }
        }

        private void txtCodigoProducto_Enter(object sender, EventArgs e)
        {
            if (txtCodigoProducto.Text == "Codigo")
            {
                txtCodigoProducto.Text = "";
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

        private void txtCodigoDeBarra_Leave(object sender, EventArgs e)
        {
            if (txtCodigoDeBarra.Text == "")
            {
                txtCodigoDeBarra.Text = "Codigo De Barra";
            }
        }

        private void txtCodigoDeBarra_Enter(object sender, EventArgs e)
        {
            if (txtCodigoDeBarra.Text == "Codigo De Barra")
            {
                txtCodigoDeBarra.Text = "";
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
    }
}
