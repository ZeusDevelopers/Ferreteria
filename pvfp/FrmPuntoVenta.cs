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
        ClsVentas clsventa = new ClsVentas();
        
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
        #region controles
        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
        public void txt_deja()
        {
            Txtcodigo.ForeColor = Color.Silver;
            Txtcodigo.Text = "Escanee codigo de barras ";
            Txtcodigo.Font = new Font(Txtcodigo.Font, FontStyle.Italic);
        }       
        private void Txtcodigo_Leave(object sender, EventArgs e)
        {
            txt_deja();
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
            comprar();
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
            if (Char.IsDigit(e.KeyChar) ||  e.KeyChar=='.' || Char.IsControl(e.KeyChar) )
            {
                e.Handled = false;
            }
            else if ((Keys)e.KeyChar==Keys.Tab)
            {
                Lbl_cambio.Text = (total - Double.Parse(Txt_efectivo.Text)).ToString();
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
        private void FrmPuntoVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClsInicioSesion.Usuario = "";
        }
        private void Txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                venta();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool bHandled = false;
            switch (keyData)
            {
                case Keys.F5:
                    comprar();
                    bHandled = true;
                    break;
            }
            return bHandled;
        }
        #endregion
        double subtotal = 0, iva = 0, total = 0;         
        private void Btn_Aceptar_pago_Click(object sender, EventArgs e)
        {
            Cls_imprimir_ticket ticket = new Cls_imprimir_ticket();
            //imprime imagen
            ticket.imprimir();           
           //Datos de la cabecera del Ticket.
            ticket.TextoCentro("FERRETERIA VEGA");
            ticket.lineasAsteriscos();
            //Sub cabecera.            
            ticket.TextoIzquierda("ATENDIO: VENDEDOR");                        
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
            ticket.lineasAsteriscos();
            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.lineasAsteriscos();
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            //foreach (DataGridViewRow fila in dgvLista.Rows)//dgvLista es el nombre del datagridview
            //{
            //ticket.AgregaArticulo(fila.Cells[2].Value.ToString(), int.Parse(fila.Cells[5].Value.ToString()),
            //decimal.Parse(fila.Cells[4].Value.ToString()), decimal.Parse(fila.Cells[6].Value.ToString()));
            //}
            ticket.AgregaArticulo("Articulo A", 200, 1000.20m, 4000.89m);
            ticket.AgregaArticulo("Articulo B", 100, 10.10m, 100);            
            ticket.AgregaArticulo("broca concreto  1/4", 100, 10.10m, 100);
            ticket.AgregaArticulo("Monofilamento", 1, 30, 30);

            ticket.lineasIgual();            
            ticket.AgregarTotales("         SUBTOTAL......$", 1000);
            ticket.AgregarTotales("         IVA...........$", 10.04M);//La M indica que es un decimal en C#
            ticket.AgregarTotales("         TOTAL.........$", 200);
            ticket.TextoIzquierda("");
            ticket.AgregarTotales("         EFECTIVO......$", 200);
            ticket.AgregarTotales("         CAMBIO........$", 0);
            //Texto final del Ticket.        
            ticket.TextoIzquierda("");
            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
            ticket.CortaTicket();
            ticket.ImprimirTicket("POS-58");//Nombre de la impresora ticketera            
        }
        public void totales(string numero)
        {
            subtotal = Convert.ToDouble( Decimal.Round(Convert.ToDecimal( subtotal), 2));
            subtotal +=  Double.Parse(numero);
            iva = Convert.ToDouble(Decimal.Round(Convert.ToDecimal(subtotal * .16),2));
            total = subtotal + iva;
            total =(Double)Decimal.Round(Convert.ToDecimal( total),2);
        }
        public void venta()
        {
            try
            {

           
            DataTable table = clsventa.VerProducto(Txtcodigo.Text);
            foreach (DataRow elemento in table.Rows)
            {
                DgvVentas.Rows.Add(elemento[0], elemento[1], 1, elemento[2], "$" + elemento[2]);
                totales(elemento[2].ToString());
                Txtcodigo.Text = "";
            }
            lbliva.Text = "$" + iva.ToString();
            Lblsubtotal.Text = "$" + subtotal.ToString();
            Lbl_total_final.Text = "$" + total.ToString();
            Lbltotal.Text = Lbl_total_final.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }
        private void Limpiar()
        {
            Txt_efectivo.ForeColor = Color.Silver;
            Txt_efectivo.Text = "$ 0.00";
            Txt_efectivo.Font = new Font(Txt_efectivo.Font, FontStyle.Italic);
            Lbltotal.Text = "$ 0.00";
            Lbl_cambio.Text = "$ 0.00";
        }
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            FrmPuntoVenta_Buscar frm = new FrmPuntoVenta_Buscar(this);            
            frm.Show();
        }
        public void comprar()
        {
            DialogResult r = MessageBox.Show("Pago con tarjeta", "Pago", MessageBoxButtons.YesNo);
            if (r.ToString() == "Yes")
            {
                GbVenta.Visible = true;
                Txt_efectivo.Visible = false;
                LblPago.Visible = false;
                Txt_efectivo.Visible = false;
                LblCambio.Visible = false;
                Lbl_cambio.Visible = false;
                Lbl_tarjeta.Visible = true;
            }
            else
            {
                GbVenta.Visible = true;
                Txt_efectivo.Visible = true;
                LblPago.Visible = true;
                Txt_efectivo.Visible = true;
                LblCambio.Visible = true;
                Lbl_cambio.Visible = true;
                Lbl_tarjeta.Visible = false;
            }
            Btn_comprar.Enabled = false;
        }
        internal void dato_encontrado(string codigobarras,string producto,string precio)
        {
            try
            {
                DgvVentas.Rows.Add(codigobarras, producto, 1, "$" + precio, "$" + precio);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }           
        }
      
    }
}