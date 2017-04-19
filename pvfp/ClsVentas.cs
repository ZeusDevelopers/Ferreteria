using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  //Referencia mysqldata
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.Xml;
using System.Net.NetworkInformation;

namespace PVFP
{
    class ClsVentas
    {

        #region MYSQL
        public DataTable VerProducto(string productoid,int a)
        {
            DataTable tabla = new DataTable();
            try
            {
                MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
                MySqlCommand _comando = new MySqlCommand(String.Format("SELECT `Codigodebarra`,`Nombre`,SUM(`Ganancia_Mayoreo`+Precio_Costo),A_Piso,UM,producto.Producto_ID FROM `producto` left join almacen on producto.Producto_ID=almacen.Producto_ID " +
                    "  where producto.Codigodebarra=@prod and A_Piso <>'0';"), conexion);
                _comando.Parameters.AddWithValue("@prod",productoid);
                MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
                _dataAdapter.Fill(tabla);
                conexion.Close();
            }
            catch (Exception  ex)
            {
                //if (ex.Message.Contains("Unknown column"))
                //    //MessageBox.Show("No Existe Producto o Inventario Insuficiente ");
                //else
                //    //MessageBox.Show(ex.Message);                 
                return tabla;
            }
            return tabla;
        }
        public DataTable VerProducto(string productoid)
        {
            DataTable tabla = new DataTable();
            try
            {
                MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
                MySqlCommand _comando = new MySqlCommand(String.Format("SELECT `Codigodebarra`,`Nombre`,SUM(`Ganancia_Venta`+Precio_Costo),A_Piso,UM,producto.Producto_ID FROM `producto` left join almacen on producto.Producto_ID=almacen.Producto_ID " +
                    "  where producto.Codigodebarra=@prod and A_Piso <>'0';"), conexion);
                _comando.Parameters.AddWithValue("@prod", productoid);
                MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
                _dataAdapter.Fill(tabla);
                conexion.Close();
            }
            catch (Exception ex)
            {
                //if (ex.Message.Contains("Unknown column"))
                //    //MessageBox.Show("No Existe Producto o Inventario Insuficiente ");
                //else
                //    //MessageBox.Show(ex.Message);                 
                return tabla;
            }
            return tabla;
        }

        public int registrar_venta(double totalventa,string fecha,double iva ,double subtotal,int empleadoid)
        {
            int numero=-1;
            try
            {                
                MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
                MySqlCommand _comando = new MySqlCommand("insert into salida values (0,0,@fecha,@totalventa,@iva,@subtotal,@empleadoid);", conexion);
                _comando.Parameters.AddWithValue("@fecha", fecha);
                _comando.Parameters.AddWithValue("@totalventa", totalventa);
                _comando.Parameters.AddWithValue("@iva", iva);
                _comando.Parameters.AddWithValue("@subtotal", subtotal);
                _comando.Parameters.AddWithValue("@empleadoid", empleadoid);
                _comando.ExecuteNonQuery();
                _comando = new MySqlCommand("select Salida_ID from salida order by Salida_ID desc limit 1", conexion);
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    numero = Int32.Parse(_reader["Salida_ID"].ToString());
                }                
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            return numero;
        }
        public void registrar_productos_venta(int salidaid,int productoid,double cantidad,double descuento,double precio,double prod_vendo)
        {            
            try
            {
                MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
                MySqlCommand _comando = new MySqlCommand("insert into salida_detalle values(@Salida_ID,@Producto_ID,@Cantidad,@Descuento,@PrecioUnitario,@TotalProducto);", conexion);
                _comando.Parameters.AddWithValue("@Salida_ID", salidaid);
                _comando.Parameters.AddWithValue("@Producto_ID", productoid);
                _comando.Parameters.AddWithValue("@Cantidad", cantidad);
                _comando.Parameters.AddWithValue("@Descuento", descuento);
                _comando.Parameters.AddWithValue("@PrecioUnitario", precio);
                _comando.Parameters.AddWithValue("@TotalProducto", prod_vendo);
                _comando.ExecuteNonQuery();
                _comando = new MySqlCommand("select Salida_ID from salida order by Salida_ID desc limit 1", conexion);                
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        public void remover_cant(double canti,int id)
        {
            //Ping p = new Ping();
            //PingReply r = p.Send("8.8.8.8");
            
            int numero;
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand("update almacen set almacen.A_piso =Round(almacen.A_piso - @cant,2 )where almacen.Producto_ID = @id", conexion);
            _comando.Parameters.AddWithValue("@cant", canti);
            _comando.Parameters.AddWithValue("@id", id);
            _comando.ExecuteNonQuery();          
            conexion.Close();
        }
        #endregion
    }
}
