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
    public partial class Frmconsulta_vntas : Form
    {
        public Frmconsulta_vntas()
        {
            InitializeComponent();
        }
        NumberFormatInfo nfi = new CultureInfo("Es-MX", false).NumberFormat;
        private void RadBtn_fechaini_CheckedChanged(object sender, EventArgs e)
        {
            Dtpfechinicio.Visible=true;
            Lbl_fechinicio.Visible = true;
            DtpFechafianl.Visible = false;
            LblFechFin.Visible = false;
        }
        Cls_reporte_ventas ven = new Cls_reporte_ventas();
        private void RadBtn_fechintervalo_CheckedChanged(object sender, EventArgs e)
        {
            DtpFechafianl.Visible = true;
            LblFechFin.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tb= new DataTable();
           string fech_ini = Dtpfechinicio.Value.ToString("yyyy-MM-dd 00:00:00");
           string fech_fin = RadBtn_fechintervalo.Checked ? DtpFechafianl.Value.ToString("yyyy-MM-dd hh:mm:ss") :
                Dtpfechinicio.Value.ToString("yyyy-MM-dd 23:59:59");
            switch (cmbreporte.SelectedIndex)
            {
                case 0:
                    tb=ven.Impuestos(fech_ini,fech_fin);
                 break;
                case 1:
                   tb= ven.Ganancia(fech_ini, fech_fin);
                    break;
                default:
                    break;
            }
            double perro = 0.0d;
            foreach (DataRow item in tb.Rows)
            {
                string n= item[0].ToString();

             perro = n!="" ? Double.Parse(item[0].ToString()) : 0.0d;               
            }
            Lblresul.Text = perro.ToString("C",nfi);
        }

        private void cmbreporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbreporte.SelectedIndex==0)
            {
                LBltipo.Text = "Impuesto";
            }
            else if (cmbreporte.SelectedIndex == 1)
            {
                LBltipo.Text = "Ganancia";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
