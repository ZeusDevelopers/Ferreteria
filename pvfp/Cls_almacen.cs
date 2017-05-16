using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PVFP;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ferreteria
{
    class Cls_almacen : ClsInicioSesion
    {       
        public DataTable VerTodosProductos(int tipo, string param,bool opc)
        {           
            string conca = opc ? "A_Piso as 'Piso'" : "A_Almacen as 'Almacen'";      
            string comando = "SELECT `Codigodebarra` as 'Codigo de Barras',`Nombre`," + conca + "   " +
                ",UM,producto.Producto_ID FROM `producto` inner join " +
                " almacen on almacen.Producto_ID = producto.Producto_ID ";
            switch (tipo)
            {
                case 0:
                    comando += "where producto.Codigodebarra=@v";
                    break;
                case 1:
                    comando += "where producto.Folio=@v";
                    break;
                case 2:
                    comando += " where producto.Nombre like concat('%',@v,'%') ";
                    break;
                default:
                    break;
            }
            comando += opc ? "  and almacen.A_Piso>0 " : " and almacen.A_Almacen>0 ";
            DataTable tabla = new DataTable();
            MySqlConnection conexion = ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@v", param);
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(tabla);
            conexion.Close();  
            return tabla;
        }
        public int Numero()
        {
            int num = -1;
            MySqlConnection conexion = ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand("select round(count(Codigodebarra)/10,0)  as 'contador' from almacen inner " +
                "join producto on almacen.Producto_ID=producto.Producto_ID " +
                "where A_Almacen >0 or A_Piso>0  " +
                "", conexion);
            MySqlDataReader rd = _comando.ExecuteReader();            
            while (rd.Read())
            {
                num=Int32.Parse(rd["contador"].ToString());
            }
            return num;
            //select Round(count(almacen_ID)/ 10,0) from almacen;
        }
        public DataTable Paginado(int pag)
        {
            DataTable tabla = new DataTable();
            string comando = "select Codigodebarra,Nombre,A_piso as 'Piso'," +
                " A_Almacen as 'Almacen' from almacen inner join producto " +
                "on almacen.Producto_ID=producto.Producto_ID where A_Almacen >0 " +
                "or A_Piso>0  limit 10 offset @m;";
            MySqlConnection conexion = ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@m", pag);
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        public void Mover(string tipo,int id,double cant)
        {
            double piso = 0,almacen=0;
            //select A_Piso,A_almacen from almacen
            MySqlConnection conexion = ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand("select A_Piso,A_almacen from almacen" +
                " where almacen.Producto_ID= @id;"
                , conexion);
            _comando.Parameters.AddWithValue("@id",id);
            MySqlDataReader rd = _comando.ExecuteReader();
            while (rd.Read())
            {
                piso = Double.Parse(rd["A_Piso"].ToString());
                almacen = Double.Parse(rd["A_almacen"].ToString());
            }            


            //agregar a piso o almacen segun sea el caso
            conexion = ObtenerConexion();
            double tot = tipo == "almacen" ? almacen + cant : piso + cant;
            string opc = tipo == "almacen" ? "A_Almacen" : "A_Piso";
            string comando = "update almacen set " +opc+" = @cant where almacen.Producto_ID= @id;";
            _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@id",id);
            _comando.Parameters.AddWithValue("@cant", tot);
            _comando.ExecuteNonQuery();
            conexion.Clone();

            //restar a piso o almacen segun sea el caso
            conexion = ObtenerConexion();
            opc = tipo == "almacen" ? "A_Piso" : "A_Almacen";
            tot = tipo == "almacen" ? piso - cant : almacen - cant;
            comando = "update almacen set " + opc + " = @cant where almacen.Producto_ID= @id;";
            _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@cant", tot);
            _comando.ExecuteNonQuery();
            conexion.Clone();


        }
    }
}
