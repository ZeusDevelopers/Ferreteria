using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;  //Referencia mysqldata
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace PVFP
{
    class ClsCategorias
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

        public ArrayList ArregloID = new ArrayList();
        public ArrayList ArregloDescripcion = new ArrayList();
        public void CargarCategorias()
        {
            ArregloID = new ArrayList();
            ArregloDescripcion = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM categorias"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloID.Add(_reader["Descripcion"].ToString());
            }
            conexion.Close();
        }

        public void AgregarCategorias(string categoria, string descripcion)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand comando = new MySqlCommand(String.Format("INSERT INTO categorias (`Categoria_ID`, `Descripcion`) VALUES (?categoria, ?descripcion)"), conexion);
            comando.Parameters.AddWithValue("?categoria", categoria);
            comando.Parameters.AddWithValue("?descripcion", descripcion);
            MySqlDataReader reader = comando.ExecuteReader();
            conexion.Close();
        }

        public void EditarCategorias(string categoria, string descripcion)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand comando = new MySqlCommand(String.Format("UPDATE categorias SET Descripcion = ?descripcion WHERE Categoria_ID = ?categoria"), conexion);
            comando.Parameters.AddWithValue("?categoria", categoria);
            comando.Parameters.AddWithValue("?descripcion", descripcion);
            MySqlDataReader reader = comando.ExecuteReader();
            conexion.Close();
        }

        public void BorrarCategorias(string categoria)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand comando = new MySqlCommand(String.Format("Delete From `categorias`  WHERE Categoria_ID = ?categoria"), conexion);
            comando.Parameters.AddWithValue("?categoria", categoria);
            MySqlDataReader reader = comando.ExecuteReader();
            conexion.Close();
        }
        #endregion
    }
}
