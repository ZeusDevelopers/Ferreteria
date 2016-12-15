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
        }

        void cargar()
        {
            perdida.ConsultarPath();
            perdida.CargarPerdida();
            ArrayList arreprodid = perdida.arregloproductoid;
            ArrayList arrecan = perdida.arreglocantidad;
            ArrayList arremot = perdida.arreglomotivo;
            for (int i = 0; i < arreprodid.Count; i++)
            {
                dataGridView1.Rows.Add(arreprodid[i].ToString(), arrecan[i].ToString(), arremot[i].ToString());
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            perdida.GuardarPerdida(0, cmbproducto.SelectedIndex, txtcantidad.Text, txtmotivo.Text);
            MessageBox.Show("Perdida agregada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargar();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
