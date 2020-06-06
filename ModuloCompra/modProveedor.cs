using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ModuloCompra
{
     public class modProveedor
    {
        public DataSet cargarProveedor(string condicion)
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            string sql;
            DataSet resultado = new DataSet();
            try
            {
               Conexion_DB.AbrirConexion();
                sql = "select * from db_proveedores where id=" + condicion;
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(resultado, "rsProveedor");
                Conexion_DB.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al seleccionar Proveedor " + ex.Message);
            }

            return resultado;
        }
        public DataSet cargarProveedorTabla(string condicion)
        {
            MySqlDataAdapter consulta = new MySqlDataAdapter();
            string sql;
            DataSet resultado = new DataSet();
            try
            {
                Conexion_DB.AbrirConexion();
                sql = "select id as Codigo,RazonSocial as 'Razon Social',ruc as Ruc  from db_proveedores " + condicion;
                consulta = new MySqlDataAdapter(sql, Conexion_DB.conexion);
                consulta.Fill(resultado, "rsProveedor");
                Conexion_DB.CerraConexion();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al seleccionar Proveedor " + ex.Message);
            }
            return resultado;
        }
    }
}
