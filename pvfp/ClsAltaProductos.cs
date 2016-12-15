using System;
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
        #region Path
        string pathfinal = "server=127.0.0.1; database=FerreteriaL1; Uid=root; pwd=;";
        public void ConsultarPath()
        {
            string path = Application.StartupPath.ToString() + "\\Path\\Path.txt";
            FileStream ObjArchivo = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader ObjLectura = new StreamReader(ObjArchivo);
            pathfinal = ObjLectura.ReadToEnd();
            ObjLectura.Close();
            pathfinal = pathfinal.Remove(0, 5);
        }

        #endregion
        #region MYSQL
        public static MySqlConnection ObtenerConexion(string pathfinal)
        {
            MySqlConnection conectar = new MySqlConnection(pathfinal);
            conectar.Open();
            return conectar;
        }
        public DataTable VerProducto(string fol)
        {
            DataTable tabla = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM Productos  WHERE Producto_ID = " + fol), conexion);
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(tabla);
            conexion.Close();
            return tabla;
        }
        public DataTable VerTodosProductos()
        {
            DataTable tabla = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM Productos"), conexion);
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(tabla);
            conexion.Close();
            return tabla;
        }
        public void AgregarProducto(string Producto_ID, string Nombre, string Categoria_ID,
        string CostoCompra, string Tipo_ID, string Folio, string Descripcion, string UM,string marca, string codigobarras)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("INSERT INTO productos (`Producto_ID`, `Nombre`, `Categoria_ID`, `CostoCompra`, `Tipo_ID`, `Codigo`, `Descripcion`, `UM`,`Marca`,`CodigoBarras`) VALUES" +
                " (" + Producto_ID + ",'" + Nombre + "'," + Categoria_ID + "," + CostoCompra + "," + Tipo_ID + ",'" + Folio + "','" + Descripcion + "','" + UM + "','" + marca+ "','" +codigobarras+"')"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }
        public ArrayList ArregloProductomod;
        public void CargarProductoMod()
        {
            ArregloProductomod = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Nombre, Producto_ID FROM productos"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloProductomod.Add(_reader["Producto_ID"].ToString() + "," + _reader["Nombre"].ToString());
            }
            conexion.Close();
        }
        public ArrayList ArregloTipo = new ArrayList();
        public void CargarTipod()
        {
            ArregloProductomod = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Tipo_ID FROM tiposcargos"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloTipo.Add(_reader["Tipo_ID"].ToString());
            }
            conexion.Close();
        }
        public void EditarProducto(string Producto_ID, string Nombre, string Categoria_ID,
        string CostoCompra, string Tipo_ID, string Folio, string Descripcion, string UM,string marca,string codigobarras)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("UPDATE `productos` SET  " +
                "`Nombre`='" + Nombre + "',`Categoria_ID`=" + Categoria_ID + "," +
                "`CostoCompra`=" + CostoCompra + ",`Tipo_ID`=" + Tipo_ID + ",`Codigo`='" + Folio + "'," +
                "`Descripcion`='" + Descripcion + "',`UM`='" + UM + "',`Marca`='"+marca + "',`CodigoBarras`='" + codigobarras+"' WHERE `Producto_ID`=" + Producto_ID), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }
        public void BorrarProducto(string producto)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("Delete From `productos`  WHERE Producto_ID = " + producto), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }
        public string Obtener_productoId()
        {
            ArregloProductomod = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT  Producto_ID FROM productos"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloProductomod.Add(_reader["Producto_ID"].ToString());
            }
            conexion.Close();
            return ArregloProductomod[ArregloProductomod.Count - 1].ToString();

        }
        #endregion
    }
}
