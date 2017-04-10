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
    public partial class FrmPerdida : Form
    {
        ClsPerdida perdida = new ClsPerdida();

        public FrmPerdida()
        {
            InitializeComponent();
        }

        private void FrmPerdida_Load(object sender, EventArgs e)
        {
            cargar();
            DataTable tb = perdida.productso();
            foreach (DataRow item in tb.Rows)
            {
                cmbproducto.Items.Add(item[0].ToString());
            }
        }

        void cargar()
        {
            dataGridView1.DataSource = perdida.CargarPerdida();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcantidad.Text == "")
                {
                    MessageBox.Show("Ingrese Cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtmotivo.Text == "")
                {
                    MessageBox.Show("Ingrese Motivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmbproducto.SelectedIndex == -1)
                {
                    MessageBox.Show("Ingrese Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    perdida.GuardarPerdida(0, cmbproducto.SelectedIndex, txtcantidad.Text, txtmotivo.Text);
                    MessageBox.Show("Perdida agregada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }          
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
