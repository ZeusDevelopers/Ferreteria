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
    public partial class FrmPuntoVenta_VentaFinal : Form
    {
        public FrmPuntoVenta_VentaFinal()
        {
            InitializeComponent();
        }
        DataTable Venta;
        public FrmPuntoVenta_VentaFinal(DataTable venta)
        {
            Venta = venta;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            try
            {               
                        Cls_imprimir_ticket ticket = new Cls_imprimir_ticket();
                        //imprime imagen
                        ticket.imprimir();
                        //Datos de la cabecera del Ticket.
                        ticket.TextoIzquierda("     PLOMERIA y FERRETERIA");
                        ticket.TextoCentro("VEGA");
                        ticket.lineasAsteriscos();
                        ticket.TextoCentro("MARITZA FELIX QUINONEZ");
                        ticket.TextoIzquierda("R.F.C FEQM-661228-1MA");
                        ticket.TextoIzquierda("REGIMEN FISCAL:INCORPORACION");
                        ticket.TextoIzquierda("FISCAL");
                        ticket.TextoIzquierda("Ave.Tecnologico # 1060 Colonia  Jardines de la montana C.P 84063");
                        ticket.TextoCentro("(631)315-8024");
                        ticket.TextoCentro("Nogales,Sonora,Mexico");

                        ticket.lineasAsteriscos();
                        //Sub cabecera.            
                        ticket.TextoIzquierda("ATENDIO: " + ClsInicioSesion.Usuario);
                        ticket.TextoExtremos("FECHA:" + DateTime.Now.ToShortDateString(), "HORA:" + DateTime.Now.ToShortTimeString());
                        ticket.lineasAsteriscos();
                        //Articulos a vender.
                        ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
                        ticket.lineasAsteriscos();
                        decimal precio, importe;
                        foreach (DataRow fila in Venta.Rows)
                        {
                            //precio = Decimal.Parse(fila[3]..ToString().Replace("$", String.Empty));
                            //importe = Decimal.Parse(fila.Cells[3].Value.ToString().Replace("$", String.Empty));
                            //ticket.AgregaArticulo(fila.Cells[1].Value.ToString(), 1, precio, importe);
                        }
                        ticket.lineasIgual();
                        //ticket.AgregarTotales("         SUBTOTAL......$", (decimal)subtotal);
                        //ticket.AgregarTotales("         IVA...........$", (decimal)iva);//La M indica que es un decimal en C#
                        //ticket.AgregarTotales("         TOTAL.........$", (decimal)total);
                        ticket.TextoIzquierda("");
                        ticket.AgregarTotales("         EFECTIVO......$", Decimal.Parse(Txt_efectivo.Text));
                        string cade = Lbl_cambio.Text.ToString().Replace("$", String.Empty);
                        double mioa = Double.Parse(cade);
                        ticket.AgregarTotales("         CAMBIO........$", (decimal)mioa);
                        //Texto final del Ticket.                            
                        ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
                        ticket.CortaTicket();
                        ticket.ImprimirTicket("POS-58");//Nombre de la impresora ticketera            
                                                        //  ticket.ImprimirTicket("Microsoft XPS Document Writer");
                        btncerrar.Enabled = true;
                        BtnCancelar.Enabled = false;
                        Btn_Aceptar_pago.Enabled = false;                       
                        MessageBox.Show("Pago Realizado ");                 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            }
        }

        private void Btn_Aceptar_pago_Click(object sender, EventArgs e)
        {

        }
    }
}
