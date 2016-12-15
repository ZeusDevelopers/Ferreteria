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
    class ClsTiposCargos
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
        public ArrayList ArregloPublico = new ArrayList();
        public ArrayList ArregloMayoreo = new ArrayList();
        public ArrayList ArregloSubdis = new ArrayList();
        public void CargarEmpleadosSesion()
        {
            ArregloPublico = new ArrayList();
            ArregloMayoreo = new ArrayList();
            ArregloSubdis = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM TiposCargos"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloPublico.Add(_reader["Publico"].ToString());
                ArregloMayoreo.Add(_reader["Mayoreo"].ToString());
                ArregloSubdis.Add(_reader["Subdis"].ToString());
            }
            conexion.Close();
        }
        public ArrayList Tipo_id()
        {
            ArrayList array_tipo = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT 	* FROM TiposCargos"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloPublico.Add(_reader["Publico"].ToString());
                ArregloMayoreo.Add(_reader["Mayoreo"].ToString());
                ArregloSubdis.Add(_reader["Subdis"].ToString());
            }
            conexion.Close();
            return array_tipo;
        }
        public ArrayList Tipo()
        {
            ArrayList array_tipo = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Tipo_ID FROM TiposCargos"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                array_tipo.Add(_reader["Tipo_ID"].ToString());
            
            }
            conexion.Close();
            return array_tipo;
        }
        #endregion
    }
}
