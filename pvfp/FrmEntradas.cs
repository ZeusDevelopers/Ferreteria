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


        private void FrmEntradas_Load(object sender, EventArgs e)
        {
            //obtener_id();
            llenarProvedores();
           // llenarProductos();
        }
        private void btnAgrProductos_Click(object sender, EventArgs e)
        {
            //gbxEntrada.Visible = false;
            //gbxEntCompra.Visible = true;
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
                Form  frmEntDetalle= new frmEntradasDetalle();
                frmEntDetalle.Show();
            }
        }
        #region LoadForma
        public void llenarProvedores()
        {
            cmbProveedores.Items.Clear();
            
            proveedor.CargarProveedor();
            ArrayList arrprov = proveedor.ArgProveedor;
            cmbProveedores.Items.Add("0,Registrar Proveedor");
            for (int i = 0; i < arrprov.Count; i++)
            {
                cmbProveedores.Items.Add(arrprov[i].ToString());
            }
        }
        //public void llenarProductos()
        //{
        //    cmbProducto.Items.Clear();            
        //    productos.CargarProductoMod();
        //    ArrayList arrprod = productos.ArregloProductomod;
        //    cmbProducto.Items.Add("0,Registrar Producto");
        //    for (int i = 0; i < arrprod.Count; i++)
        //    {
        //        cmbProducto.Items.Add(arrprod[i].ToString());
        //    }
        //}

        public void obtener_id()
        {
            try
            {
                txtEntradaID.Text = (Int32.Parse(entradas.Obtener_entradaId()) + 1).ToString(); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dgvProductos.CurrentCell.ColumnIndex == 4)
            {
                dgvProductos.Rows.RemoveAt(dgvProductos.CurrentCell.RowIndex);
                CalularTotal();
            }
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
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.RowCount > 0)
                {
                    string[] prov = cmbProveedores.SelectedItem.ToString().Split(',');
                    entradas.agrEntrada(txtEntradaID.Text, prov[0], DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"),
                        txtTotalCompra.Text, "1");

                    for (int i = 0; i < dgvProductos.RowCount; i++)
                    {
                        string[] id = dgvProductos[0, i].Value.ToString().Split(',');
                        entradas.agrEntrada_Detalle(txtEntradaID.Text, id[0].ToString(),
                        dgvProductos[1, i].Value.ToString(), dgvProductos[2, i].Value.ToString(),
                        dgvProductos[3, i].Value.ToString());
                    }
                    MessageBox.Show("Registro de entrada añadido correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProductos.Rows.Clear();
                    txtTotalCompra.Text = "0";
                    //obtener_id();
                }
                else
                { MessageBox.Show("Añada un producto a la lista para comprar", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Information); }
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

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
