using MySql.Data.MySqlClient;
using PVFP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria
{
    class Cls_reporte_ventas
    {
        public DataTable Impuestos(string fecha_ini, string Fecha_fin)
        {
            DataTable elemento = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            string comando = "select Sum(s.IVA) as iva from salida s where" +
                " fecha between @fech1 and  @fech2 ";
            MySqlCommand _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@fech1", fecha_ini);
            _comando.Parameters.AddWithValue("@fech2", Fecha_fin);            
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(elemento);
            conexion.Close();
            return elemento;
        }
        public DataTable Ganancia(string fecha_ini, string Fecha_fin)
        {
            DataTable elemento = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            string comando = "SELECT SUM(ROUND((sal_det.PrecioUnitario - prod.Precio_Costo), 2)) FROM salida sal" +
                " INNER JOIN salida_detalle sal_det INNER JOIN producto prod ON sal.Salida_ID = sal_det.Salida_ID " +
                "AND prod.Producto_ID = sal_det.Producto_ID where Fecha between @fech1 and @fech2";
            MySqlCommand _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@fech1", fecha_ini);
            _comando.Parameters.AddWithValue("@fech2", Fecha_fin);
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(elemento);
            conexion.Close();
            return elemento;
        }
    }
}
