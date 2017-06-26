using System;
using MySql.Data.MySqlClient;  //Referencia mysqldata
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace PVFP
{
    class ClsInicioSesion
    {
        #region Path        
    //     private static string pathfinal = "server=localhost; database=FerreteriaL1; Uid=root; pwd=1234;";        
         private static string pathfinal = "server=127.0.0.1; database=FerreteriaL1; Uid=root; pwd=;";
    
        #endregion
        #region MYSQL
        public static double Dolar
        {
            get { return dolar; }
        }
        public static int empleados_id
        {
            get { return emp; }
        }
        private static double dolar,empl;
        private static int emp;
        public static void precio_dolar()
        {

            try
            {
                // var valor_dolar = new WebClient().DownloadString("https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20html%20where%20url%3D'https%3A%2F%2Fbbv.infosel.com%2Fbancomerindicators%2FindexV5.aspx%3F%23'%20%20%20&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys");
                //string lur = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20html%20where%20url%3D" + "'" + "https%3A%2F%2Fbbv.infosel.com%2Fbancomerindicators%2FindexV5.aspx%3F%23'%20%20%20&format=xml&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";
                //string lur = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20html%20where%20url%3D%27http%3A%2F%2Fwww.eldolar.info%2Fes-MX%2Fmexico%2Fdia%2Fhoy%27%20and%20xpath%3D%27%2F%2Fhtml%5B%22container%22%5D%2F%2Ftable%5B%22dllsTable%22%5D%27&format=xml&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";
                //XmlDocument doc1 = new XmlDocument();
                //doc1.Load(lur);
                //var elemList = doc1.DocumentElement.ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes.Item(2).ChildNodes.Item(4).ChildNodes.Item(3).InnerText;
                //string elemList = doc1.DocumentElement.ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes.Item(2).ChildNodes.Item(4).ChildNodes.Item(4).InnerText;
                string elemList = Obtener_precio_pagina();
                dolar = Double.Parse(elemList);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        static string Obtener_precio_pagina()
        {
            WebClient client = new WebClient();
            var mol = client.DownloadString("http://www.eldolar.info/es-MX/mexico/dia/hoy");
            TextReader sr = new StringReader(mol.ToString());
            // setup SgmlReader
            Sgml.SgmlReader sgmlReader = new Sgml.SgmlReader();
            sgmlReader.DocType = "HTML";
            sgmlReader.WhitespaceHandling = WhitespaceHandling.All;
            sgmlReader.CaseFolding = Sgml.CaseFolding.ToLower;
            sgmlReader.InputStream = sr;
            // create document
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.XmlResolver = null;
            doc.Load(sgmlReader);
            //selecciona el valor del dolar bancomer de la pagina con xpath
            var prec_dol = doc.SelectSingleNode("html/body/div/main/div[@class = " + '"' + "content" + '"' + "]" + "/table/tbody/tr[5]/td[5]").InnerText;
            return prec_dol;
        }


        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar=null;
            try
            {
                conectar = new MySqlConnection(pathfinal);
                conectar.Open();                
            }
            catch (Exception )
            {
               
            }
            return conectar;
        }
        public string usuario,puesto;
        public bool bandera = false;
        private static string nombre = "";
        //se asigna el usuario desde el login 
        public static string Usuario
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public void Sesion(string usuario, string contraseña)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion();
            MySqlCommand _comando = new MySqlCommand(String.Format("select Nombre,sesion.Puesto,Empleado_ID from sesion inner join empleados on sesion.Sesion_ID = empleados.Sesion_ID" +
                " WHERE Usuario =@usu and Contraseña =@contra "), conexion);
            _comando.Parameters.AddWithValue("@usu", usuario);
            _comando.Parameters.AddWithValue("@contra", contraseña);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                bandera = true;                
                nombre = _reader["Nombre"].ToString().Length>12?
                _reader["Nombre"].ToString().Remove(12):
                _reader["Nombre"].ToString();                
                puesto = _reader["Puesto"].ToString();
                emp = Convert.ToInt32(_reader["Empleado_ID"].ToString());
            }
            
            _reader.Close();                    
            conexion.Close();
        }
        #endregion
    }
}
