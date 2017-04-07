using PVFP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        int valor_final = 0;
        int val=0;
        string tipo = "0";
        Cls_Consulta consulta = new Cls_Consulta();
        string fech_ini;
        string fech_fin;
        string a="0";
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
                if (dataGridView1.Columns["Eliminar"] != null)
                {
                    dataGridView1.CellClick -= DataGridView1_CellClick;
                    dataGridView1.Columns.Remove("Eliminar");                    
                }
            if (Rbtn_venta.Checked)
            {
                val = -1;
                txtintervalo.Text = "0";
                LblCantidad.Text = "/0";
                dataGridView1.DataSource = consulta.num_venta(Int32.Parse(TxtVenta.Text));
                tipo = "cuatro";
            }
            else  if (Rbtn_fecha.Checked)
            {
                fechas();
            }
            else
            {
                MessageBox.Show("Seleccione un elemento","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public void fechas()
        {                       
                tipo = "uno";
                dataGridView1.DataSource = null;
                fech_ini = Dtpfechinicio.Value.ToString("yyyy-MM-dd 00:00:00");
                fech_fin = Dtpfechinicio.Value.ToString("yyyy-MM-dd 23:59:59");
                a = "-1";
                int intervalo = consulta.intervalo(fech_ini, fech_fin, Int32.Parse(a));
                salt = intervalo / 10;
                LblCantidad.Text = "/" + (salt + 1).ToString();
                inter = Int32.Parse(salt.ToString());
                valor_final = 0;
                txtintervalo.Text = "1";
                dataGridView1.DataSource = consulta.fecha_intervalo(fech_ini, fech_fin, 0, -1);            
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
                if (e.ColumnIndex!=5)
                {
                    Frm_consuta_recibodet rec = new Frm_consuta_recibodet(Int32.Parse(dataGridView1["No.Venta", e.RowIndex].Value.ToString()),1);
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
        private void add_colum_dele()
        {
            DataGridViewButtonColumn Columna_eliminar = new DataGridViewButtonColumn();
            Columna_eliminar.Name = "Eliminar";
            if (dataGridView1.Columns["Eliminar"] == null && dataGridView1.Rows.Count>0)
            {
                
                dataGridView1.Columns.Insert(5, Columna_eliminar);
                dataGridView1.CellClick += DataGridView1_CellClick; 
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    item.Cells["Eliminar"].Value = "Remover";
                }
            }
        }
        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            add_colum_dele();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==5)
            {
                DialogResult r = MessageBox.Show("¿Desea eliminar la venta: "+dataGridView1[0,e.RowIndex].Value+" permanentemente?","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (r.Equals(DialogResult.Yes))
                {

                }
                else
                {

                }
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
                if (dataGridView1.Columns["Eliminar"] != null)
                {
                    dataGridView1.CellClick -= DataGridView1_CellClick;
                    dataGridView1.Columns.Remove("Eliminar");
                }
                val++;
                txtintervalo.Text =  (val + 1).ToString();
                dataGridView1.DataSource = consulta.fecha_intervalo(fech_ini, fech_fin, val * 10, -1);
                add_colum_dele();
            }
        }

        private void Btn_anteriro_Click(object sender, EventArgs e)
        {
            if (val>0)
            {
                if (dataGridView1.Columns["Eliminar"] != null)
                {
                    dataGridView1.CellClick -= DataGridView1_CellClick;
                    dataGridView1.Columns.Remove("Eliminar");
                }
                val--;
                txtintervalo.Text = (val + 1).ToString();
                dataGridView1.DataSource = consulta.fecha_intervalo(fech_ini, fech_fin, val*10, -1);
                add_colum_dele();
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
