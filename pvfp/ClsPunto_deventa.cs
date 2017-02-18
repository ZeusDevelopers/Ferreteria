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
               "SELECT`CodigoBarras` as 'Codigo',`Nombre` as 'Articulo', round(`CostoCompra`, 20) as 'Precio' FROM `productos`"
                ), conexion);
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(tabla);
            //tabla.Columns["Precio"].Convert(
    //val => DateTime.Parse(val.ToString()).ToString("dd/MMM/yyyy"));
           
            conexion.Close();
            return tabla;
        }
    }
}
