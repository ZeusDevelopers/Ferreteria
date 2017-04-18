using MySql.Data.MySqlClient;
using PVFP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    class Cls_devolucion
    {

        public void eliminar(int id_vent,int valor)
        {
            try
            {
            int cant=0; int numero=0;
            llenar_dtb(id_vent);
            //Obtiene la cantidad
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
            conexion.Close();
                ////// cambiar salida el total////////
                /*     obtiene el subtotal         */
                double subtot=0;
                conexion = ClsInicioSesion.ObtenerConexion();
                comando = "select Subtotal from salida where Salida_ID= @id";
                _comando = new MySqlCommand(comando, conexion);
                _comando.Parameters.AddWithValue("@id", id_vent);
                lee = _comando.ExecuteReader();
                while (lee.Read())
                {
                    subtot = Double.Parse(lee["Subtotal"].ToString());
                }                
                lee.Close();
                conexion.Close();

                /*               seleccionamos                   */
                conexion = ClsInicioSesion.ObtenerConexion();
                double c = 0;
                comando = "select TotalProducto from salida_detalle where salida_ID=@id and Producto_ID= @sal_id";
                _comando = new MySqlCommand(comando, conexion);
                _comando.Parameters.AddWithValue("@id", id_vent);
                _comando.Parameters.AddWithValue("@sal_id", elemento.Rows[valor][0].ToString());
                lee = _comando.ExecuteReader();
                while (lee.Read())
                {
                    c = Double.Parse(lee["TotalProducto"].ToString());
                }
                lee.Close();
                conexion.Close();
                double nuevo_precio = subtot - c,iva=0,tot=0;
                /*          Nuevo Precio de la venta           */

                conexion = ClsInicioSesion.ObtenerConexion();                
                comando = "update salida set salida.Subtotal =@np,salida.IVA=@niva,salida.TotalVenta=@totven where salida.Salida_ID=@id;";
                _comando = new MySqlCommand(comando, conexion);
                _comando.Parameters.AddWithValue("@id", id_vent);
                _comando.Parameters.AddWithValue("@np",nuevo_precio);
                iva = (nuevo_precio * .16);
                _comando.Parameters.AddWithValue("@niva", iva);
                tot = iva + nuevo_precio;
                _comando.Parameters.AddWithValue("@totven",tot);
                 _comando.ExecuteReader();
                conexion.Close();
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
            string cadena = "";
            /////////////VERIFICAR SI NO HAY PRODUCTOS PARA ELIMINAR LA VENTA///////////////
            conexion = ClsInicioSesion.ObtenerConexion();
            comando =
              "select Count(Salida_id)  as t from Salida_detalle where salida_Id=@id ;";
          _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@id", id_vent);
            MySqlDataReader lee2 = _comando.ExecuteReader();
            while (lee2.Read())
            {
                cadena = lee2["t"].ToString();
            }
            lee2.Close();
            conexion.Close();
            conexion.Open();
            comando =
                "select if (@a>0," +
                "'uno'," +
                "concat('delete from salida where salida_id=',@id)) as t";
            _comando = new MySqlCommand(comando, conexion);            
            _comando.Parameters.AddWithValue("@id", id_vent);
            _comando.Parameters.AddWithValue("@a", cadena);
            lee2 = _comando.ExecuteReader();            
            comando = "";
            while (lee2.Read())
            {
                comando= lee2["t"].ToString();
            }
            lee2.Close();
            conexion.Clone();
                ///////////////////ejecuta query///////////////////
                if (!comando.Equals("uno"))
                {
                    conexion = ClsInicioSesion.ObtenerConexion();
                    _comando = new MySqlCommand(comando, conexion);
                    _comando.ExecuteNonQuery();
                    conexion.Close();
                }
                            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }       
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
        public void Eliminar_uno(int id_vent,int poscion,double cant)
        {
            llenar_dtb(id_vent);
            /*                Ingreso Nueva Cantidad                   */
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            string comando = "update salida_detalle " +
                "set Cantidad=(Cantidad-@num) where Salida_ID = @id and Producto_ID=@sal_id";
            MySqlCommand _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@id", id_vent);
            _comando.Parameters.AddWithValue("@num", cant);
            _comando.Parameters.AddWithValue("@sal_id", elemento.Rows[poscion][0].ToString());
            _comando.ExecuteNonQuery();
            conexion.Close();
            /*  Cambiamos el precio del total de producto             */
            conexion = ClsInicioSesion.ObtenerConexion();
            comando = "update salida_detalle set " +
                "TotalProducto=(select Cantidad*PrecioUnitario)where Salida_ID=@id;";
            _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@id", id_vent);
            _comando.ExecuteNonQuery();
            conexion.Close();
            /*    Regresamos al A_piso el producto      */            
            conexion = ClsInicioSesion.ObtenerConexion();
            comando = "UPDATe almacen set almacen.A_Piso=@num+A_piso " +
                "where almacen.Producto_ID=@id";
            _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@num", cant);
            _comando.Parameters.AddWithValue("@id", elemento.Rows[poscion][0].ToString());
            _comando.ExecuteNonQuery();
            conexion.Close();

        }

    }
}
