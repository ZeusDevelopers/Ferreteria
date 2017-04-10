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

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmAltaProductos alta = new FrmAltaProductos();
            alta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            Frm_Consulta categorias = new Frm_Consulta();
            categorias.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEmpleados empleados = new FrmEmpleados();
            empleados.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores proveedores = new FrmProveedores();
            proveedores.Show();
        }

        private void btnTCargos_Click(object sender, EventArgs e)
        {
            //FrmTiposCargos tiposcargos = new FrmTiposCargos();
            Frm_Devolucion tiposcargos = new Frm_Devolucion();
            tiposcargos.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmPerdida perdida = new FrmPerdida();
            perdida.Show();
        }

        private void BtnAlmacen_Click(object sender, EventArgs e)
        {
            FrmAlmacen almacen = new FrmAlmacen();
            almacen.Show();
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

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            FrmEntradas Entradas = new FrmEntradas(); ;
            Entradas.Show();
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

        private void Btn_venta_admin_Click(object sender, EventArgs e)
        {
            FrmPuntoVenta frm = new FrmPuntoVenta(true);
            frm.Show();
        }
    }
}
