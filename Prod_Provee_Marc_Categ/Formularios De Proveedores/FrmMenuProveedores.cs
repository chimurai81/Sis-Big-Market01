﻿using MySql.Data.MySqlClient;
using Prod_Provee_Marc_Categ.Formularios_De_Proveedores;
using System;
using System.Data;
using System.Windows.Forms;

namespace Prod_Provee_Marc_Categ.Formularios
{
    public partial class FrmMenuProveedores : Form
    {
        public FrmMenuProveedores()
        {
            InitializeComponent();
        }

        public void GetAll(string condicion)
        {
            string sql;
            MySqlDataAdapter consulta;
            DataSet resultado;
            sql = "select * from db_proveedores where Estado = 1 " + condicion;

            try
            {
                modulo.AbrirConexion();
                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                resultado = new DataSet();
                consulta.Fill(resultado, "rsresultado");
                dataGridView1.DataSource = resultado.Tables["rsresultado"];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GetAll2(string condicion)
        {
            string sql;
            MySqlDataAdapter consulta;
            DataSet resultado;
            sql = "select * from db_proveedores where Estado = 0 " + condicion;

            try
            {
                modulo.AbrirConexion();
                consulta = new MySqlDataAdapter(sql, modulo.conexion);
                resultado = new DataSet();
                consulta.Fill(resultado, "rsresultado");
                dataGridView1.DataSource = resultado.Tables["rsresultado"];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static string estadosw;
        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value == true)
            {
                GetAll("");
            }
            else
            {
                GetAll2("");
            }
            comboBox1.SelectedIndex = 0;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FrmAgregarNuevoProveedor frm = new FrmAgregarNuevoProveedor();
            frm.ShowDialog();
            GetAll("");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        FrmModificarSinBoton modifSinBtn;
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            modifSinBtn = new FrmModificarSinBoton();
            AddOwnedForm(modifSinBtn);
            modifSinBtn.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            FrmModificarConBoton frm10 = new FrmModificarConBoton();
            AddOwnedForm(frm10);
            frm10.ShowDialog();
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }
            valor = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string condicion;
            condicion = "";

            if (comboBox1.SelectedItem.ToString() == "PROVEEDOR")
            {
                condicion = " and RazonSocial like '%" + txtBuscar.Text.ToUpperInvariant() + "%'";
            }


            if (comboBox1.SelectedItem.ToString() == "RUC")
            {
                condicion = " and Ruc like '%" + txtBuscar.Text + "%'";
            }

            if (bunifuiOSSwitch1.Value == true)
            {
                GetAll(condicion);
            }
            else
            {
                GetAll2(condicion);
            }

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

        public static string valor;
        private void bunifuiOSSwitch1_Click(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value == true)
            {
                GetAll("");
            }
            else
            {
                GetAll2("");
            }
        }
    }
}
