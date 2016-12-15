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
    public partial class FrmAltaProductos : Form
    {
        public FrmAltaProductos()
        {
            InitializeComponent();
        }
        ClsAltaProductos productos = new ClsAltaProductos();
       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsAltaProductos objProducto = new ClsAltaProductos("0",txtNombre.Text,
                    cmbCategoria.SelectedText.ToString(),txtCostoCompra.Text,
                    cmbTipo.SelectedText.ToString(),txtFolio.Text,txtdescripcion.Text,txtUM.Text);
                objProducto.AgregarProducto();
                
                
                MessageBox.Show("Producto añadido correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarActualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema. " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        ClsCategorias Categorias = new ClsCategorias();
        private void FrmAltaProductos_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Clear();
            cmbmodCategoria.Items.Clear();
            cmbmodNombre.Items.Clear();
            cmbmodTipo.Items.Clear();
            //Lenar categorias
            Categorias.ConsultarPath();
            Categorias.CargarCategorias();
            ArrayList arrcat = Categorias.ArregloDescripcion;
            for (int i = 0; i < arrcat.Count; i++)
            {
                cmbCategoria.Items.Add(arrcat[i].ToString());
                cmbmodCategoria.Items.Add(arrcat[i].ToString());
            }
            //Lenar productos nombre
            productos.ConsultarPath();
           productos.CargarProductoMod();
            ArrayList arrprod = productos.ArregloProductomod;
            for (int i = 0; i < arrprod.Count; i++)
            {
                cmbmodNombre.Items.Add(arrprod[i].ToString());
            }
            //llenar tipo
            ArrayList arrTipo = productos.ArregloTipo;
            for (int i = 0; i < arrTipo.Count; i++)
            {
                cmbmodTipo.Items.Add(arrTipo[i].ToString());
            }
            //llenar gridv
            ArrayList Ar = productos.VerTodosProductos();
            dgvProducto.Rows.Clear();
               for (int i = 0; i < Ar.Count; i++)
               {
                productos.LeerUnRegistro(i);
                dgvProducto.Rows.Add(productos.Producto_ID,productos.Nombre, productos.Categoria_ID,
                    productos.CostoCompra, productos.Tipo_ID, productos.Folio, productos.Descripcion);
                }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
          
        }
        private void cmbmodDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ArrayList Ar = productos.VerProducto(cmbmodNombre.SelectedItem.ToString());
          
            txtmodCostoCompra.Text = "";
            txtmodDescripcion.Text = "";
            txtmodFolio.Text = "";
            txtmodNombre.Text = "";
            txtmodProductoID.Text = "";
            txtmodUM.Text = "";
            for (int i = 0; i < Ar.Count; i++)
            {
                productos.LeerUnRegistro(i);
                txtmodUM.Text = productos.UM;
                txtmodProductoID.Text = productos.Producto_ID;
                txtmodNombre.Text = productos.Nombre;
                txtmodFolio.Text = productos.Folio;
                txtmodCostoCompra.Text = productos.CostoCompra;
                txtmodDescripcion.Text = productos.Descripcion;
                cmbmodTipo.SelectedIndex= Convert.ToInt32(productos.Tipo_ID) - 1;
                cmbmodCategoria.SelectedIndex = Convert.ToInt32(productos.Categoria_ID)-1;
          
            }
            
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            productos.BorrarProducto(txtmodProductoID.Text);
            MessageBox.Show("Eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarActualizar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            productos.EditarProducto(txtmodProductoID.Text);
            MessageBox.Show("Modificado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarActualizar();
            //llenar gridv
            ArrayList Ar = productos.VerTodosProductos();
            dgvProducto.Rows.Clear();
            for (int i = 0; i < Ar.Count; i++)
            {
                productos.LeerUnRegistro(i);
                dgvProducto.Rows.Add(productos.Producto_ID, productos.Nombre, productos.Categoria_ID,
                    productos.CostoCompra, productos.Tipo_ID, productos.Folio, productos.Descripcion);
            }
        }
        public void LimpiarActualizar()
        {
            cmbmodNombre.Items.Clear();
            cmbmodCategoria.Items.Clear();
            cmbmodTipo.Items.Clear();
            productos.ConsultarPath();
            productos.CargarProductoMod();
            ArrayList arrnomb = productos.ArregloProductomod;
            for (int i = 0; i < arrnomb.Count; i++)
            {
                cmbmodNombre.Items.Add(arrnomb[i].ToString());
            }
            ArrayList arrTipo = productos.ArregloTipo;
            for (int i = 0; i < arrTipo.Count; i++)
            {
                cmbmodTipo.Items.Add(arrTipo[i].ToString());
                cmbTipo.Items.Add(arrTipo[i].ToString());
            }
            Categorias.ConsultarPath();
            Categorias.CargarCategorias();
            ArrayList arrcat = Categorias.ArregloDescripcion;
            for (int i = 0; i < arrcat.Count; i++)
            {
                cmbCategoria.Items.Add(arrcat[i].ToString());
                cmbmodCategoria.Items.Add(arrcat[i].ToString());
            }
            txtmodCostoCompra.Text = "";
            txtmodDescripcion.Text = "";
            txtmodFolio.Text = "";
            txtmodNombre.Text = "";
            txtmodProductoID.Text = "";
            txtmodUM.Text = "";
            //txtProductoID recordar es autonumerico
            txtNombre.Text = "";
            txtCostoCompra.Text = "";
            txtFolio.Text = "";
            txtdescripcion.Text = "";
            txtUM.Text = "";
            //llenar gridv
            ArrayList Ar = productos.VerTodosProductos();
            dgvProducto.Rows.Clear();
            for (int i = 0; i < Ar.Count; i++)
            {
                productos.LeerUnRegistro(i);
                dgvProducto.Rows.Add(productos.Producto_ID, productos.Nombre, productos.Categoria_ID,
                    productos.CostoCompra, productos.Tipo_ID, productos.Folio, productos.Descripcion);
            }
        }
       // private void btnmodCalcularp_Click(object sender, EventArgs e)
        //{
            //double subtotal, subtotal2, total;
           // subtotal = Convert.ToDouble(txtmodCosto.Text) / (1 - (Convert.ToDouble(txtmodGanancia.Text)));
            //subtotal2 = Convert.ToDouble(txtmodCosto.Text) * (Convert.ToDouble(txtmodIVA.Text));
            //total = (subtotal + subtotal2);
          //  txtmodPrecio.Text = total.ToString();
        //}

        
    }

}
