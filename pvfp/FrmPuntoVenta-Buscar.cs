using System;
using System.Collections;
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
    public partial class FrmPuntoVenta_Buscar : Form
    {
        NumberFormatInfo nfi = new CultureInfo("Es-MX", false).NumberFormat;
        ClsPunto_deventa venta = new ClsPunto_deventa();
        FrmPuntoVenta frm = null;
        int roww = -1;
        public FrmPuntoVenta_Buscar() { InitializeComponent(); }
        bool _admin;
        public FrmPuntoVenta_Buscar(Form forma,bool admin)
        {
            InitializeComponent();
            frm = forma as FrmPuntoVenta;
            _admin = admin;
        }
        ArrayList numeros = new ArrayList();                
        private void DgvProductos_DataSourceChanged(object sender, EventArgs e)
        {
            if(DgvProductos.Columns.Count>0)
            DgvProductos.Columns["Producto_ID"].Visible = false;
        }
        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            Busqueda();
            DgvProductos.ClearSelection();
            roww = -1;
        }
        void Busqueda()
        {           
            if (Cmb_tipo_busqueda.SelectedIndex != -1)
            {
                DataTable tb = null;
                if (Txtcodigo.Text != "")
                {
                    tb = venta.VerTodosProductos(Cmb_tipo_busqueda.SelectedIndex, Txtcodigo.Text,_admin);
                    var c = tb.Rows[0].ItemArray[0].ToString();
                    if (c=="")
                    {
                        MessageBox.Show("No existe Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
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
                            dr[3] = item[3];
                            dr[4] = item[4];
                            dr[5] = item[5];
                            resul.Rows.Add(dr);
                        }
                        tb= resul;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DgvProductos.DataSource = tb;
            }
            else
            {
                MessageBox.Show("Seleccione una opcion");
                Txtcodigo.Text = "";
            }
        }         
        private void FrmPuntoVenta_Buscar_Load(object sender, EventArgs e)
        {
            this.Width = 784;
            this.Height = this.Height + 10;
        }
        private void Txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Busqueda();
                DgvProductos.ClearSelection();
                roww = -1;
            }
        }
        void Agregar(int ind)
        {
            try
            {
                frm.dato_encontrado(DgvProductos[0, ind].Value.ToString(), DgvProductos[1, ind].Value.ToString(), DgvProductos[2, ind].Value.ToString(), Double.Parse(DgvProductos[3, ind].Value.ToString()), DgvProductos[4, ind].Value.ToString(), DgvProductos[5, ind].Value.ToString());
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            if (roww>-1)
            {
                Agregar(roww);
            }
            else
            {
                MessageBox.Show("Seleccione un elemento","Erro",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

        private void DgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            roww = e.RowIndex;
            //DgvProductos.SelectedRows.
        }

        private void DgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            roww = e.RowIndex;
            Agregar(roww);
        }
    }
}
