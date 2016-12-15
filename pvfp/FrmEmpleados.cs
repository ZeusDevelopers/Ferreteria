using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PVFP
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }
        ClsEmpleados ObjEmpleados = new ClsEmpleados();

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            cargar();
        }

        void cargar()
        {
            dataGridView2.Rows.Clear();
            cmbBuscarNombre.Items.Clear();
            ObjEmpleados.ConsultarPath();
            ObjEmpleados.CargarEmpleadosSesion();
            ObjEmpleados.CargarEmpleadosDatos();
            ArrayList arreus = ObjEmpleados.ArregloUsu;
            ArrayList arrecontr = ObjEmpleados.ArregloContra;
            ArrayList arrepuest = ObjEmpleados.ArregloPuesto;
            //
            ArrayList arrenom = ObjEmpleados.ArregloNom;
            ArrayList arreape = ObjEmpleados.ArregloApel;
            ArrayList arresexo = ObjEmpleados.ArregloSexo;
            ArrayList arredire = ObjEmpleados.ArregloDire;
            ArrayList arretel = ObjEmpleados.ArregloTel;

            for (int i = 0; i < arreus.Count; i++)
            {
                dataGridView2.Rows.Add(arrenom[i].ToString(), arreape[i].ToString(), arresexo[i].ToString(), arredire[i].ToString(), arretel[i].ToString(), arreus[i].ToString(), arrecontr[i].ToString(), arrepuest[i].ToString());
            }
        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            try
            {
            ObjEmpleados.GuardarNuevoEmpleado(0, txtnombre.Text, txtapellido.Text, cmbsexo.SelectedText, txtdireccion.Text, txttelefono.Text);
            ObjEmpleados.GuardarNuevoEmpleadoSesion(0, txtusuario.Text, txtcontraseña.Text, cmbpuesto.SelectedIndex.ToString());
            MessageBox.Show("Empleado añadido correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            ObjEmpleados.EditarEmpleado(0, txtnombre.Text, txtapellido.Text, cmbsexo.SelectedText, txtdireccion.Text, txttelefono.Text);
            ObjEmpleados.EditarEmpleadoSesion(0, txtusuario.Text, txtcontraseña.Text, cmbpuesto.SelectedIndex.ToString());
            MessageBox.Show("Empleado modificado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ObjEmpleados.EliminarEmpleado(cmbBuscarNombre.SelectedIndex);
            ObjEmpleados.EliminarSesion(cmbBuscarNombre.SelectedIndex);
            MessageBox.Show("Empleado eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargar();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
