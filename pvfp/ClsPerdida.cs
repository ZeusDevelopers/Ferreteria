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
    class ClsPerdida
    {

        
        #region MYSQL
     

        public void GuardarPerdida(int perdida_id, int producto_id, string cantidad, string motivo)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("INSERT INTO `Perdida`(`Perdida_ID`, `Producto_ID`, `Cantidad`, `Motivo`) VALUES ('" + 0 + "','" + producto_id + "','" + cantidad + "','" + motivo + "')"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }
        public ArrayList arregloproductoid;
        public ArrayList arreglomotivo;
        public ArrayList arreglocantidad;
        public void CargarPerdida()
        {
            arregloproductoid = new ArrayList();
            arreglomotivo = new ArrayList();
            arreglocantidad = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM perdida"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                arregloproductoid.Add(_reader["Producto_ID"].ToString());
                arreglocantidad.Add(_reader["Cantidad"].ToString());
                arreglomotivo.Add(_reader["Motivo"].ToString());
            }
            conexion.Close();
        }
        #endregion

    }
}
