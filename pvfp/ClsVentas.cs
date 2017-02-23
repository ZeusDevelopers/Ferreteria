using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  //Referencia mysqldata
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace PVFP
{
    class ClsVentas
    {

        #region MYSQL
        public DataTable VerProducto(string productoid)
        {
            DataTable tabla = new DataTable();
            try
            {
                MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
                MySqlCommand _comando = new MySqlCommand(String.Format("SELECT `Codigodebarra`,`Nombre`,`Precio_Venta` FROM `producto` where `Codigodebarra`=" + productoid), conexion);
                MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
                _dataAdapter.Fill(tabla);
                conexion.Close();
            }
            catch (Exception  ex)
            {
                if (ex.Message.Contains("Unknown column"))
                    MessageBox.Show("No Existe Producto");
                else
                    MessageBox.Show(ex.Message);                 
            }
            return tabla;
        }
        #endregion
    }
}
