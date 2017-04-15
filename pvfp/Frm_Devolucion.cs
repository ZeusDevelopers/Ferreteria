using PVFP;
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

namespace Ferreteria
{
    public partial class Frm_Devolucion : Form
    {
        double salt;
        int inter = 0;
        NumberFormatInfo nfi = new CultureInfo("Es-MX", false).NumberFormat;
        int val = 0;       
        Cls_Consulta consulta = new Cls_Consulta();
        string fech_ini;
        Cls_devolucion dv = new Cls_devolucion();
        string fech_fin;
        string a = "0";
        public Frm_Devolucion()
        {
            InitializeComponent();
        }
        //Proyecto Final
        //5 tablas sql    
        //relacionadas entre si
        //reportes(Datos) 4
        //5 campos de cada forma

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Rbtn_venta.Checked)
                {
                    val = -1;
                    txtintervalo.Text = "0";
                    LblCantidad.Text = "/0";
                    DataTable tb = consulta.num_venta(Int32.Parse(TxtVenta.Text));
                    DataTable resul = new DataTable();
                    foreach (DataColumn item in tb.Columns)
                    {
                        resul.Columns.Add(item.ColumnName);
                    }
                    foreach (DataRow item in tb.Rows)
                    {
                        DataRow dr = resul.NewRow();
                        dr[0] = item[0];
                        dr[1] = item[1];
                        dr[2] = Double.Parse(item[2].ToString()).ToString("C", nfi);
                        dr[3] = Double.Parse(item[3].ToString()).ToString("C", nfi);
                        dr[4] = Double.Parse(item[4].ToString()).ToString("C", nfi);
                        resul.Rows.Add(dr);

                    }
                    dataGridView1.DataSource = resul;                    
                }
                else if (Rbtn_fecha.Checked)
                {
                    fechas();
                }
                else
                {
                    MessageBox.Show("Seleccione un elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void fechas()
        {            
            dataGridView1.DataSource = null;
            fech_ini = Dtpfechinicio.Value.ToString("yyyy-MM-dd 00:00:00");
            fech_fin = Dtpfechinicio.Value.ToString("yyyy-MM-dd 23:59:59");
            a = "-1";
            int intervalo = consulta.intervalo(fech_ini, fech_fin, Int32.Parse(a));
            salt = intervalo / 10;
            LblCantidad.Text = "/" + (salt + 1).ToString();
            inter = Int32.Parse(salt.ToString());
            txtintervalo.Text = "1";
            DataTable tb = consulta.fecha_intervalo(fech_ini, fech_fin, 0, -1);
            DataTable resul = new DataTable();
            foreach (DataColumn item in tb.Columns)
            {
                resul.Columns.Add(item.ColumnName);
            }
            foreach (DataRow item in tb.Rows)
            {
                DataRow dr = resul.NewRow();
                dr[0] = item[0];
                dr[1] = item[1];
                dr[2] = Double.Parse(item[2].ToString()).ToString("C", nfi);
                dr[3] = Double.Parse(item[3].ToString()).ToString("C", nfi);
                dr[4] = Double.Parse(item[4].ToString()).ToString("C", nfi);
                resul.Rows.Add(dr);

            }
            dataGridView1.DataSource = resul;
        }

        private void RadBtn_fechaini_CheckedChanged(object sender, EventArgs e)
        {

            Lbl_fechinicio.Visible = true;
            Dtpfechinicio.Visible = true;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != 5)
                {
                    Frm_consuta_recibodet rec = new Frm_consuta_recibodet(Int32.Parse(dataGridView1["No.Venta", e.RowIndex].Value.ToString()), 1, this);
                    rec.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void Rbtn_venta_CheckedChanged(object sender, EventArgs e)
        {
            Rbtn_fecha.Checked = false;
        }

        private void Rbtn_fecha_CheckedChanged(object sender, EventArgs e)
        {
            Rbtn_venta.Checked = false;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (val < salt)
            {
                val++;
                txtintervalo.Text = (val + 1).ToString();
                DataTable tb = consulta.fecha_intervalo(fech_ini, fech_fin, val * 10, -1);
                DataTable resul = new DataTable();
                foreach (DataColumn item in tb.Columns)
                {
                    resul.Columns.Add(item.ColumnName);
                }
                foreach (DataRow item in tb.Rows)
                {
                    DataRow dr = resul.NewRow();
                    dr[0] = item[0];
                    dr[1] = item[1];
                    dr[2] = Double.Parse(item[2].ToString()).ToString("C", nfi);
                    dr[3] = Double.Parse(item[3].ToString()).ToString("C", nfi);
                    dr[4] = Double.Parse(item[4].ToString()).ToString("C", nfi);
                    resul.Rows.Add(dr);

                }
                dataGridView1.DataSource = resul;
            }
        }

        private void Btn_anteriro_Click(object sender, EventArgs e)
        {
            if (val > 0)
            {
                val--;
                txtintervalo.Text = (val + 1).ToString();
                DataTable tb = consulta.fecha_intervalo(fech_ini, fech_fin, val * 10, -1);
                DataTable resul = new DataTable();
                foreach (DataColumn item in tb.Columns)
                {
                    resul.Columns.Add(item.ColumnName);
                }
                foreach (DataRow item in tb.Rows)
                {
                    DataRow dr = resul.NewRow();
                    dr[0] = item[0];
                    dr[1] = item[1];
                    dr[2] = Double.Parse(item[2].ToString()).ToString("C", nfi);
                    dr[3] = Double.Parse(item[3].ToString()).ToString("C", nfi);
                    dr[4] = Double.Parse(item[4].ToString()).ToString("C", nfi);
                    resul.Rows.Add(dr);

                }
                dataGridView1.DataSource = resul;
            }

        }

        public void llenado()
        {
            if (TxtVenta.Text == "")
            {
                dataGridView1.DataSource = consulta.fecha_intervalo(fech_ini, fech_fin, val * 10, -1);
            }
            else
            {
                dataGridView1.DataSource = consulta.num_venta(Int32.Parse(TxtVenta.Text));
            }
        }

        private void Frm_Devolucion_Load(object sender, EventArgs e)
        {
            this.Width = 750;
            this.Height = 550;            
        }
    }
}
