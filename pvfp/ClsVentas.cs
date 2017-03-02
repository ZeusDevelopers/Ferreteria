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
                MySqlCommand _comando = new MySqlCommand(String.Format("SELECT `Codigodebarra`,`Nombre`,`Precio_Venta` FROM `producto` where `Codigodebarra`=" + productoid), conexion);
                MySqlDataAdapter _dataAdapter = new MySqlDataAdapter(_comando);
                _dataAdapter.Fill(tabla);
                conexion.Close();
            }
            catch (Exception  ex)
            {
                if (ex.Message.Contains("Unknown column"))
                    MessageBox.Show("No Existe Producto");
                else
                    MessageBox.Show(ex.Message);                 
            }
            return tabla;
        }

        public double precio_dolar()
        {
            //   var valor_dolar = new WebClient().DownloadString("http://download.finance.yahoo.com/d/quotes?s=USDMXN%3DX&f=l1n");
            var valor_dolar = new WebClient().DownloadString("https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20html%20where%20url%3D'https%3A%2F%2Fbbv.infosel.com%2Fbancomerindicators%2FindexV5.aspx%3F%23'%20%20%20&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys");
            string lur = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20html%20where%20url%3D" + "'" + "https%3A%2F%2Fbbv.infosel.com%2Fbancomerindicators%2FindexV5.aspx%3F%23'%20%20%20&format=xml&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(lur);            
            string elemList = doc1.DocumentElement.ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes.Item(4).ChildNodes.Item(0).ChildNodes.Item(4).ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes.Item(4).ChildNodes.Item(5).ChildNodes.Item(0).Value;          
            double preio = Double.Parse(elemList);
            return preio;
        }

        #endregion
    }
}
