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
    public partial class frmEnProv : Form
    {
        public frmEnProv()
        {
            InitializeComponent();
        }
        ClsProveedores Proveedores = new ClsProveedores();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //try
            //{
                Proveedores.AgregarProveedor("0", txtNom.Text, txttel.Text, txtcorreo.Text, txtdire.Text, txtdescr.Text, txtbanco.Text, txtcuenta.Text);
                MessageBox.Show("Proveedor añadido correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                txtdescr.Text = "";
                txtdire.Text = "";
                txtNom.Text = "";
                txttel.Text = "";
                txtcuenta.Text = "";
                txtcorreo.Text = "";
                txtbanco.Text = "";
                
                this.Close();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Proveedor no añadido, revise sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
