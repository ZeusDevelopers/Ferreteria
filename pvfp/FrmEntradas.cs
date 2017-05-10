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
    public partial class FrmEntradas : Form
    {
        public FrmEntradas()
        {
            InitializeComponent();
        }
        ClsAltaProductos productos = new ClsAltaProductos();
        ClsProveedores proveedor = new ClsProveedores();
        ClsEntrada entradas = new ClsEntrada();
        ClsAlmacen almacen = new ClsAlmacen();


        private void FrmEntradas_Load(object sender, EventArgs e)
        {
            //obtener_id();
            llenarProvedores();
            // llenarProductos();
            llenar_mostrar();
        }
        public void llenar_mostrar()
        {
            dgvEntradas.Rows.Clear();

            ArrayList arrEntradas = entradas.CargarEntradas();
            for (int i = 0; i < arrEntradas.Count; i++)
            {
                
                string[] r = arrEntradas[i].ToString().Split('|');
                dgvEntradas.Rows.Add(r[0], r[1], r[2], r[3], r[4], "VerDetalle");
            }
        }
        private void btnAgrProductos_Click(object sender, EventArgs e)
        {
            //gbxEntrada.Visible = false;
            //gbxEntCompra.Visible = true;
            frmEntradasDetalle entDetalle = new frmEntradasDetalle();
            entDetalle.agrRenglon += new frmEntradasDetalle.pasar(AgregarRenglon);
            bool form_abierto = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType()== typeof(frmEntradasDetalle))
                {
                    form_abierto = true;
                }
            }
            if (form_abierto==false)
            {
                entDetalle.Show();
            }

            
        }
        public void AgregarRenglon(string renglon)
        {
            string[] r = renglon.Split('|');
            dgvProductos.Rows.Add(r[0], r[1], r[2],r[3],"Almacen", r[4],"Editar" );
            CalularTotal();
        }
        #region LoadForma
        public void llenarProvedores()
        {
            cmbProveedores.Items.Clear();
            
            proveedor.CargarProveedor();
            ArrayList arrprov = proveedor.ArgProveedor;
            cmbProveedores.Items.Add("0-Registrar Proveedor");
            for (int i = 0; i < arrprov.Count; i++)
            {
                cmbProveedores.Items.Add(arrprov[i].ToString());
            }
        }
        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProveedores.SelectedIndex == 0)
            {
                frmEnProv AltProv = new frmEnProv();
                AltProv.Show();
            }
        }

        private void cmbProveedores_Click(object sender, EventArgs e)
        {
            llenarProvedores();
        }


        #endregion
        //private void btnTerminar_Click(object sender, EventArgs e)
        //{
        //    gbxEntrada.Visible = true;
        //    gbxEntCompra.Visible = false;
        //    lblTotProd.Visible = false;
        //    txtTotalProducto.Visible = false;
        //    CalularTotal();
        //}




        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentCell.ColumnIndex == 5)
            {
                dgvProductos.Rows.RemoveAt(dgvProductos.CurrentCell.RowIndex);
                CalularTotal();

            }
            if (dgvProductos.CurrentCell.ColumnIndex == 6)
            {
                txtCantidad.Text = dgvProductos[1, dgvProductos.CurrentCell.RowIndex].Value.ToString();
                txtCostoUn.Text = dgvProductos[2, dgvProductos.CurrentCell.RowIndex].Value.ToString();
                lblImporte.Text = dgvProductos[3, dgvProductos.CurrentCell.RowIndex].Value.ToString();
                lblIndex.Text = dgvProductos.CurrentCell.RowIndex.ToString();

                txtCantidad.Visible = true;
                txtCostoUn.Visible = true;
                lblImporte.Visible = true;
                btnEditar.Visible = true;
                label3.Visible = true;
                label7.Visible = true;
                label8.Visible = true;

            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        { int index =Convert.ToInt32(lblIndex.Text);
            dgvProductos[1, index].Value=txtCantidad.Text.ToString();
            dgvProductos[2, index].Value= txtCostoUn.Text.ToString();
            dgvProductos[3, index].Value = lblImporte.Text.ToString();
            CalularTotal();
            txtCantidad.Visible = false;
            txtCostoUn.Visible = false;
            lblImporte.Visible = false;
            btnEditar.Visible = false;
            label3.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
        }
        
        private void CalularTotal()
        {
            double TotalCompra = 0;
            if (dgvProductos.RowCount > 0)
            {
                for (int i = 0; i < dgvProductos.RowCount; i++)
                {
                    TotalCompra += Convert.ToDouble(dgvProductos[3, i].Value.ToString());
                }
            }
            txtTotalCompra.Text = TotalCompra.ToString();
            double iva = Convert.ToDouble(txtIVA.Text); double SumProd = Convert.ToDouble(txtTotalCompra.Text);
            double ImporteTotal = SumProd + (iva * SumProd);
            txtTotalImporte.Text = ImporteTotal.ToString();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.RowCount <= 0)
                {
                MessageBox.Show("Añada un producto a la lista para comprar", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               else if (cmbProveedores.SelectedItem.ToString() == ""|| cmbProveedores.SelectedIndex==0)
                {
                    MessageBox.Show("Elija un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //else if (cmbLugarAlmacen.SelectedItem.ToString() == "" || cmbProveedores.SelectedIndex == 0)
                //{
                //    MessageBox.Show("Elija un Lugar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                else if (txtEntradaID.Text == "")
                {
                    MessageBox.Show("Ingrese Numero de Factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int EmpleadoID = ClsInicioSesion.empleados_id;
                    string[] prov = cmbProveedores.SelectedItem.ToString().Split('-');
                    double iva = Convert.ToDouble(txtIVA.Text); double SumProd = Convert.ToDouble(txtTotalCompra.Text);
                    double ImporteTotal = SumProd+(iva*SumProd);
                    entradas.agrEntrada(txtEntradaID.Text, prov[0], DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"),
                       ImporteTotal.ToString(), EmpleadoID.ToString());

                    //YYYY-MM-DD mysql

                    for (int i = 0; i < dgvProductos.RowCount; i++)
                    {
                        string[] id = dgvProductos[0, i].Value.ToString().Split('-');
                        entradas.agrEntrada_Detalle(txtEntradaID.Text, id[0].ToString(),
                        dgvProductos[1, i].Value.ToString(), dgvProductos[2, i].Value.ToString(),
                        dgvProductos[3, i].Value.ToString());
                        double cantidaProducto= Convert.ToDouble(almacen.CantidadtablaAlmacen(id[0].ToString(), "A_" + dgvProductos[4, i].Value.ToString())) + Convert.ToDouble(dgvProductos[1, i].Value.ToString());
                        almacen.AgregarDesdeEntrada(cantidaProducto.ToString(), "A_"+ dgvProductos[4, i].Value.ToString(), DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"), id[0].ToString());
                        productos.ModifPrecio(id[0].ToString(), dgvProductos[2, i].Value.ToString());
                    }
                    MessageBox.Show("Registro de entrada añadido correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProductos.Rows.Clear();
                    txtTotalCompra.Text = "0";
                    txtTotalImporte.Text = "0";
                    llenar_mostrar();
                    //obtener_id();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmMenuAdmin menu = new FrmMenuAdmin();
            menu.Show();
            this.Close();
        }
        
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

        private void txtCostoUn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char wDecimal = char.Parse(System.Windows.Forms.Application.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if ((txtCostoUn.Text.Contains(wDecimal)))
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

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCantidad.Text == "") { txtCantidad.Text = "0"; }
            if (txtCostoUn.Text == "") { txtCostoUn.Text = "0"; }
            lblImporte.Text = (Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtCostoUn.Text)).ToString();
        }

        private void txtCostoUn_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCantidad.Text == "") { txtCantidad.Text = "0"; }
            if (txtCostoUn.Text == "") { txtCostoUn.Text = "0"; }
            lblImporte.Text = (Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtCostoUn.Text)).ToString();
        }

        private void xToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (cmb_tipo_busquedaMostrar.SelectedIndex != -1)
            {
                string a;
                if (cmb_tipo_busquedaMostrar.SelectedIndex == 1)
                {
                    for (int i = 0; i < dgvEntradas.Rows.Count; i++)
                    {
                        dgvEntradas.Rows[i].Selected = false;
                        a = dgvEntradas[2, i].Value.ToString();
                        if (a.Contains(txtBuscar.Text))
                        {
                            dgvEntradas.Rows[i].Selected = true;
                            dgvEntradas.FirstDisplayedScrollingRowIndex = i;
                            break;
                        }

                    }
                }
                else
                {
                    for (int i = 0; i < dgvEntradas.Rows.Count; i++)
                    {
                        dgvEntradas.Rows[i].Selected = false;
                        a = dgvEntradas[0, i].Value.ToString();
                        if (a.Contains(txtBuscar.Text))
                        {
                            dgvEntradas.Rows[i].Selected = true;
                            dgvEntradas.FirstDisplayedScrollingRowIndex = i;
                            break;
                        }

                    }
                }

            }
        }

        private void dgvEntradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEntradas.CurrentCell.ColumnIndex == 5)
            {
                dgvEntDetalle.DataSource = entradas.VerEntradaDetalle(dgvEntradas[0, dgvEntradas.CurrentCell.RowIndex].Value.ToString());
                cmb_tipo_busquedaMostrar.Visible = false;
                label19.Visible = false;
                txtBuscar.Visible = false;
                Btn_Buscar.Visible = false;
                dgvEntradas.Visible = false;
                dgvEntDetalle.Visible = true;
                btnVerEntradas.Visible = true;
            }
        }

        private void btnVerEntradas_Click(object sender, EventArgs e)
        {
            cmb_tipo_busquedaMostrar.Visible = true;
            label19.Visible = true;
            txtBuscar.Visible = true;
            Btn_Buscar.Visible = true;
            dgvEntradas.Visible = true;
            dgvEntDetalle.Visible = false;
            btnVerEntradas.Visible = false;
        }
    }
}
