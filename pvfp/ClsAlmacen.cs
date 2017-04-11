using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  //Referencia mysqldata
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace PVFP
{
    class ClsAlmacen
    {

        #region MYSQL  
        public ArrayList ArregloPro = new ArrayList();
        public ArrayList ArregloPiso = new ArrayList();
        public ArrayList ArregloAlma = new ArrayList();
        public void CargarAlmacen()
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM almacen"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloPiso.Add(_reader["A_Piso"].ToString());
                ArregloAlma.Add(_reader["A_Almacen"].ToString());
            }
            conexion.Close();
        }
        public void Cargarpro()
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM producto"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloPro.Add(_reader["Nombre"].ToString());
            }
            conexion.Close();
        }
        public string CantidadtablaAlmacen(string Producto_ID,string lugar)
        {
            ArrayList arrCantidadAlmacen = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT A_"+lugar+" as lugar from almacen WHERE Producto_ID="+Producto_ID), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                arrCantidadAlmacen.Add(_reader["lugar"].ToString());
            }
            conexion.Close();
            return arrCantidadAlmacen[0].ToString();

        }
        public void AgregarPAlmacen(string Almacen_ID, string Producto_ID, string CodigoBarras, 
            string Folio, string A_Piso, string A_Almacen, string Localizacion, string FechaCompra)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("INSERT INTO almacen (`Almacen_ID`, `Producto_ID`, `CodigoBarras`, `Folio`, `A_Piso`, `A_Almacen`, `Localizacion`, `FechaCompra`) VALUES" +
             "(@almacen_ID,@producto_ID, @codigoBarras, @folio, @a_Piso, @a_Almacen, @localizacion, @fechaCompra)"), conexion);

            _comando.Parameters.AddWithValue("@almacen_ID", Almacen_ID);
            _comando.Parameters.AddWithValue("@producto_ID", Producto_ID);
            _comando.Parameters.AddWithValue("@codigoBarras", CodigoBarras);
            _comando.Parameters.AddWithValue("@folio", Folio);
            _comando.Parameters.AddWithValue("@a_Piso", A_Piso);
            _comando.Parameters.AddWithValue("@a_Almacen", A_Almacen);
            _comando.Parameters.AddWithValue("@localizacion", Localizacion);
            _comando.Parameters.AddWithValue("@fechaCompra", FechaCompra);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }
        public void AgregarDesdeEntrada(string CalntidadAAlmacen, string Lugar,string Fecha,string Producto_ID)
        {
            //UPDATE `almacen` SET `A_Almacen`=2,`FechaCompra`='04-03-2017' WHERE Producto_ID=1
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("UPDATE `almacen` SET `"+Lugar+"`= @Cantidad,"+
                "`FechaCompra`= @fecha WHERE Producto_ID = @producto_ID"), conexion);


            _comando.Parameters.AddWithValue("@Cantidad", CalntidadAAlmacen);
            _comando.Parameters.AddWithValue("@fecha", Fecha);
            _comando.Parameters.AddWithValue("@producto_ID", Producto_ID);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }
        public ArrayList ArregloProducto = new ArrayList();
        public void CargarAlmacenProductos()
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT nombre FROM productos"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloProducto.Add(_reader["Nombre"].ToString());
            }
            conexion.Close();
        }


        public void Actualizar(string id, string almacen, string piso)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(String.Format("UPDATE almacen SET A_Piso = ?piso, A_Almacen = ?almacen WHERE Producto_ID = ?id"), conexion);
            //UPDATE `almacen` SET `Producto_ID`=[value-1],`CodigoBarras`=[value-2],`Folio`=[value-3],
            //`A_Piso`=[value-4],`A_Almacen`=[value-5],`Localizacion`=[value-6],`FechaCompra`=[value-7],`IVA`=[value-8] WHERE CodigoBarras='1' or Folio='2'

            comando.Parameters.AddWithValue("?piso", piso);
            comando.Parameters.AddWithValue("?almacen", almacen);
            comando.Parameters.AddWithValue("?id", id);
            MySqlDataReader reader = comando.ExecuteReader();
            conexion.Close();
        }

        public void Resta()
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM almacen"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloPiso.Add(_reader["A_Piso"].ToString());
                ArregloAlma.Add(_reader["A_Almacen"].ToString());
            }
            conexion.Close();
        }
        #endregion
    }
}
