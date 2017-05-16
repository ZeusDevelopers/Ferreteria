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
    public partial class Frm_Almacen : Form
    {
        public Frm_Almacen()
        {
            InitializeComponent();
        }        
        int id = 0;
        string tipo = "";
        double cant = 0.0d;
        private void Cmb_cambio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_cambio.SelectedIndex==0)
            {
                Gbx_almacen.Text = "Almacen a Piso";
                
            }
            else
            {
                Gbx_almacen.Text = "Piso a Almacen";
            }
        }

        private void Btn_pasar_Click(object sender, EventArgs e)
        {
            int b = 0;
            double a = txtcantidad.Text!="" ? Double.Parse(txtcantidad.Text):0;
            if (a<=cant && id!=-1)
            {
                bool ent=false;
                if((tipo.Contains("Kit") || tipo.Contains("Unidad")) 
                    )
                {
                    if(Int32.TryParse(a.ToString(), out b))
                    {
                        ent = true;
                    }
                    else
                    {
                        MessageBox.Show("Solo numeros enteros");
                        ent = false;
                    }
                }
                else { ent = true; }
                if (ent)
                {
                    try
                    {
                        //Almacen a Piso
                        // Piso a Almacen
                        string op = Cmb_cambio.SelectedIndex == 0 ? "" : "almacen";
                        almacen.Mover(op, id, a);
                        MessageBox.Show("Traspaso procesado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Llenado();
                        lblcantidad.Visible = false;
                        id = -1;
                        tipo = "";
                        cant = 0;
                        txtcantidad.Text = "";
                        txt_producto.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                
            }
            else
            {
                MessageBox.Show("Cantidad incorrecta o insuficiete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {            
            id = -1;
            tipo = "";
            cant = 0;
            txtcantidad.Text = "";
            txt_producto.Text = "";
            bool un;
            if (Cmb_cambio.SelectedIndex!=-1){ un = Cmb_cambio.SelectedIndex == 1;
                Frm_Almacen_buscar find = new Frm_Almacen_buscar(un,this);
                find.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un tipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        internal void Agregar(DataRow rw) {
            id=Int32.Parse(rw[4].ToString());
            tipo = rw[3].ToString();
            cant =Double.Parse(rw[2].ToString());
            txt_producto.Text = rw[1].ToString();
            lblcantidad.Visible = true;
            lblcantidad.Text = "Cantidad actual:"+cant.ToString();
        }
        Cls_almacen almacen = new Cls_almacen();
        int opc = 0,max=0;
        private void Frm_Almacen_Load(object sender, EventArgs e)
        {
            this.Height += 60;
            max = almacen.Numero();
            lblcant.Text = "/"+max.ToString();
            dgv_resul.DataSource = almacen.Paginado(opc);
        }
        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else {
                e.Handled = true;
            }
        }
        private void Btn_previous_Click(object sender, EventArgs e)
        {
            if (opc>0)
            {
                opc--;
            }
            txtcant.Text = opc>0 ?opc.ToString():"1";
            Llenado();
        }
        private void btnext_Click(object sender, EventArgs e)
        {
            if (opc < max)
            {
                opc++;
            }
            txtcant.Text = opc.ToString();
            Llenado();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void Llenado()
        {
            dgv_resul.DataSource = almacen.Paginado(opc);
        }
    }
}
