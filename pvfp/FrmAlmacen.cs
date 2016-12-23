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
    public partial class FrmAlmacen : Form
    {
        public FrmAlmacen()
        {
            InitializeComponent();
        }
        ClsAlmacen almacen = new ClsAlmacen();
        private void FrmAlmacen_Load(object sender, EventArgs e)
        {
            cargar();
        }

        void cargar()
        {
            dataGridView1.Rows.Clear();
            cmbaalmacen.Items.Clear();
            cmbapiso.Items.Clear();
            almacen.CargarAlmacen();
            ArrayList arrPro = almacen.ArregloProducto;
            ArrayList arrPi = almacen.ArregloPiso;
            ArrayList arrAl = almacen.ArregloAlma;
            for (int i = 0; i < arrPro.Count; i++)
            {
                dataGridView1.Rows.Add(arrPro[i].ToString(),arrPi[i].ToString(), arrAl[i].ToString());
                cmbapiso.Items.Add(arrPro[i].ToString());
                cmbaalmacen.Items.Add(arrPro[i].ToString());
            }
        }

        private void btnapiso_Click(object sender, EventArgs e)
        {
            
            txtcantidadapiso.Text = "";
        }

        private void btnaalmacen_Click(object sender, EventArgs e)
        {

        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
