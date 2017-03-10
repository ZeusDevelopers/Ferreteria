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
            dgvProductos.Rows.Add(r[0], r[1], r[2],r[3], r[4]);
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
                
                    string[] prov = cmbProveedores.SelectedItem.ToString().Split('-');
                    entradas.agrEntrada(txtEntradaID.Text, prov[0], DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"),
                        txtTotalCompra.Text, "1");

                    //YYYY-MM-DD mysql

                    for (int i = 0; i < dgvProductos.RowCount; i++)
                    {
                        string[] id = dgvProductos[0, i].Value.ToString().Split('-');
                        entradas.agrEntrada_Detalle(txtEntradaID.Text, id[0].ToString(),
                        dgvProductos[1, i].Value.ToString(), dgvProductos[2, i].Value.ToString(),
                        dgvProductos[3, i].Value.ToString());
                        double cantidaProducto= Convert.ToDouble(almacen.CantidadAlmacen(id[0].ToString())) + Convert.ToDouble(dgvProductos[1, i].Value.ToString());
                        almacen.AgregarDesdeEntrada(cantidaProducto.ToString(), DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"), id[0].ToString());
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
