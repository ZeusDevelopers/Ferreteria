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
    class ClsAltaProductos
    {
        #region Path
        string pathfinal = "server=127.0.0.1; database=FerreteriaL1; Uid=root; pwd=;";
        public void ConsultarPath()
        {
            string path = Application.StartupPath.ToString() + "\\Path\\Path.txt";
            FileStream ObjArchivo = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader ObjLectura = new StreamReader(ObjArchivo);
            pathfinal = ObjLectura.ReadToEnd();
            ObjLectura.Close();
            pathfinal = pathfinal.Remove(0, 5);
        }

        #endregion
        #region MYSQ
        public static MySqlConnection ObtenerConexion(string pathfinal)
        {
            MySqlConnection conectar = new MySqlConnection(pathfinal);
            conectar.Open();
            return conectar;
        }
       
        public struct Datos
        {
            public string producto_ID;
            public string nombre;
            public string categoria_ID;
            public string costoCompra;
            public string tipo_ID;
            public string folio;
            public string descripcion;
            public string uM;
        }
        Datos Dato;
        
        public string Producto_ID
        {
            get { return Dato.producto_ID; }
            set { Dato.producto_ID = value; }
        }
        public string Nombre
        {
            get { return Dato.nombre; }
            set { Dato.nombre = value; }
        }
        public string Categoria_ID
        {
            get { return Dato.categoria_ID; }
            set { Dato.categoria_ID = value; }
        }
        public string CostoCompra
        {
            get { return Dato.costoCompra; }
            set { Dato.costoCompra = value; }
        }
        public string Tipo_ID
        {
            get { return Dato.tipo_ID; }
            set { Dato.tipo_ID = value; }
        }
        public string Folio
        {
            get { return Dato.folio; }
            set { Dato.folio = value; }
        }

        public string Descripcion
        {
            get { return Dato.descripcion; }
            set { Dato.descripcion = value; }
        }
        public string UM
        {
            get { return Dato.uM; }
            set { Dato.uM = value; }
        }

        public ClsAltaProductos()
        { }
        public ClsAltaProductos(string producto_ID,string nombre,string categoria_ID,
        string costoCompra,string tipo_ID, string folio,string descripcion,string uM)
        {
            this.Producto_ID= producto_ID;
            this.Nombre= nombre;
            this.Categoria_ID=categoria_ID;
            this.CostoCompra= costoCompra;
            this.Tipo_ID= tipo_ID;
            this.Folio=folio;
            this.Descripcion= descripcion;
            this.UM=uM;
    }

        ArrayList MyArray = new ArrayList();
        public ArrayList VerProducto(string fol)
        {
            MyArray = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM Productos  WHERE Folio = '" + fol + "'"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Producto_ID = (_reader["Producto_ID"].ToString());
                Nombre = (_reader["Nombre"].ToString());
                Categoria_ID = (_reader["Categoria_ID"].ToString());
                CostoCompra = (_reader["CostoCompra"].ToString());
                Tipo_ID = (_reader["Tipo_ID"].ToString());
                Folio = (_reader["Folio"].ToString());
                Descripcion = (_reader["Descripcion"].ToString());
                UM = (_reader["UM"].ToString());
                MyArray.Add(Dato);
            }
            conexion.Close();

            return MyArray;
        }
        public ArrayList VerTodosProductos()
        {
            MyArray = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM Productos"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Producto_ID = (_reader["Producto_ID"].ToString());
                Nombre = (_reader["Nombre"].ToString());
                Categoria_ID = (_reader["Categoria_ID"].ToString());
                CostoCompra = (_reader["CostoCompra"].ToString());
                Tipo_ID = (_reader["Tipo_ID"].ToString());
                Folio = (_reader["Folio"].ToString());
                Descripcion = (_reader["Descripcion"].ToString());
                UM = (_reader["UM"].ToString());
                MyArray.Add(Dato);
            }
            conexion.Close();

            return MyArray;
        }
        public void LeerUnRegistro(int i)
        {
            Dato = (Datos)MyArray[i];
        }
        public void AgregarProducto()
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("INSERT INTO productos (`Producto_ID`, `Nombre`, `Categoria_ID`, `CostoCompra`, `Tipo_ID`, `Folio`, `Descripcion`, `UM`) VALUES" +
                " (" + Producto_ID+",'"+ Nombre+"',"+ Categoria_ID+","+ CostoCompra+","+ Tipo_ID+",'"+ Folio+"','"+ Descripcion+"','"+ UM + "')"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }
        public ArrayList ArregloProductomod = new ArrayList();
        public void CargarProductoMod()
        {
            ArregloProductomod = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Nombre, Producto_ID FROM productos"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloProductomod.Add(_reader["Producto_ID"].ToString()+","+ _reader["Nombre"].ToString());
            }
            conexion.Close();
        }
        public ArrayList ArregloTipo = new ArrayList();
        public void CargarTipod()
        {
            ArregloProductomod = new ArrayList();
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Tipo_ID FROM tiposcargos"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                ArregloTipo.Add(_reader["Tipo_ID"].ToString());
            }
            conexion.Close();
        }
        public void EditarProducto(string producto)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("UPDATE `productos` SET "+
                ",`Nombre`="+Nombre+",`Categoria_ID`="+Categoria_ID+","+
                "`CostoCompra`="+CostoCompra+",`Tipo_ID`="+Tipo_ID+",`Folio`="+Folio+","+
                "`Descripcion`="+Descripcion+",`UM`="+UM+" WHERE `Producto_ID`=" + producto ), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }
        //p
        public void BorrarProducto(string producto)
        {
            MySqlConnection conexion = ClsInicioSesion.ObtenerConexion(pathfinal);
            MySqlCommand _comando = new MySqlCommand(String.Format("Delete From `productos`  WHERE Producto_ID = " + producto), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            conexion.Close();
        }


        #endregion
    }
}
