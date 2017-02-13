using System;
using System.Collections;
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
    public partial class FrmPuntoVenta_Buscar : Form
    {
        ClsPunto_deventa venta = new ClsPunto_deventa();
        FrmPuntoVenta frm = null;
        public FrmPuntoVenta_Buscar(Form forma)
        {
            InitializeComponent();
            frm = forma as FrmPuntoVenta;
            DgvProductos.DataSource = venta.VerTodosProductos();
            this.DgvProductos.Columns[0].Width = 133;
            this.DgvProductos.Columns[1].Width = 392;
            this.DgvProductos.Columns[2].Width = 133;
            
            
        }
        ArrayList numeros = new ArrayList();
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int contador;
        private void Txtcodigo_TextChanged(object sender, EventArgs e)
        {
            string a;
            if (Txtcodigo.Text == "")
            {
                contador = 0;
                DgvProductos.ClearSelection();
            }
            else
                numeros.Clear();
            for (int i = 0; i < DgvProductos.Rows.Count; i++)
            {
                a = DgvProductos[1, i].Value.ToString();
                if (a.Contains(Txtcodigo.Text) || a.ToUpperInvariant().Contains(Txtcodigo.Text.ToUpperInvariant()))
                {                                      
                    contador++;                    
                    numeros.Add(i);
                    if (contador == 1)
                    {
                       DgvProductos.Rows[i].Selected = true;
                       DgvProductos.FirstDisplayedScrollingRowIndex = i;
                    }
                }
            }            
            indice = 0;
            contador = 0;
        }
        int indice;
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (!e.Type.ToString().Contains("End"))
            {               
                if (numeros.Count == 0)
                {
                    MessageBox.Show("No se encontro el producto");
                }
                else
                {
                    DgvProductos.ClearSelection();
                    if (!e.Type.ToString().Contains("Increment"))
                    {
                        if (indice <= 0 || indice >= numeros.Count) { indice = numeros.Count - 1; }
                        else { indice--; }
                        DgvProductos.Rows[Int32.Parse(numeros[indice].ToString())].Selected = true;
                        DgvProductos.FirstDisplayedScrollingRowIndex = Int32.Parse(numeros[indice].ToString());                                                
                    }
                    else
                    {
                        if (indice >= numeros.Count-1) { indice = 0; } else { indice++; }
                        DgvProductos.Rows[Int32.Parse(numeros[indice].ToString())].Selected = true;
                        DgvProductos.FirstDisplayedScrollingRowIndex = Int32.Parse(numeros[indice].ToString());
                    }
                }
            }            
        }
        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                Prod_select(Int32.Parse(numeros[indice].ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show( );
            Prod_select(e.RowIndex);
        }
        public void Prod_select(int ind)
        {
            try
            {
                frm.dato_encontrado(DgvProductos[0, ind].Value.ToString(), DgvProductos[1, ind].Value.ToString(), DgvProductos[2, ind].Value.ToString());
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void FrmPuntoVenta_Buscar_Load(object sender, EventArgs e)
        {
            this.DgvProductos.ClearSelection();
        }
    }
}
