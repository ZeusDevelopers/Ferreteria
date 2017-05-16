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
    public partial class Frm_Almacen_buscar : Form
    {
        bool est;
        Frm_Almacen fr=null;
        public Frm_Almacen_buscar() { InitializeComponent(); }
        public Frm_Almacen_buscar(bool _est,Form un)
        {
            InitializeComponent();
            est = _est;
             fr = un as Frm_Almacen;
        }
        Cls_almacen almacen = new Cls_almacen();
        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {

            Buscar();
        }
        public void Buscar()
        {
            index = -1;
            try
            {
                DgvProductos.DataSource = almacen.VerTodosProductos(Cmb_tipo_busqueda.SelectedIndex, Txtcodigo.Text, est);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DgvProductos_DataSourceChanged(object sender, EventArgs e)
        {
               DgvProductos.Columns["Producto_ID"].Visible = false;            
        }

        private void Txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                Buscar();
            }
        }
        int index = -1;
        private void DgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            Elegir();
        }

        private void DgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            Elegir();
        }
        void Elegir()
        {
            if (index!=-1) {
                DataRow row = (DgvProductos.Rows[index].DataBoundItem as DataRowView).Row;
                fr.Agregar(row);
                this.Close(); }
        }

        private void Frm_Almacen_buscar_Load(object sender, EventArgs e)
        {
            this.Width += 110;
            this.Height += 10;

        }

        private void DgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
    }
}
