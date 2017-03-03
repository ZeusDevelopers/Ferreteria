﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  //Referencia mysqldata
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Collections;


namespace PVFP
{
    class ClsAltaProductos
    {

        #region MYSQL

        public DataTable VerProducto(string fol)
        {
            DataTable tabla = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM `producto` WHERE `Producto_ID` = " + fol), conexion);
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(tabla);
            conexion.Close();
            return tabla;
        }
        public DataTable VerTodosProductos()
        {
            DataTable tabla = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
                "SELECT `Codigodebarra`, `Folio`, `Nombre`," +
                "`Tipo_Cargo`, `UM`, `Precio_Costo`, `Precio_Venta`, `Precio_Mayoreo` FROM `producto`"
                ), conexion);

            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(tabla);
            conexion.Close();
            return tabla;
        }
        public void AgregarProducto(string Producto_ID, string Codigodebarra, string Folio, string Nombre,
            string Tipo_Cargo, string UM, string Precio_Costo, string Precio_Venta, string Precio_Mayoreo)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("INSERT INTO producto (`Producto_ID`, `Codigodebarra`, `Folio`, `Nombre`, `Tipo_Cargo`, `UM`, `Precio_Costo`, `Precio_Venta`, `Precio_Mayoreo`) VALUES" +
             "(@producto_ID,@codigodebarra,@folio,@nombre,@tipo_Cargo,@uM,@precio_Costo,@precio_Venta, @precio_Mayoreo)"), conexion);

            _comando.Parameters.AddWithValue("@producto_ID", Producto_ID);
            _comando.Parameters.AddWithValue("@codigodebarra", Codigodebarra);
            _comando.Parameters.AddWithValue("@folio", Folio);
            _comando.Parameters.AddWithValue("@nombre", Nombre);
            _comando.Parameters.AddWithValue("@tipo_Cargo", Tipo_Cargo);
            _comando.Parameters.AddWithValue("@uM", UM);
            _comando.Parameters.AddWithValue("@precio_Costo", Precio_Costo);
            _comando.Parameters.AddWithValue("@precio_Venta", Precio_Venta);
            _comando.Parameters.AddWithValue("@precio_Mayoreo", Precio_Mayoreo);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }
        public ArrayList ArregloProductomod;
        public void CargarProductoMod()
        {
            ArregloProductomod = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Nombre, Producto_ID FROM producto"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloProductomod.Add(_reader["Producto_ID"].ToString() + " - " + _reader["Nombre"].ToString());
            }
            conexion.Close();
        }
        public ArrayList ArregloTipo = new ArrayList();
        public void CargarTipod()
        {
            ArregloProductomod = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Tipo_ID FROM tiposcargos"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloTipo.Add(_reader["Tipo_ID"].ToString());
            }
            conexion.Close();
        }
        public void EditarProducto(string Producto_ID, string Codigodebarra, string Folio, string Nombre,
            string Tipo_Cargo, string UM, string Precio_Costo, string Precio_Venta, string Precio_Mayoreo)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("UPDATE `producto` SET  " +
                "`Codigodebarra`='" + Codigodebarra + "', `Folio`='" + Folio + "'," +
                "`Nombre`='" + Nombre + "', `Tipo_Cargo`='" + Tipo_Cargo + "', `UM`='" + UM + "'," +
                "`Precio_Costo`=" + Precio_Costo + ",`Precio_Venta`=" + Precio_Venta + ",`Precio_Mayoreo`=" + Precio_Mayoreo +
                " WHERE Producto_ID =" + Producto_ID + ""), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }
        public void BorrarProducto(string producto)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("Delete From `producto`  WHERE Producto_ID = @producto"), conexion);
            _comando.Parameters.AddWithValue("@producto", producto);
            _comando.ExecuteReader();
            conexion.Close();
        }
        public string Obtener_productoId()
        {
            ArregloProductomod = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT  IFNULL(max(Producto_ID),0)IDProd FROM producto"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloProductomod.Add(_reader["IDProd"].ToString());
            }
            conexion.Close();
            return ArregloProductomod[0].ToString();

        }
        #endregion
    }
}
