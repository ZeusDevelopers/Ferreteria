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
        private void btnAgrPG_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "") { txtCantidad.Text = "0"; }
            if (txtCostoUnit.Text == "") { txtCostoUnit.Text = "0"; }
            txtTotalProducto.Text = (Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtCostoUnit.Text)).ToString();
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
            cmbProducto.Items.Add("0,Registrar Producto");
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
        }
    }
}
