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
        int id_emp;
        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            this.Width = this.Width + 150;
            cargar();
            
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusuario.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtcontraseña.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese Contrasena", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbpuesto.SelectedIndex == -1)
                {
                    MessageBox.Show("Ingrese Puesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtnombre.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtapellido.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese Apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbsexo.SelectedIndex == -1)
                {
                    MessageBox.Show("Ingrese Sexo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtapellido.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese Direccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txttelefono.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese Numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtdireccion.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese Direccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {                    
                    switch (btnagregar.Text)
                    {
                        case "Agregar"://Agregar
                            DialogResult r= ObjEmpleados.GuardarNuevoEmpleado(txtusuario.Text, txtcontraseña.Text, cmbpuesto.SelectedIndex, txtnombre.Text, txtapellido.Text, cmbsexo.SelectedText, txtdireccion.Text, txttelefono.Text);
                            if (r.Equals(DialogResult.Yes))
                            {
                                MessageBox.Show("Usuario Registrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cargar();
                                id_emp = -1;
                                Btn_eliminar.Enabled = false;
                                limpiar_campos();
                            }
                            else
                            {
                                MessageBox.Show("Usuario Existente pruebe con otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                        case "Editar"://Agregar
                            ObjEmpleados.Editar(txtusuario.Text, txtcontraseña.Text, cmbpuesto.SelectedIndex, txtnombre.Text,
                                txtapellido.Text, cmbsexo.SelectedText, txtdireccion.Text, txttelefono.Text, id_emp);
                            MessageBox.Show("Actualizado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnagregar.Text = "Agregar";                            
                            cargar();
                            id_emp = -1;
                            Btn_eliminar.Enabled = false;
                            limpiar_campos();
                            break;
                        default:
                            break;
                    }                                     

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public void cargar()
        {
            try
            {
                Dgv_datos.DataSource = ObjEmpleados.consulta_usuario();
                DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                uninstallButtonColumn.Name = "Seleccionar";                                
                int columnIndex = 3;
                if (Dgv_datos.Columns["Seleccionar"] == null)
                {
                    Dgv_datos.Columns.Insert(columnIndex, uninstallButtonColumn);
                    Dgv_datos.CellClick += Dgv_datos_CellClick;
                }
                foreach (DataGridViewRow item in Dgv_datos.Rows )
                {
                    item.Cells["Seleccionar"].Value = "Seleccionar";
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);                
            }            
        }

        private void Dgv_datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Btn_eliminar.Enabled = true;
                id_emp = Int32.Parse(Dgv_datos["No Empleado", e.RowIndex].Value.ToString());
                DataTable pag1 = ObjEmpleados.consulta_dat_empleados(Int32.Parse(Dgv_datos["No Empleado", e.RowIndex].Value.ToString()));
                foreach (DataRow item in pag1.Rows)
                {
                    txtnombre.Text = item[0].ToString();
                    txtapellido.Text = item[1].ToString();
                    cmbsexo.SelectedIndex = cmbsexo.FindString(item[2].ToString());
                    txtdireccion.Text = item[3].ToString();
                    txttelefono.Text = item[4].ToString();
                    txtusuario.Text = item[5].ToString();
                    txtcontraseña.Text=item[6].ToString();
                    cmbpuesto.SelectedIndex =Int32.Parse(item[7].ToString());                    
                }
                btnagregar.Text = "Editar";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_emp != -1)
                {
                    DialogResult r = MessageBox.Show("¿Eliminar Registro?","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if (r==DialogResult.Yes)
                    {
                        Btn_eliminar.Enabled = false;
                        btnagregar.Text = "Agregar";
                        ObjEmpleados.borrar_empleados(id_emp);
                        cargar();
                        MessageBox.Show("Usuario Borrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        id_emp = -1;
                        limpiar_campos();
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }
        public void limpiar_campos()
        {
            txtapellido.Clear();
            txtcontraseña.Clear();
            txtdireccion.Clear();
            txtnombre.Clear();
            txttelefono.Clear();
            txtusuario.Clear();
            cmbpuesto.SelectedIndex = -1;
            cmbsexo.SelectedIndex = -1;
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar_campos();
            id_emp = -1;
            Btn_eliminar.Enabled = false;
            btnagregar.Text = "Agregar";
        }
    }
}
