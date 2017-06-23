using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVFP
{
    class Cls_Consulta
    {
        DataTable elemento;
        public DataTable fecha_intervalo(string fecha_ini,string Fecha_fin, int intervalo,int id_empl)
        {
            elemento = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            string comando = id_empl == -1 ?
            "select Salida_ID as 'No.Venta',Fecha,Subtotal,IVA,TotalVenta from salida where Fecha between @fech1 and @fech2 limit 10 offset @terv"
            : "select Salida_ID as 'No.Venta',Fecha,Subtotal,IVA,TotalVenta from salida where Fecha between @fech1 and @fech2 and Empleado_ID=@emp limit 10 offset @terv";
            MySqlCommand _comando = new MySqlCommand(comando, conexion);                       
            _comando.Parameters.AddWithValue("@fech1",fecha_ini);
            _comando.Parameters.AddWithValue("@fech2", Fecha_fin);
            _comando.Parameters.AddWithValue("@terv", intervalo);
            if (id_empl != -1) { _comando.Parameters.AddWithValue("@emp", id_empl); }
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(elemento);
            conexion.Close();
            return elemento;
        }
        public DataTable fecha_intervalo(string fecha_ini, int intervalo, int id_empl)
        {
            elemento = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            string comando = id_empl == -1 ?
                "select Salida_ID as 'No.Venta',Fecha,Subtotal,IVA,TotalVenta from salida where Fecha= @fech1  limit 10 offset @terv":
                "select Salida_ID as 'No.Venta',Fecha,Subtotal,IVA,TotalVenta from salida where Fecha= @fech1 and Empleado_ID=@emp limit 10 offset @terv";
            MySqlCommand _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@fech1", fecha_ini);            
            _comando.Parameters.AddWithValue("@terv", intervalo);
            if (id_empl != -1) { _comando.Parameters.AddWithValue("@emp", id_empl); }
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(elemento);
            conexion.Close();
            return elemento;
        }
        public int intervalo(string fecha_ini, string Fecha_fin, int id_empl)
        {
            int numero = 0;
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            string comando = id_empl == -1 ?
                "select count(Salida_ID) from salida where Fecha between @fech1 and @fech2 " :
                "select count(Salida_ID) from salida where Fecha between @fech1 and @fech2 and Empleado_ID=@emp";
            MySqlCommand _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@fech1", fecha_ini);
            _comando.Parameters.AddWithValue("@fech2", Fecha_fin);
            if (id_empl != -1) { _comando.Parameters.AddWithValue("@emp", id_empl); }
            MySqlDataReader lee = _comando.ExecuteReader();
            while (lee.Read())
            {
                numero = Int32.Parse(lee["count(Salida_ID)"].ToString());
            }
            return numero;
        }
        public double corte_coj(string fecha_ini, string Fecha_fin, int id_empl)
        {
            //select round(sum(salida.TotalVenta),2) as Ventas from salida where Fecha between
            double numero = 0;
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            string comando = id_empl == -1 ?
                "select round(sum(salida.TotalVenta),2) as Ventas from salida where Fecha between  @fech1 and @fech2 " :
                "select round(sum(salida.TotalVenta),2) as Ventas from salida where Fecha between @fech1 and @fech2 and Empleado_ID=@emp";
            MySqlCommand _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@fech1", fecha_ini);
            _comando.Parameters.AddWithValue("@fech2", Fecha_fin);
            if (id_empl != -1) { _comando.Parameters.AddWithValue("@emp", id_empl); }
            MySqlDataReader lee = _comando.ExecuteReader();
            while (lee.Read())
            {
                string num = lee["Ventas"].ToString();
                numero =num!="" ? Double.Parse(num):0.0d;
            }
            return id_empl!=-1 ? numero : 0;
        }             
        public int intervalo(string fecha_ini, int id_empl)
        {
            int numero = 0;
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            string comando = id_empl == -1 ?
                "select count(Salida_ID) from salida where Fecha=@fech1  " :
                "select count(Salida_ID) from salida where Fecha=@fech1 and Empleado_ID=@emp";
            MySqlCommand _comando = new MySqlCommand(comando , conexion);
            _comando.Parameters.AddWithValue("@fech1", fecha_ini);
            if (id_empl != -1) { _comando.Parameters.AddWithValue("@emp", id_empl); }
            MySqlDataReader lee = _comando.ExecuteReader();
            while (lee.Read())
            {
                numero = Int32.Parse(lee["count(Salida_ID)"].ToString());
            }
            return numero;
        }
        public int intervalo(int id)
        {
            int numero = 0;
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            string comando = "select count(Salida_ID)from salida where Empleado_Id=@id";            
            MySqlCommand _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@id",id);
            MySqlDataReader lee = _comando.ExecuteReader();
            while (lee.Read())
            {
                numero = Int32.Parse(lee["count(Salida_ID)"].ToString());
            }
            return numero;
        }
        public DataTable num_venta(int id_venta)
        {
             elemento = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand("select Salida_ID as 'No.Venta',Fecha,Subtotal,IVA,TotalVenta from salida where Salida_ID= " +
                "@id_venta  ", conexion);
            _comando.Parameters.AddWithValue("@Id_venta",id_venta);            
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(elemento);
            conexion.Close();
            return elemento;
        }
        public DataTable empleados()
        {
            elemento = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand("select concat(Empleado_ID,' - ',Nombre) as 'Empleados' from empleados", conexion);            
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(elemento);
            conexion.Close();
            return elemento;
        }
        public DataTable ventas(int id)
        {
            elemento = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand("select Nombre,Cantidad,PrecioUnitario from salida_detalle left join producto on salida_detalle.Producto_ID = producto.Producto_ID" +
                " where Salida_ID = @m", conexion);
            _comando.Parameters.AddWithValue("@m",id);
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(elemento);
            conexion.Close();
            return elemento;
        }
        public string empledado(int id)
        {
            string elemento = "";
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand("  select Nombre  from salida inner join empleados on salida.Empleado_ID=empleados.Empleado_ID where Salida_ID= @m", conexion);
            _comando.Parameters.AddWithValue("@m", id);
            MySqlDataReader lee = _comando.ExecuteReader();
            while (lee.Read())
            {
                elemento = lee["Nombre"].ToString();
            }
            conexion.Close();
            return elemento;
        }
        public DataTable ventas_vendedro(int id,int offset)
        {
            elemento = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(
                  "select Salida_ID as 'No.Venta',Fecha,Subtotal,IVA,TotalVenta from salida where Empleado_Id=@id limit 10 offset @seri"

                , conexion);
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@seri",offset);
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(elemento);
            conexion.Close();
            return elemento;
        }
    }
}

