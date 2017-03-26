using System;
using MySql.Data.MySqlClient;  //Referencia mysqldata
using System.IO;
using System.Windows.Forms;

namespace PVFP
{
    class ClsInicioSesion
    {
        #region Path        
        //private static string pathfinal = "server=localhost; database=FerreteriaL1; Uid=root; pwd=1234;";
        private static string pathfinal = "server=127.0.0.1; database=FerreteriaL1; Uid=root; pwd=;";
       // string pathfinal = "server=127.0.0.1; database=FerreteriaL1; Uid=root; pwd=;";
        public void ConsultarPah()
        {
           // string path = Application.StartupPath.ToString() + "\\Path\\Path.txt";
            //FileStream ObjArchivo = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            //StreamReader ObjLectura = new StreamReader(ObjArchivo);
            //pathfinal = ObjLectura.ReadToEnd();
            //ObjLectura.Close();
            // pathfinal = pathfinal.Remove(0, 5);
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
            MySqlCommand _comando = new MySqlCommand(String.Format("select empleados.Empleado_ID,sesion.Puesto from sesion inner join empleados on sesion.Sesion_ID = empleados.Sesion_ID" +
                " WHERE Usuario =@usu and Contraseña =@contra "), conexion);
            _comando.Parameters.AddWithValue("@usu", usuario);
            _comando.Parameters.AddWithValue("@contra", contraseña);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                bandera = true;                
                nombre = _reader["Empleado_ID"].ToString();                
                puesto = _reader["Puesto"].ToString();
            }
            _reader.Close();                    
            conexion.Close();
        }
        #endregion
    }
}
