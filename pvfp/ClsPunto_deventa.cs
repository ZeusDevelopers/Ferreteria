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
        public DataTable VerTodosProductos(int tipo,string param,bool ad)
        {
            string conca = ad ? "SUM(`Ganancia_Mayoreo`+Precio_Costo)" : "SUM(`Ganancia_Venta`+Precio_Costo)";
            string comando = "SELECT `Codigodebarra` as 'Codigo de Barras',`Nombre`," + conca+" as 'Precio de venta', A_Piso as 'Inventario',UM,producto.Producto_ID FROM `producto` inner join  almacen on almacen.Producto_ID = producto.Producto_ID ";
            switch (tipo)
            {
                case 0:
                    comando += "where producto.Codigodebarra=@v";
                    break;
                case 1:
                    comando += "where producto.Folio=@v";
                    break;
                case 2:
                    comando += "where producto.Nombre like concat('%',@v,'%')";
                    break;
                default:
                    break;
            }
            DataTable tabla = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@v",param);
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(tabla);           
            conexion.Close();
            return tabla;
        }
    }
}
