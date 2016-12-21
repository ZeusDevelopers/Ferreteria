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
    class ClsEmpleados
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

        public void GuardarNuevoEmpleado(int id, string nombre, string apellido, string sexo, string direccion, string telefono)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("INSERT INTO `empleados`(`Empleado_ID`, `Nombre`, `Apellido`, `Sexo`, `Direccion`, `Telefono`, `Sesion_ID`) VALUES ('" + id + "','" + nombre + "','" + apellido + "','" + sexo + "','" + direccion + "','" + telefono + "','" + id + "')"), conexion);
             _comando.ExecuteReader();
            conexion.Close();
        }

        public void GuardarNuevoEmpleadoSesion(int id, string usuario, string contraseña, string puesto)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("INSERT INTO `sesion`(`ID`, `Usuario`, `Contraseña`, `Puesto`) VALUES ('" + id + "','" + usuario + "','" + contraseña + "','" + puesto + "')"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }

        public void EditarEmpleado(int id, string nombre, string apellido, string sexo, string direccion, string telefono)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("INSERT INTO `empleados`(`Empleado_ID`, `Nombre`, `Apellido`, `Sexo`, `Direccion`, `Telefono`, `Sesion_ID`) VALUES ('" + id + "','" + nombre + "','" + apellido + "','" + sexo + "','" + direccion + "','" + telefono + "','" + id + "')"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }

        public void EditarEmpleadoSesion(int id, string usuario, string contraseña, string puesto)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("INSERT INTO `sesion`(`ID`, `Usuario`, `Contraseña`, `Puesto`) VALUES ('" + id + "','" + usuario + "','" + contraseña + "','" + puesto + "')"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }

        public void EliminarEmpleado(int id)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("DELETE FROM `empleados` WHERE Empleado_ID ='" + id + "'"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }
        public void EliminarSesion(int id)
        { 
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("DELETE FROM `sesion` WHERE Empleado_ID ='" + id + "'"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }

        public ArrayList ArregloUsu = new ArrayList();
        public ArrayList ArregloContra = new ArrayList();
        public ArrayList ArregloPuesto = new ArrayList();
        public void CargarEmpleadosSesion()
        {
            ArregloUsu = new ArrayList();
            ArregloContra = new ArrayList();
            ArregloPuesto = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM sesion"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloUsu.Add(_reader["Usuario"].ToString());
                ArregloContra.Add(_reader["Contraseña"].ToString());
                ArregloPuesto.Add(_reader["Puesto"].ToString());
            }
            conexion.Close();
        }
        public ArrayList ArregloNom = new ArrayList();
        public ArrayList ArregloApel = new ArrayList();
        public ArrayList ArregloSexo = new ArrayList();
        public ArrayList ArregloDire = new ArrayList();
        public ArrayList ArregloTel = new ArrayList();
        public void CargarEmpleadosDatos()
        {
            ArregloNom = new ArrayList();
            ArregloApel = new ArrayList();
            ArregloSexo = new ArrayList();
            ArregloDire = new ArrayList();
            ArregloTel = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM empleados"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloNom.Add(_reader["Nombre"].ToString());
                ArregloApel.Add(_reader["Apellido"].ToString());
                ArregloSexo.Add(_reader["Sexo"].ToString());
                ArregloDire.Add(_reader["Direccion"].ToString());
                ArregloTel.Add(_reader["Telefono"].ToString());
            }
            conexion.Close();
        }
        #endregion
    }
}
