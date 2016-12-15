using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  //Referencia mysqldata
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace PVFP
{
    class ClsEntrada
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
        string Id_Empleado = "";
        
        public DataTable Fill_Combo(string campo)
        {
            string query = "";
            if (campo=="Provedores")
            {
                query = "SELECT CONCAT(Proveedor_ID, " + " - " + ", Nombre) FROM proveedores";
            }
            else
            {
                query = "SELECT CONCAT(Producto_ID," + " - " + ", Nombre) FROM productos";
            }
            DataTable data = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(query, conexion);
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(data);
            return data;
        }
        ArrayList ArregloEntrada;
        public string Obtener_entradaId()
        {
            ArregloEntrada = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT  Entrada_ID FROM entrada"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloEntrada.Add(_reader["Entrada_ID"].ToString());
            }
            conexion.Close();
            return ArregloEntrada[ArregloEntrada.Count - 1].ToString();

        }
        public void agrEntrada(string Entrada_ID, string Proveedor_ID, string Fecha, 
            string TotalCompra,string Empleado_ID)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("INSERT INTO entrada (`Entrada_ID`, `Proveedor_ID`, `Fecha`, `TotalCompra`, `Empleado_ID`) VALUES" +
                " (" + Entrada_ID+","+Proveedor_ID + ",'" + Fecha + "'," + TotalCompra + "," + Empleado_ID + ")"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }
        public void agrEntrada_Detalle(string Entrada_ID, string Producto_ID,string Cantidad,
            string CostoCompra, string TotalProducto)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("INSERT INTO entrada_detalle (`Entrada_ID`, `Producto_ID`, `Cantidad`, `CostoCompra`, `TotalPoducto`) VALUES" +
                " (" + Entrada_ID + ","+Producto_ID + "," + Cantidad +"," + CostoCompra+ "," + TotalProducto+")"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }
        #endregion
    }
}
