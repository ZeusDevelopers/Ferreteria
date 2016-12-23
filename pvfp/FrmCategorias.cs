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
    public partial class FrmCategorias : Form
    {
        ClsCategorias Categorias = new ClsCategorias();
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            cargar();
        }
        void cargar()
        {
            cmbCategoriaEditar.Items.Clear();
            dataGridView1.Rows.Clear();
            Categorias.ConsultarPath();
            Categorias.CargarCategorias();
            ArrayList arrID = Categorias.ArregloID;
            ArrayList arrDes = Categorias.ArregloDescripcion;
            for (int i = 0; i < arrID.Count; i++)
            {
                dataGridView1.Rows.Add(arrID[i].ToString(), arrDes[i].ToString());
                cmbCategoriaEditar.Items.Add(arrID[i].ToString());
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Categorias.AgregarCategorias(txtCategoriaAgregar.Text, txtDescripcionAgregar.Text);
                MessageBox.Show("Añadido correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategoriaAgregar.Text = ""; txtDescripcionAgregar.Text = "";
                cargar();
            }
            catch (Exception)
            {
                MessageBox.Show("Categoria no agregada, revise sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Categorias.EditarCategorias(cmbCategoriaEditar.SelectedItem.ToString(), txtDescripcionEditar.Text);
                MessageBox.Show("Editado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargar();
            }
            catch (Exception)
            {
                MessageBox.Show("Categoria no editada, revise sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Categorias.BorrarCategorias(cmbCategoriaEditar.SelectedItem.ToString());
                MessageBox.Show("Editado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescripcionEditar.Text = "";
                cargar();
            }
            catch(Exception)
            {
                MessageBox.Show("Categoria no eliminada, revise sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCategoriaEditar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Categorias.ConsultarPath();
            Categorias.CargarCategorias();
            ArrayList arrDes = Categorias.ArregloDescripcion;
            txtDescripcionEditar.Text = arrDes[cmbCategoriaEditar.SelectedIndex].ToString();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
