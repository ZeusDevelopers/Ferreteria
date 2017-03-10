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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }
        ClsProveedores Proveedores = new ClsProveedores();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedores.AgregarProveedor("0", txtNom.Text, txttel.Text, txtcorreo.Text, txtdire.Text, txtdescr.Text, txtbanco.Text, txtcuenta.Text);
                MessageBox.Show("Proveedor añadido correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargar();
                txtdescr.Text = "";
                txtdire.Text = "";
                txtNom.Text = "";
                txttel.Text = "";
                txtcuenta.Text = "";
                txtcorreo.Text = "";
                txtbanco.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Proveedor no añadido, revise sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            cargar();
        }

        void cargar()
        {
            dataGridView1.Rows.Clear();
            cmbNombre.Items.Clear();
            Proveedores.CargarProveedores();
            ArrayList arrNom = Proveedores.ArregloNom;
            ArrayList arrTel = Proveedores.ArregloTel;
            ArrayList arrCor = Proveedores.ArregloCor;
            ArrayList arrDir = Proveedores.ArregloDir;
            ArrayList arrBan = Proveedores.ArregloBan;
            ArrayList arrCue = Proveedores.ArregloCue;
            ArrayList arrDes = Proveedores.ArregloDes;
            for (int i = 0; i < arrNom.Count; i++)
            {
                dataGridView1.Rows.Add(arrNom[i].ToString(), arrTel[i].ToString(), arrCor[i].ToString(), arrDir[i].ToString(), arrBan[i].ToString(), arrCue[i].ToString(), arrDes[i].ToString());
            }
            ////////////            
            Proveedores.CargarProveedoresNombre();
            ArrayList arrNom1 = Proveedores.ArregloNombre;
            for (int i = 0; i < arrNom1.Count; i++)
            {
                cmbNombre.Items.Add(arrNom1[i].ToString());
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedores.EditarProveedores(cmbNombre.SelectedIndex.ToString(), txtNom.Text,txttel.Text,txtcorreo.Text,txtdire.Text,txtbanco.Text,txtcuenta.Text,txtdescr.Text);
                MessageBox.Show("Editado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdescr.Text = "";
                txtdire.Text = "";
                txtNom.Text = "";
                txttel.Text = "";
                txtcuenta.Text = "";
                txtcorreo.Text = "";
                txtbanco.Text = "";
                cargar();
            }
            catch (Exception)
            {
                MessageBox.Show("Categoria no editada, revise sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {           
            Proveedores.CargarProveedores();
            ArrayList ArregloNom = Proveedores.ArregloNom;
            ArrayList ArregloTel = Proveedores.ArregloTel;
            ArrayList ArregloCor = Proveedores.ArregloCor;
            ArrayList ArregloDir = Proveedores.ArregloDir;
            ArrayList ArregloBan = Proveedores.ArregloBan;
            ArrayList ArregloCue = Proveedores.ArregloCue;
            ArrayList ArregloDes = Proveedores.ArregloDes;
            txtNom.Text = ArregloNom[cmbNombre.SelectedIndex].ToString();
            txttel.Text = ArregloTel[cmbNombre.SelectedIndex].ToString();
            txtcorreo.Text = ArregloCor[cmbNombre.SelectedIndex].ToString();
            txtdire.Text = ArregloDir[cmbNombre.SelectedIndex].ToString();
            txtbanco.Text = ArregloBan[cmbNombre.SelectedIndex].ToString();
            txtcuenta.Text = ArregloCue[cmbNombre.SelectedIndex].ToString();
            txtdescr.Text = ArregloDes[cmbNombre.SelectedIndex].ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedores.BorrarProveedor(cmbNombre.SelectedIndex.ToString());
                MessageBox.Show("Proveedor eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargar();
            }
            catch (Exception)
            {
                MessageBox.Show("Proveedor no eliminada, revise sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
