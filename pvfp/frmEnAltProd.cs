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
            BtnGuardar.Image = new Bitmap(Ferreteria.Properties.Resources.ImgGuardar);
        }
        ClsAltaProductos productos = new ClsAltaProductos();
        ClsAlmacen almacen = new ClsAlmacen();
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
                    almacen.AgregarPAlmacen("0", productos.Obtener_productoId(), Txtcodigobarras.Text, txtFolio.Text, "0", "0",
                        "Fila1", DateTime.Now.Date.ToString("yy-MM-dd"));
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

        private void txtPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char wDecimal = char.Parse(System.Windows.Forms.Application.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if ((txtPrecioCosto.Text.Contains(wDecimal)))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            char wDecimal = char.Parse(System.Windows.Forms.Application.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if ((txtPrecioVenta.Text.Contains(wDecimal)))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void txtPrecioMayore_KeyPress(object sender, KeyPressEventArgs e)
        {
            char wDecimal = char.Parse(System.Windows.Forms.Application.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if ((txtPrecioMayore.Text.Contains(wDecimal)))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void txtPrecioVenta_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPrecioCosto.Text == "" || txtPrecioCosto.Text == "0")
            {
                txtPrecioCosto.Text = "0";
                MessageBox.Show("Agregue un valor al precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtPrecioVenta.Text == "" || txtPrecioVenta.Text == "0")
                {
                    txtPrecioVenta.Text = "0";
                    MessageBox.Show("Agregue un valor entero para calcular un resultado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double pc = Convert.ToDouble(txtPrecioCosto.Text);
                    double porcVent = Convert.ToDouble(txtPrecioVenta.Text);
                    double precioVenta = pc + (pc * (porcVent / 100));
                    lblPrecioVenta.Text = precioVenta.ToString();

                }
            }
        }

        private void txtPrecioMayore_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtPrecioCosto.Text == "" || txtPrecioCosto.Text == "0")
            {
                txtPrecioCosto.Text = "0";
                MessageBox.Show("Agregue un valor al precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtPrecioMayore.Text == "" || txtPrecioMayore.Text == "0")
                {
                    txtPrecioMayore.Text = "0";
                    MessageBox.Show("Agregue un valor entero para calcular un resultado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double pc = Convert.ToDouble(txtPrecioCosto.Text);
                    double porcMayore = Convert.ToDouble(txtPrecioMayore.Text);
                    double precioMayore = pc + (pc * (porcMayore / 100));
                    lblPrecioMayoreo.Text = precioMayore.ToString();

                }
            }
        }
    }
    
}
