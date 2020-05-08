using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Usuarios.Formularios;
using Clientes;
using Prod_Provee_Marc_Categ.Formularios;
using Prod_Provee_Marc_Categ.Formularios_de_Categoria;

namespace MenuPrincipal
{
    public partial class FrmMenuPrincipal3 : Form
    {
        public FrmMenuPrincipal3(string text)
        {
            InitializeComponent();
            //para evitar parpadeos en el formulario, y redimencionar el formulario.
            this.Text = string.Empty; //cadena de string vacia
            this.ControlBox = false; // desabiliamos la caja contenedora
            this.DoubleBuffered = true; //activamos el doble buffer para evitar parpadeos en el form.
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // para que se vea la barra inferior de windows
            lblUsuarioActivo.Text = text;
            CustomizeDesing();
        }
        //para el sub menu
        private void CustomizeDesing()
        {
              panelSubMenuProductos.Visible = false;
            //panelSubMenuCaja.Visible = false;
            //panelSubMenuReportes.Visible = false;
        }
        
        private void hideSubMenu()
        {
            if (panelSubMenuProductos.Visible == true)
                panelSubMenuProductos.Visible = false;
            //if (panelSubMenuCaja.Visible == true)
            //    panelSubMenuCaja.Visible = false;
            //if (panelSubMenuReportes.Visible == true)
            //    panelSubMenuReportes.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                transicionPanelBtnProductos.Show(subMenu);
                //subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        //finsubmenu

        // inicio
        //esto funciona para poder mover a todos los lados el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //fin


        private void ptbSideBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (SidebarWrapper.Width == 202)
            {
                SidebarWrapper.Visible = false;
                SidebarWrapper.Width = 58;
                bunifuTransition1.Show(SidebarWrapper);
            }
            else
            {
                SidebarWrapper.Visible = false;
                SidebarWrapper.Width = 202;
                bunifuTransition2.Show(SidebarWrapper);
            }
        }



        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
            
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PanelContenedor.Controls.Add(formulario);
                PanelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }


        private void PtbMinimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ptbmaxi_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            ptbmaxi.Visible = false;
            ptbRestore.Visible = true;
        }

        private void ptbRestore_Click_2(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ptbmaxi.Visible = true;
            ptbRestore.Visible = false;
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            lblTitulodeFormulario.Text = "VENTAS";
            hideSubMenu();//siempre al final de todo
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            lblTitulodeFormulario.Text = "INICIO";
            showSubMenu(panelSubMenuProductos);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmMenuProductos>();
            lblTitulodeFormulario.Text = "PRODUCTOS";
            hideSubMenu();//siempre al final de todo
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            AbrirFormulario<FrmMenuProveedores>();
            lblTitulodeFormulario.Text = "PROVEEDORES";
            hideSubMenu();//siempre al final de todo
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            lblTitulodeFormulario.Text = "DEVOLUCION";
            hideSubMenu();//siempre al final de todo
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmMenuPrincipalParaClientes>();
            lblTitulodeFormulario.Text = "CLIENTES";
            hideSubMenu();//siempre al final de todo
        }

        private void BtnCaja_Click(object sender, EventArgs e)
        {
            lblTitulodeFormulario.Text = "CAJA";
            hideSubMenu();//siempre al final de todo
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            lblTitulodeFormulario.Text = "COTIZACION";
            hideSubMenu();//siempre al final de todo
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            lblTitulodeFormulario.Text = "REPORTES";
            hideSubMenu();//siempre al final de todo
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmMenuUsuarios>();
            lblTitulodeFormulario.Text = "USUARIOS";
            hideSubMenu();//siempre al final de todo
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ptbSideBar_Click(object sender, EventArgs e)
        {

        }

        private void btnSubMenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmMenuCategorias>();
            lblTitulodeFormulario.Text = "CATEGORIA";
            hideSubMenu();//siempre al final de todo
        }
    }
}
