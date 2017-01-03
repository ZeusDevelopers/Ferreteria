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
    public partial class FrmInicioSesion : Form
    {
        ClsInicioSesion conexion = new ClsInicioSesion();
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {
            conexion.ConsultarPath();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Sesion(txtusuario.Text, txtcontraseña.Text);
                if (conexion.bandera == false)
                {
                    txtcontraseña.Text = "";
                    MessageBox.Show("Usuario o Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Correcto", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.usuario = txtusuario.Text;
                    this.WindowState = FormWindowState.Minimized;
                    if (conexion.puesto == "0")//ADMIN
                    {
                        txtcontraseña.Text = "";
                        FrmMenuAdmin admin = new FrmMenuAdmin();
                        admin.Show();

                    }
                    else //Trabajador
                    {
                        txtcontraseña.Text = "";
                        FrmPuntoVenta venta = new FrmPuntoVenta();
                        venta.Show();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
