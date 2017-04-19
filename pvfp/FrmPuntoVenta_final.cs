using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVFP
{
    public partial class FrmPuntoVenta_final : Form
    {
        ClsVentas vender = new ClsVentas();
        NumberFormatInfo nfi = new CultureInfo("Es-MX", false).NumberFormat;
        DataTable ven = new DataTable();
        double venta = 100,total=0,val1=0,val2=0,val3=0,cambio=0;
        double dolar = 0,tot,iva,subtotal;
        FrmPuntoVenta frm = null;

        public FrmPuntoVenta_final(double dolar,double total,double iva, double subtotal,DataTable ven,Form forma)
        {
            InitializeComponent();
            frm= forma as FrmPuntoVenta;
            this.dolar = dolar;
            this.iva = iva;
            this.subtotal = subtotal;
            this.ven = ven;
            this.venta = total;
        }
        private void BtnEfectivo_Click(object sender, EventArgs e)
        {
            Txtdinero.Text = "";
            txttarjeta.Text = "";
            Btn_Pagar.Enabled = false;
            chck_pagodolar.Visible = true;
            LblTarjeta.Visible = false;
            txttarjeta.Visible = false;
            Txtdinero.Visible = true;
            Lblefectivo.Visible = true;
            Lblefectivo.Text = "Efectivo";
            chck_pagodolar.Checked = false;
            txttarjeta.Visible = false;
            LblTarjeta.Visible = false;
            Lblcam.Text = "$0.00";
            val1 = 0; val2 = 0; val3 = 0; total=0;
        }
        private void BtnTarjeta_Click(object sender, EventArgs e)
        {
            Txtdinero.Text = "";
            txttarjeta.Text = "";
            Btn_Pagar.Enabled = false;
            chck_pagodolar.Visible = false;
            LblTarjeta.Visible = false;
            chck_pagodolar.Checked = false;
            txttarjeta.Visible = false;
            Txtdinero.Visible = true;
            Lblefectivo.Visible = true;
            Lblefectivo.Text = "Tarjeta";
            lbldolar.Visible = false;
            txtdolar.Visible = false;
            txttarjeta.Visible = false;
            val1 = 0; val2 = 0; val3 = 0; total = 0;
            LblTarjeta.Visible = false;
            Lblcam.Text = "$0.00";
        }
        private void Btncombinado_Click(object sender, EventArgs e)
        {
            Txtdinero.Text = "";
            txttarjeta.Text = "";
            Btn_Pagar.Enabled = false;
            chck_pagodolar.Visible = true;
            LblTarjeta.Visible = false;
            LblTarjeta.Visible = true;
            txttarjeta.Visible = true;
            Txtdinero.Visible = true;
            Lblefectivo.Visible = true;
            Lblcam.Text = "$0.00";
            Lblefectivo.Text = "Efectivo";            
            chck_pagodolar.Checked = false;
            val1 = 0; val2 = 0; val3 = 0; total = 0;
        }
        private void chck_pagodolar_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_pagodolar.Checked)
            {
                LblDolarPrecio.Visible = true;
                txtdolar.Visible = true;
                lbldolar.Visible = true;
                Lbl_total_dlls.Visible = true;
            }
            else
            {
                Lbl_total_dlls.Visible = false;
                LblDolarPrecio.Visible = false;
                txtdolar.Visible = false;
                lbldolar.Visible = false;
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resul= MessageBox.Show("¿Desea Cancelar La venta?, se borraran todos los datos", "Cancelar", MessageBoxButtons.YesNo);
            if (resul.ToString()=="Yes")
            {
                frm.limpiar();
                frm.unlock();
                this.TopMost = false;
                this.Close();
            }
        }
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {            
            frm.unlock();
            this.TopMost = false;
            this.Close();
        }
        Cls_imprimir imprimir = new Cls_imprimir();        
        private void Btn_Pagar_Click(object sender, EventArgs e)
        {
            try
            {
                this.TopMost = false;
                ven.Columns.RemoveAt(1);
                ven.Columns.RemoveAt(2);
                ven.Columns.RemoveAt(4);                
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                int id=vender.registrar_venta(venta, date, iva, subtotal,ClsInicioSesion.empleados_id);
                double uno, dos;                
                foreach (DataRow item in ven.Rows)
                {
                    uno = Double.Parse(item[2].ToString().Replace("$", String.Empty));
                    dos = Double.Parse(item[3].ToString().Replace("$", String.Empty));
                    vender.registrar_productos_venta(id,Int32.Parse(item[4].ToString()), Double.Parse(item[0].ToString()), 0,uno,dos);
                    vender.remover_cant(Double.Parse(item[0].ToString()), Convert.ToInt32(item[4].ToString()));
                }                               
                ven.Columns.RemoveAt(4);
                imprimir.imprime(ven, total.ToString(), cambio.ToString(), subtotal, iva, venta,id,false);
                frm.limpiar();
                frm.unlock();
                MessageBox.Show("$ " + cambio.ToString(), "Cambio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TopMost = false;
                
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }           
        }

        private void txtdolar_TextChanged(object sender, EventArgs e)
        {
            double a;

            if (!Double.TryParse(txtdolar.Text, out a) && !(txtdolar.Text == String.Empty))
            { }
            else if (txtdolar.Text == String.Empty)
            {
                Btn_Pagar.Enabled = false;
                val2 = 0.0;                
                total = val1 + val2 + val3;
                Lblcam.Text = (-venta + total).ToString("C", nfi);
                cambio = -venta + total;
                Lblcam.ForeColor = Color.Red;
            }
            else
            {
                val2 = dolar * double.Parse(txtdolar.Text);
                Lbl_total_dlls.Text = val2.ToString("C",nfi);
                total = val1 + val2 + val3;
                Lblcam.Text = (-venta + total).ToString("C", nfi);
                cambio = -venta + total;
                if (venta <= total)
                {
                    Lblcam.ForeColor = Color.Green;
                    Btn_Pagar.Enabled = true;
                }
                else
                {
                    Btn_Pagar.Enabled = false;
                    Lblcam.ForeColor = Color.Red;
                }
            }
        }

        private void txttarjeta_TextChanged(object sender, EventArgs e)
        {
            double a;

            if (!Double.TryParse(txttarjeta.Text, out a) && !(txttarjeta.Text == String.Empty))
            { }
            else if (txttarjeta.Text == String.Empty)
            {
                Btn_Pagar.Enabled = false;
                val3 = 0.0;
                Lblcam.ForeColor = Color.Red;
                cambio = -venta + total;
                total = val1 + val2 + val3;
                Lblcam.Text = (- venta + total).ToString("C", nfi);
            }
            else
            {
                val3 = double.Parse(txttarjeta.Text);
                total = val1 + val2 + val3;
                Lblcam.Text = (-venta + total).ToString("C", nfi);
                cambio = -venta + total;
                if (venta <= total)
                {
                    Lblcam.ForeColor = Color.Green;
                    Btn_Pagar.Enabled = true;
                }
                else
                {
                    Btn_Pagar.Enabled = false;
                    Lblcam.ForeColor = Color.Red;
                }
            }
        }
        public void caracteres_de_aceptacion(TextBox texto)
        {
            texto.KeyPress += Texto_KeyPress;      
        }
        private void Texto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar=='.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void FrmPuntoVenta_final_Load(object sender, EventArgs e)
        {
            
            caracteres_de_aceptacion(Txtdinero);
            caracteres_de_aceptacion(txtdolar);
            caracteres_de_aceptacion(txttarjeta);
            LblTot.Text = venta.ToString("C",nfi);
            LblDolarPrecio.Text = "Dolar Bancomer " + Environment.NewLine + "$ "+dolar.ToString();
        }        
        private void Txtdinero_TextChanged(object sender, EventArgs e)
        {
            double a;
            
            if (!Double.TryParse(Txtdinero.Text, out a) && !(Txtdinero.Text == String.Empty))
            { }
            else if (Txtdinero.Text == String.Empty) {
                Btn_Pagar.Enabled = false;            
                val1 = 0.0;
                Lblcam.ForeColor = Color.Red;
                total = val1 + val2 + val3;
                Lblcam.Text = (-venta + total).ToString("C", nfi);
                cambio = -venta + total;
            }
            else
            {
                val1 = double.Parse(Txtdinero.Text);
                total = val1 + val2 + val3;
                Lblcam.Text = (-venta + total).ToString("C",nfi);
                cambio = -venta + total;
                if (venta <= total)
                {
                    Lblcam.ForeColor = Color.Green;
                    Btn_Pagar.Enabled = true;
                }
                else
                {
                    Btn_Pagar.Enabled = false;
                    Lblcam.ForeColor = Color.Red;
                }                
            }
        }
    }
}
