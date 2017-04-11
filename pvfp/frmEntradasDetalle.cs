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
    public partial class frmEntradasDetalle : Form
    {
        public frmEntradasDetalle()
        {
            InitializeComponent();
        }

        ClsAltaProductos productos = new ClsAltaProductos();
        public delegate void pasar(string renglon);
        public event pasar agrRenglon;
        private void frmEntradasDetalle_Load(object sender, EventArgs e)
        {
            cmbProducto.Visible = false;
            label1.Visible = false;
            Txtcodigo.Visible = false;
            btnBuscar.Visible = false;
            llenarProductos();
        }
        private void btnAgrPG_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "") { txtCantidad.Text = "0"; }
            if (txtCostoUnit.Text == "") { txtCostoUnit.Text = "0"; }
            txtTotalProducto.Text = (Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtCostoUnit.Text)).ToString();
            agrRenglon(cmbProducto.SelectedItem.ToString() + "|" + txtCantidad.Text + "|" + txtCostoUnit.Text + "|" + txtTotalProducto.Text + "|Quitar");
            //  dgvProductos.Rows.Add(cmbProducto.SelectedItem.ToString(), txtCantidad.Text, txtCostoUnit.Text,
            //   txtTotalProducto.Text, "Quitar");
            txtCantidad.Text = "";
            txtCostoUnit.Text = "";
            txtTotalProducto.Text = "";
            lblTotProd.Visible = false;
            txtTotalProducto.Visible = false;
            cmbProducto.Refresh();
        }

        private void btnCalTotProd_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "") { txtCantidad.Text = "0"; }
            if (txtCostoUnit.Text == "") { txtCostoUnit.Text = "0"; }
            lblTotProd.Visible = true;
            txtTotalProducto.Visible = true;
            txtTotalProducto.Text = (Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtCostoUnit.Text)).ToString();

        }
        #region keypress
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            char wDecimal = char.Parse(System.Windows.Forms.Application.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if ((txtCantidad.Text.Contains(wDecimal)))
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

        private void txtCostoUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char wDecimal = char.Parse(System.Windows.Forms.Application.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if ((txtCantidad.Text.Contains(wDecimal)))
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
        #endregion
        private void cmbProducto_Click(object sender, EventArgs e)
        {
            llenarProductos();
        }
        public void llenarProductos()
        {
            cmbProducto.Items.Clear();
            productos.CargarProductoMod();
            ArrayList arrprod = productos.ArregloProductomod;
            cmbProducto.Items.Add("0-Registrar Producto");
            for (int i = 0; i < arrprod.Count; i++)
            {
                cmbProducto.Items.Add(arrprod[i].ToString());
            }
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == 0)
            {
                frmEnAltProd AltProd = new frmEnAltProd();
                AltProd.Show();
            }
            else
            {
                string[] id= cmbProducto.SelectedItem.ToString().Split('-');
                lblPrecioAnterior.Text = productos.ObtenerPrecio(id[0].ToString()).ToString();
            }
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Cmb_tipo_busqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_tipo_busqueda.SelectedIndex == 2)
            {
                cmbProducto.Visible = true;
                label1.Visible = true;
                Txtcodigo.Visible = false;
                btnBuscar.Visible = false;
            }
            if (Cmb_tipo_busqueda.SelectedIndex <2)
            {
                cmbProducto.Visible = false;
                label1.Visible = false;
                Txtcodigo.Visible = true;
                btnBuscar.Visible = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Cmb_tipo_busqueda.SelectedIndex != -1)
            {
                if (Cmb_tipo_busqueda.SelectedIndex == 0)
                {
                    int a = productos.BuscarCodigoBarra(Txtcodigo.Text);
                    if (a > 0)
                    {
                        productos.BuscarProdCargarProductoMod(Txtcodigo.Text);
                        ArrayList Productos = productos.ArregloProductomod;
                        cmbProducto.SelectedIndex = cmbProducto.FindString(Productos[0].ToString());
                        string[] id = Productos[0].ToString().Split('-');
                       lblPrecioAnterior.Text= productos.ObtenerPrecio(id[0].ToString()).ToString();
                        MessageBox.Show(id[1].ToString(), "Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }
                if (Cmb_tipo_busqueda.SelectedIndex == 1)
                {
                    int a = productos.BuscarFolio(Txtcodigo.Text);
                    if (a > 0)
                    {
                        productos.BuscarPFolioProductoMod(Txtcodigo.Text);
                        ArrayList Productos = productos.ArregloProductomod;
                        cmbProducto.SelectedIndex = cmbProducto.FindString(Productos[0].ToString());
                        string[] id = Productos[0].ToString().Split('-');
                        lblPrecioAnterior.Text = productos.ObtenerPrecio(id[0].ToString()).ToString();
                        MessageBox.Show(id[1].ToString(), "Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                }

            }
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCantidad.Text == "") { txtCantidad.Text = "0"; }
            if (txtCostoUnit.Text == "") { txtCostoUnit.Text = "0"; }
            lblTotProd.Visible = true;
            txtTotalProducto.Visible = true;
            txtTotalProducto.Text = (Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtCostoUnit.Text)).ToString();

        }

        private void txtCostoUnit_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCantidad.Text == "") { txtCantidad.Text = "0"; }
            if (txtCostoUnit.Text == "") { txtCostoUnit.Text = "0"; }
            lblTotProd.Visible = true;
            txtTotalProducto.Visible = true;
            txtTotalProducto.Text = (Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtCostoUnit.Text)).ToString();

        }
    }
}
