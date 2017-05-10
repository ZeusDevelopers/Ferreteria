using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  //Referencia mysqldata
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace PVFP
{
    class ClsEntrada
    {
    
        #region MYSQL
        //string Id_Empleado = "";
        
        public DataTable Fill_Combo(string campo)
        {
            string query = "";
            if (campo=="Provedores")
            {
                query = "SELECT CONCAT(Proveedor_ID," + "-" + ", Nombre) FROM proveedores";
            }
            else
            {
                query = "SELECT CONCAT(Producto_ID," + "-" + ", Nombre) FROM productos";
            }
            DataTable data = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(query, conexion);
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(data);
            return data;
        }
        ArrayList ArregloEntrada;
        public string Obtener_entradaId()
        {
            ArregloEntrada = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("select IFNULL(max(Entrada_ID),0)entradaid from entrada"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloEntrada.Add(_reader["entradaid"].ToString());
            }
            conexion.Close();
            return ArregloEntrada[ArregloEntrada.Count - 1].ToString();

        }
        public void agrEntrada(string NumFactura, string Proveedor_ID, string Fecha, 
            string TotalCompra,string Empleado_ID)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("INSERT INTO entrada (`NumFactura`, `Proveedor_ID`, `Fecha`, `TotalCompra`, `Empleado_ID`) VALUES" +
                " ('" + NumFactura+"',"+Proveedor_ID + ",'" + Fecha + "'," + TotalCompra + "," + Empleado_ID + ")"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }
        public void agrEntrada_Detalle(string NumFactura, string Producto_ID,string Cantidad,
            string CostoCompra, string TotalProducto)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("INSERT INTO entrada_detalle (`EntradaDetalle_ID`,`NumFactura`, `Producto_ID`, `Cantidad`, `CostoCompra`, `TotalProducto`) VALUES" +
                " (0,'" + NumFactura + "',"+Producto_ID + "," + Cantidad +"," + CostoCompra+ "," + TotalProducto+")"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }
        
        public DataTable VerTodasentradas()
        {
            
            DataTable tabla = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT NumFactura, proveedores.Nombre as Proveedor, DATE_FORMAT(FEcha, '%d-%m-%Y') AS Fecha, TotalCompra, "+
                " concat_ws(' ',empleados.Nombre, empleados.Apellido) as Empleado FROM `entrada` "+
                " inner join proveedores on proveedores.Proveedor_ID=entrada.Proveedor_ID INNER join "+
                " empleados on empleados.Empleado_ID=entrada.Empleado_ID order by Fecha DESC"
                ), conexion);

            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(tabla);
            conexion.Close();
            return tabla;
        }
        public ArrayList CargarEntradas()
        {
            ArrayList arrEntradas = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT NumFactura, proveedores.Nombre as Proveedor, DATE_FORMAT(FEcha, '%d-%m-%Y') AS Fecha, TotalCompra, " +
                " concat_ws(' ',empleados.Nombre, empleados.Apellido) as Empleado FROM `entrada` " +
                " inner join proveedores on proveedores.Proveedor_ID=entrada.Proveedor_ID INNER join " +
                " empleados on empleados.Empleado_ID=entrada.Empleado_ID order by Fecha DESC"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                arrEntradas.Add(_reader["NumFactura"].ToString() + "|" + _reader["Proveedor"].ToString() + "|" + 
                    _reader["Fecha"].ToString() + "|" + _reader["TotalCompra"].ToString() + "|" +
                    _reader["Empleado"].ToString());
            }
            conexion.Close();
            return arrEntradas;
        }
        public DataTable VerEntradaDetalle( string Factura)
        {

            DataTable tabla = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "Select producto.Nombre, Cantidad, CostoCompra as PrecioUnitario, "+
                " TotalProducto as Importe from entrada_detalle inner join producto "+
                " on producto.Producto_ID= entrada_detalle.Producto_ID WHERE NumFactura = '"+Factura+"'"
                ), conexion);

            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        #endregion
    }
}
