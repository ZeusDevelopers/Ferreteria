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
        bool cant_correcta = false;
        double subtotal = 0, iva = 0, total = 0, roww = -1;
        public FrmPuntoVenta()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap(Btn_comprar.ClientRectangle.Width, Btn_comprar.ClientRectangle.Height);
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.Clear(Btn_eliminar.BackColor);
                string line1 = "Abrir";
                StringFormat SF = new StringFormat();
                SF.Alignment = StringAlignment.Center;
                //SF.LineAlignment = StringAlignment.Near;
                G.DrawImage(PVFP.Properties.Resources.abrir, 24, 2, 40, 40);
                using (Font arial = new Font("Arial", 13))
                {
                    Rectangle RC = Btn_comprar.ClientRectangle;
                    RC.Inflate(-8, -43);
                    G.DrawString(line1, arial, Brushes.Black, RC, SF);
                }
            }
            btn_abrir_cajon.Image = bmp;
            bmp = new Bitmap(Btn_comprar.ClientRectangle.Width, Btn_comprar.ClientRectangle.Height);
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.Clear(Btn_eliminar.BackColor);

                string line1 = "Eliminar ";


                StringFormat SF = new StringFormat();
                SF.Alignment = StringAlignment.Center;
                //SF.LineAlignment = StringAlignment.Near;
                G.DrawImage(PVFP.Properties.Resources.Eliminar, 24, 2, 40, 40);
                using (Font arial = new Font("Arial", 13))
                {
                    Rectangle RC = Btn_comprar.ClientRectangle;
                    RC.Inflate(-8, -43);
                    G.DrawString(line1, arial, Brushes.Black, RC, SF);
                }


            }
            Btn_eliminar.Image = bmp;
            bmp = new Bitmap(Btn_comprar.ClientRectangle.Width, Btn_comprar.ClientRectangle.Height);
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.Clear(Btn_comprar.BackColor);

                string line1 = "Cobrar ";
                string line2 = "(F6)";

                StringFormat SF = new StringFormat();
                SF.Alignment = StringAlignment.Center;
                //SF.LineAlignment = StringAlignment.Near;
                G.DrawImage(PVFP.Properties.Resources.Icono, 24, 2, 40, 40);
                using (Font arial = new Font("Arial", 13))
                {
                    Rectangle RC = Btn_comprar.ClientRectangle;
                    RC.Inflate(-8, -43);
                    G.DrawString(line1, arial, Brushes.Black, RC, SF);
                }


            }
            Btn_comprar.Image = bmp;
            bmp = new Bitmap(Btn_limpiar.ClientRectangle.Width, Btn_limpiar.ClientRectangle.Height);
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.Clear(Btn_limpiar.BackColor);

                string line1 = "Limpiar ";
                string line2 = "(F8)";

                StringFormat SF = new StringFormat();
                SF.Alignment = StringAlignment.Center;
                //SF.LineAlignment = StringAlignment.Near;
                G.DrawImage(PVFP.Properties.Resources.bote, 24, 2, 40, 40);
                using (Font arial = new Font("Arial", 13))
                {
                    Rectangle RC = Btn_limpiar.ClientRectangle;
                    RC.Inflate(-8, -43);
                    G.DrawString(line1, arial, Brushes.Black, 15, 45);
                }

                Btn_limpiar.Image = bmp;


            }

            bmp = new Bitmap(Btn_cantidad.ClientRectangle.Width, Btn_cantidad.ClientRectangle.Height);
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.Clear(Btn_cantidad.BackColor);

                string line1 = "Cant.";
                StringFormat SF = new StringFormat();
                SF.Alignment = StringAlignment.Center;
                //SF.LineAlignment = StringAlignment.Near;
                G.DrawImage(PVFP.Properties.Resources.editar, 24, 4, 40, 40);
                using (Font arial = new Font("Arial", 13))
                {
                    Rectangle RC = Btn_cantidad.ClientRectangle;
                    RC.Inflate(-8, -43);
                    G.DrawString(line1, arial, Brushes.Black, RC, SF);
                }

                Btn_cantidad.Image = bmp;
            }
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.Clear(Btn_cantidad.BackColor);

                string line1 = "Cant.";
                StringFormat SF = new StringFormat();
                SF.Alignment = StringAlignment.Center;
                //SF.LineAlignment = StringAlignment.Near;
                G.DrawImage(PVFP.Properties.Resources.editar, 24, 4, 40, 40);
                using (Font arial = new Font("Arial", 13))
                {
                    Rectangle RC = Btn_cantidad.ClientRectangle;
                    RC.Inflate(-8, -43);
                    G.DrawString(line1, arial, Brushes.Black, RC, SF);
                }

                //    Btn_cantidad.Image = bmp;
            }
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
            if (Txtcodigo.Text == "Escanee codigo de barras ")
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
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.' || (Char.IsControl(e.KeyChar) && e.KeyChar != 13))
            {
                e.Handled = false;
            }
            else if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (Double.Parse(Txt_efectivo.Text) < total)
                {
                    MessageBox.Show("Cantidad Incorrecta");
                    cant_correcta = false;
                }
                else
                {
                    cant_correcta = true;
                    Lbl_cambio.Text = Math.Abs((total - Double.Parse(Txt_efectivo.Text))).ToString();
                }
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
            if (subtotal!=0)
            {
                totales();
            }
        }
        private void FrmPuntoVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClsInicioSesion.Usuario = "";
        }
        private void Txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                                         
            if (e.KeyChar == 13)
            {

                venta();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool bHandled = false;
            switch (keyData)
            {
                case Keys.F6:
                    comprar();
                    bHandled = true;
                    break;
                case Keys.F7:
                    cantidad();
                    bHandled = true;
                    break;
                case Keys.F8:
                    limpiar();
                    bHandled = true;
                    break;
                case Keys.F9:
                    elim();
                    bHandled = true;
                    break;
                case Keys.F10:
                    Cls_imprimir_ticket tic = new Cls_imprimir_ticket();
                    tic.AbreCajon();
                    tic.ImprimirTicket("POS-58");
                    bHandled = true;
                    break;
            }
            return bHandled;
        }
        #endregion              
        private void Btn_Aceptar_pago_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Txt_efectivo.Text == "" || !cant_correcta )&& Lbl_tarjeta.Visible==false)
                {
                    MessageBox.Show("Ingrese Monto");
                }
                else
                {
                    if (Lbl_tarjeta.Visible != true) { 
                        Cls_imprimir_ticket ticket = new Cls_imprimir_ticket();
                    //imprime imagen
                    ticket.imprimir();
                    //Datos de la cabecera del Ticket.
                    ticket.TextoIzquierda("     PLOMERIA y FERRETERIA");
                        ticket.TextoCentro("VEGA");
                        ticket.lineasAsteriscos();
                        ticket.TextoCentro("MARITZA FELIX QUINONEZ");
                        ticket.TextoIzquierda("R.F.C FEQM-661228-1MA");
                        ticket.TextoIzquierda("REGIMEN FISCAL:INCORPORACION");
                        ticket.TextoIzquierda("FISCAL");
                        ticket.TextoIzquierda("Ave.Tecnologico # 1060 Colonia  Jardines de la montana C.P 84063");
                        ticket.TextoCentro("(631)315-8024");
                        ticket.TextoCentro("Nogales,Sonora,Mexico");

                        ticket.lineasAsteriscos();
                    //Sub cabecera.            
                    ticket.TextoIzquierda("ATENDIO: " + ClsInicioSesion.Usuario);
                    ticket.TextoExtremos("FECHA:" + DateTime.Now.ToShortDateString(), "HORA:" + DateTime.Now.ToShortTimeString());
                    ticket.lineasAsteriscos();
                    //Articulos a vender.
                    ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
                    ticket.lineasAsteriscos();
                    decimal precio, importe;
                    foreach (DataGridViewRow fila in DgvVentas.Rows)
                    {
                        precio = Decimal.Parse(fila.Cells[3].Value.ToString().Replace("$", String.Empty));
                        importe = Decimal.Parse(fila.Cells[3].Value.ToString().Replace("$", String.Empty));
                        ticket.AgregaArticulo(fila.Cells[1].Value.ToString(), 1, precio, importe);
                    }
                    ticket.lineasIgual();
                    ticket.AgregarTotales("         SUBTOTAL......$", (decimal)subtotal);
                    ticket.AgregarTotales("         IVA...........$", (decimal)iva);//La M indica que es un decimal en C#
                    ticket.AgregarTotales("         TOTAL.........$", (decimal)total);
                    ticket.TextoIzquierda("");
                    ticket.AgregarTotales("         EFECTIVO......$", Decimal.Parse(Txt_efectivo.Text));
                    string cade = Lbl_cambio.Text.ToString().Replace("$", String.Empty);
                    double mioa = Double.Parse(cade);
                    ticket.AgregarTotales("         CAMBIO........$", (decimal)mioa);
                    //Texto final del Ticket.                            
                    ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
                    ticket.CortaTicket();
                    ticket.ImprimirTicket("POS-58");//Nombre de la impresora ticketera            
                      //  ticket.ImprimirTicket("Microsoft XPS Document Writer");
                        btncerrar.Enabled = true;
                    BtnCancelar.Enabled = false;
                    Btn_Aceptar_pago.Enabled = false;
                    cant_correcta = false;
                        MessageBox.Show("Pago Realizado ");
                    }
               else
               {
                        MessageBox.Show("Pago Realizado con tarjeta");
               }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }
        public void totales(string numero)
        {
            subtotal = Convert.ToDouble(Decimal.Round(Convert.ToDecimal(subtotal), 2));
            subtotal += Double.Parse(numero);
            iva = Convert.ToDouble(Decimal.Round(Convert.ToDecimal(subtotal * .16), 2));
            total = subtotal + iva;
            total = (Double)Decimal.Round(Convert.ToDecimal(total), 2);
        }
        public void totales()
        {
            subtotal = 0;
            foreach (DataGridViewRow item in DgvVentas.Rows)
            {
                subtotal += Double.Parse(item.Cells[4].Value.ToString().Replace("$", String.Empty));
            }
            subtotal = Convert.ToDouble(Decimal.Round(Convert.ToDecimal(subtotal), 2));
            iva = Convert.ToDouble(Decimal.Round(Convert.ToDecimal(subtotal * .16), 2));
            total = subtotal + iva;
            total = (Double)Decimal.Round(Convert.ToDecimal(total), 2);
            lbliva.Text = "$ " + iva.ToString();
            Lblsubtotal.Text = "$ " + subtotal.ToString();
            Lbl_total_final.Text = "$ " + total.ToString();
            Lbltotal.Text =  Lbl_total_final.Text;
        }
        public void venta()
        {
            try
            {
                DataTable table = clsventa.VerProducto(Txtcodigo.Text);
                if (table.Rows.Count > 0)
                {
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
                else
                {
                    //MessageBox.Show("Producto no Existe");
                    Txtcodigo.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }
        void pagar()
        {

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
            try
            {
                FrmPuntoVenta_Buscar frm = new FrmPuntoVenta_Buscar(this);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DgvVentas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

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
        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            //Btn_limpiar.Enabled = false;
        }
        private void Txt_efectivo_TextChanged(object sender, EventArgs e)
        {

        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            try
            {
                btncerrar.Enabled = false;
                limpiar();
                GbVenta.Visible = false;
                Btn_comprar.Enabled = true;
                Txt_efectivo.Text = "";
                Btn_Aceptar_pago.Enabled = true;
                BtnCancelar.Enabled = false;
                Btn_Aceptar_pago.Enabled = true;
                BtnCancelar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }
        private void FrmPuntoVenta_Load(object sender, EventArgs e)
        {
            DataGridViewColumn row = DgvVentas.Columns[3];
            row.DefaultCellStyle.BackColor = Color.LawnGreen;
            Gb_Venta.BackColor = Color.FromArgb(5, 255, 255, 255);
        }
        private void Btn_cantidad_Click(object sender, EventArgs e)
        {
            cantidad();
        }
        void cantidad()
        {
            if (roww != -1)
            {
                string cant = Clsinputbox.ShowDialog("INGRESE CANTIDAD", "CANTIDAD", roww.ToString());
                DgvVentas[2, Int32.Parse(roww.ToString())].Value = cant;
                DgvVentas[4, Int32.Parse(roww.ToString())].Value = "$" + (Double.Parse(cant) * Double.Parse(DgvVentas[3, Int32.Parse(roww.ToString())].Value.ToString().Replace("$", String.Empty))).ToString();
                roww = -1;
                totales();
            }
            else
            {
                MessageBox.Show("Seleccione Un elemento");
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            elim();
        }
        void elim()
        {
            if (roww != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Eliminar", "Eliminar elemento", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == dialogResult)
                {
                    DgvVentas.Rows.RemoveAt(Convert.ToInt32(roww));
                    totales();
                }
                roww = -1;
            }
            else
            {
                MessageBox.Show("Seleccione Un elemento");
            }
        }
        private void btn_abrir_cajon_Click(object sender, EventArgs e)
        {
            Cls_imprimir_ticket tic = new Cls_imprimir_ticket();
            tic.AbreCajon();
            tic.ImprimirTicket("POS-58");
        }

        private void Txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            roww = e.RowIndex;
        }        
        internal void dato_encontrado(string codigobarras, string producto, string precio)
        {
            try
            {
                DgvVentas.Rows.Add(codigobarras, producto, 1, "$" + precio, "$" + precio);
                totales(precio);
                lbliva.Text = "$" + iva.ToString();
                Lblsubtotal.Text = "$" + subtotal.ToString();
                Lbl_total_final.Text = "$" + total.ToString();
                Lbltotal.Text = Lbl_total_final.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void limpiar()
        {
            DialogResult r = MessageBox.Show("Desea Finalizar venta", "Finalizar", MessageBoxButtons.YesNo);
            if (r.ToString() == "Yes")
            {
                lbliva.Text = "$ 0.00";
                Lbltotal.Text = "$ 0.00";
                Lbl_cambio.Text = "$ 0.00";
                Lblsubtotal.Text = "$ 0.00";
                Lbl_total_final.Text = "$ 0.00";
                iva = 0;
                subtotal = 0;
                total = 0;
                DgvVentas.Rows.Clear();
                DgvVentas.Refresh();
            }
        }

        
    }
}