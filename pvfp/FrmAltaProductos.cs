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
using System.Data.SqlClient;
namespace PVFP
{
    public partial class FrmAltaProductos : Form
    {
        public FrmAltaProductos()
        {
            InitializeComponent();
            BtnGuardar.Image = new Bitmap(PVFP.Properties.Resources.ImgGuardar);
            btnEliminar.Image = new Bitmap(PVFP.Properties.Resources.Eliminar);
            btnModificar.Image = new Bitmap(PVFP.Properties.Resources.Actualizar); 
        }
        ClsAltaProductos productos = new ClsAltaProductos();
        ClsCategorias Categorias = new ClsCategorias();
        ClsTiposCargos tipos = new ClsTiposCargos();
        SqlConnection conexion = new SqlConnection();
        ClsAlmacen almacen = new ClsAlmacen();
        //Localizable = true ; --Formato a Form              
        private void frmProductos_Load(object sender, EventArgs e)
        {
            try
            {
                //Llena Tipos
                ArrayList tipo = tipos.Tipo();
                foreach (String item in tipo)
                {
                    cmbxTipoCargo.Items.Add(item.ToString());
                    cmbxmodTipoCargo.Items.Add(item.ToString());
                }
                //Llena_campos_editar
                cmb_modificar();
                //llena dvg
                llenar_mostrar();
                lblID.Text = (Convert.ToInt32(productos.Obtener_productoId())+1).ToString(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void cmb_modificar()
        {
            cmbmodProdID.Items.Clear();
            productos.CargarProductoMod();
            ArrayList Productos = productos.ArregloProductomod;
            for (int i = 0; i < Productos.Count; i++)
            {
                cmbmodProdID.Items.Add(Productos[i].ToString());
            }


        }
        public void llenar_mostrar()
        {
            dgvProducto.DataSource = productos.VerTodosProductos();
        }

        public void llenar_modifcacion(string indice)
        {
            try
            {
                DataTable tabla = productos.VerProducto(indice);
                DataRow elemento = tabla.Rows[0];

                txtModCodigoBarras.Text = elemento[1].ToString(); ;
                txtmodFolio.Text = elemento[2].ToString(); ;
                txtmodNombre.Text = elemento[3].ToString(); ;
                cmbxmodTipoCargo.Text = "";
                cmbxmodUM.Text = "";
                txtmodPrecioCosto.Text = elemento[6].ToString();
                txtmodPrecioVenta.Text = elemento[7].ToString();
                txtmodPrecioMayoreo.Text = elemento[8].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string a;
            for (int i = 0; i < dgvProducto.Rows.Count; i++)
            {
                a = dgvProducto[2, i].Value.ToString();
                if (a.Contains(txtBuscar.Text))
                {
                    dgvProducto.Rows[i].Selected = true;
                    dgvProducto.FirstDisplayedScrollingRowIndex = i;
                    break;
                }

            }
        }
        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _toolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void txtCostoCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '.' || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

        }
        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            //try
            //{
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Ingrese Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtPrecioCosto.Text == "")
                {
                    MessageBox.Show("Ingrese Precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtFolio.Text == "")
                {
                    MessageBox.Show("Ingrese Folio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbxUM.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Ingrese Unidad Metrica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Txtcodigobarras.Text == "")
                {
                    MessageBox.Show("Ingrese codigo de barras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    productos.AgregarProducto("0", Txtcodigobarras.Text, txtFolio.Text, txtNombre.Text, cmbxTipoCargo.SelectedItem.ToString(),
                        cmbxUM.SelectedItem.ToString(), txtPrecioCosto.Text, txtPrecioVenta.Text, txtPrecioMayore.Text);
                    MessageBox.Show("Producto añadido correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    almacen.AgregarPAlmacen("0",lblID.Text,Txtcodigobarras.Text,txtFolio.Text,txtCantPiso.Text,txtCantAlmacen.Text,
                        txtLocalizacion.Text, DateTime.Now.Date.ToString("dd-MM-yy"));
                    Txtcodigobarras.Text = "";
                    txtFolio.Text = "";
                    txtNombre.Text = "";
                    cmbxTipoCargo.Text = "";





                     
                    cmbxUM.Text = "";
                    txtPrecioCosto.Text = "";
                    txtPrecioVenta.Text = "";
                    txtPrecioMayore.Text = "";

                    txtCantPiso.Text = "";
                    txtCantAlmacen.Text = "";
                    txtLocalizacion.Text = "";
                    //quitar el iva de almacen
                    lblID.Text = (Convert.ToInt32(productos.Obtener_productoId()) + 1).ToString();
                    //actualizar campos                
                    cmb_modificar();
                    llenar_mostrar();
                    //se obtiene proximo id

               }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ocurrio un problema. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("esta seguro que desea eliminar este producto de forma permanente", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    productos.BorrarProducto(cmbmodProdID.SelectedItem.ToString());
                    MessageBox.Show("Producto Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmodFolio.Text = "";
                    txtmodNombre.Text = "";
                    cmbxmodTipoCargo.Text = "";
                    cmbxmodUM.Text = "";
                    txtmodPrecioCosto.Text = "";
                    txtmodPrecioVenta.Text = "";
                    cmbmodProdID.Text = "";
                    txtmodPrecioMayoreo.Text = "";
                    txtModCodigoBarras.Text = "";
                    //obtener_id();
                    llenar_mostrar();
                    cmb_modificar();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string[] id = cmbmodProdID.SelectedItem.ToString().Split(',');
                productos.EditarProducto(id[0].ToString(), txtModCodigoBarras.Text, txtmodFolio.Text,
                 txtmodNombre.Text, cmbxmodTipoCargo.SelectedItem.ToString(), cmbxmodUM.SelectedItem.ToString(),
                 txtmodPrecioCosto.Text, txtmodPrecioVenta.Text, txtmodPrecioMayoreo.Text);
                MessageBox.Show("Producto Modificado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbmodProdID.Text = "";
                txtmodFolio.Text = "";
                txtmodNombre.Text = "";
                cmbxmodTipoCargo.Text = "";
                cmbxmodUM.Text = "";
                txtmodPrecioCosto.Text = "";
                txtmodPrecioVenta.Text = "";

                txtmodPrecioMayoreo.Text = "";
                txtModCodigoBarras.Text = "";
                //actualiza gridview
                llenar_mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbmodProdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] id = cmbmodProdID.SelectedItem.ToString().Split(',');
            llenar_modifcacion(id[0].ToString());
        }

        private void cmbxTipoCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
