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
       
        private void frmEnAltProd_Load(object sender, EventArgs e)
        {
           
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
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

                    Txtcodigobarras.Text = "";
                    txtFolio.Text = "";
                    txtNombre.Text = "";
                    cmbxTipoCargo.Text = "";
                    cmbxUM.Text = "";
                    txtPrecioCosto.Text = "";
                    txtPrecioVenta.Text = "";
                    txtPrecioMayore.Text = "";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
