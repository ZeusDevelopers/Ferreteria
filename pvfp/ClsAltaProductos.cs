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
       
        #region MYSQL
    
        public DataTable VerProducto(string fol)
        {
            DataTable tabla = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM Productos  WHERE Producto_ID = " + fol), conexion);
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
                "select `Producto_ID` as 'Id Producto',`Nombre`,`Marca`,`Categoria_ID` as Categoria,`CostoCompra` as Precio,`Tipo_ID` as Tipo, `Codigo`,`UM` as 'Unidad de medida', `CodigoBarras` as 'Codigo de Barras' from productos"
                ), conexion);

            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(tabla);
            conexion.Close();
            return tabla;
        }
        public void AgregarProducto(string Producto_ID, string Nombre, string Categoria_ID,
        string CostoCompra, string Tipo_ID, string Folio, string Descripcion, string UM,string marca, string codigobarras)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("INSERT INTO productos (`Producto_ID`, `Nombre`, `Categoria_ID`, `CostoCompra`, `Tipo_ID`, `Codigo`, `Descripcion`, `UM`,`Marca`,`CodigoBarras`) VALUES" +
             "(@productid,@nombre,@categoriaid,@costocompra,@tipoid,@codigo,@descripcion,@um,@marca,@codigobarras)"), conexion);            
            _comando.Parameters.AddWithValue("@productid", Producto_ID);
            _comando.Parameters.AddWithValue("@nombre", Nombre);
            _comando.Parameters.AddWithValue("@categoriaid", Categoria_ID);
            _comando.Parameters.AddWithValue("@costocompra", CostoCompra);
            _comando.Parameters.AddWithValue("@tipoid", Tipo_ID);
            _comando.Parameters.AddWithValue("@codigo", Folio);
            _comando.Parameters.AddWithValue("@descripcion", Descripcion);
            _comando.Parameters.AddWithValue("@um", UM);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@codigobarras", codigobarras);
            MySqlDataReader _reader =_comando.ExecuteReader();
            conexion.Close();
        }
        public ArrayList ArregloProductomod;
        public void CargarProductoMod()
        {
            ArregloProductomod = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
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
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
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
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("UPDATE `productos` SET  " +
                "`Nombre`='" + Nombre + "',`Categoria_ID`=" + Categoria_ID + "," +
                "`CostoCompra`=" + CostoCompra + ",`Tipo_ID`=" + Tipo_ID + ",`Codigo`='" + Folio + "'," +
                "`Descripcion`='" + Descripcion + "',`UM`='" + UM + "',`Marca`='"+marca + "',`CodigoBarras`='" + codigobarras+"' WHERE `Producto_ID`=" + Producto_ID), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }
        public void BorrarProducto(string producto)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("Delete From `productos`  WHERE Producto_ID = @producto"), conexion);
            _comando.Parameters.AddWithValue("@producto", producto);
            _comando.ExecuteReader();
            conexion.Close();
        }
        public string Obtener_productoId()
        {
            ArregloProductomod = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
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
