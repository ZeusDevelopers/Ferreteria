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
    public partial class FrmPuntoVenta : Form
    {
        FrmPuntoVenta_final frmventa;
        ClsVentas clsventa = new ClsVentas();
        NumberFormatInfo nfi = new CultureInfo("Es-MX", false).NumberFormat;
        bool cant_correcta = false;
        double subtotal = 0, iva = 0, total = 0, roww = -1;
        public FrmPuntoVenta()
        {
            InitializeComponent();
            #region                  
            Bitmap bmp = new Bitmap(Btn_comprar.ClientRectangle.Width, Btn_comprar.ClientRectangle.Height);
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.Clear(Btn_eliminar.BackColor);
                string line1 = "Abrir";
                StringFormat SF = new StringFormat();
                SF.Alignment = StringAlignment.Center;
                G.DrawImage(Ferreteria.Properties.Resources.abrir, 24, 2, 40, 40);
                using (Font arial = new Font("Arial", 13))
                {
                    Rectangle RC = Btn_comprar.ClientRectangle;
                    RC.Inflate(-8, -43);
                    G.DrawString(line1, arial, Brushes.Black, RC, SF);
                }
                btn_abrir_cajon.Image = bmp;
            }
            bmp = new Bitmap(Btn_comprar.ClientRectangle.Width, Btn_comprar.ClientRectangle.Height);
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.Clear(Btn_eliminar.BackColor);
                string line1 = "Eliminar ";
                StringFormat SF = new StringFormat();
                SF.Alignment = StringAlignment.Center;
                G.DrawImage(Ferreteria.Properties.Resources.Eliminar, 24, 2, 40, 40);
                using (Font arial = new Font("Arial", 13))
                {
                    Rectangle RC = Btn_comprar.ClientRectangle;
                    RC.Inflate(-8, -43);
                    G.DrawString(line1, arial, Brushes.Black, RC, SF);
                }
                Btn_eliminar.Image = bmp;
            }
            bmp = new Bitmap(Btn_comprar.ClientRectangle.Width, Btn_comprar.ClientRectangle.Height);
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.Clear(Btn_comprar.BackColor);
                string line1 = "Cobrar ";
                StringFormat SF = new StringFormat();
                SF.Alignment = StringAlignment.Center;
                G.DrawImage(Ferreteria.Properties.Resources.Icono, 24, 2, 40, 40);
                using (Font arial = new Font("Arial", 13))
                {
                    Rectangle RC = Btn_comprar.ClientRectangle;
                    RC.Inflate(-8, -43);
                    G.DrawString(line1, arial, Brushes.Black, RC, SF);
                }
                Btn_comprar.Image = bmp;
            }
            bmp = new Bitmap(Btn_limpiar.ClientRectangle.Width, Btn_limpiar.ClientRectangle.Height);
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.Clear(Btn_limpiar.BackColor);
                string line1 = "Limpiar ";
                StringFormat SF = new StringFormat();
                SF.Alignment = StringAlignment.Center;
                G.DrawImage(Ferreteria.Properties.Resources.bote, 24, 2, 40, 40);
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
                G.DrawImage(Ferreteria.Properties.Resources.editar, 24, 4, 40, 40);
                using (Font arial = new Font("Arial", 13))
                {
                    Rectangle RC = Btn_cantidad.ClientRectangle;
                    RC.Inflate(-8, -43);
                    G.DrawString(line1, arial, Brushes.Black, RC, SF);
                }
                Btn_cantidad.Image = bmp;
            }
            #endregion
        }
        #region controles
        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region txt tipo PlaceHodert
        private void Txtcodigo_Leave(object sender, EventArgs e)
        {
            Txtcodigo.ForeColor = Color.Silver;
            Txtcodigo.Text = "Escanee codigo de barras ";
            Txtcodigo.Font = new Font(Txtcodigo.Font, FontStyle.Italic);
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
        #endregion
        private void Btn_comprar_Click(object sender, EventArgs e)
        {

            comprar();

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
            try
            {
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
                        MessageBox.Show("Caja Abierta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }

            }
            catch (Exception)
            {


            }
            return bHandled;
        }

        private void comprar()
        {
            if (!( total <= 0)) {

                btn_abrir_cajon.Enabled = false;
                Btn_Buscar.Enabled = false;
                Btn_cantidad.Enabled = false;
                //Btn_comprar.Enabled = false;
                Btn_limpiar.Enabled = false;
                Btn_eliminar.Enabled = false;
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn col in DgvVentas.Columns)
                {
                    dt.Columns.Add(col.HeaderText);
                }
                for (int i = 0; i < DgvVentas.Rows.Count; i++)
                {
                    DataGridViewRow row = DgvVentas.Rows[i];
                    DataRow dr = dt.NewRow();
                    for (int j = 0; j < DgvVentas.Columns.Count; j++)
                    {
                        dr[j] = (row.Cells[j].Value == null) ? "" : row.Cells[j].Value.ToString();
                    }
                    dt.Rows.Add(dr);
                }
                frmventa = new FrmPuntoVenta_final(dolar, total, iva, subtotal, dt, this);
                frmventa.TopMost = true;
                frmventa.Show();
            }
            else
            {
                MessageBox.Show("No hay articulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        public void totales(string numero)
        {
            totales();
            //subtotal = Convert.ToDouble(Decimal.Round(Convert.ToDecimal(subtotal), 2));
            //subtotal += Double.Parse(numero);
            //iva = Convert.ToDouble(Decimal.Round(Convert.ToDecimal(subtotal * .16), 2));
            //total = subtotal + iva;
            //total = (Double)Decimal.Round(Convert.ToDecimal(total), 2);
            //lbliva.Text = iva.ToString("C", nfi);
            //Lblsubtotal.Text = subtotal.ToString("C", nfi);
            //Lbl_total_final.Text = total.ToString("C", nfi);
        }
        public void totales()
        {
            subtotal = 0;
            foreach (DataGridViewRow item in DgvVentas.Rows)
            {
                subtotal += Double.Parse(item.Cells[5].Value.ToString().Replace("$", String.Empty));
            }
            subtotal = Convert.ToDouble(Decimal.Round(Convert.ToDecimal(subtotal), 2));
            iva = Convert.ToDouble(Decimal.Round(Convert.ToDecimal(subtotal * .16), 2));
            total = subtotal + iva;
            total = (Double)Decimal.Round(Convert.ToDecimal(total), 2);
            lbliva.Text = iva.ToString("C", nfi);
            Lblsubtotal.Text = subtotal.ToString("C", nfi);
            Lbl_total_final.Text = total.ToString("C", nfi);
        }
        public void venta()
        {
            try
            {
                DataTable table = clsventa.VerProducto(Txtcodigo.Text);
                double num1;
                int cont = 0;
                string n1;
                bool codigo=true;
                if (table.Rows.Count > 0)
                {                   
                    if (DgvVentas.Rows.Count>0)
                    {
                        foreach (DataGridViewRow item in DgvVentas.Rows)
                        {                                          
                            if (item.Cells[1].Value.ToString()==table.Rows[0][0].ToString() && item.Cells[2].Value.ToString() == table.Rows[0][1].ToString())
                            {
                                double a =Double.Parse(item.Cells[3].Value.ToString());
                                if (a>0)
                                {                                    
                                    DgvVentas[3, cont].Value = a - 1;
                                    DgvVentas[0, cont].Value = (Double.Parse(DgvVentas[0, cont].Value.ToString()) + 1);
                                    codigo = false;
                                    DgvVentas[5, cont].Value = (Double.Parse( DgvVentas[0, cont].Value.ToString()) * Double.Parse(DgvVentas[4, cont].Value.ToString().Replace("$", String.Empty))).ToString("C", nfi);
                                    totales(DgvVentas[5, cont].Value.ToString().Replace("$", String.Empty));
                                    Txtcodigo.Text = "";
                                    break;
                                }
                                else
                                {
                                    codigo = false;
                                    Txtcodigo.Text = "";
                                    MessageBox.Show("Inventario insuficiente");
                                }
                                
                            }
                            cont++;
                        }
                    }
                  


                    if (!codigo)
                    {

                    }
                    else
                    {
                        foreach (DataRow elemento in table.Rows)
                        {
                            num1 = Double.Parse(elemento[2].ToString());
                            n1 = num1.ToString("C", nfi);
                            double p = Double.Parse(elemento[3].ToString()) - 1;
                            DgvVentas.Rows.Add(1, elemento[0], elemento[1], p, n1, n1, elemento[4], elemento[5]);
                            totales(elemento[2].ToString());                            
                            Txtcodigo.Text = "";
                        }
                        totales();
                    }
                }
                else
                {
                    MessageBox.Show("No existe producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Txtcodigo.Text = "";
                }
                DgvVentas.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
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
        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void FrmPuntoVenta_Load(object sender, EventArgs e)
        {
            DataGridViewColumn row = DgvVentas.Columns[4];
            row.DefaultCellStyle.BackColor = Color.LawnGreen;
            Gb_Venta.BackColor = Color.FromArgb(5, 255, 255, 255);
            DgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ClsVentas.precio_dolar();
            dolar = ClsVentas.Dolar;
        }
        double dolar = 0;
        private void Btn_cantidad_Click(object sender, EventArgs e)
        {
            try
            {
                cantidad();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }

        }
        void cantidad()
        {
            if (roww != -1)
            {
                string cant = Clsinputbox.ShowDialog("INGRESE CANTIDAD", "CANTIDAD", roww);
                if (cant != "empty")
                {

                    // verifica unidad de medida 
                    int a = 0;
                    bool ent = Int32.TryParse(cant, out a) ? true : false, entra = false;
                    string option = cant.GetType().ToString();
                    double m = Double.Parse(DgvVentas[3, Int32.Parse(roww.ToString())].Value.ToString());
                    if (Double.Parse(cant) <= m && Double.Parse(cant) != 0)
                    {
                        string x = DgvVentas[6, Int32.Parse(roww.ToString())].Value.ToString();
                        if ((x.Contains("Kit") || x.Contains("Unidad")) && ent)
                        {
                            entra = true;
                        }
                        else if (x.Contains("Decimal") || x.Contains("Metro") && !ent)
                        {
                            entra = true;
                        }
                        if (entra)
                        {
                            double ini = Double.Parse(DgvVentas[3, Int32.Parse(roww.ToString())].Value.ToString());
                            double cmp = Double.Parse(DgvVentas[0, Int32.Parse(roww.ToString())].Value.ToString());
                            if (cmp > Double.Parse(cant))
                            {
                                DgvVentas[3, Int32.Parse(roww.ToString())].Value = ini + (cmp-Double.Parse(cant)) ;
                            }
                            else
                            {
                                DgvVentas[3, Int32.Parse(roww.ToString())].Value = ini - Double.Parse(cant);
                            }
                            DgvVentas[0, Int32.Parse(roww.ToString())].Value = cant;                        
                            DgvVentas[5, Int32.Parse(roww.ToString())].Value = (Double.Parse(cant) * Double.Parse(DgvVentas[4, Int32.Parse(roww.ToString())].Value.ToString().Replace("$", String.Empty))).ToString("C", nfi);
                          
                           
                            roww = -1;
                            totales();
                        }
                        else
                        {
                            MessageBox.Show("Error con unidad de medida");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inventario Insuficiente");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione Un elemento");
            }
            roww = -1;
            DgvVentas.ClearSelection();
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
            DgvVentas.ClearSelection();            
        }
        private void btn_abrir_cajon_Click(object sender, EventArgs e)
        {
            try
            {
                Cls_imprimir_ticket tic = new Cls_imprimir_ticket();
                tic.AbreCajon();
                tic.ImprimirTicket("POS-58");
                MessageBox.Show("Caja Abierta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            roww = e.RowIndex;
        }
        internal void dato_encontrado(string codigobarras, string producto, string precio, int stock, string um, string productoid)
        {
            try
            {
                DgvVentas.Rows.Add(1, codigobarras, producto, stock, Double.Parse(precio).ToString("C", nfi), Double.Parse(precio).ToString("C", nfi), um, productoid);
                totales(precio);
                DgvVentas.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void limpiar()
        {
            DialogResult r = MessageBox.Show("Desea Limpiar Todo", "Finalizar", MessageBoxButtons.YesNo);
            if (r.ToString() == "Yes")
            {
                lbliva.Text = "$ 0.00";
                Lblsubtotal.Text = "$ 0.00";
                Lbl_total_final.Text = "$ 0.00";
                iva = 0;
                subtotal = 0;
                total = 0;
                DgvVentas.Rows.Clear();
                DgvVentas.Refresh();
            }
            DgvVentas.ClearSelection();
        }
        public void unlock()
        {
            btn_abrir_cajon.Enabled = true;
            Btn_Buscar.Enabled = true;
            Btn_cantidad.Enabled = true;
            Btn_comprar.Enabled = true;
            Btn_limpiar.Enabled = true;
            Btn_eliminar.Enabled = true;
        }
    }
}