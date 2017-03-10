using System;
using MySql.Data.MySqlClient;  //Referencia mysqldata
using System.IO;
using System.Windows.Forms;

namespace PVFP
{
    class ClsInicioSesion
    {
        #region Path        
        private static string pathfinal = "server=localhost; database=FerreteriaL1; Uid=root; pwd=1234;";
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
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar=null;
            try
            {
                conectar = new MySqlConnection(pathfinal);
                conectar.Open();                
            }
            catch (Exception )
            {
               
            }
            return conectar;
        }
        public string usuario,puesto;
        public bool bandera = false;
        private static string nombre = "";
        //se asigna el usuario desde el login 
        public static string Usuario
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public void Sesion(string usuario, string contraseña)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM `sesion` WHERE Usuario =@usu and Contraseña =@contra "), conexion);
            _comando.Parameters.AddWithValue("@usu", usuario);
            _comando.Parameters.AddWithValue("@contra", contraseña);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                bandera = true;
                usuario = _reader.GetString(1);
                contraseña = _reader.GetString(2);
                puesto = _reader.GetString(3);
            }
            _reader.Close();
            _comando = new MySqlCommand(String.Format("select nombre from empleados left join sesion on empleados.Sesion_ID = (select Sesion_ID from sesion where Usuario =@usu) where Usuario is Null ;"), conexion);
            _comando.Parameters.AddWithValue("@usu", usuario);
            _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                nombre = _reader.GetString(0);
            }            
            conexion.Close();
        }
        #endregion
    }
}
