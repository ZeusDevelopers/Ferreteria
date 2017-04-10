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
    public partial class Frm_consuta_recibodet : Form
    {
        int ids,numero=0;
        public Frm_consuta_recibodet(int id)
        {
            InitializeComponent();
            ids = id;           
        }
        Frm_Devolucion frm = null;
        public Frm_consuta_recibodet(int id,int tipo,Form from)
        {
            InitializeComponent();
            ids = id;
            frm = from as Frm_Devolucion;
            numero = tipo;            
        }

        private void cargar()
        {
            DataGridViewButtonColumn Columna_eliminar = new DataGridViewButtonColumn();
            Columna_eliminar.Name = "Eliminar";
            if (dataGridView1.Columns["Eliminar"] == null)
            {
                dataGridView1.Columns.Insert(3, Columna_eliminar);
                dataGridView1.CellClick += DataGridView1_CellClick;
            }
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Cells["Eliminar"].Value = "Remover";
            }
        }
        Cls_devolucion devol = new Cls_devolucion();
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==3)
            {
                DialogResult r= MessageBox.Show("Desea eliminar este producto de la venta", "eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r.Equals(DialogResult.Yes))
                {
                    devol.eliminar(ids, e.RowIndex);
                    frm.llenado();
                    this.Close();
                }
            }
        }

        Cls_Consulta cn = new Cls_Consulta();

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void Frm_consuta_recibodet_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.ventas(ids);
            label1.Text = "Empleado: " + cn.empledado(ids);
            if (numero == 1)
            {
                cargar();
            }           
        }
    }
}
