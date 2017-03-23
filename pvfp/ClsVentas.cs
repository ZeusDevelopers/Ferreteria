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

namespace PVFP
{
    class ClsVentas
    {

        #region MYSQL
        public DataTable VerProducto(string productoid)
        {
            DataTable tabla = new DataTable();
            try
            {
                MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
                MySqlCommand _comando = new MySqlCommand(String.Format("SELECT `Codigodebarra`,`Nombre`,`Precio_Venta`,A_Piso,UM,producto.Producto_ID FROM `producto` left join almacen on producto.Producto_ID=almacen.Producto_ID " +
                    "  where producto.Codigodebarra='" + productoid + "' and A_Piso <>'0';"), conexion);
                MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
                _dataAdapter.Fill(tabla);
                conexion.Close();
            }
            catch (Exception  ex)
            {
                if (ex.Message.Contains("Unknown column"))
                    MessageBox.Show("No Existe Producto o Inventario Insuficiente ");
                else
                    MessageBox.Show(ex.Message);                 
            }
            return tabla;
        }
        public static double Dolar
        {
            get { return dolar; }
        }
        private static double dolar;
        public  static void precio_dolar()
        {
            
            //   var valor_dolar = new WebClient().DownloadString("http://download.finance.yahoo.com/d/quotes?s=USDMXN%3DX&f=l1n");
            var valor_dolar = new WebClient().DownloadString("https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20html%20where%20url%3D'https%3A%2F%2Fbbv.infosel.com%2Fbancomerindicators%2FindexV5.aspx%3F%23'%20%20%20&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys");
            //string lur = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20html%20where%20url%3D" + "'" + "https%3A%2F%2Fbbv.infosel.com%2Fbancomerindicators%2FindexV5.aspx%3F%23'%20%20%20&format=xml&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";
            string lur = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20html%20where%20url%3D%27http%3A%2F%2Fwww.eldolar.info%2Fes-MX%2Fmexico%2Fdia%2Fhoy%27%20and%20xpath%3D%27%2F%2Fhtml%5B%22container%22%5D%2F%2Ftable%5B%22dllsTable%22%5D%27&format=xml&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";
            XmlDocument doc1 = new XmlDocument();            
            doc1.Load(lur);            
            string elemList = doc1.DocumentElement.ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes.Item(2).ChildNodes.Item(4).ChildNodes.Item(4).InnerText;                            
            dolar = Double.Parse(elemList);            
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
            //insert into salida_detalle values(Salida_ID, Producto_ID, Cantidad, Descuento, PrecioUnitario, TotalProducto);
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
            int numero;
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand("update almacen set almacen.A_piso = almacen.A_piso - @cant where almacen.Producto_ID = @id", conexion);
            _comando.Parameters.AddWithValue("@cant", canti);
            _comando.Parameters.AddWithValue("@id", id);
            _comando.ExecuteNonQuery();          
            conexion.Close();
        }
        #endregion
    }
}
