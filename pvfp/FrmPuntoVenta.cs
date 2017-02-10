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
    public partial class FrmPuntoVenta : Form
    {
        public FrmPuntoVenta()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap(Btn_comprar.ClientRectangle.Width, Btn_comprar.ClientRectangle.Height+40);
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.Clear(Btn_comprar.BackColor);

                string line1 = "Cobrar " ;
                string line2 = "(F6)";

                StringFormat SF = new StringFormat();
                SF.Alignment = StringAlignment.Center;
                //SF.LineAlignment = StringAlignment.Near;
                G.DrawImage(PVFP.Properties.Resources.Icono,24,2,40,40);
                using (Font arial = new Font("Arial", 14))
                {
                    Rectangle RC = Btn_comprar.ClientRectangle;
                    RC.Inflate(-8, -43);
                    G.DrawString(line1, arial, Brushes.Black, RC, SF);
                }

                
            }
            Btn_comprar.Image = bmp;
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }        
        private void Txtcodigo_Leave(object sender, EventArgs e)
        {
            Txtcodigo.ForeColor = Color.Silver;
            Txtcodigo.Text = "Escanee codigo de barras ";
            Txtcodigo.Font = new Font(Txtcodigo.Font, FontStyle.Italic);
        }
        private void Txtcodigo_Enter(object sender, EventArgs e)
        {
            if (Txtcodigo.Text== "Escanee codigo de barras ")
            {
                Txtcodigo.Text = "";
            }
            Txtcodigo.ForeColor = Color.Black;
            Txtcodigo.Font = new Font(Txtcodigo.Font, FontStyle.Regular);
        }

        private void Btn_comprar_Click(object sender, EventArgs e)
        {
           DialogResult r= MessageBox.Show("Pago con tarjeta", "Pago", MessageBoxButtons.YesNo);
            if (r.ToString()=="No")
            {
                GbVenta.Visible = true;
            }
            Btn_comprar.Enabled = false;
        }

        private void Txt_efectivo_Leave(object sender, EventArgs e)
        {
            Txt_efectivo.ForeColor = Color.Silver;
            Txt_efectivo.Text = "$ 0.00";
            Txt_efectivo.Font = new Font(Txt_efectivo.Font, FontStyle.Italic);
        }
        private void Txt_efectivo_Enter(object sender, EventArgs e)
        {
            if (Txt_efectivo.Text == "$ 0.00")
            {
                Txt_efectivo.Text = "";
            }
            Txt_efectivo.ForeColor = Color.Black;
            Txt_efectivo.Font = new Font(Txt_efectivo.Font, FontStyle.Regular);
        }
        private void Txt_efectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) ||  e.KeyChar!='.' || !Char.IsControl(e.KeyChar) )
            {
                e.Handled = false;
            }   
            else
            {
                MessageBox.Show("Solo se permiten numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Btn_comprar.Enabled = true;
            GbVenta.Visible = false;
        }
        private void Limpiar()
        {
            Txt_efectivo.ForeColor = Color.Silver;
            Txt_efectivo.Text = "$ 0.00";
            Txt_efectivo.Font = new Font(Txt_efectivo.Font, FontStyle.Italic);
            Lbltotal.Text= "$ 0.00";
            Lbl_cambio.Text = "$ 0.00";
        }
    }
}
