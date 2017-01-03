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
        
        #region MYSQL
       
        public ArrayList ArregloPublico = new ArrayList();
        public ArrayList ArregloMayoreo = new ArrayList();
        public ArrayList ArregloSubdis = new ArrayList();
        public void CargarEmpleadosSesion()
        {
            ArregloPublico = new ArrayList();
            ArregloMayoreo = new ArrayList();
            ArregloSubdis = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
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
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
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
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
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
