using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMenuVistaPrincipal
{
    public class moduloConsultas
    {
        //stockminimo
        public DataSet CargarStockMinimoDeProducto(string condicion)
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            DataSet resultado = new DataSet();
            string sql;
            try
            {
                ModuloDBConexion.AbrirConexion();
                sql = "select CodigoProducto as 'Codigo' , Descripcion, Stock from db_productos where stock < 10" + condicion;
                consulta = new MySqlDataAdapter(sql, ModuloDBConexion.conexion);
                consulta.Fill(resultado, "rsProducto");
                ModuloDBConexion.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar Producto " + ex.Message);
            }
            return resultado;
        }
        //cantidad de clientes
        public DataSet CantidadClientes(string condicion)
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            DataSet resultado = new DataSet();
            string sql;
            try
            {
                ModuloDBConexion.AbrirConexion();
                sql = "select count(*) as 'cant' from db_clientes " + condicion;
                consulta = new MySqlDataAdapter(sql, ModuloDBConexion.conexion);
                consulta.Fill(resultado, "rsProducto");
                ModuloDBConexion.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar Cantidad Clientes " + ex.Message);
            }
            return resultado;
        }
        //cantidad de Usuarios
        public DataSet CantidadUsuarios(string condicion)
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            DataSet resultado = new DataSet();
            string sql;
            try
            {
                ModuloDBConexion.AbrirConexion();
                sql = "select count(*) as 'cant' from db_usuarios " + condicion;
                consulta = new MySqlDataAdapter(sql, ModuloDBConexion.conexion);
                consulta.Fill(resultado, "rsProducto");
                ModuloDBConexion.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar Cantidad Usuario " + ex.Message);
            }
            return resultado;
        }
        //cantidad de proveedores
        public DataSet CantidadProveedores(string condicion)
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            DataSet resultado = new DataSet();
            string sql;
            try
            {
                ModuloDBConexion.AbrirConexion();
                sql = "select count(*) as 'cant' from db_proveedores " + condicion;
                consulta = new MySqlDataAdapter(sql, ModuloDBConexion.conexion);
                consulta.Fill(resultado, "rsProducto");
                ModuloDBConexion.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar Cantidad proveedores " + ex.Message);
            }
            return resultado;
        }
        //cantidad de productos
        public DataSet CantidadProductos(string condicion)
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            DataSet resultado = new DataSet();
            string sql;
            try
            {
                ModuloDBConexion.AbrirConexion();
                sql = "select count(*) as 'cant' from db_productos " + condicion;
                consulta = new MySqlDataAdapter(sql, ModuloDBConexion.conexion);
                consulta.Fill(resultado, "rsProducto");
                ModuloDBConexion.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar Cantidad productos " + ex.Message);
            }
            return resultado;
        }
        //cantidad de marcas
        public DataSet CantidadMarcas(string condicion)
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            DataSet resultado = new DataSet();
            string sql;
            try
            {
                ModuloDBConexion.AbrirConexion();
                sql = "select count(*) as 'cant' from db_marca " + condicion;
                consulta = new MySqlDataAdapter(sql, ModuloDBConexion.conexion);
                consulta.Fill(resultado, "rsProducto");
                ModuloDBConexion.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar Cantidad productos " + ex.Message);
            }
            return resultado;
        }
    }
}
