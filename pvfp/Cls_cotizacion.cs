using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVFP;
using MySql.Data.MySqlClient;
using System.Data;

namespace Ferreteria
{
    class Cls_cotizacion : ClsInicioSesion
    {
       public void Inicio(double tot_vent,double iva,double sub)
        {
            MySqlConnection conexion = ObtenerConexion();
            string comando = "insert into cotizacion values(0,1,curdate(),@tot_ven,@iva,@sub,@emplid);";
            MySqlCommand _comando = new MySqlCommand(comando, conexion);
            // _comando.Parameters.AddWithValue("@v", param);            
            _comando.Parameters.AddWithValue("@tot_ven", tot_vent);
            _comando.Parameters.AddWithValue("@iva", iva);
            _comando.Parameters.AddWithValue("@sub", sub);
            _comando.Parameters.AddWithValue("@emplid", empleados_id);
            _comando.ExecuteNonQuery();
            conexion.Close();            
        }
        public int Registrar_cotizacion(DataTable dt)
        {
            MySqlConnection conexion = ObtenerConexion();
            int num = -1;
            string comando = "select cotizacion_ID from cotizacion order by cotizacion.cotizacion_ID desc limit 1 ; ";
            MySqlCommand _comando = new MySqlCommand(comando, conexion);
            MySqlDataReader rd = _comando.ExecuteReader();
            while (rd.Read())
            {
                num = Int32.Parse(rd["cotizacion_ID"].ToString());
            }
            conexion = ObtenerConexion();
            comando = "";
            _comando = new MySqlCommand(comando, conexion);
            foreach (DataRow item in dt.Rows)
            {
                Inserta(num,Int32.Parse(item[4].ToString()),Double.Parse(item[1].ToString()), 0,Double.Parse(item[2].ToString().Remove(0,1)),Double.Parse(item[3].ToString().Remove(0, 1)));
            }
            return num;
        }
        void Inserta(int cot, int prod_id, double cant, double desc,double pre,double totpro)
        {
            MySqlConnection conexion = ObtenerConexion();
            string comando = "insert into cotizacion_detalle  values(@cot_id," +
                "@proc,@cant,@desc_,@pre_uni,@totpro);";
            MySqlCommand _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@cot_id",cot);
            _comando.Parameters.AddWithValue("@proc", prod_id);//@cant
            _comando.Parameters.AddWithValue("@cant", cant);
            _comando.Parameters.AddWithValue("@desc_", desc);
            _comando.Parameters.AddWithValue("@pre_uni", pre);
            _comando.Parameters.AddWithValue("@totpro", totpro);
            _comando.ExecuteNonQuery();
            conexion.Close();
        }
        public DataTable Regresa(int id)
        {
            DataTable tb= new DataTable();            
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            string comando = "select ct.Cantidad,p.Codigodebarra,p.Nombre,al.A_Piso,ct.PrecioUnitario,ct.TotalProducto,p.UM,p.Producto_ID from cotizacion_detalle ct inner join producto p on ct.Producto_ID=p.Producto_ID inner join almacen   al on al.Producto_ID=ct.Producto_ID where ct.cotizacion_ID=@b;";
            MySqlCommand _comando = new MySqlCommand(comando, conexion);
            _comando.Parameters.AddWithValue("@b",id);
            MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
            _dataAdapter.Fill(tb);            
            conexion.Close();
            return tb;
        }
    }
}
