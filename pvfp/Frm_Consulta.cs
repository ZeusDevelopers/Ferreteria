using Ferreteria;
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
    public partial class Frm_Consulta : Form
    {
        string[] datos = new string[] { "unp","dos"};

        public Frm_Consulta()
        {
            InitializeComponent();            
        }
        int inter = 0;
        int valor_final = 0;
        string tipo = "0";
        string a;
        private void RadBtn_fechaini_CheckedChanged(object sender, EventArgs e)
        {
            DtpFechafianl.Visible = false;
            LblFechFin.Visible = false;
            Lbl_fechinicio.Visible = true;
            Dtpfechinicio.Visible = true;
        }
        private void RadBtn_fechintervalo_CheckedChanged(object sender, EventArgs e)
        {
            DtpFechafianl.Visible = true;
            LblFechFin.Visible = true;
            Lbl_fechinicio.Visible = true;
            Dtpfechinicio.Visible = true;
        }
        private void DtpFechafianl_ValueChanged(object sender, EventArgs e)
        {


        }
        Cls_Consulta consulta = new Cls_Consulta();
        string fech_ini;
        string fech_fin;
        private void Btn_anteriro_Click(object sender, EventArgs e)
        {
            try
            {
                if (true)
                {
                    val = valor_final;
                    txtintervalo.Text = (val+1).ToString();
                    if (val < inter)
                    {
                        val++;
                        tipo_query();
                        valor_final = val;
                        txtintervalo.Text = (val+1).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (true)
                {
                    //val = Int32.Parse(txtintervalo.Text);
                    val = valor_final;
                    if (val > 0)
                    {
                        val--;
                        tipo_query();
                        valor_final = val;
                        txtintervalo.Text = (val+1).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            
            if (!chckfecha.Checked && !chckventa.Checked && !chck_empleado.Checked)
            {
                MessageBox.Show("Seleccione un tipo de busqueda","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
             else  if (chckfecha.Checked && !chckventa.Checked)
            {
                fechas();                
            }
            else if (!chckfecha.Checked && chckventa.Checked && !chck_empleado.Checked)
            {
                val = -1;
                txtintervalo.Text = "0";
                LblCantidad.Text = "/0";
                dataGridView1.DataSource = consulta.num_venta(Int32.Parse(TxtVenta.Text));
                tipo = "cuatro";
            }
            else if (!chckfecha.Checked && !chckventa.Checked && chck_empleado.Checked && Cmb_Empleado.SelectedItem!=null)
            {
                tipo = "tres";
                int intervalo = consulta.intervalo(Int32.Parse(Cmb_Empleado.SelectedItem.ToString().Split('-')[0].ToString()));
                int saltos = intervalo / 10 > 0 ? intervalo / 10 : 1;
                LblCantidad.Text = saltos != 1 ? "/" + (saltos + 1).ToString() : "/" + saltos.ToString();
                inter = saltos;
                valor_final = 0;
                txtintervalo.Text = "1";
                dataGridView1.DataSource = consulta.ventas_vendedro(Int32.Parse(Cmb_Empleado.SelectedItem.ToString().Split('-')[0].ToString()),0);
            }
        }
        public void fechas()
        {
            if (!RadBtn_fechaini.Checked)
            {
                if (Dtpfechinicio.Value < DtpFechafianl.Value)
                {
                    tipo = "uno";
                    dataGridView1.DataSource = null;
                    fech_ini = Dtpfechinicio.Value.ToString("yyyy-MM-dd 00:00:00");
                    fech_fin = DtpFechafianl.Value.ToString("yyyy-MM-dd hh:mm:ss");
                    a = chck_empleado.Checked && Cmb_Empleado.SelectedIndex!=-1 ? Cmb_Empleado.SelectedItem.ToString().Split('-')[0] : "-1";
                    int intervalo = consulta.intervalo(fech_ini, fech_fin,Int32.Parse(a));                    
                    int saltos = intervalo / 10 > 0 ? intervalo / 10 : 1;
                    LblCantidad.Text = saltos != 1 ? "/" + (saltos + 1).ToString() : "/" + saltos.ToString() ;
                    inter = saltos;
                    valor_final = 0;
                    txtintervalo.Text = "1";
                    dataGridView1.DataSource = consulta.fecha_intervalo(fech_ini, fech_fin, 0, Int32.Parse(a));
                }
                else
                {
                    MessageBox.Show("Intervalo Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (RadBtn_fechaini.Checked)
            {
                tipo = "uno";
                dataGridView1.DataSource = null;
                fech_ini = Dtpfechinicio.Value.ToString("yyyy-MM-dd 00:00:00");
                fech_fin = Dtpfechinicio.Value.ToString("yyyy-MM-dd 23:59:59");
                a = chck_empleado.Checked ? Cmb_Empleado.SelectedItem.ToString().Split('-')[0] : "-1";
                int intervalo = consulta.intervalo(fech_ini, fech_fin, Int32.Parse(a));
                double salt = intervalo / 10;
                LblCantidad.Text = "/" + (salt+1).ToString();
                inter = Int32.Parse(salt.ToString());
                valor_final = 0;
                txtintervalo.Text = "1";
                dataGridView1.DataSource = consulta.fecha_intervalo(fech_ini, fech_fin, 0, Int32.Parse(a));
            }
        }
        int val;       
        private void tipo_query()
        {            
            switch (tipo)
            {
                case "uno":
                    dataGridView1.DataSource = consulta.fecha_intervalo(fech_ini, fech_fin, val * 10, Int32.Parse(a));
                    break;
                case "dos":
                    dataGridView1.DataSource = consulta.fecha_intervalo(fech_ini, val * 10, Int32.Parse(a));
                    break;
                case "tres":
                    dataGridView1.DataSource = consulta.ventas_vendedro(Int32.Parse(Cmb_Empleado.SelectedItem.ToString().Split('-')[0].ToString()), val*10);
                    break;
                default:
                    break;
            }
        }

        private void chckventa_CheckedChanged(object sender, EventArgs e)
        {
            
            chckfecha.Checked = false;
            chck_empleado.Checked = false;
            
        }

        private void chckfecha_CheckedChanged(object sender, EventArgs e)
        {
            chckventa.Checked = false;
        }

        private void Frm_Consulta_Load(object sender, EventArgs e)
        {
            DataTable tb = consulta.empleados();
            foreach (DataRow item in tb.Rows)
            {
                Cmb_Empleado.Items.Add(item[0].ToString());
            }
            this.Width = this.Width + 20;
        }

        private void chck_empleado_CheckedChanged(object sender, EventArgs e)
        {
            chckventa.Checked = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    Frm_consuta_recibodet rec = new Frm_consuta_recibodet(Int32.Parse(dataGridView1["No.Venta", e.RowIndex].Value.ToString()));
            //    rec.Show();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Frm_consuta_recibodet rec = new Frm_consuta_recibodet(Int32.Parse(dataGridView1["No.Venta", e.RowIndex].Value.ToString()));
                rec.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btn_nuevo_form_Click(object sender, EventArgs e)
        {
            Frmconsulta_vntas ferre = new Frmconsulta_vntas();
            ferre.Show();
        }
    }
}

