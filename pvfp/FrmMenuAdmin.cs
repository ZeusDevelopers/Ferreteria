using Ferreteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVFP
{
    public partial class FrmMenuAdmin : Form
    {
        public FrmMenuAdmin()
        {
            InitializeComponent();
        }
        FrmAltaProductos alta;
        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (alta == null)
            {
                alta = new FrmAltaProductos();
                alta.Show();
            }
            else if (!alta.Visible)
            {
                alta = new FrmAltaProductos();
                alta.Show();
            }
            else
            {
                alta.BringToFront();
            }            
        }
        Frm_Consulta categorias;
        private void button2_Click(object sender, EventArgs e)
        {
            if (categorias == null)
            {
                categorias = new Frm_Consulta();
                categorias.Show();
            }
            else if (!categorias.Visible)
            {
                categorias = new Frm_Consulta();
                categorias.Show();
            }
            else
            {
                categorias.BringToFront();
            }            
        }
        FrmEmpleados empleados;
        private void button1_Click(object sender, EventArgs e)
        {
            if (empleados == null)
            {
                empleados = new FrmEmpleados();
                empleados.Show();
            }
            else if (!empleados.Visible)
            {
                empleados = new FrmEmpleados();
                empleados.Show();
            }
            else
            {
                empleados.BringToFront();
            }            
        }
        FrmProveedores proveedores;
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            if (proveedores == null)
            {
                proveedores = new FrmProveedores();
                proveedores.Show();
            }
            else if (!proveedores.Visible)
            {
                proveedores = new FrmProveedores();
                proveedores.Show();
            }
            else
            {
                proveedores.BringToFront();
            }            
        }
        Frm_Devolucion tiposcargos;
        private void btnTCargos_Click(object sender, EventArgs e)
        {
            if (tiposcargos == null)
            {
                tiposcargos = new Frm_Devolucion();
                tiposcargos.Show();
            }
            else if (!tiposcargos.Visible)
            {
                tiposcargos = new Frm_Devolucion();
                tiposcargos.Show();
            }
            else
            {
                tiposcargos.BringToFront();
            }            
        }
        FrmPerdida perdida;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (perdida == null)
            {
                perdida = new FrmPerdida();
                perdida.Show();
            }
            else if (!perdida.Visible)
            {
                perdida = new FrmPerdida();
                perdida.Show();
            }
            else
            {
                perdida.BringToFront();
            }
        }
        Frm_Almacen almacen;
        private void BtnAlmacen_Click(object sender, EventArgs e)
        {
            //FrmAlmacen almacen = new FrmAlmacen();
            if (almacen == null)
            {
                almacen = new Frm_Almacen();
                almacen.Show();
            }           
            else if (!almacen.Visible)
            {
                almacen = new Frm_Almacen();
                almacen.Show();
            }
            else
            {
                almacen.BringToFront();
            }
        }
        //FrmConsultaMayorProductos mayor = new FrmConsultaMayorProductos();

        private void mayorVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  mayor.Show();
        }

        private void mayorSemanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mayor.Show();
        }

        private void mayorDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mayor.Show();
        }
        FrmEntradas Entradas;
        private void btnEntradas_Click(object sender, EventArgs e)
        {
            if (Entradas == null)
            {
                Entradas = new FrmEntradas();
                Entradas.Show();
            }
            else if (! Entradas.Visible)
            {
                Entradas = new FrmEntradas();
                Entradas.Show();
            }
            else
            {
                Entradas.BringToFront();
            }           
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenuAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClsInicioSesion.Usuario = "";
        }

        private void FrmMenuAdmin_Load(object sender, EventArgs e)
        {

        }
        private FrmPuntoVenta frm;
        private void Btn_venta_admin_Click(object sender, EventArgs e)
        {
            if (frm == null)
            {
                frm = new FrmPuntoVenta(true);
                frm.Show();
            }            
            else if (!frm.Visible)
            {
                frm = new FrmPuntoVenta(true);
                frm.Show();
            }
            else
            {
                frm.BringToFront();
            }

        }
    }
}
