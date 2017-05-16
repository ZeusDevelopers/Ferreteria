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
    public partial class FrmPuntoVenta_cotizacion : Form
    {
        DataTable tb = new DataTable();
        DataGridView DgvVentas;
        double subtotal = 0,iva=0,total=0;
        FrmPuntoVenta frm;
        cls_reporte cl = new cls_reporte();
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        Cls_cotizacion cotizacion = new Cls_cotizacion();
        void Buscar() {
            if (txtbuscar.Text != String.Empty)
            {
                string _co = txtbuscar.Text.Split('-')[1];
                tb= cotizacion.Regresa(Int32.Parse(_co));
                if (tb.Rows.Count>0)
                {
                    frm.Llenar_venta(tb);
                }
                else
                {
                    MessageBox.Show("No existe cotizacion","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            
        }
        public FrmPuntoVenta_cotizacion(DataGridView dv ,double _subtotal, double _iva,double _total,Form drm)
        {
            InitializeComponent();
            DgvVentas = dv;
            subtotal = _subtotal;
            iva = _iva;
            total = _total;
            frm = drm as FrmPuntoVenta;
        }
        
        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {          
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
            
            DataTable tb = new DataTable();
            tb.Columns.Add("Articulo");
            tb.Columns.Add("Cantidad");
            tb.Columns.Add("Precio");
            tb.Columns.Add("Importe");
            tb.Columns.Add("producto_id");

         
            foreach (DataRow item in dt.Rows)
            {
                tb.Rows.Add(item[2], item[0], item[4], item[5], item[7]);
            }
            


            NumberFormatInfo nfi = new CultureInfo("Es-MX", false).NumberFormat;
            cl.Genera(tb, ClsInicioSesion.Usuario, subtotal.ToString("C", nfi), iva.ToString("C", nfi), total.ToString("C", nfi));
            frm.limpiar();
            this.Close();
            }
            catch (Exception ex)
            {
                //ex.Message = "The process cannot access the file 'C:\\Users\\salaz\\Documents\\GitHub\\Ferreteria\\PVFP\\bin\\Debug\\cotizar.pdf' "
                //because it is being used by another process.
                if (ex.Message.Contains("because it is being used by another process.") || ex.Message.Contains("proceso."))
                    MessageBox.Show("Cierre la cotizacion actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
