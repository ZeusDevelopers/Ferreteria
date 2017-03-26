using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  //Referencia mysqldata
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Data;

namespace PVFP
{
    class ClsEmpleados
    {
   
        #region MYSQL
    
        public void GuardarNuevoEmpleado(string usuario,string contra,int puesto,string nombre,string apellidos,string sexi,
        string direccion,string numero)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();//puesto=1 || puerto=0
            MySqlCommand _comando = new MySqlCommand("INSERT INTO Sesion VALUES(0,@Usuario,@Contra,@puesto)", conexion);
            //MySqlCommand _comando = new MySqlCommand("INSERT INTO empleados VALUES(1,@Nombre,@Apellidos,@sexo,@direccion,@numero,@Sesionid)", conexion);
            _comando.Parameters.AddWithValue("@usuario",usuario);
            _comando.Parameters.AddWithValue("@Contra", contra);
            _comando.Parameters.AddWithValue("@puesto",puesto);
            _comando.ExecuteNonQuery();
            _comando = new MySqlCommand("select Sesion_ID from sesion order by Sesion_Id desc limit 1 ", conexion);
            //select Sesion_ID from sesion order by Sesion_Id desc limit 1  
            MySqlDataReader _reader = _comando.ExecuteReader();
            int sesion_id=0;
            while (_reader.Read())
            {
                sesion_id = Int32.Parse(_reader["Sesion_ID"].ToString());
            }
            _reader.Close();
            _comando = new MySqlCommand("INSERT INTO empleados VALUES(0,@Nombre,@Apellidos,@sexo,@direccion,@numero,@Sesionid)", conexion);
            _comando.Parameters.AddWithValue("@nombre",nombre);
            _comando.Parameters.AddWithValue("@Apellidos",apellidos);
            _comando.Parameters.AddWithValue("@sexo",sexi);
            _comando.Parameters.AddWithValue("@direccion",direccion);
            _comando.Parameters.AddWithValue("@numero",numero);
            _comando.Parameters.AddWithValue("@Sesionid",sesion_id);
            _comando.ExecuteNonQuery();
            conexion.Close();
        }
        public DataTable consulta_usuario()
        {
            DataTable tb = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();//puesto=1 || puerto=0
            MySqlCommand _comando = new MySqlCommand("select Empleado_ID as 'No Empleado',Nombre,Apellido from empleados ;", conexion);            
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(tb);
            conexion.Close();
            return tb;
        }
        public DataTable consulta_dat_empleados(int num_id)
        {
            DataTable tb = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();//puesto=1 || puerto=0
            MySqlCommand _comando = new MySqlCommand("select Nombre,Apellido,Sexo,Direccion,Telefono,Usuario,Contraseña,Puesto from empleados inner join sesion on " +
                " empleados.Sesion_ID=sesion.Sesion_ID WHERE empleados.Empleado_ID = @numero" , conexion);
            _comando.Parameters.AddWithValue("@numero",num_id);
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(tb);
            conexion.Close();
            return tb;
        }
        public void borrar_empleados(int num_id)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();//puesto=1 || puerto=0
            MySqlCommand _comando = new MySqlCommand("delete elemento,ses from empleados as elemento inner join sesion as ses on   elemento.Sesion_ID=ses.Sesion_ID  " +
                "WHERE Empleado_ID= @numero", conexion);
            _comando.Parameters.AddWithValue("@numero", num_id);
            _comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void Editar(string usuario, string contra, int puesto, string nombre, string apellidos, string sexi,
        string direccion, string numero,int id)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();//puesto=1 || puerto=0                        
            MySqlCommand _comando = new MySqlCommand("update empleados as emp inner join sesion as ses on  emp.Sesion_ID=ses.Sesion_ID  " +
                "set emp.Nombre=@nombre, emp.Apellido=@pe,emp.Direccion=@dirc,emp.Sexo=@sex,emp.Telefono=@telf, " +
                "ses.Usuario=@usu,ses.Contraseña=@pass,ses.Puesto=@pues " +
                "where emp.Empleado_ID=@id;", conexion);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@pe", apellidos);
            _comando.Parameters.AddWithValue("@dirc", direccion);
            _comando.Parameters.AddWithValue("@sex", sexi);           
            _comando.Parameters.AddWithValue("@telf", numero);
            _comando.Parameters.AddWithValue("@usu", usuario);
            _comando.Parameters.AddWithValue("@pass", contra);
            _comando.Parameters.AddWithValue("@pues", puesto);
            _comando.Parameters.AddWithValue("@id", id);
            _comando.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion
    }
}

