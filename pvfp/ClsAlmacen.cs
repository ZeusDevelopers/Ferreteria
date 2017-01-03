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
