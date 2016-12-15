using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PVFP
{
    public partial class frmEnAltProd : Form
    {
        public frmEnAltProd()
        {
            InitializeComponent();
        }
        ClsAltaProductos productos = new ClsAltaProductos();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //productos.AgregarProducto("0", txtNombre.Text,
                //    cmbCategoria.SelectedItem.ToString(), txtCostoCompra.Text,
                //    cmbTipo.SelectedItem.ToString(), txtFolio.Text, txtdescripcion.Text, txtUM.Text,TxtMarca.Text);
                MessageBox.Show("Producto añadido correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCostoCompra.Text = "";
                txtFolio.Text = "";
                txtNombre.Text = "";
                txtUM.Text = "";
                txtdescripcion.Text = "";
                cmbTipo.Text = "";
                cmbCategoria.Text = "";
                
                //se obtiene proximo id
                obtener_id();
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void obtener_id()
        {
            try
            {
                txtProductoID.Text = (Int32.Parse(productos.Obtener_productoId()) + 1).ToString(); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        ClsCategorias Categorias = new ClsCategorias();
        ClsTiposCargos tipos = new ClsTiposCargos();

        private void frmEnAltProd_Load(object sender, EventArgs e)
        {
            obtener_id();
            //Lenar categorias
            Categorias.ConsultarPath();
            Categorias.CargarCategorias();
            ArrayList arrcat = Categorias.ArregloID;
            for (int i = 0; i < arrcat.Count; i++)
            {
                cmbCategoria.Items.Add(arrcat[i].ToString());
            }
            //Llena Tipos
            ArrayList tipo = tipos.Tipo();
            foreach (String item in tipo)
            {
                cmbTipo.Items.Add(item.ToString());
            }  
        }
    }
    
}
