using MySql.Data.MySqlClient;
using PVFP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria
{
    class Cls_devolucion
    {

        public void eliminar(int id_vent,int valor)
        {
            int cant=0; int numero=0;
            llenar_dtb(id_vent);
            //unnod
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            string comando = "select Cantidad from salida_detalle where salida_ID=@id and Producto_ID= @sal_id";
            MySqlCommand _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@id", id_vent);
            _comando.Parameters.AddWithValue("@sal_id", elemento.Rows[valor][0].ToString());
            MySqlDataReader lee = _comando.ExecuteReader();
            while (lee.Read())
            {
                cant = Int32.Parse(lee["Cantidad"].ToString());
            }
            lee.Close();
            conexion.Clone();            
            ///////BORRAR//////////
            conexion = ClsInicioSesion.ObtenerConexion();
            comando = "delete  from salida_detalle where  salida_ID=@id and Producto_ID= @sal_id";
            _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@id", id_vent);
            _comando.Parameters.AddWithValue("@sal_id", elemento.Rows[valor][0].ToString());
          _comando.ExecuteNonQuery();
            conexion.Close();
            ///////////////PASAR A PISO///////////////
            conexion = ClsInicioSesion.ObtenerConexion();
             comando = "select A_piso from almacen where Producto_ID= @id";
             _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@id", elemento.Rows[valor][0].ToString());
            lee = _comando.ExecuteReader();            
            while (lee.Read())
            {
                numero = Int32.Parse(lee["A_piso"].ToString());
            }
            numero = numero + cant;
            lee.Close();
            conexion.Close();
            ///////////////////////INSERTAR EN PISO////////////////////////
            conexion = ClsInicioSesion.ObtenerConexion();
            comando = "UPDATe almacen set almacen.A_Piso=@num where almacen.Producto_ID=@id";
            _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@num", numero);
            _comando.Parameters.AddWithValue("@id",elemento.Rows[valor][0].ToString());
            _comando.ExecuteNonQuery();
            conexion.Close();
        }
        //        select Producto_ID from Salida inner join salida_detalle on salida.Salida_ID=salida_detalle.Salida_ID where SALIDA.SALIDA_iD=60;
        //;
        DataTable elemento;
        public void llenar_dtb(int id)
        {
            elemento = new DataTable();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            string comando = "select Producto_ID from Salida inner join salida_detalle " +
                "on salida.Salida_ID=salida_detalle.Salida_ID where SALIDA.SALIDA_iD=@id;";

            MySqlCommand _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@id", id);                
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(elemento);
            conexion.Close();
            
        }
    }
}
