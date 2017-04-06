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
    class ClsPunto_deventa
    {
        public DataTable VerTodosProductos()
        {
            DataTable tabla = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format(
               "SELECT `Codigodebarra` as 'Codigo de Barras',`Nombre`,`Ganancia_Venta` as 'Precio de venta',A_Piso as 'Inventario',UM,producto.Producto_ID FROM `producto`" +
               "inner join  almacen on almacen.Producto_ID = producto.Producto_ID"
                ), conexion);
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(tabla);           
            conexion.Close();
            return tabla;
        }
    }
}
