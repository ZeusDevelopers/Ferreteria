using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;  //Referencia mysqldata
using System.IO;
using System.Windows.Forms;

namespace PVFP
{
    class ClsConexion
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

        public string usuario, contraseña, puesto;
        public bool bandera = false;
        public void Sesion(string usuario, string contraseña)
        {
            MySqlConnection conexion = ClsConexion.ObtenerConexion(pathfinal);
            MySqlCommand comando = new MySqlCommand(String.Format("SELECT * FROM `sesion` WHERE Usuario = ?usuario and Contraseña = ?contra"), conexion);
            comando.Parameters.AddWithValue("?usuario", usuario);
            comando.Parameters.AddWithValue("?contra", contraseña);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                bandera = true;
                usuario = reader.GetString(1);
                contraseña = reader.GetString(2);
                puesto = reader.GetString(3);
            }
            conexion.Close();
        }
        #endregion

    }
}
