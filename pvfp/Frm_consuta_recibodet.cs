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
    public partial class Frm_consuta_recibodet : Form
    {
        int ids;
        public Frm_consuta_recibodet(int id)
        {
            InitializeComponent();
            ids = id;           
        }

        Cls_Consulta cn = new Cls_Consulta();
        private void Frm_consuta_recibodet_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.ventas(ids);
            label1.Text = "Empleado: " + cn.empledado(ids);
        }
    }
}
