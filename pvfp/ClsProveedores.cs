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
    class ClsProveedores
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

        public ArrayList ArregloNombre = new ArrayList();
        public void CargarProveedoresNombre()
        {
            ArregloNombre = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM proveedores"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloNombre.Add(_reader["Nombre"].ToString());
            }
            conexion.Close();
        }
        public ArrayList ArgProveedor = new ArrayList();
        public void CargarProveedor()
        {
            ArgProveedor = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Proveedor_ID, Nombre FROM proveedores"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArgProveedor.Add(_reader["Proveedor_ID"].ToString() + "," + _reader["Nombre"].ToString());
            }
            conexion.Close();
        }
        public ArrayList ArregloNom = new ArrayList();
        public ArrayList ArregloTel = new ArrayList();
        public ArrayList ArregloCor = new ArrayList();
        public ArrayList ArregloDir = new ArrayList();
        public ArrayList ArregloBan = new ArrayList();
        public ArrayList ArregloCue = new ArrayList();
        public ArrayList ArregloDes = new ArrayList();
        public void CargarProveedores()
        {
            ArregloNombre = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM proveedores"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloNom.Add(_reader["Nombre"].ToString());
                ArregloTel.Add(_reader["Telefono"].ToString());
                ArregloCor.Add(_reader["Correo"].ToString());
                ArregloDir.Add(_reader["Direccion"].ToString());
                ArregloBan.Add(_reader["Banco"].ToString());
                ArregloCue.Add(_reader["Cuenta"].ToString());
                ArregloDes.Add(_reader["Descripcion"].ToString());
            }
            conexion.Close();
        }

        public void AgregarProveedor(int proveedor_ID, string nombre, string telefono, string correo, string direccion, string descripcion, string banco, string cuenta)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("INSERT INTO `Proveedores`(`Proveedor_ID`, `Nombre`, `Telefono`, `Correo`, `Direccion`, `Banco`, `Cuenta`, `Descripcion`) VALUES ('?proveedorid, ?nombre, ?telefono, ?correo, ?direccion, ?banco, ?cuenta, ?descripcion)"), conexion);
            _comando.Parameters.AddWithValue("?nombre", nombre);
            _comando.Parameters.AddWithValue("?telefono", telefono);
            _comando.Parameters.AddWithValue("?correo", correo);
            _comando.Parameters.AddWithValue("?direccion", direccion);
            _comando.Parameters.AddWithValue("?banco", banco);
            _comando.Parameters.AddWithValue("?cuenta", cuenta);
            _comando.Parameters.AddWithValue("?descripcion", descripcion);
            _comando.Parameters.AddWithValue("?proveedorid", proveedor_ID);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }

        public void EditarProveedores(string proveedorid, string nombre, string telefono, string correo, string direccion, string banco, string cuenta, string descripcion)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("UPDATE `proveedores` SET `Nombre`=' ?nombre ',`Telefono`=' ?telefono ',`Correo`=' ?correo ',`Direccion`=' ?direccion ',`Banco`=' ?banco ',`Cuenta`=' ?cuenta ',`Descripcion`=' ?descripcion ' WHERE Proveedor_ID = ?proveedorid"), conexion);
            _comando.Parameters.AddWithValue("?nombre", nombre);
            _comando.Parameters.AddWithValue("?telefono", telefono);
            _comando.Parameters.AddWithValue("?correo", correo);
            _comando.Parameters.AddWithValue("?direccion", direccion);
            _comando.Parameters.AddWithValue("?banco", banco);
            _comando.Parameters.AddWithValue("?cuenta", cuenta);
            _comando.Parameters.AddWithValue("?descripcion", descripcion);
            _comando.Parameters.AddWithValue("?proveedorid", proveedorid);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }

        public void BorrarProveedor(string proveedorid)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("Delete From `proveedores`  WHERE Proveedor_ID = ?proveedorid"), conexion);
            _comando.Parameters.AddWithValue("?proveedorid", proveedorid);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }
        #endregion
    }
}
