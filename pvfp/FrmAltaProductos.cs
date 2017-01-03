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
            BtnGuardar.Image =new  Bitmap(PVFP.Properties.Resources.ImgGuardar);
            btnEliminar.Image = new Bitmap(PVFP.Properties.Resources.Eliminar);
            btnModificar.Image = new Bitmap(PVFP.Properties.Resources.Actualizar);            
        }
        ClsAltaProductos productos = new ClsAltaProductos();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Ingrese Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtCostoCompra.Text == "")
                {
                    MessageBox.Show("Ingrese Precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtFolio.Text == "")
                {
                    MessageBox.Show("Ingrese Folio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }             
                else if (txtUM.Text == "")
                {
                    MessageBox.Show("Ingrese Unidad Metrica", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (TxtMarca.Text == "")
                {
                    MessageBox.Show("Ingrese Marca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtdescripcion.Text == "")
                {
                    MessageBox.Show("Ingrese descripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }              
                else if (txt_codigodebarras.Text == "")
                {
                    MessageBox.Show("Ingrese codigo de barras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {                                 
                    productos.AgregarProducto("0", txtNombre.Text,
                        (cmbCategoria.SelectedIndex + 1).ToString(), txtCostoCompra.Text,
                        cmbTipo.SelectedItem.ToString(), txtFolio.Text, txtdescripcion.Text, txtUM.Text, TxtMarca.Text, Txtcodigobarras.Text);
                    MessageBox.Show("Producto añadido correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCostoCompra.Text = "";
                    txtFolio.Text = "";
                    TxtMarca.Text = "";
                    txtNombre.Text = "";
                    txtUM.Text = "";
                    txtdescripcion.Text = "";
                    cmbTipo.Text = "";
                    cmbCategoria.Text = "";
                    Txtcodigobarras.Text = "";
                    //actualizar campos                
                    cmb_modificar();
                    llenar_mostrar();
                    //se obtiene proximo id
                    obtener_id();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        ClsCategorias Categorias = new ClsCategorias();
        ClsTiposCargos tipos = new ClsTiposCargos();
        SqlConnection conexion = new SqlConnection();  
        //Localizable = true ; --Formato a Form              
        private void FrmAltaProductos_Load(object sender, EventArgs e)
        {
            try
            {
             obtener_id();
            //Lenar categorias            
            Categorias.CargarCategorias();
            ArrayList arrcat = Categorias.ArregloID;
            for (int i = 0; i < arrcat.Count; i++)
            {
                cmbCategoria.Items.Add(arrcat[i].ToString());
                Cmb_categoria.Items.Add(arrcat[i].ToString());
            }
            //Llena Tipos
            ArrayList tipo = tipos.Tipo();
            foreach (String item in tipo)
            {
                
                cmbTipo.Items.Add(item.ToString());
                Cmb_Tipo.Items.Add(item.ToString());                
            }
            //Llena_campos_editar
            cmb_modificar();
            //llena dvg
            llenar_mostrar();          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("esta seguro que desea eliminar este producto de forma permanente", "Borrar", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    productos.BorrarProducto(CmbId.SelectedItem.ToString());
                    MessageBox.Show("Producto Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_unidad_medida.Text = "";
                    Txt_nombre.Text = "";
                    txt_folio.Text = "";
                    txt_descripciom.Text = "";
                    Txt_Compra.Text = "";
                    Cmb_categoria.Text = "";
                    Cmb_Tipo.Text = "";
                    obtener_id();
                    llenar_mostrar();
                    cmb_modificar();
                    CmbId.Text = "";
                    txt_codigodebarras.Text = "";
                    txt_marca.Text = "";
                }                        
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                productos.EditarProducto(CmbId.SelectedItem.ToString(), Txt_nombre.Text ,
                   (Cmb_categoria.SelectedIndex+1).ToString(), Txt_Compra.Text ,
                  Cmb_Tipo.SelectedItem.ToString(), txt_folio.Text, txt_descripciom.Text, txt_unidad_medida.Text,txt_marca.Text,txt_codigodebarras.Text);                
                MessageBox.Show("Producto Modificado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_unidad_medida.Text = "";
                Txt_nombre.Text = "";
                txt_folio.Text = "";
                txt_descripciom.Text = "";
                Txt_Compra.Text = "";
                Cmb_categoria.Text = "";
                Cmb_Tipo.Text = "";
                txt_marca.Text = "";
                txt_codigodebarras.Text = "";
                //actualiza gridview
                llenar_mostrar();
            }         
             catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void cmb_modificar()
        {
            CmbId.Items.Clear();
            foreach (DataRow item in productos.VerTodosProductos().Rows)
            {
                CmbId.Items.Add(item[0]);
            }  
        }
        public void llenar_mostrar()
        {            
            dgvProducto.DataSource = productos.VerTodosProductos();                        
        }
        public void obtener_id()
        {            
                txtProductoID.Text = (Int32.Parse(productos.Obtener_productoId()) + 1).ToString(); ;                       
        }
        public void llenar_modifcacion(string indice) {
            try
            {           
            DataTable tabla= productos.VerProducto(indice);
            DataRow elemento = tabla.Rows[0];
            Txt_nombre.Text = elemento[1].ToString();
            txt_marca.Text = elemento[2].ToString();
            Txt_Compra.Text = elemento[4].ToString();
            txt_folio.Text = elemento[6].ToString();
            txt_unidad_medida.Text = elemento[8].ToString();            
            txt_descripciom.Text= elemento[7].ToString();      
            txt_codigodebarras.Text= elemento[9].ToString();
            Cmb_categoria.SelectedIndex= Int32.Parse( elemento[3].ToString())-1;                           
            for (int i = 0; i < Cmb_Tipo.Items.Count; i++)
            {
                if (Cmb_Tipo.Items[i].ToString() == elemento[5].ToString())
                {
                    Cmb_Tipo.SelectedIndex = i;
                    break;
                }
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CmbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenar_modifcacion(CmbId.SelectedItem.ToString());
        }
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string a;
            for (int i = 0; i < dgvProducto.Rows.Count; i++)
            {
                a = dgvProducto[1, i].Value.ToString();
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
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar=='.' || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
           
        }
    }
}
